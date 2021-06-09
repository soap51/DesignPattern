using System;
class HasQuarterState : GumballMachineState {
    public void DoAction(Context context){
        Console.WriteLine("Do action in HasQuarterState");
        context.SetState(new GumballSoldState());
    }
}