namespace SitServerController.Models;

public class PlayerFullProfile
{
    public Info info { get; set; }
    public Characters characters { get; set; }
    public string[] suits { get; set; }
    public Weaponbuilds weaponbuilds { get; set; }
    public Dialogues dialogues { get; set; }
    public Aki aki { get; set; }
    public Vitality vitality { get; set; }
    public Inraid inraid { get; set; }
    public object[] insurance { get; set; }
    public Traderpurchases traderPurchases { get; set; }

    public float GetRaids()
    {
        string[] key = new[] { "Sessions","Pmc" };
        return GetKeyValue(key);
    }

    public float GetSurvivedRaids()
    {
        string[] key =
        {
            "ExitStatus",
            "Survived",
            "Pmc"
        };
        return GetKeyValue(key);
    }
    
    public float GetRegistration()
    {
        float date = characters.pmc.Info.RegistrationDate;
        return date;
    }
    
    public float GetTotalExperience()
    {
        float exp = characters.pmc.Info.Experience;
        return exp;
    }
    
    public string GetSurvivorClass()
    {
        return characters.pmc.SurvivorClass;
    }
    
    public float GetKillExperience()
    {
        string[] key = new[] { "ExpKill" };
        return GetKeyValue(key);
    }
    
    public float GetLootingExperience()
    {
        string[] key = new[] { "ExpLooting" };
        return GetKeyValue(key);
    }
    
    public float GetLongestWinRate()
    {
        string[] key = new[] { "LongestWinStreak",
            "Pmc" };
        return GetKeyValue(key);
    }

    public float GetKills()
    {
        string[] key =
        {
            "Kills"
        };
        return GetKeyValue(key);
    }
    
    public float GetDeaths()
    {
        string[] key =
        {
            "Deaths"
        };
        return GetKeyValue(key);
    }
    
    public float GetCurrentWinStreak()
    {
        string[] key =
        {
            "CurrentWinStreak",
            "Pmc"
        };
        return GetKeyValue(key);
    }
    
    public float GetBloodLoss()
    {
        string[] key =
        {
            "BloodLoss"
        };
        return GetKeyValue(key);
    }
    public float GetLostLimbs()
    {
        string[] key =
        {
            "BodyPartsDestroyed"
        };
        return GetKeyValue(key);
    }
    public float GetHpHealed()
    {
        string[] key =
        {
            "Heal"
        };
        return GetKeyValue(key);
    }
    public float GetFractures()
    {
        string[] key =
        {
            "Fractures"
        };
        return GetKeyValue(key);
    }
    public float GetContusions()
    {
        string[] key =
        {
            "Contusions"
        };
        return GetKeyValue(key);
    }
    public float GetDehydrations()
    {
        string[] key =
        {
            "Dehydrations"
        };
        return GetKeyValue(key);
    }
    public float GetExhaustions()
    {
        string[] key =
        {
            "Exhaustions"
        };
        return GetKeyValue(key);
    }

    public float GetKeyValue(string[] key)
    {
        foreach (var value in characters.pmc.Stats.OverallCounters.Items)
        {
            if (Compare(key, value.Key))
            {
                return value.Value;
            }
        }

        return 0;
    }
    
    private bool Compare(string[] firstArray, string[] secondArray)
    {
        if (firstArray.Length != secondArray.Length)
            return false;
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
                return false;
        }
        return true;
    }
}



public class Info
{
    public string id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public bool wipe { get; set; }
    public string edition { get; set; }
}

public class Characters
{
    public Pmc pmc { get; set; }
    public Scav scav { get; set; }
}


public class Pmc
{
    public Backendcounters BackendCounters { get; set; }
    public Bonus[] Bonuses { get; set; }
    public Conditioncounters ConditionCounters { get; set; }
    public Customization Customization { get; set; }
    public Encyclopedia Encyclopedia { get; set; }
    public Health Health { get; set; }
    public Hideout Hideout { get; set; }
    public Info1 Info { get; set; }
    public object[] InsuredItems { get; set; }
    public Inventory Inventory { get; set; }
    public Quest[] Quests { get; set; }
    public Ragfairinfo RagfairInfo { get; set; }
    public Skills Skills { get; set; }
    public Stats Stats { get; set; }
    public Tradersinfo TradersInfo { get; set; }
    public object[] WishList { get; set; }
    public string _id { get; set; }
    public string aid { get; set; }
    public string savage { get; set; }
    public Repeatablequest[] RepeatableQuests { get; set; }
    public Carextractcounts CarExtractCounts { get; set; }
    public Unlockedinfo UnlockedInfo { get; set; }
    public string SurvivorClass { get; set; }
}

public class Backendcounters
{
}

public class Conditioncounters
{
    public object[] Counters { get; set; }
}

public class Customization
{
    public string Body { get; set; }
    public string Feet { get; set; }
    public string Hands { get; set; }
    public string Head { get; set; }
}

public class Encyclopedia
{
    public bool _5448bd6b4bdc2dfc2f8b4569 { get; set; }
    public bool _5448be9a4bdc2dfd2f8b456a { get; set; }
    public bool _5448c12b4bdc2d02308b456f { get; set; }
    public bool _5448fee04bdc2dbc018b4567 { get; set; }
    public bool _5449016a4bdc2d6f028b456f { get; set; }
    public bool _544a11ac4bdc2d470e8b456a { get; set; }
    public bool _544a5caa4bdc2d1a388b4568 { get; set; }
    public bool _544a5cde4bdc2d39388b456b { get; set; }
    public bool _544fb25a4bdc2dfb738b4567 { get; set; }
    public bool _544fb3364bdc2d34748b456a { get; set; }
    public bool _544fb37f4bdc2dee738b4567 { get; set; }
    public bool _544fb3f34bdc2d03748b456a { get; set; }
    public bool _544fb45d4bdc2dee738b4568 { get; set; }
    public bool _54527a984bdc2d4e668b4567 { get; set; }
    public bool _545cdae64bdc2d39198b4568 { get; set; }
    public bool _545cdb794bdc2d3a198b456a { get; set; }
    public bool _557ff21e4bdc2d89578b4586 { get; set; }
    public bool _557ffd194bdc2d28148b457f { get; set; }
    public bool _55801eed4bdc2d89578b4588 { get; set; }
    public bool _55802d5f4bdc2dac148b458e { get; set; }
    public bool _559ba5b34bdc2d1f1a8b4582 { get; set; }
    public bool _55d480c04bdc2d1d4e8b456a { get; set; }
    public bool _55d4887d4bdc2d962f8b4570 { get; set; }
    public bool _55d7217a4bdc2d86028b456d { get; set; }
    public bool _56083e1b4bdc2dc8488b4572 { get; set; }
    public bool _56083eab4bdc2d26448b456a { get; set; }
    public bool _560d5e524bdc2d25448b4571 { get; set; }
    public bool _560e620e4bdc2d724b8b456b { get; set; }
    public bool _5644bd2b4bdc2d3b4c8b4572 { get; set; }
    public bool _5645bc214bdc2d363b8b4571 { get; set; }
    public bool _5645bcc04bdc2d363b8b4572 { get; set; }
    public bool _5648a7494bdc2d9d488b4583 { get; set; }
    public bool _5648b0744bdc2d363b8b4578 { get; set; }
    public bool _5648b1504bdc2d9d488b4584 { get; set; }
    public bool _5649aa744bdc2ded0b8b457e { get; set; }
    public bool _5649ad3f4bdc2df8348b4585 { get; set; }
    public bool _5649ade84bdc2d1b2b8b4587 { get; set; }
    public bool _5649af094bdc2df8348b4586 { get; set; }
    public bool _5649b0544bdc2d1b2b8b458a { get; set; }
    public bool _5649b1c04bdc2d16268b457c { get; set; }
    public bool _564ca99c4bdc2d16268b4589 { get; set; }
    public bool _567143bf4bdc2d1a0f8b4567 { get; set; }
    public bool _5696686a4bdc2da3298b456a { get; set; }
    public bool _569668774bdc2da2298b4568 { get; set; }
    public bool _56d59d3ad2720bdb418b4577 { get; set; }
    public bool _56dfef82d2720bbd668b4567 { get; set; }
    public bool _56dff3afd2720bba668b4567 { get; set; }
    public bool _56e294cdd2720b603a8b4575 { get; set; }
    public bool _56ea8222d2720b69698b4567 { get; set; }
    public bool _570fd6c2d2720bc6458b457f { get; set; }
    public bool _5710c24ad2720bc3458b45a3 { get; set; }
    public bool _57347d7224597744596b4e72 { get; set; }
    public bool _57347da92459774491567cf5 { get; set; }
    public bool _573718ba2459775a75491131 { get; set; }
    public bool _5751a25924597722c463c472 { get; set; }
    public bool _5755356824597772cb798962 { get; set; }
    public bool _5755383e24597772cb798966 { get; set; }
    public bool _576a581d2459771e7b1bc4f1 { get; set; }
    public bool _576a5ed62459771e9c2096cb { get; set; }
    public bool _576a63cd2459771e796e0e11 { get; set; }
    public bool _576a7c512459771e796e0e17 { get; set; }
    public bool _57cd379a24597778e7682ecf { get; set; }
    public bool _57dc2fa62459775949412633 { get; set; }
    public bool _57dc324a24597759501edc20 { get; set; }
    public bool _57dc32dc245977596d4ef3d3 { get; set; }
    public bool _57dc334d245977597164366f { get; set; }
    public bool _57dc347d245977596754e7a1 { get; set; }
    public bool _5811ce772459770e9e5f9532 { get; set; }
    public bool _584984812459776a704a82a6 { get; set; }
    public bool _5857a8bc2459772bad15db29 { get; set; }
    public bool _58864a4f2459770fcc257101 { get; set; }
    public bool _5887431f2459777e1612938f { get; set; }
    public bool _58948c8e86f77409493f7266 { get; set; }
    public bool _58949dea86f77409483e16a8 { get; set; }
    public bool _58949edd86f77409483e16a9 { get; set; }
    public bool _5894a05586f774094708ef75 { get; set; }
    public bool _5894a13e86f7742405482982 { get; set; }
    public bool _5894a2c386f77427140b8342 { get; set; }
    public bool _5894a42086f77426d2590762 { get; set; }
    public bool _5894a51286f77426d13baf02 { get; set; }
    public bool _5894a5b586f77426d2590767 { get; set; }
    public bool _5894a73486f77426d259076c { get; set; }
    public bool _5894a81786f77427140b8347 { get; set; }
    public bool _590c5d4b86f774784e1b9c45 { get; set; }
    public bool _590c657e86f77412b013051d { get; set; }
    public bool _590c661e86f7741e566b646a { get; set; }
    public bool _590c678286f77426c9660122 { get; set; }
    public bool _590c695186f7741e566b64a2 { get; set; }
    public bool _592c2d1a86f7746dbe2af32a { get; set; }
    public bool _595cf16b86f77427440c32e2 { get; set; }
    public bool _59984ab886f7743e98271174 { get; set; }
    public bool _5998517986f7746017232f7e { get; set; }
    public bool _599851db86f77467372f0a18 { get; set; }
    public bool _5998597786f77414ea6da093 { get; set; }
    public bool _59985a8086f77414ec448d1a { get; set; }
    public bool _599860ac86f77436b225ed1a { get; set; }
    public bool _599860e986f7743bb57573a6 { get; set; }
    public bool _59bffbb386f77435b379b9c2 { get; set; }
    public bool _59bffc1f86f77435b128b872 { get; set; }
    public bool _59c6633186f7740cf0493bb9 { get; set; }
    public bool _59ccd11386f77428f24a488f { get; set; }
    public bool _59ccfdba86f7747f2109a587 { get; set; }
    public bool _59d36a0086f7747e673f3946 { get; set; }
    public bool _59e770b986f7742cbd762754 { get; set; }
    public bool _5a0c27731526d80618476ac4 { get; set; }
    public bool _5aa2b87de5b5b00016327c25 { get; set; }
    public bool _5aa7cfc0e5b5b00015693143 { get; set; }
    public bool _5aafbde786f774389d0cbc0f { get; set; }
    public bool _5ab8f39486f7745cd93a1cca { get; set; }
    public bool _5ac4cd105acfc40016339859 { get; set; }
    public bool _5ac50c185acfc400163398d4 { get; set; }
    public bool _5ac50da15acfc4001718d287 { get; set; }
    public bool _5ac72e475acfc400180ae6fe { get; set; }
    public bool _5ac7655e5acfc40016339a19 { get; set; }
    public bool _5af0454c86f7746bf20992e8 { get; set; }
    public bool _5b40e5e25acfc4001a599bea { get; set; }
    public bool _5b432b965acfc47a8774094e { get; set; }
    public bool _5b432d215acfc4771e1c6624 { get; set; }
    public bool _5bed625c0db834001c062946 { get; set; }
    public bool _5beec1bd0db834001e6006f3 { get; set; }
    public bool _5beec3420db834001b095429 { get; set; }
    public bool _5beec3e30db8340019619424 { get; set; }
    public bool _5beec8b20db834001961942a { get; set; }
    public bool _5beec8c20db834001d2c465c { get; set; }
    public bool _5beec8ea0db834001a6f9dbf { get; set; }
    public bool _5beec91a0db834001961942d { get; set; }
    public bool _5beec9450db83400970084fd { get; set; }
    public bool _5beecbb80db834001d2c465e { get; set; }
    public bool _5beed0f50db834001c062b12 { get; set; }
    public bool _5bf3f59f0db834001a6fa060 { get; set; }
    public bool _5bffdc370db834001d23eca8 { get; set; }
    public bool _5c0505e00db834001b735073 { get; set; }
    public bool _5c0e530286f7747fa1419862 { get; set; }
    public bool _5c0e53c886f7747fa54205c7 { get; set; }
    public bool _5c0e722886f7740458316a57 { get; set; }
    public bool _5c488a752e221602b412af63 { get; set; }
    public bool _5c48a14f2e2216152006edd7 { get; set; }
    public bool _5c48a2852e221602b21d5923 { get; set; }
    public bool _5c48a2a42e221602b66d1e07 { get; set; }
    public bool _5c48a2c22e221602b313fb6c { get; set; }
    public bool _5ca20abf86f77418567a43f2 { get; set; }
    public bool _5ca20d5986f774331e7c9602 { get; set; }
    public bool _5d02778e86f774203e7dedbe { get; set; }
    public bool _5d02797c86f774203f38e30a { get; set; }
    public bool _5d0a29fed7ad1a002769ad08 { get; set; }
    public bool _5d0a3e8cd7ad1a6f6a3d35bd { get; set; }
    public bool _5d1b36a186f7742523398433 { get; set; }
    public bool _5d1b371186f774253763a656 { get; set; }
    public bool _5d40407c86f774318526545a { get; set; }
    public bool _5d5d85c586f774279a21cbdb { get; set; }
    public bool _5d5d940f86f7742797262046 { get; set; }
    public bool _5d5e9c74a4b9364855191c40 { get; set; }
    public bool _5e2af47786f7746d404f3aaa { get; set; }
    public bool _5e2af4a786f7746d3f3c3400 { get; set; }
    public bool _5e831507ea0a7c419c2f9bd9 { get; set; }
    public bool _5e8488fa988a8701445df1e4 { get; set; }
    public bool _5e870397991fd70db46995c8 { get; set; }
    public bool _5e87071478f43e51ca2de5e1 { get; set; }
    public bool _5e87076ce2db31558c75a11d { get; set; }
    public bool _5e87080c81c4ed43e83cefda { get; set; }
    public bool _5e8708d4ae379e67d22e0102 { get; set; }
    public bool _5e87114fe2db31558c75a120 { get; set; }
    public bool _5e87116b81c4ed43e83cefdd { get; set; }
    public bool _5f4f9eb969cdc30ff33f09db { get; set; }
    public bool _62a091170b9d3c46de5b6cf2 { get; set; }
    public bool _62a09cb7a04c0c5c6e0a84f8 { get; set; }
    public bool _5938994586f774523a425196 { get; set; }
}

public class Health
{
    public Bodyparts BodyParts { get; set; }
    public Energy Energy { get; set; }
    public Hydration Hydration { get; set; }
    public Temperature Temperature { get; set; }
    public float UpdateTime { get; set; }
}

public class Bodyparts
{
    public Chest Chest { get; set; }
    public Head Head { get; set; }
    public Leftarm LeftArm { get; set; }
    public Leftleg LeftLeg { get; set; }
    public Rightarm RightArm { get; set; }
    public Rightleg RightLeg { get; set; }
    public Stomach Stomach { get; set; }
}

public class Chest
{
    public Health1 Health { get; set; }
}

public class Health1
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Head
{
    public Health2 Health { get; set; }
}

public class Health2
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Leftarm
{
    public Health3 Health { get; set; }
}

public class Health3
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Leftleg
{
    public Health4 Health { get; set; }
}

public class Health4
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Rightarm
{
    public Health5 Health { get; set; }
}

public class Health5
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Rightleg
{
    public Health6 Health { get; set; }
}

public class Health6
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Stomach
{
    public Health7 Health { get; set; }
}

public class Health7
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Energy
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Hydration
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Temperature
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Hideout
{
    public Area[] Areas { get; set; }
    public Improvements Improvements { get; set; }
    public Production Production { get; set; }
    public float sptUpdateLastRunTimestamp { get; set; }
}

public class Improvements
{
}

public class Production
{
}

public class Area
{
    public bool active { get; set; }
    public float completeTime { get; set; }
    public bool constructing { get; set; }
    public string lastRecipe { get; set; }
    public float level { get; set; }
    public bool passiveBonusesEnabled { get; set; }
    public Slot[] slots { get; set; }
    public float type { get; set; }
}

public class Slot
{
    public float locationIndex { get; set; }
}

public class Info1
{
    public float AccountType { get; set; }
    public bool BannedState { get; set; }
    public float BannedUntil { get; set; }
    public object[] Bans { get; set; }
    public float Experience { get; set; }
    public string GameVersion { get; set; }
    public bool IsStreamerModeAvailable { get; set; }
    public float LastTimePlayedAsSavage { get; set; }
    public float Level { get; set; }
    public string LowerNickname { get; set; }
    public float MemberCategory { get; set; }
    public string Nickname { get; set; }
    public float NicknameChangeDate { get; set; }
    public float RegistrationDate { get; set; }
    public float SavageLockTime { get; set; }
    public Settings Settings { get; set; }
    public string Side { get; set; }
    public string Voice { get; set; }
    public bool lockedMoveCommands { get; set; }
}

public class Settings
{
    public string BotDifficulty { get; set; }
    public float Experience { get; set; }
    public string Role { get; set; }
}

public class Inventory
{
    public string equipment { get; set; }
    public Fastpanel fastPanel { get; set; }
    public Item[] items { get; set; }
    public string questRaidItems { get; set; }
    public string questStashItems { get; set; }
    public string sortingTable { get; set; }
    public string stash { get; set; }
}

public class Fastpanel
{
}

public class Item
{
    public string _id { get; set; }
    public string _tpl { get; set; }
    public string parentId { get; set; }
    public string slotId { get; set; }
    public Upd upd { get; set; }
    public object location { get; set; }
}

public class Upd
{
    public Repairable Repairable { get; set; }
    public Firemode FireMode { get; set; }
    public Medkit MedKit { get; set; }
    public float StackObjectsCount { get; set; }
    public Key Key { get; set; }
    public bool SpawnedInSession { get; set; }
    public Resource Resource { get; set; }
    public Sight Sight { get; set; }
    public Fooddrink FoodDrink { get; set; }
    public Foldable Foldable { get; set; }
}

public class Repairable
{
    public float MaxDurability { get; set; }
    public float Durability { get; set; }
}

public class Firemode
{
    public string FireMode { get; set; }
}

public class Medkit
{
    public float HpResource { get; set; }
}

public class Key
{
    public float NumberOfUsages { get; set; }
}

public class Resource
{
    public float Value { get; set; }
}

public class Sight
{
    public float[] ScopesCurrentCalibPointIndexes { get; set; }
    public float[] ScopesSelectedModes { get; set; }
    public float SelectedScope { get; set; }
}

public class Fooddrink
{
    public float HpPercent { get; set; }
}

public class Foldable
{
    public bool Folded { get; set; }
}

public class Ragfairinfo
{
    public bool isRatingGrowing { get; set; }
    public object[] offers { get; set; }
    public float rating { get; set; }
}

public class Skills
{
    public Common[] Common { get; set; }
    public Mastering[] Mastering { get; set; }
    public float Points { get; set; }
}

public class Common
{
    public string Id { get; set; }
    public float Progress { get; set; }
    public float PointsEarnedDuringSession { get; set; }
    public float LastAccess { get; set; }
}

public class Mastering
{
    public string Id { get; set; }
    public float Progress { get; set; }
}

public class Stats
{
    public Sessioncounters SessionCounters { get; set; }
    public Overallcounters OverallCounters { get; set; }
    public float SessionExperienceMult { get; set; }
    public float ExperienceBonusMult { get; set; }
    public float TotalSessionExperience { get; set; }
    public float LastSessionDate { get; set; }
    public object[] DroppedItems { get; set; }
    public object[] FoundInRaidItems { get; set; }
    public object[] Victims { get; set; }
    public object[] CarriedQuestItems { get; set; }
    public Damagehistory DamageHistory { get; set; }
    public Deathcause DeathCause { get; set; }
    public float TotalInGameTime { get; set; }
    public string SurvivorClass { get; set; }
}

public class Sessioncounters
{
    public Item1[] Items { get; set; }
}

public class Item1
{
    public string[] Key { get; set; }
    public float Value { get; set; }
}

public class Overallcounters
{
    public Item2[] Items { get; set; }
}

public class Item2
{
    public string[] Key { get; set; }
    public float Value { get; set; }
}

public class Damagehistory
{
    public string LethalDamagePart { get; set; }
    public Bodyparts1 BodyParts { get; set; }
}

public class Bodyparts1
{
    public object[] Head { get; set; }
    public object[] Chest { get; set; }
    public object[] Stomach { get; set; }
    public object[] LeftArm { get; set; }
    public object[] RightArm { get; set; }
    public object[] LeftLeg { get; set; }
    public object[] RightLeg { get; set; }
}

public class Deathcause
{
    public string DamageType { get; set; }
    public string Side { get; set; }
    public string Role { get; set; }
    public string WeaponId { get; set; }
}

public class Tradersinfo
{
    public _54Cb50c76803fa8b248b4571 _54cb50c76803fa8b248b4571 { get; set; }
    public _54Cb57776803fa99248b456e _54cb57776803fa99248b456e { get; set; }
    public _579Dc571d53a0658a154fbec _579dc571d53a0658a154fbec { get; set; }
    public _58330581Ace78e27b8b10cee _58330581ace78e27b8b10cee { get; set; }
    public _5935C25fb3acc3127c3d8cd9 _5935c25fb3acc3127c3d8cd9 { get; set; }
    public _5A7c2eca46aef81a7ca2145d _5a7c2eca46aef81a7ca2145d { get; set; }
    public _5Ac3b934156ae10c4430e83c _5ac3b934156ae10c4430e83c { get; set; }
    public _5C0647fdd443bc2504c2d371 _5c0647fdd443bc2504c2d371 { get; set; }
    public _638F541a29ffd1183d187f57 _638f541a29ffd1183d187f57 { get; set; }
    public Ragfair ragfair { get; set; }
    public Cooptrader coopTrader { get; set; }
    public Usectrader usecTrader { get; set; }
    public Beartrader bearTrader { get; set; }
}

public class _54Cb50c76803fa8b248b4571
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class _54Cb57776803fa99248b456e
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class _579Dc571d53a0658a154fbec
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class _58330581Ace78e27b8b10cee
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class _5935C25fb3acc3127c3d8cd9
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class _5A7c2eca46aef81a7ca2145d
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class _5Ac3b934156ae10c4430e83c
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class _5C0647fdd443bc2504c2d371
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class _638F541a29ffd1183d187f57
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class Ragfair
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class Cooptrader
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class Usectrader
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class Beartrader
{
    public bool disabled { get; set; }
    public float loyaltyLevel { get; set; }
    public float salesSum { get; set; }
    public float standing { get; set; }
    public float nextResupply { get; set; }
    public bool unlocked { get; set; }
}

public class Carextractcounts
{
}

public class Unlockedinfo
{
    public object[] unlockedProductionRecipe { get; set; }
}

public class Bonus
{
    public string templateId { get; set; }
    public string type { get; set; }
}

public class Quest
{
    public string qid { get; set; }
    public float startTime { get; set; }
    public float status { get; set; }
    public Statustimers statusTimers { get; set; }
    public string[] completedConditions { get; set; }
    public float availableAfter { get; set; }
}

public class Statustimers
{
    public float _1 { get; set; }
}

public class Repeatablequest
{
    public string name { get; set; }
    public object[] activeQuests { get; set; }
    public object[] inactiveQuests { get; set; }
    public float endTime { get; set; }
    public Changerequirement changeRequirement { get; set; }
}

public class Changerequirement
{
}

public class Scav
{
    public string _id { get; set; }
    public string aid { get; set; }
    public object savage { get; set; }
    public Info2 Info { get; set; }
    public Customization1 Customization { get; set; }
    public Health8 Health { get; set; }
    public Inventory1 Inventory { get; set; }
    public Skills1 Skills { get; set; }
    public Stats1 Stats { get; set; }
    public object Encyclopedia { get; set; }
    public Conditioncounters1 ConditionCounters { get; set; }
    public Backendcounters1 BackendCounters { get; set; }
    public object[] InsuredItems { get; set; }
    public Hideout1 Hideout { get; set; }
    public object[] Bonuses { get; set; }
    public Tradersinfo1 TradersInfo { get; set; }
}

public class Info2
{
    public string Nickname { get; set; }
    public string LowerNickname { get; set; }
    public string Side { get; set; }
    public string Voice { get; set; }
    public float Level { get; set; }
    public float Experience { get; set; }
    public float RegistrationDate { get; set; }
    public string GameVersion { get; set; }
    public float AccountType { get; set; }
    public float MemberCategory { get; set; }
    public bool lockedMoveCommands { get; set; }
    public float SavageLockTime { get; set; }
    public float LastTimePlayedAsSavage { get; set; }
    public Settings1 Settings { get; set; }
    public float NicknameChangeDate { get; set; }
    public object[] NeedWipeOptions { get; set; }
    public object lastCompletedWipe { get; set; }
    public object lastCompletedEvent { get; set; }
    public bool BannedState { get; set; }
    public float BannedUntil { get; set; }
    public bool IsStreamerModeAvailable { get; set; }
    public bool SquadInviteRestriction { get; set; }
}

public class Settings1
{
}

public class Customization1
{
    public string Head { get; set; }
    public string Body { get; set; }
    public string Feet { get; set; }
    public string Hands { get; set; }
}

public class Health8
{
    public Hydration1 Hydration { get; set; }
    public Energy1 Energy { get; set; }
    public Temperature1 Temperature { get; set; }
    public Bodyparts2 BodyParts { get; set; }
    public float UpdateTime { get; set; }
}

public class Hydration1
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Energy1
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Temperature1
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Bodyparts2
{
    public Head1 Head { get; set; }
    public Chest1 Chest { get; set; }
    public Stomach1 Stomach { get; set; }
    public Leftarm1 LeftArm { get; set; }
    public Rightarm1 RightArm { get; set; }
    public Leftleg1 LeftLeg { get; set; }
    public Rightleg1 RightLeg { get; set; }
}

public class Head1
{
    public Health9 Health { get; set; }
}

public class Health9
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Chest1
{
    public Health10 Health { get; set; }
}

public class Health10
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Stomach1
{
    public Health11 Health { get; set; }
}

public class Health11
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Leftarm1
{
    public Health12 Health { get; set; }
}

public class Health12
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Rightarm1
{
    public Health13 Health { get; set; }
}

public class Health13
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Leftleg1
{
    public Health14 Health { get; set; }
}

public class Health14
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Rightleg1
{
    public Health15 Health { get; set; }
}

public class Health15
{
    public float Current { get; set; }
    public float Maximum { get; set; }
}

public class Inventory1
{
    public Item3[] items { get; set; }
    public string equipment { get; set; }
    public string stash { get; set; }
    public string questRaidItems { get; set; }
    public string questStashItems { get; set; }
    public string sortingTable { get; set; }
    public Fastpanel1 fastPanel { get; set; }
}

public class Fastpanel1
{
}

public class Item3
{
    public string _id { get; set; }
    public string _tpl { get; set; }
    public string parentId { get; set; }
    public string slotId { get; set; }
    public Upd1 upd { get; set; }
    public object location { get; set; }
}

public class Upd1
{
    public Repairable1 Repairable { get; set; }
    public Firemode1 FireMode { get; set; }
    public float StackObjectsCount { get; set; }
    public Medkit1 MedKit { get; set; }
    public Fooddrink1 FoodDrink { get; set; }
}

public class Repairable1
{
    public float Durability { get; set; }
    public float MaxDurability { get; set; }
}

public class Firemode1
{
    public string FireMode { get; set; }
}

public class Medkit1
{
    public float HpResource { get; set; }
}

public class Fooddrink1
{
    public float HpPercent { get; set; }
}

public class Skills1
{
    public object[] Common { get; set; }
    public object[] Mastering { get; set; }
    public float Points { get; set; }
}

public class Stats1
{
    public object[] CarriedQuestItems { get; set; }
    public object[] Victims { get; set; }
    public float TotalSessionExperience { get; set; }
    public float LastSessionDate { get; set; }
    public Sessioncounters1 SessionCounters { get; set; }
    public Overallcounters1 OverallCounters { get; set; }
    public float TotalInGameTime { get; set; }
}

public class Sessioncounters1
{
    public object[] Items { get; set; }
}

public class Overallcounters1
{
    public object[] Items { get; set; }
}

public class Conditioncounters1
{
    public object[] Counters { get; set; }
}

public class Backendcounters1
{
}

public class Hideout1
{
    public Production1 Production { get; set; }
    public Area1[] Areas { get; set; }
}

public class Production1
{
}

public class Area1
{
    public float type { get; set; }
    public float level { get; set; }
    public bool active { get; set; }
    public bool passiveBonusesEnabled { get; set; }
    public float completeTime { get; set; }
    public bool constructing { get; set; }
    public object[] slots { get; set; }
    public object lastRecipe { get; set; }
}

public class Tradersinfo1
{
}

public class Weaponbuilds
{
}

public class Dialogues
{
}

public class Aki
{
    public string version { get; set; }
    public Mod[] mods { get; set; }
}

public class Mod
{
    public string author { get; set; }
    public long dateAdded { get; set; }
    public string name { get; set; }
    public string version { get; set; }
}

public class Vitality
{
    public Health16 health { get; set; }
    public Effects effects { get; set; }
}

public class Health16
{
    public float Hydration { get; set; }
    public float Energy { get; set; }
    public float Temperature { get; set; }
    public float Head { get; set; }
    public float Chest { get; set; }
    public float Stomach { get; set; }
    public float LeftArm { get; set; }
    public float RightArm { get; set; }
    public float LeftLeg { get; set; }
    public float RightLeg { get; set; }
}

public class Effects
{
    public Head2 Head { get; set; }
    public Chest2 Chest { get; set; }
    public Stomach2 Stomach { get; set; }
    public Leftarm2 LeftArm { get; set; }
    public Rightarm2 RightArm { get; set; }
    public Leftleg2 LeftLeg { get; set; }
    public Rightleg2 RightLeg { get; set; }
}

public class Head2
{
}

public class Chest2
{
}

public class Stomach2
{
}

public class Leftarm2
{
}

public class Rightarm2
{
}

public class Leftleg2
{
}

public class Rightleg2
{
}

public class Inraid
{
    public string location { get; set; }
    public string character { get; set; }
}

public class Traderpurchases
{
}