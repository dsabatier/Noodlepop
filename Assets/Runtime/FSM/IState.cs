namespace Noodlepop.FiniteStateMachine
{
    public interface IState
    {
        void Enter();
        void Process();
        void Exit();
    }
}
