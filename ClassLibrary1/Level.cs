using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Engine
{
    public class LevelStats
    {
        public int Strength { get; set; }
        public int Magic { get; set; }
        public int Dexerity { get; set; }
        public int Defense { get; set; }
        public int LevelPoints { get; set; }

        public LevelStats(int strength, int magic, int dexerity, int defense, int levelPoints)
        {
            Strength = strength;
            Magic = magic;
            Dexerity = dexerity;
            Defense = defense;
            LevelPoints = levelPoints;
        }
        public static LevelStats CreateDefaultPlayer()
        {
            LevelStats level = new LevelStats(1, 1, 1, 1, 0);
            return level;
        }

        public static LevelStats CreatePlayerFromXmlString(string xmlLevelData)
        {
            try
            {
                XmlDocument levelData = new XmlDocument();

                levelData.LoadXml(xmlLevelData);

                int strength = Convert.ToInt32(levelData.SelectSingleNode("/Player/Stats/strength").InnerText);
                int magic = Convert.ToInt32(levelData.SelectSingleNode("/Player/Stats/Magic").InnerText);
                int dexerity = Convert.ToInt32(levelData.SelectSingleNode("/Player/Stats/Dexerity").InnerText);
                int defense = Convert.ToInt32(levelData.SelectSingleNode("/Player/Stats/Defense").InnerText);
                int levelPoints = Convert.ToInt32(levelData.SelectSingleNode("/Player/Stats/LevelPoints").InnerText);

                LevelStats level = new LevelStats(strength, magic, dexerity, defense, levelPoints);

                return level;
            }
            catch
            {
                // If there was an error with the XML data, return a default player object
                return LevelStats.CreateDefaultPlayer();
            }
        }
        public string ToXmlString()
        {
            XmlDocument levelData = new XmlDocument();

            // Create the top-level XML node
            XmlNode player = levelData.CreateElement("Player");
            levelData.AppendChild(player);

            // Create the "Stats" child node to hold the other player statistics nodes
            XmlNode stats = levelData.CreateElement("Stats");
            player.AppendChild(stats);

            // Create the child nodes for the "Stats" node
            XmlNode strength = levelData.CreateElement("strength");
            strength.AppendChild(levelData.CreateTextNode(strength.ToString()));
            stats.AppendChild(strength);

            XmlNode magic = levelData.CreateElement("Magic");
            magic.AppendChild(levelData.CreateTextNode(magic.ToString()));
            stats.AppendChild(magic);

            XmlNode dexerity = levelData.CreateElement("Dexerity");
            dexerity.AppendChild(levelData.CreateTextNode(dexerity.ToString()));
            stats.AppendChild(dexerity);

            XmlNode defense = levelData.CreateElement("Defense");
            defense.AppendChild(levelData.CreateTextNode(defense.ToString()));
            stats.AppendChild(defense);

            XmlNode levelPoints = levelData.CreateElement("LevelPoints");
            levelPoints.AppendChild(levelData.CreateTextNode(levelPoints.ToString()));
            stats.AppendChild(levelPoints);

            return levelData.InnerXml; // The XML document, as a string, so we can save the data to disk
        }
    }
}
