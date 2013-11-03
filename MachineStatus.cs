using System;

namespace StatePattern
{
    public class MachineStatus
    {
        private String name;
        public const string InsertedQuarterMessage = "InsertedQuarterMessage";
        private const string SoldOutMessage = "SoldOutMessage";
        private const string SoldMessage = "SoldMessage";
        private const string SoldCorrectMessage = "SoldCorrectMessage";
        private const string HasQuarterMessage = "HasQuarterMessage";
        private const string NoQuarterMessage = "NoQuarterMessage";
        private const string NoGumballMessage = "NoGumballMessage";
        private const string DispenseSucessMessage = "DispenseSucessMessage";
        private const string EjectSucessMessage = "EjectSucessMessage";

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

        public string InsertedQuarterAction(GumballMachine gumballMachine)
        {
            if (gumballMachine.State == SOLD)
                return SoldMessage;
            if (gumballMachine.State == SOLD_OUT)
                return SoldOutMessage;
            if (gumballMachine.State == HAS_QUARTER)
                return HasQuarterMessage;

            gumballMachine.State = HAS_QUARTER;
            return GumballMachine.InsertedQuarterMessage;
        }

        public string TurnCrankAction(GumballMachine gumballMachine)
        {
            if (gumballMachine.State == SOLD)
                return SoldMessage;
            if (gumballMachine.State == NO_QUARTER)
                return NoQuarterMessage;
            if (gumballMachine.State == SOLD_OUT)
                return SoldOutMessage;

            gumballMachine.State = SOLD;
            return SoldCorrectMessage;
        }

        public string DispenseAction(GumballMachine gumballMachine)
        {
            if (gumballMachine.State == NO_QUARTER)
                return NoQuarterMessage;
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

        public string EjectQuarterAction(GumballMachine gumballMachine)
        {
            if (gumballMachine.State == NO_QUARTER)
                return NoQuarterMessage;
            if (gumballMachine.State == SOLD_OUT)
                return SoldOutMessage;
            if (gumballMachine.State == SOLD)
                return SoldMessage;

            gumballMachine.State = NO_QUARTER;
            return EjectSucessMessage;
        }
    }
}




   