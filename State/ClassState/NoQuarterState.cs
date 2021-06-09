using System;
class NoQuarterState : GumballMachineState {
    public void DoAction(Context context){
        Console.WriteLine("Do action in NoQuaterState");

        if(context.Coin > 0){
            context.Coin--;
            context.SetState(new HasQuarterState());           
        }
    }
}