using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSHW
{
    public class Temp
    {
        public uint tempSeqNo;
        public byte[] data;
    }
    public class Packet1
    {
        private List<Temp> tempPackets = new List<Temp>();
        private string name;
        private uint order = 0;
        private int data_Length = 0;
        private byte[] data = null;
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public uint Order
        {
            get { return order; }
            set { order = value; }
        }

        public int Data_Length
        {
            get { return data_Length; }
            set { data_Length = value; }
        }

        public byte[] Data
        {
            get { return data; }
            set { data = value; }
        }

        public List<Temp> TempPackets
        {
            get { return tempPackets; }
            set { tempPackets = value; }
        }
    }
}
