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
            return MachineMessageSugar.InsertedQuarterMessage;
        }

        public override string TurnCrankAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.NoQuarterMessage;
        }

        public override string DispenseAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.NoQuarterMessage;
        }

        public override string EjectQuarterAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.NoQuarterMessage;
        }
    }
}