using System;
class OutOfGumballState: GumballMachineState {
    public void DoAction(Context context){
        Console.WriteLine("Do action in OutOfGumballState");
    }
}