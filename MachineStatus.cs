using System;

namespace StatePattern
{
    public class MachineStatus
    {
        private String name;

        private MachineStatus(String name)
        {
            this.name = name;
        }

        public static MachineStatus NO_QUARTER = new MachineStatus(" NO_QUARTER");
        public static MachineStatus HAS_QUARTER = new MachineStatus("HAS_QUARTER");
        public static MachineStatus SOLD_OUT = new MachineStatus("SOLD_OUT");
        public static MachineStatus SOLD = new MachineStatus("SOLD");

        public String toString()
        {
            return name;
        }
    }
}




   