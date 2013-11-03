namespace StatePattern
{
    public class GumballMachine
    {
        public const string InsertedQuarterMessage = "InsertedQuarterMessage";
        private const string SoldOutMessage = "SoldOutMessage";
        private const string SoldMessage = "SoldMessage";
        private const string SoldCorrectMessage = "SoldCorrectMessage";
        private const string HasQuarterMessage = "HasQuarterMessage";
        private const string NoQuarterMessage = "NoQuarterMessage";
        private const string NoGumballMessage = "NoGumballMessage";
        private const string DispenseSucessMessage = "DispenseSucessMessage";
        private const string EjectSucessMessage = "EjectSucessMessage";

        public GumballMachine(int gumballNum, MachineStatus machineStatus)
        {
            GumballNum = gumballNum;
            State = machineStatus;
        }

        public int GumballNum { get; set; }

        public MachineStatus State { get; set; }

        public string InsertQuarter()
        {
            if (State == MachineStatus.SOLD)
                return SoldMessage;
            if (State == MachineStatus.SOLD_OUT)
                return SoldOutMessage;
            if (State == MachineStatus.HAS_QUARTER)
                return HasQuarterMessage;

            State = MachineStatus.HAS_QUARTER;
            return InsertedQuarterMessage;
        }

        public string TurnCrank()
        {
            if (State == MachineStatus.SOLD)
                return SoldMessage;
            if (State == MachineStatus.NO_QUARTER)
                return NoQuarterMessage;
            if (State == MachineStatus.SOLD_OUT)
                return SoldOutMessage;

            State = MachineStatus.SOLD;
            return SoldCorrectMessage;
        }

        public string Dispense()
        {
            if (State == MachineStatus.NO_QUARTER)
                return NoQuarterMessage;
            if (State == MachineStatus.HAS_QUARTER)
                return HasQuarterMessage;
            if (State == MachineStatus.SOLD_OUT)
                return SoldOutMessage;

            GumballNum--;
            if (GumballNum == 0)
            {
                State = MachineStatus.SOLD_OUT;
                return NoGumballMessage;
            }

            State = MachineStatus.NO_QUARTER;
            return DispenseSucessMessage;
        }

        public string EjectQuarter()
        {
            if (State == MachineStatus.NO_QUARTER)
                return NoQuarterMessage;
            if (State == MachineStatus.SOLD_OUT)
                return SoldOutMessage;
            if (State == MachineStatus.SOLD)
                return SoldMessage;

            State = MachineStatus.NO_QUARTER;
            return EjectSucessMessage;
        }
    }
}