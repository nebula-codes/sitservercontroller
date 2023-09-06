using SitServerController.Models;

namespace SitServerController.Controllers;

public class TraderController
{
    public PlayerFullProfile _fullProfile { get; set; }


    public TraderController(PlayerFullProfile profile)
    {
        _fullProfile = profile;
    }
    
    public async Task<Trader> GetPraporInformation()
    {
        var prapor = new Trader();
        try
        {
            prapor.loyaltyLevel = _fullProfile.characters.pmc.TradersInfo._54cb50c76803fa8b248b4571.loyaltyLevel;
            prapor.disabled = _fullProfile.characters.pmc.TradersInfo._54cb50c76803fa8b248b4571.disabled;
            prapor.standing = _fullProfile.characters.pmc.TradersInfo._54cb50c76803fa8b248b4571.standing;
            prapor.unlocked = _fullProfile.characters.pmc.TradersInfo._54cb50c76803fa8b248b4571.unlocked;
            prapor.salesSum = _fullProfile.characters.pmc.TradersInfo._54cb50c76803fa8b248b4571.salesSum;
            prapor.nextResupply = _fullProfile.characters.pmc.TradersInfo._54cb50c76803fa8b248b4571.nextResupply;
            prapor.name = "Prapor";
            prapor.imagePath = "/54cb50c76803fa8b248b4571.png";
        }
        catch (Exception e)
        {
            prapor.loyaltyLevel = 0;
            prapor.disabled = false;
            prapor.standing = 0;
            prapor.unlocked = true;
            prapor.salesSum = 0;
            prapor.nextResupply = 0;
            prapor.name = "Prapor";
            prapor.imagePath = "/54cb50c76803fa8b248b4571.png";
            Console.WriteLine(e);
            throw;
        }

        return prapor;
    }
    
    public Trader GetTherapistInformation()
    {
        var therapist = new Trader();
        therapist.loyaltyLevel = _fullProfile.characters.pmc.TradersInfo._54cb57776803fa99248b456e.loyaltyLevel;
        therapist.disabled = _fullProfile.characters.pmc.TradersInfo._54cb57776803fa99248b456e.disabled;
        therapist.standing = _fullProfile.characters.pmc.TradersInfo._54cb57776803fa99248b456e.standing;
        therapist.unlocked = _fullProfile.characters.pmc.TradersInfo._54cb57776803fa99248b456e.unlocked;
        therapist.salesSum = _fullProfile.characters.pmc.TradersInfo._54cb57776803fa99248b456e.salesSum;
        therapist.nextResupply = _fullProfile.characters.pmc.TradersInfo._54cb57776803fa99248b456e.nextResupply;
        therapist.name = "Therapist";
        return therapist;
    }
    
    public Trader GetSkierInformation()
    {
        var skier = new Trader();
        skier.loyaltyLevel = _fullProfile.characters.pmc.TradersInfo._58330581ace78e27b8b10cee.loyaltyLevel;
        skier.disabled = _fullProfile.characters.pmc.TradersInfo._58330581ace78e27b8b10cee.disabled;
        skier.standing = _fullProfile.characters.pmc.TradersInfo._58330581ace78e27b8b10cee.standing;
        skier.unlocked = _fullProfile.characters.pmc.TradersInfo._58330581ace78e27b8b10cee.unlocked;
        skier.salesSum = _fullProfile.characters.pmc.TradersInfo._58330581ace78e27b8b10cee.salesSum;
        skier.nextResupply = _fullProfile.characters.pmc.TradersInfo._58330581ace78e27b8b10cee.nextResupply;
        skier.name = "Therapist";
        return skier;
    }
    
    public Trader GetPeacekeeperInformation()
    {
        var peacekeeper = new Trader();
        peacekeeper.loyaltyLevel = _fullProfile.characters.pmc.TradersInfo._5935c25fb3acc3127c3d8cd9.loyaltyLevel;
        peacekeeper.disabled = _fullProfile.characters.pmc.TradersInfo._5935c25fb3acc3127c3d8cd9.disabled;
        peacekeeper.standing = _fullProfile.characters.pmc.TradersInfo._5935c25fb3acc3127c3d8cd9.standing;
        peacekeeper.unlocked = _fullProfile.characters.pmc.TradersInfo._5935c25fb3acc3127c3d8cd9.unlocked;
        peacekeeper.salesSum = _fullProfile.characters.pmc.TradersInfo._5935c25fb3acc3127c3d8cd9.salesSum;
        peacekeeper.nextResupply = _fullProfile.characters.pmc.TradersInfo._5935c25fb3acc3127c3d8cd9.nextResupply;
        peacekeeper.name = "Peacekeeper";
        return peacekeeper;
    }
    
    public Trader GetFenceInformation()
    {
        var fence = new Trader();
        fence.loyaltyLevel = _fullProfile.characters.pmc.TradersInfo._579dc571d53a0658a154fbec.loyaltyLevel;
        fence.disabled = _fullProfile.characters.pmc.TradersInfo._579dc571d53a0658a154fbec.disabled;
        fence.standing = _fullProfile.characters.pmc.TradersInfo._579dc571d53a0658a154fbec.standing;
        fence.unlocked = _fullProfile.characters.pmc.TradersInfo._579dc571d53a0658a154fbec.unlocked;
        fence.salesSum = _fullProfile.characters.pmc.TradersInfo._579dc571d53a0658a154fbec.salesSum;
        fence.nextResupply = _fullProfile.characters.pmc.TradersInfo._579dc571d53a0658a154fbec.nextResupply;
        fence.name = "Fence";
        return fence;
    }
    
    public Trader GetMechanicInformation()
    {
        var mechanic = new Trader();
        mechanic.loyaltyLevel = _fullProfile.characters.pmc.TradersInfo._5a7c2eca46aef81a7ca2145d.loyaltyLevel;
        mechanic.disabled = _fullProfile.characters.pmc.TradersInfo._5a7c2eca46aef81a7ca2145d.disabled;
        mechanic.standing = _fullProfile.characters.pmc.TradersInfo._5a7c2eca46aef81a7ca2145d.standing;
        mechanic.unlocked = _fullProfile.characters.pmc.TradersInfo._5a7c2eca46aef81a7ca2145d.unlocked;
        mechanic.salesSum = _fullProfile.characters.pmc.TradersInfo._5a7c2eca46aef81a7ca2145d.salesSum;
        mechanic.nextResupply = _fullProfile.characters.pmc.TradersInfo._5a7c2eca46aef81a7ca2145d.nextResupply;
        mechanic.name = "Mechanic";
        return mechanic;
    }
    
    public async Task<Trader> GetRagmanInformation()
    {
        var ragman = new Trader();
        ragman.loyaltyLevel = _fullProfile.characters.pmc.TradersInfo._5ac3b934156ae10c4430e83c.loyaltyLevel;
        ragman.disabled = _fullProfile.characters.pmc.TradersInfo._5ac3b934156ae10c4430e83c.disabled;
        ragman.standing = _fullProfile.characters.pmc.TradersInfo._5ac3b934156ae10c4430e83c.standing;
        ragman.unlocked = _fullProfile.characters.pmc.TradersInfo._5ac3b934156ae10c4430e83c.unlocked;
        ragman.salesSum = _fullProfile.characters.pmc.TradersInfo._5ac3b934156ae10c4430e83c.salesSum;
        ragman.nextResupply = _fullProfile.characters.pmc.TradersInfo._5ac3b934156ae10c4430e83c.nextResupply;
        ragman.name = "Ragman";
        return ragman;
    }
    
    public Trader GetJaegerInformation()
    {
        var jaeger = new Trader();
        jaeger.loyaltyLevel = _fullProfile.characters.pmc.TradersInfo._5c0647fdd443bc2504c2d371.loyaltyLevel;
        jaeger.disabled = _fullProfile.characters.pmc.TradersInfo._5c0647fdd443bc2504c2d371.disabled;
        jaeger.standing = _fullProfile.characters.pmc.TradersInfo._5c0647fdd443bc2504c2d371.standing;
        jaeger.unlocked = _fullProfile.characters.pmc.TradersInfo._5c0647fdd443bc2504c2d371.unlocked;
        jaeger.salesSum = _fullProfile.characters.pmc.TradersInfo._5c0647fdd443bc2504c2d371.salesSum;
        jaeger.nextResupply = _fullProfile.characters.pmc.TradersInfo._5c0647fdd443bc2504c2d371.nextResupply;
        jaeger.name = "Jaeger";
        return jaeger;
    }
    
    public async Task<Trader> GetAnastasiaInformation()
    {
        var anastasia = new Trader();
        anastasia.loyaltyLevel = _fullProfile.characters.pmc.TradersInfo.anastasia.loyaltyLevel;
        anastasia.disabled = _fullProfile.characters.pmc.TradersInfo.anastasia.disabled;
        anastasia.standing = _fullProfile.characters.pmc.TradersInfo.anastasia.standing;
        anastasia.unlocked = _fullProfile.characters.pmc.TradersInfo.anastasia.unlocked;
        anastasia.salesSum = _fullProfile.characters.pmc.TradersInfo.anastasia.salesSum;
        anastasia.nextResupply = _fullProfile.characters.pmc.TradersInfo.anastasia.nextResupply;
        anastasia.name = "Anastasia";
        return anastasia;
    }
}