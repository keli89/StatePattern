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
        public int GumballNum { get;set; }

        public GumballMachine(int gumballNum, MachineStatus machineStatus)
        {
            GumballNum = gumballNum;
            State = machineStatus;
        }

        public MachineStatus State { get;set; }

        public string InsertQuarter()
        {
            return State.InsertedQuarterAction(this);
        }

        public string TurnCrank()
        {
            return State.TurnCrankAction(this);
        }

        public string Dispense()
        {
            return State.DispenseAction(this);
        }

        public string EjectQuarter()
        {
            return State.EjectQuarterAction(this);
        }
    }


}