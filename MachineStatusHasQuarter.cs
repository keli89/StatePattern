namespace StatePattern
{
    public class MachineStatusHasQuarter : MachineStatus
    {
        public MachineStatusHasQuarter(string name) : base(name)
        {
        }

        public override string InsertedQuarterAction(GumballMachine gumballMachine)
        {
            return HasQuarterMessage;
        }

        public override string TurnCrankAction(GumballMachine gumballMachine)
        {
            gumballMachine.State = SOLD;
            return SoldCorrectMessage;
        }

        public override string DispenseAction(GumballMachine gumballMachine)
        {
                return HasQuarterMessage;
        }

        public override string EjectQuarterAction(GumballMachine gumballMachine)
        {
            gumballMachine.State = NO_QUARTER;
            return EjectSucessMessage;
        }
    }
}