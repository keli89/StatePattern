namespace StatePattern
{
    public class MachineStatusHasQuarter : MachineStatus
    {
        public MachineStatusHasQuarter(string name) : base()
        {
        }

        public override string InsertedQuarterAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.HasQuarterMessage;
        }

        public override string TurnCrankAction(GumballMachine gumballMachine)
        {
            gumballMachine.State = SOLD;
            return MachineMessageSugar.SoldCorrectMessage;
        }

        public override string DispenseAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.HasQuarterMessage;
        }

        public override string EjectQuarterAction(GumballMachine gumballMachine)
        {
            gumballMachine.State = NO_QUARTER;
            return MachineMessageSugar.EjectSucessMessage;
        }
    }
}