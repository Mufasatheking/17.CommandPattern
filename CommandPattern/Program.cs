using CommandPattern;

Console.WriteLine("***Command Pattern Demo***\n");
/*Client holds both the Invoker and Command Objects*/
Invoke invoker = new Invoke ();
Receiver intendedreceiver = new Receiver();
MyUndoCommand undoCmd = new MyUndoCommand(intendedreceiver);
invoker.SetCommand(undoCmd);
invoker.ExecuteCommand();
MyRedoCommand redoCmd = new MyRedoCommand(intendedreceiver);
invoker.SetCommand(redoCmd);
invoker.ExecuteCommand();
ExampleCommand exampleCmd = new ExampleCommand(intendedreceiver);
invoker.SetCommand(exampleCmd);
invoker.ExecuteCommand();
Console.ReadKey();