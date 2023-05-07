namespace CommandPattern
{
    //Receiver Class
    public class Receiver
    {
        public void Example()
        {
            Console.WriteLine("Example command");
        }
        public void PerformUndo()
        {
            Console.WriteLine("Executing-MyUndoCommand");
        }
        public void PerformRedo()
        {
            Console.WriteLine("Executing-MyRedoCommand");
        }
        //Optional method-If you want to perform any prior tasks before //Undo.
        public void OptionalTaskPriorToUndo()
        {
            Console.WriteLine("Executing-Optional Tasks prior to execute undo command");
        }
        //Optional method-If you want to perform any prior tasks before //Redo.
        public void OptionalTaskPriorToRedo()
        {
            Console.WriteLine("Executing-Optional Tasks prior to execute redo command");
        }
    }
}