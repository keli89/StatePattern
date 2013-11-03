namespace StatePattern
{
    public class MachineStatusNoQuarter : MachineStatus
    {
        public MachineStatusNoQuarter(string name) : base(name)
        {
        }

        public override string InsertedQuarterAction(GumballMachine gumballMachine)
        {
            gumballMachine.State = HAS_QUARTER;
            return InsertedQuarterMessage;
        }

        public override string TurnCrankAction(GumballMachine gumballMachine)
        {
            return NoQuarterMessage;
        }

        public override string DispenseAction(GumballMachine gumballMachine)
        {
            return NoQuarterMessage;
        }

        public override string EjectQuarterAction(GumballMachine gumballMachine)
        {
            return NoQuarterMessage;
        }
    }
}