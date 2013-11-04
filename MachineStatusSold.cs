namespace StatePattern
{
    public class MachineStatusSold : MachineStatus
    {
        public MachineStatusSold(string name) : base(name)
        {
        }

        public override string InsertedQuarterAction(GumballMachine gumballMachine)
        {
            return SoldMessage;
        }

        public override string TurnCrankAction(GumballMachine gumballMachine)
        {
            return SoldMessage;
        }

        public override string DispenseAction(GumballMachine gumballMachine)
        {
            gumballMachine.GumballNum--;
            if (gumballMachine.GumballNum == 0)
            {
                gumballMachine.State = SOLD_OUT;
                return NoGumballMessage;
            }

            gumballMachine.State = NO_QUARTER;
            return DispenseSucessMessage;
        }

        public override string EjectQuarterAction(GumballMachine gumballMachine)
        {
            return SoldMessage;
        }
    }
}