namespace StatePattern
{
    public abstract class MachineStatus
    {
        public static MachineStatus NO_QUARTER = new MachineStatusNoQuarter("NO_QUARTER");
        public static MachineStatus HAS_QUARTER = new MachineStatusHasQuarter("HAS_QUARTER");
        public static MachineStatus SOLD_OUT = new MachineStatusSoldOut("SOLD_OUT");
        public static MachineStatus SOLD = new MachineStatusSold("SOLD");

        public abstract string InsertedQuarterAction(GumballMachine gumballMachine);

        public abstract string TurnCrankAction(GumballMachine gumballMachine);

        public abstract string DispenseAction(GumballMachine gumballMachine);

        public abstract string EjectQuarterAction(GumballMachine gumballMachine);
    }
}