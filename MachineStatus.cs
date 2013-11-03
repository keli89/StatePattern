using System;

namespace StatePattern
{
    public class MachineStatus
    {
        public const string InsertedQuarterMessage = "InsertedQuarterMessage";
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

        public virtual string InsertedQuarterAction(GumballMachine gumballMachine)
        {
            if (gumballMachine.State == SOLD)
                return SoldMessage;
            if (gumballMachine.State == SOLD_OUT)
                return SoldOutMessage;
                return HasQuarterMessage;
        }

        public virtual string TurnCrankAction(GumballMachine gumballMachine)
        {
            if (gumballMachine.State == SOLD)
                return SoldMessage;
            if (gumballMachine.State == SOLD_OUT)
                return SoldOutMessage;

            gumballMachine.State = SOLD;
            return SoldCorrectMessage;
        }

        public virtual string DispenseAction(GumballMachine gumballMachine)
        {
            if (gumballMachine.State == HAS_QUARTER)
                return HasQuarterMessage;
            if (gumballMachine.State == SOLD_OUT)
                return SoldOutMessage;

            gumballMachine.GumballNum--;
            if (gumballMachine.GumballNum == 0)
            {
                gumballMachine.State = SOLD_OUT;
                return NoGumballMessage;
            }

            gumballMachine.State = NO_QUARTER;
            return DispenseSucessMessage;
        }

        public virtual string EjectQuarterAction(GumballMachine gumballMachine)
        {
            if (gumballMachine.State == SOLD_OUT)
                return SoldOutMessage;
            if (gumballMachine.State == SOLD)
                return SoldMessage;

            gumballMachine.State = NO_QUARTER;
            return EjectSucessMessage;
        }
    }
}