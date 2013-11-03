namespace StatePattern
{
    public class MachineStatusSoldOut : MachineStatus
    {
        public MachineStatusSoldOut(string name) : base(name)
        {
        }

        public override string InsertedQuarterAction(GumballMachine gumballMachine)
        {
            return SoldOutMessage;
        }

        public override string TurnCrankAction(GumballMachine gumballMachine)
        {
            return SoldOutMessage;
        }

        public override string DispenseAction(GumballMachine gumballMachine)
        {
            return SoldOutMessage;
        }

        public override string EjectQuarterAction(GumballMachine gumballMachine)
        {
            return SoldOutMessage;
        }
    }
}