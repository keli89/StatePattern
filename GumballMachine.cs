namespace StatePattern
{
    public class GumballMachine
    {
      
        public int GumballNum { get; set;}

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