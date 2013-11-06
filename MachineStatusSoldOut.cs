namespace StatePattern
{
    public class MachineStatusSoldOut : MachineStatus
    {
        public MachineStatusSoldOut(string name) : base()
        {
        }

        public override string InsertedQuarterAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.SoldOutMessage;
        }

        public override string TurnCrankAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.SoldOutMessage;
        }

        public override string DispenseAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.SoldOutMessage;
        }

        public override string EjectQuarterAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.SoldOutMessage;
        }
    }
}