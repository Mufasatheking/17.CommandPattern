namespace CommandPattern
{
    public class MyRedoCommand : ICommand
    {
        private Receiver receiver;
        public MyRedoCommand(Receiver recv)
        {
            receiver=recv;
        }
        public void Do()
        {
            //Perform any optional task prior to ReDo
            receiver.OptionalTaskPriorToRedo();
            //Call ReDo in receiver now
            receiver.PerformRedo();
        }
    }
}