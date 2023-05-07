namespace CommandPattern
{
    public class ExampleCommand :ICommand
    {
        private readonly Receiver _receiver;

        public ExampleCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void Do()
        {
            _receiver.Example();
        }
    }
}