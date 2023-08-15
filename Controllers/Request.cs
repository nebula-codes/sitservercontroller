using SitServerController.Models;

namespace SitServerController.Controllers;

using zlib;
using System;
using System.IO;
using System.Net;
using System.Text;

public class Request
{
    public string Session;
    public string RemoteEndPoint;
    public static int bufsize = 4096;
    public Request(string session, string remoteEndPoint)
    {
        Session = session;
        Server server = new Server();
        RemoteEndPoint = server.HttpUrl;
        Console.WriteLine("URL: " + server.HttpUrl);
    }
    
    public Stream Send(string url, string method = "GET", string data = null, bool compress = true)
        {
            // disable SSL encryption
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            // set session headers
            var request = WebRequest.Create(new Uri(RemoteEndPoint + url));

            if (!string.IsNullOrWhiteSpace(Session))
            {
                request.Headers.Add("Cookie", $"PHPSESSID={Session}");
                request.Headers.Add("SessionId", Session);
            }

            request.Headers.Add("Accept-Encoding", "deflate");
            request.Method = method;

            if (method != "GET" && !string.IsNullOrWhiteSpace(data))
            {
                // set request body
                var bytes = (compress) ? CompressToBytes(data, zlibConst.Z_BEST_COMPRESSION) : Encoding.UTF8.GetBytes(data);

                request.ContentType = "application/json";
                request.ContentLength = bytes.Length;

                if (compress)
                {
                    request.Headers.Add("Content-Encoding", "deflate");
                }

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
            }

            // get response stream
            try
            {
                var response = request.GetResponse();
                return response.GetResponseStream();
            }
            catch (Exception)
            {
                // Not sure why this was a unityengine debug logger. Possilby used by another module?
            }

            return null;
        }

        public string GetJson(string url, bool compress = true)
        {
            using (var stream = Send(url, "GET", null, compress))
            {
                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return Decompress(ms.ToArray(), null);
                }
            }
        }

        public string PostJson(string url, string data, bool compress = true)
        {
            using (var stream = Send(url, "POST", data, compress))
            {
                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return Decompress(ms.ToArray(), null);
                }
            }
        }
    
    public static byte[] CompressToBytes(string text, int compressLevel, Encoding encoding = null)
    {
        if (encoding == null)
        {
            encoding = Encoding.UTF8;
        }

        byte[] bytes = encoding.GetBytes(text);
        ZStream zStream = new ZStream();
        zStream.deflateInit(compressLevel);
        byte[] array = new byte[bytes.Length + 30];
        zStream.next_in = bytes;
        zStream.next_in_index = 0;
        zStream.avail_in = bytes.Length;
        zStream.next_out_index = 0;
        zStream.avail_out = array.Length;
        zStream.next_out = array;
        zStream.deflate(4);
        bytes = new byte[zStream.next_out_index];
        Array.Copy(zStream.next_out, 0, bytes, 0, zStream.next_out_index);
        return bytes;
    }

    public static byte[] CompressToBytes(byte[] bytes, int compressLevel)
    {
        ZStream zStream = new ZStream();
        zStream.deflateInit(compressLevel);
        byte[] array = new byte[bytes.Length + 30];
        zStream.next_in = bytes;
        zStream.next_in_index = 0;
        zStream.avail_in = bytes.Length;
        zStream.next_out_index = 0;
        zStream.avail_out = array.Length;
        zStream.next_out = array;
        zStream.deflate(4);
        bytes = new byte[zStream.next_out_index];
        Array.Copy(zStream.next_out, 0, bytes, 0, zStream.next_out_index);
        return bytes;
    }
    
    public static string Decompress(string compressed, Encoding encoding = null)
        {
            if (string.IsNullOrEmpty(compressed))
            {
                return "";
            }

            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }

            byte[] bytes = encoding.GetBytes(compressed);
            ZStream zStream = new ZStream();
            zStream.inflateInit();
            MemoryStream memoryStream = new MemoryStream();
            int num = 0;
            byte[] next_out = new byte[bufsize];
            zStream.next_in = bytes;
            zStream.next_in_index = 0;
            zStream.avail_in = bytes.Length;
            do
            {
                zStream.avail_out = bufsize;
                zStream.next_out = next_out;
                zStream.next_out_index = 0;
                zStream.total_out = zStream.total_out;
                num = zStream.inflate(0);
                if (num != 0 && num != 1)
                {
                    break;
                }

                memoryStream.Write(zStream.next_out, 0, zStream.next_out_index);
            }
            while (zStream.avail_in > 0 || zStream.avail_out == 0);
            bytes = memoryStream.ToArray();
            memoryStream.Close();
            return encoding.GetString(bytes);
        }

        public static string Decompress(byte[] bytes, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }

            ZStream zStream = new ZStream();
            zStream.inflateInit();
            MemoryStream memoryStream = new MemoryStream();
            int num = 0;
            byte[] next_out = new byte[bufsize];
            zStream.next_in = bytes;
            zStream.next_in_index = 0;
            zStream.avail_in = bytes.Length;
            do
            {
                zStream.avail_out = bufsize;
                zStream.next_out = next_out;
                zStream.next_out_index = 0;
                zStream.total_out = zStream.total_out;
                num = zStream.inflate(0);
                if (num != 0 && num != 1)
                {
                    break;
                }

                memoryStream.Write(zStream.next_out, 0, zStream.next_out_index);
            }
            while (zStream.avail_in > 0 || zStream.avail_out == 0);
            bytes = memoryStream.ToArray();
            memoryStream.Close();
            return encoding.GetString(bytes);
        }
}