namespace StatePattern
{
    public class MachineStatusSold : MachineStatus
    {
        public MachineStatusSold(string name) : base(name)
        {
        }

        public override string InsertedQuarterAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.SoldMessage;
        }

        public override string TurnCrankAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.SoldMessage;
        }

        public override string DispenseAction(GumballMachine gumballMachine)
        {
            gumballMachine.GumballNum--;
            if (gumballMachine.GumballNum == 0)
            {
                gumballMachine.State = SOLD_OUT;
                return MachineMessageSugar.NoGumballMessage;
            }

            gumballMachine.State = NO_QUARTER;
            return MachineMessageSugar.DispenseSucessMessage;
        }

        public override string EjectQuarterAction(GumballMachine gumballMachine)
        {
            return MachineMessageSugar.SoldMessage;
        }
    }
}