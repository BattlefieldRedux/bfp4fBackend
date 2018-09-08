using BlazeLibWV;
using System;

namespace BFP4FLauncherWV
{
    public class GameInfo
    {
        public int id;
        public bool isRunning;

        public Blaze.TdfDoubleList ATTR;
        public uint GSTA;
        public long GSET;
        public long VOIP;
        public string VSTR;
        public string GNAM;
        public int[] slotUse;
        public PlayerInfo[] players;

        public GameInfo()
        {
            players = new PlayerInfo[32];
            slotUse = new int[32];
            for (int i = 0; i < 32; i++)
                slotUse[i] = -1;
        }

        public byte getNextSlot()
        {
            for (byte i = 0; i < 32; i++)
                if (slotUse[i] == -1)
                    return i;
            return 255;
        }

        public void setNextSlot(int id)
        {            
            for (byte i = 0; i < 32; i++)
                if (slotUse[i] == -1)
                {
                    Console.WriteLine("setNextSlot called");
                    slotUse[i] = id;
                    return;
                }
        }

        public void removePlayer(int id)
        {            
            for (byte i = 0; i < 32; i++)
                if (slotUse[i] == id)
                {
                    Console.WriteLine("removePlayer called");
                    slotUse[i] = -1;
                    players[i] = null;
                    return;
                }
        }
    }
}
