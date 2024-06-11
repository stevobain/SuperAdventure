﻿using System.Collections.Generic;

namespace Engine
{
    public class Quest
    {
        public int ID {  get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RewardExperiencePoints { get; set; }

        public int RewardGold { get; set; }

        public Item RewardItem { get; set; }

        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest(int iD, string name, string description, int rewardExperiencePoints, int rewardGold)
        {
            ID = iD;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
