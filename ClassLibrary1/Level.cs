using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LevelStats
    {
        public int Strength { get; set; }
        public int Magic { get; set; }
        public int Dexerity { get; set; }
        public int Defense { get; set; }
        public int LevelPoints { get; set; }

        private LevelStats(int strength, int magic, int dexerity, int defense, int levelPoints)
        {
            Strength = strength;
            Magic = magic;
            Dexerity = dexerity;
            Defense = defense;
            LevelPoints = levelPoints;
        }
        public static LevelStats CreateDefaultPlayer()
        {
            LevelStats level = new LevelStats(1, 1, 1, 1, 1);
            return level;
        }

        public static LevelStats CreatePlayerFromXmlString(string xmlLevelData)
        {
            try
            {
                XmlDocument levelData = new XmlDocument();

                levelData.LoadXml(xmlLevelData);

                int strength = Convert.ToInt32(levelData.SelectSingleNode("/Player/Stats/Strength").InnerText);
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
            XmlDocument LevelData = new XmlDocument();

            // Create the top-level XML node
            XmlNode player = LevelData.CreateElement("Player");
            LevelData.AppendChild(player);

            // Create the "Stats" child node to hold the other player statistics nodes
            XmlNode stats = LevelData.CreateElement("Stats");
            player.AppendChild(stats);

            // Create the child nodes for the "Stats" node
            XmlNode strength = LevelData.CreateElement("Strength");
            strength.AppendChild(LevelData.CreateTextNode(Strength.ToString()));
            stats.AppendChild(strength);

            XmlNode magic = LevelData.CreateElement("Magic");
            magic.AppendChild(LevelData.CreateTextNode(Magic.ToString()));
            stats.AppendChild(magic);

            XmlNode dexerity = LevelData.CreateElement("Dexerity");
            dexerity.AppendChild(LevelData.CreateTextNode(Dexerity.ToString()));
            stats.AppendChild(dexerity);

            XmlNode defense = LevelData.CreateElement("Defense");
            defense.AppendChild(LevelData.CreateTextNode(Defense.ToString()));
            stats.AppendChild(defense);

            XmlNode levelPoints = LevelData.CreateElement("LevelPoints");
            levelPoints.AppendChild(LevelData.CreateTextNode(LevelPoints.ToString()));
            stats.AppendChild(levelPoints);

            return LevelData.InnerXml; // The XML document, as a string, so we can save the data to disk
        }
    }
}
