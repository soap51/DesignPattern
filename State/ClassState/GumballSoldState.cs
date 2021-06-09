using System;
class GumballSoldState : GumballMachineState {
    public void DoAction(Context context){
        Console.WriteLine("Do action in GumballSoldState");
        if(context.Gumball > 0){
            context.Gumball--;
            context.SetState(new NoQuarterState());           
        }else if(context.Gumball == 0){
            context.SetState(new OutOfGumballState());
        }
    }
}