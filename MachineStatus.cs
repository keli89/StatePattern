using System;

namespace StatePattern
{
    public abstract class MachineStatus
    {
        protected const string InsertedQuarterMessage = "InsertedQuarterMessage";
        protected const string SoldOutMessage = "SoldOutMessage";
        protected const string SoldMessage = "SoldMessage";
        protected const string SoldCorrectMessage = "SoldCorrectMessage";
        protected const string HasQuarterMessage = "HasQuarterMessage";
        protected const string NoQuarterMessage = "NoQuarterMessage";
        protected const string NoGumballMessage = "NoGumballMessage";
        protected const string DispenseSucessMessage = "DispenseSucessMessage";
        protected const string EjectSucessMessage = "EjectSucessMessage";

        public static MachineStatus NO_QUARTER = new MachineStatusNoQuarter("NO_QUARTER");
        public static MachineStatus HAS_QUARTER = new MachineStatusHasQuarter("HAS_QUARTER");
        public static MachineStatus SOLD_OUT = new MachineStatusSoldOut("SOLD_OUT");
        public static MachineStatus SOLD = new MachineStatusSold("SOLD");
        private readonly String name;

        protected MachineStatus(String name)
        {
            this.name = name;
        }

        public String toString()
        {
            return name;
        }

        public abstract string InsertedQuarterAction(GumballMachine gumballMachine);

        public abstract string TurnCrankAction(GumballMachine gumballMachine);

        public abstract string DispenseAction(GumballMachine gumballMachine);

        public abstract string EjectQuarterAction(GumballMachine gumballMachine);
    }
}