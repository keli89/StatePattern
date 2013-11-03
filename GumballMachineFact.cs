using Xunit;

namespace StatePattern
{
    public class GumballMachineFact
    {
        [Fact]
        public void gumball_machine_status_should_be_no_quarter_at_start()
        {
            var gumballMachine = new GumballMachine(10, MachineStatus.NO_QUARTER);
            Assert.Equal(MachineStatus.NO_QUARTER, gumballMachine.State);
        }

        [Fact]
        public void gumball_machine_status_should_be_has_quarter_if_insert_a_quarter()
        {
            var gumballMachine = new GumballMachine(10, MachineStatus.NO_QUARTER);
            gumballMachine.InsertQuarter();
            Assert.Equal(MachineStatus.HAS_QUARTER, gumballMachine.State);
        }

        [Fact]
        public void gumball_machine_status_should_be_no_quarter_if_eject_quarter_when_status_is_has_quarter()
        {
            var gumballMachine = new GumballMachine(10, MachineStatus.HAS_QUARTER);
            gumballMachine.EjectQuarter();
            Assert.Equal(MachineStatus.NO_QUARTER, gumballMachine.State);
        }

        [Fact]
        public void gumball_machine_status_should_be_sold_if_turn_crank_given_status_is_has_quarter()
        {
            var gumballMachine = new GumballMachine(1, MachineStatus.HAS_QUARTER);
            gumballMachine.TurnCrank();
            Assert.Equal(MachineStatus.SOLD, gumballMachine.State);
        }

        [Fact]
        public void gumball_machine_status_should_back_to_no_quarter_if_dispense_given_has_gumball_and_status_is_sold()
        {
            var gumballMachine = new GumballMachine(10, MachineStatus.SOLD);
            gumballMachine.Dispense();
            Assert.Equal(gumballMachine.GumballNum, 9);
            Assert.Equal(MachineStatus.NO_QUARTER, gumballMachine.State);
        }

        [Fact]
        public void gumball_machine_status_should_be_sold_out_if_dispense_given_no_gumball_and_status_is_sold()
        {
            var gumballMachine = new GumballMachine(1, MachineStatus.SOLD);
            gumballMachine.Dispense();
            Assert.Equal(MachineStatus.SOLD_OUT, gumballMachine.State);
        }
    }
}