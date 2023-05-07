namespace CommandPattern
{
    //Invoker class
    public class Invoke
    {
        ICommand commandToBePerformed;
        public void SetCommand(ICommand command)
        {
            this.commandToBePerformed = command;
        }
        public void ExecuteCommand()
        {
            commandToBePerformed.Do();
        }
    }
}