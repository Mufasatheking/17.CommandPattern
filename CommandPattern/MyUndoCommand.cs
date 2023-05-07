namespace CommandPattern
{
    public class MyUndoCommand: ICommand
    {
        private Receiver receiver;
        public MyUndoCommand(Receiver recv)
        {
            receiver=recv;
        }
        public void Do()
        {
            //Perform any optional task prior to UnDo
            receiver.OptionalTaskPriorToUndo();
            //Call UnDo in receiver now
            receiver.PerformUndo();
        }
    }
}