using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster (int id, string name, int maxDamage, int rewardExperience, int rewardGold, int currentHitPoints, int maximumHitPoints) : base (currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaxDamage = maxDamage;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;

            LootTable = new List<LootItem>();
        }
    }
}
