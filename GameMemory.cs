using System.Diagnostics;

namespace LiveSplit.OoS
{
    class OoSMemory
    {
        public Emulator emulator { get; set; }
        public GameVersion version { get; set; }

        public int ptrBase;
        public int[] ptrOffsetsA;
        public int[] ptrOffsetsB;

        public DeepPointer Sword, D1Ess, D2Ess, D3Ess, D4Ess, D5Ess, D6Ess, D7Ess, D8Ess, BossHP;
        public DeepPointer D1Enter, D2Enter, D3Enter, D4Enter, D5Enter, D6Enter, D7Enter, D8Enter, NPEnter;
        public DeepPointer VersionCheck, FileSelect1, FileSelect2, ResetCheck;

        public OoSMemory()
        {

        }

        public void setOffsets()
        {
            if (emulator == Emulator.bgb151)
            {
                ptrBase = 0x000FC5CC;
                ptrOffsetsA = new int[] { 0xF5C, 0x1A8 };
                ptrOffsetsB = new int[] { 0xF5C, 0x264 };
            }
            else if (emulator == Emulator.bgb152)
            {
                ptrBase = 0x000FE5CC;
                ptrOffsetsA = new int[] { 0xC4C, 0x1B0 };
                ptrOffsetsB = new int[] { 0xC4C, 0x26C };
            }
            else if (emulator == Emulator.gambatte571)
            {
                ptrBase = 0x00552038;
                ptrOffsetsA = new int[] { 0x1C, 0x10, 0x10, 0x110, 0x6C };
                ptrOffsetsB = new int[] { 0x1C, 0x10, 0x10, 0x110, 0x8C };
            }

            VersionCheck = new DeepPointer(ptrBase, ptrOffsetsA, 0x2FD);
            FileSelect1 = new DeepPointer(ptrBase, ptrOffsetsA, 0xB00);
            FileSelect2 = new DeepPointer(ptrBase, ptrOffsetsA, 0xBB3);
            ResetCheck = new DeepPointer(ptrBase, ptrOffsetsA, 0);

            setPointers();
        }

        public void setPointers()
        {
            //set A
            Sword = new DeepPointer(ptrBase, ptrOffsetsA, 0x6AC);
            D1Ess = new DeepPointer(ptrBase, ptrOffsetsA, 0x913);
            D2Ess = new DeepPointer(ptrBase, ptrOffsetsA, 0x92C);
            D3Ess = new DeepPointer(ptrBase, ptrOffsetsA, 0x940);
            D4Ess = new DeepPointer(ptrBase, ptrOffsetsA, 0x960);
            D5Ess = new DeepPointer(ptrBase, ptrOffsetsA, 0x988);
            D6Ess = new DeepPointer(ptrBase, ptrOffsetsA, 0x898);
            D7Ess = new DeepPointer(ptrBase, ptrOffsetsA, 0xA4F);
            D8Ess = new DeepPointer(ptrBase, ptrOffsetsA, 0xA5F);
            D1Enter = new DeepPointer(ptrBase, ptrOffsetsA, 0x91C);
            D2Enter = new DeepPointer(ptrBase, ptrOffsetsA, 0x939);
            D3Enter = new DeepPointer(ptrBase, ptrOffsetsA, 0x94B);
            D4Enter = new DeepPointer(ptrBase, ptrOffsetsA, 0x981);
            D5Enter = new DeepPointer(ptrBase, ptrOffsetsA, 0x9A7);
            D6Enter = new DeepPointer(ptrBase, ptrOffsetsA, 0x9BA);
            D7Enter = new DeepPointer(ptrBase, ptrOffsetsA, 0xA5B);
            D8Enter = new DeepPointer(ptrBase, ptrOffsetsA, 0xA87);
            NPEnter = new DeepPointer(ptrBase, ptrOffsetsA, 0xA97);

            //set B
            BossHP = new DeepPointer(ptrBase, ptrOffsetsB, 0x1A9);
        }

        public void getVersion(Process game)
        {
            byte _byte;

            VersionCheck.Deref<byte>(game, out _byte);
            if (_byte == 0x32)
                version = GameVersion.OoS;
            else if (_byte == 0x33)
                version = GameVersion.OoA;

            setPointers();
        }

        public bool doStart(Process game)
        {
            byte _byte;
            short _short;

            FileSelect1.Deref<byte>(game, out _byte);
            if (_byte == 0x23)
            {
                FileSelect2.Deref<short>(game, out _short);
                if (_short == 0x0301)
                    return true;
            }

            return false;
        }

        public bool doReset(Process game)
        {
            byte _byte;

            ResetCheck.Deref<byte>(game, out _byte);
            if (_byte == 0xFF)
                return true;

            return false;
        }

        public bool doSplit(string segment, Process game, OoSSettings settings)
        {
            byte _byte;

            //if (version == GameVersion.unknown)
            //    getVersion(game);

            //dungeon endings
            if (segment == settings.SplitInfo[(int)Splits.L1Sword][1])
            {
                Sword.Deref<byte>(game, out _byte);
                if (_byte == 1)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.D1Ess][1])
            {
                D1Ess.Deref<byte>(game, out _byte);
                if (_byte == 0x30)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.D2Ess][1])
            {
                D2Ess.Deref<byte>(game, out _byte);
                if (_byte == 0x30)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.D3Ess][1])
            {
                D3Ess.Deref<byte>(game, out _byte);
                if (_byte == 0x30)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.D4Ess][1])
            {
                D4Ess.Deref<byte>(game, out _byte);
                if (_byte == 0x30)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.D5Ess][1])
            {
                D5Ess.Deref<byte>(game, out _byte);
                if (_byte == 0x30)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.D6Ess][1])
            {
                D6Ess.Deref<byte>(game, out _byte);
                if (_byte == 0x30)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.D7Ess][1])
            {
                D7Ess.Deref<byte>(game, out _byte);
                if (_byte == 0x30)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.D8Ess][1])
            {
                D8Ess.Deref<byte>(game, out _byte);
                if (_byte == 0x30)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.Onox][1])
            {
                BossHP.Deref<byte>(game, out _byte);
                if (_byte == 0x01)
                    return true;
            }

            //dungeon entrances
            else if (segment == settings.SplitInfo[(int)Splits.EnterD1][1])
            {
                D1Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x10)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.EnterD2][1])
            {
                D2Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x10)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.EnterD3][1])
            {
                D3Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x10)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.EnterD4][1])
            {
                D4Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x10)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.EnterD5][1])
            {
                D5Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x10)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.EnterD6][1])
            {
                D6Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x10)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.EnterD7][1])
            {
                D7Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x10)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.EnterD8][1])
            {
                D8Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x10)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.EnterNP][1])
            {
                NPEnter.Deref<byte>(game, out _byte);
                if (_byte == 0x10)
                    return true;
            }

            return false;
        }

        private enum Splits
        {
            L1Sword, D1Ess, D2Ess, D3Ess, D4Ess, D5Ess, D6Ess, D7Ess, D8Ess, Onox,
            EnterD1, EnterD2, EnterD3, EnterD4, EnterD5, EnterD6, EnterD7, EnterD8, EnterNP
        }
    }

    public enum GameVersion
    {
        unknown,
        OoS,
        OoA
    }

    public enum Emulator
    {
        unknown,
        bgb151,
        bgb152,
        gambatte571
    }
}
