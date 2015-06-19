using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class Gladiator
    {
        public Gladiator(int totalSpendablePoints)
        {
            _points = totalSpendablePoints;
            _skills = new List<Skill>();
            _equipment = new List<Equipment>();
        }

        private readonly int _points;
        public int SpentPoints;

        public void AddSkill(Skill skill)
        {
            _skills.Add(skill);
        }

        public int SpendablePoints
        {
            get { return _points - SpentPoints; }
        }

        private List<Skill> _skills;
        private List<Equipment> _equipment;

        private static Gladiator Build(int spendablePoints)
        {
            var gladiator = new Gladiator(spendablePoints);

            return gladiator;
        }
    }

    static class GladiatorPurchasables
    {
        static GladiatorPurchasables()
        {
            random = new Random();

            List<Tier> weaponTiers = new List<Tier> { 
                new Tier { Multiplier = 0.75, Name = "Oak" }, 
                new Tier { Multiplier = 1.25, Name = "Copper" },
                new Tier { Multiplier = 2, Name = "Iron" },
                new Tier { Multiplier = 2, Name = "Bronze" }, 
                new Tier { Multiplier = 3, Name = "Silver" }, 
                new Tier { Multiplier = 4, Name = "Steel" },
                new Tier { Multiplier = 4, Name = "Platinum" },
                new Tier { Multiplier = 12, Name = "Adamantine" } 
            };

            // Weapons
            var largeDagger = new Weapon() { Name = "Large Dagger", BaseCost = 16 };
            var whip = new Weapon() { Name = "Whip", BaseCost = 26 };
            var scourge = new Weapon() { Name = "Scourge", BaseCost = 28 };
            var shortSword = new Weapon() { Name = "Short Sword", BaseCost = 20 };
            var longSword = new Weapon() { Name = "Long Sword", BaseCost = 24 };
            var twoHandedSword = new Weapon() { Name = "Two-Handed Sword", BaseCost = 28 };
            var battleAxe = new Weapon() { Name = "Battle Axe", BaseCost = 24 };
            var halberd = new Weapon() { Name = "Halberd", BaseCost = 28 };
            var greatAxe = new Weapon() { Name = "Great Axe", BaseCost = 30 };
            var mace = new Weapon() { Name = "Mace", BaseCost = 26 };
            var flail = new Weapon() { Name = "Flail", BaseCost = 28 };
            var warhammer = new Weapon() { Name = "Warhammer", BaseCost = 26 };
            var maul = new Weapon() { Name = "Maul", BaseCost = 32 };
            var morningStar = new Weapon() { Name = "Morning Star", BaseCost = 26 };
            var spear = new Weapon() { Name = "Spear", BaseCost = 20 };
            var pike = new Weapon() { Name = "Pike", BaseCost = 22 };
            var pick = new Weapon() { Name = "Pick", BaseCost = 12 };
            var bow = new Weapon() { Name = "Bow", BaseCost = 26 };
            var crossbow = new Weapon() { Name = "Crossbow", BaseCost = 26 };

            var breastPlate = new Armour() { Name = "Breast Plate", BaseCost = 20 };
            var leggings = new Armour() { Name = "Leggings", BaseCost = 14 };
            var greaves = new Armour() { Name = "Greaves", BaseCost = 18 };
            var gauntlets = new Armour() { Name = "Gauntlets", BaseCost = 8 };
            var lowBoots = new Armour() { Name = "Low Boots", BaseCost = 8 };
            var highBoots = new Armour() { Name = "High Boots", BaseCost = 10 };
            var helm = new Armour() { Name = "Helm", BaseCost = 12 };
            var cap = new Armour() { Name = "Cap", BaseCost = 10 };
            var mailShirt = new Armour() { Name = "Mail Shirt", BaseCost = 24 };

            weapons = new List<Weapon>()
            {
	            largeDagger,
	            whip,
	            scourge,
	            shortSword,
	            longSword,
	            twoHandedSword,
	            battleAxe,
	            halberd,
	            greatAxe,
	            mace,
	            flail,
	            warhammer,
	            maul,
	            morningStar,
	            spear,
	            pike,
                pick,
	            bow,
	            crossbow
            };

            armour = new List<Armour>()
            {
                helm,
                cap,
                mailShirt,
                breastPlate,
                leggings,
                greaves,
                gauntlets,
                lowBoots,
                highBoots
            };

            var knifeSkill = new Skill(){Name ="Knife",BaseCost= 5,Benefits= new List<Equipment>(){ largeDagger} };
            var lashingSkill = new Skill(){Name ="Lashing",BaseCost= 5,Benefits= new List<Equipment>(){ whip} };
            var scourgeSkill = new Skill(){Name ="Scourge",BaseCost= 5,Benefits= new List<Equipment>(){ scourge} };
            var shortSwordSkill = new Skill(){Name ="Short Sword",BaseCost= 6,Benefits= new List<Equipment>(){ shortSword} };
            var longSwordSkill = new Skill(){Name ="Long Sword",BaseCost= 6,Benefits= new List<Equipment>(){ longSword} };
            var twoHandedSwordSkill = new Skill(){Name ="Two-Handed Sword",BaseCost= 6,Benefits= new List<Equipment>(){ twoHandedSword} };
            var battleAxeSkill = new Skill(){Name ="Battle Axe",BaseCost= 6,Benefits= new List<Equipment>(){ battleAxe} };
            var halberdSkill = new Skill(){Name ="Halberd",BaseCost= 6,Benefits= new List<Equipment>(){ halberd} };
            var greatAxeSkill = new Skill(){Name ="Great Axe",BaseCost= 6,Benefits= new List<Equipment>(){ greatAxe} };
            var maceSkill = new Skill(){Name ="Mace",BaseCost= 6,Benefits= new List<Equipment>(){ mace} };
            var flailSkill = new Skill(){Name ="Flail",BaseCost= 6,Benefits= new List<Equipment>(){ flail} };
            var warhammerSkill = new Skill(){Name ="Warhammer",BaseCost= 6,Benefits= new List<Equipment>(){ warhammer} };
            var maulSkill = new Skill(){Name ="Maul",BaseCost= 6,Benefits= new List<Equipment>(){ maul} };
            var morningStarSkill = new Skill(){Name ="Morning Star",BaseCost= 6,Benefits= new List<Equipment>(){ morningStar} };
            var spearSkill = new Skill(){Name ="Spear",BaseCost= 5,Benefits= new List<Equipment>(){ spear} };
            var pikeSkill = new Skill(){Name ="Pike",BaseCost= 5,Benefits= new List<Equipment>(){ pike} };
            var bowSkill = new Skill(){Name ="Bow",BaseCost= 5,Benefits= new List<Equipment>(){ bow} };
            var crossbowSkill = new Skill(){Name ="Crossbow",BaseCost= 5,Benefits= new List<Equipment>(){ crossbow} };
            var archerySkill = new Skill(){Name ="Archery",BaseCost= 3,Benefits= new List<Equipment>(){ crossbow, bow} };
            var fighting= new Skill(){Name ="Fighting",BaseCost= 3,Benefits= new List<Equipment>(){ whip, largeDagger, scourge, shortSword, longSword, twoHandedSword, battleAxe, mace, flail, warhammer, maul, morningStar, spear, pike, pick} };
            var wrestling= new Skill(){Name ="Wrestling",BaseCost= 4,Benefits= new List<Equipment>(){ whip, largeDagger, scourge, shortSword, longSword, twoHandedSword, battleAxe, mace, flail, warhammer, maul, morningStar, spear, pike, pick, bow, crossbow, breastPlate, leggings, greaves, gauntlets, lowBoots, highBoots, helm, cap, mailShirt, sheild, buckler} };
            var striking= new Skill(){Name ="Striking",BaseCost= 4,Benefits= new List<Equipment>(){ whip, largeDagger, scourge, shortSword, longSword, twoHandedSword, battleAxe, mace, flail, warhammer, maul, morningStar, spear, pike, pick, bow, crossbow, breastPlate, leggings, greaves, gauntlets, lowBoots, highBoots, helm, cap, mailShirt, sheild, buckler} };
            var biting= new Skill(){Name ="Biting",BaseCost= 4,Benefits= new List<Equipment>(){ whip, largeDagger, scourge, shortSword, longSword, twoHandedSword, battleAxe, mace, flail, warhammer, maul, morningStar, spear, pike, pick, bow, crossbow, breastPlate, leggings, greaves, gauntlets, lowBoots, highBoots, helm, cap, mailShirt, sheild, buckler} };
            var dodging= new Skill(){Name ="Dodging",BaseCost= 5,Benefits= new List<Equipment>(){ whip, largeDagger, scourge, shortSword, longSword, twoHandedSword, battleAxe, mace, flail, warhammer, maul, morningStar, spear, pike, pick, bow, crossbow, breastPlate, leggings, greaves, gauntlets, lowBoots, highBoots, helm, cap, mailShirt, sheild, buckler} };
            var dodgingTiny= new Skill(){Name ="Dodging (Tiny)",BaseCost= 5,Benefits= new List<Equipment>(){ whip, largeDagger, scourge, shortSword, longSword, twoHandedSword, battleAxe, mace, flail, warhammer, maul, morningStar, spear, pike, pick, bow, crossbow, breastPlate, leggings, greaves, gauntlets, lowBoots, highBoots, helm, cap, mailShirt, sheild, buckler} };
            var dodgingHuge= new Skill(){Name ="Dodging (Huge)",BaseCost= 6,Benefits= new List<Equipment>(){ whip, largeDagger, scourge, shortSword, longSword, twoHandedSword, battleAxe, mace, flail, warhammer, maul, morningStar, spear, pike, pick, bow, crossbow, breastPlate, leggings, greaves, gauntlets, lowBoots, highBoots, helm, cap, mailShirt, sheild, buckler} };
            var sheildSkill = new Skill(){Name ="Sheild Skill",BaseCost= 4,Benefits= new List<Equipment>(){ whip, largeDagger, scourge, shortSword, longSword, twoHandedSword, battleAxe, mace, flail, warhammer, maul, morningStar, spear, pike, pick, breastPlate, leggings, greaves, gauntlets, lowBoots, highBoots, helm, cap, mailShirt, sheild, buckler} };
            var armourSkill = new Skill(){Name ="Armour Skill",BaseCost= 3,Benefits= new List<Equipment>(){ whip, largeDagger, scourge, shortSword, longSword, twoHandedSword, battleAxe, mace, flail, warhammer, maul, morningStar, spear, pike, pick, bow, crossbow, breastPlate, leggings, greaves, gauntlets, lowBoots, highBoots, helm, cap, mailShirt, sheild, buckler} };

            skills = new List<Skill>()
            {
                knifeSkill,
                lashingSkill,
                scourgeSkill,
                shortSwordSkill,
                longSwordSkill,
                twoHandedSwordSkill,
                battleAxeSkill,
                halberdSkill,
                greatAxeSkill,
                flailSkill,
                warhammerSkill,
                maulSkill,
                morningStarSkill,                
                maceSkill,
                pikeSkill,               
                bowSkill,
                crossbowSkill,
                spearSkill,
                archerySkill,
                fighting,
                wrestling,
                striking,
                biting,
                dodging,
                dodgingTiny,
                dodgingHuge,
                sheildSkill,
                armourSkill

            };


        }


        private static List<string> skillNames = new List<string>()
        {
             "Novice",
             "Adequate"
        };

        private static List<Armour> armour;



        private static Random random;

        private static List<Weapon> weapons;

        private static List<Skill> skills;

        public static void SpecializeGladiator(Gladiator gladiator)
        {
            var skillFocus = random.Next(30, 70);
            var pointsForSkills = Math.Floor(Convert.ToDouble(gladiator.SpendablePoints) * (Convert.ToDouble(skillFocus) / 100));
            GetSkills(gladiator, Convert.ToInt32(pointsForSkills));
        }

        public static void GetSkills(Gladiator gladiator, int points)
        {
            var buyableSkills = new List<Skill>();
            var boughtSkills = new List<Skill>();

            foreach (var skill in skills)
                buyableSkills.Add(skill);

            var failedAttempts = 0;

            while (points > 0)
            {
                var indexToBuy = random.Next(0, buyableSkills.Count);
                var skillToBuy = buyableSkills[indexToBuy];
                var pointsToSpend = random.Next(0, points);

                var levelsToBuy = skillToBuy.LevelsForPoints(pointsToSpend);
                var costForLevels = skillToBuy.PointsForLevel(levelsToBuy);
                
                points -= costForLevels;
                gladiator.SpentPoints += costForLevels;

                skillToBuy.TierName = skillNames[levelsToBuy - 1];
                boughtSkills.Add(skillToBuy);
                gladiator.AddSkill(skillToBuy);

                if (levelsToBuy == 0)
                    failedAttempts++;
                else
                    buyableSkills = GetCompatibleSkills(boughtSkills);
                
                if (failedAttempts > 10)
                    break;
            }
        }

        public static List<Skill> GetCompatibleSkills(List<Skill> skillsToCheck)
        {
            var benefittedEquipment = new List<Equipment>();
            
            foreach(var skill in skillsToCheck)
                benefittedEquipment.AddRange(skill.Benefits);

            return skills.Where(skill => skill.Benefits.Any(benefit => benefittedEquipment.Contains(benefit))).ToList();
        }
    }
}
