using System;
class Context {

    public GumballMachineState currentState;
    public int Coin {get; set;}
    public int Gumball {get; set;}
    public Context(GumballMachineState state, int coin, int gumball)
    {
        Gumball = gumball;
        Coin = coin;
        this.SetState(state);
    }
    public void SetState(GumballMachineState state){
        Console.WriteLine("coin " +Coin);
        Console.WriteLine("gumball " +Gumball);
        this.currentState = state;
        currentState.DoAction(this);
      

    }        
}