using System.Collections.Generic;
using System.Linq;

namespace LiveSplit.OoS
{
    public static class DefaultInfo
    {
        public static InfoList Pointers = new InfoList
        {
            //WRAM0 pointers
            new Info("Sword", "byte", 0, 0x6AC),
            new Info("D1Ess", "byte", 0, 0x913),
            new Info("D2Ess", "byte", 0, 0x92C),
            new Info("D3Ess", "byte", 0, 0x940),
            new Info("D4Ess", "byte", 0, 0x960),
            new Info("D5Ess", "byte", 0, 0x988),
            new Info("D6Ess", "byte", 0, 0x898),
            new Info("D7Ess", "byte", 0, 0xA4F),
            new Info("D8Ess", "byte", 0, 0xA5F),
            new Info("D1Enter", "byte", 0, 0x91C),
            new Info("D2Enter", "byte", 0, 0x939),
            new Info("D3Enter", "byte", 0, 0x94B),
            new Info("D4Enter", "byte", 0, 0x981),
            new Info("D5Enter", "byte", 0, 0x9A7),
            new Info("D6Enter", "byte", 0, 0x9BA),
            new Info("D7Enter", "byte", 0, 0xA5B),
            new Info("D8Enter", "byte", 0, 0xA87),
            new Info("NPEnter", "byte", 0, 0xA97),
            new Info("OnoxEnter", "byte", 0, 0xA91),
            new Info("VersionCheck", "byte", 0, 0x2FD),
            new Info("FileSelect1", "byte", 0, 0xB00),
            new Info("FileSelect2", "short", 0, 0xBB3),
            new Info("ResetCheck", "byte", 0, 0),

            //WRAM1 pointers
            new Info("BossHP", "byte", 1, 0x1A9),
        };

        public static InfoList BaseSplits = new InfoList
        {
            //dungeon entrances
            new Info("ED1", "D1Enter", 0x10),
            new Info("ED2", "D2Enter", 0x10),
            new Info("ED3", "D3Enter", 0x10),
            new Info("ED4", "D4Enter", 0x10),
            new Info("ED5", "D5Enter", 0x10),
            new Info("ED6", "D6Enter", 0x10),
            new Info("ED7", "D7Enter", 0x10),
            new Info("ED8", "D8Enter", 0x10),
            
            //essences
            new Info("D1", "D1Ess", 0x30),
            new Info("D2", "D2Ess", 0x30),
            new Info("D3", "D3Ess", 0x30),
            new Info("D4", "D4Ess", 0x30),
            new Info("D5", "D5Ess", 0x30),
            new Info("D6", "D6Ess", 0x30),
            new Info("D7", "D7Ess", 0x30),
            new Info("D8", "D8Ess", 0x30),

            //others
            new Info("L1Sword", "Sword", 1),
            new Info("ENP", "NPEnter", 0x10),
            new Info("EOnox", "OnoxEnter", 0x10),
            new Info("Onox", new Dictionary<string, int> { { "BossHP", 1 }, { "OnoxEnter", 0x10 } }),
        };
    }

    public class Info
    {
        public string Name { get; }

        public string Type { get; }
        public int Index { get; }
        public int Offset { get; }

        public Dictionary<string, int> Triggers { get; }

        public bool isEnabled { get; set; }

        //pointer
        public Info(string _name, string _type, int _index, int _offset)
        {
            Name = _name;
            Type = _type;
            Index = _index;
            Offset = _offset;
        }

        //single condition
        public Info(string _name, string _pointer, int _condition)
        {
            Name = _name;
            Triggers = new Dictionary<string, int> { { _pointer, _condition } };
        }

        //multiple conditions
        public Info(string _name, Dictionary<string, int> _triggers)
        {
            Name = _name;
            Triggers = _triggers;
        }

        //settings
        public Info(string _name, bool _enabled)
        {
            Name = _name;
            isEnabled = _enabled;
        }
    }

    public class InfoList : List<Info>
    {
        public Info this[string name]
        {
            get { return this.First(w => w.Name == name); }
        }
    }
}
