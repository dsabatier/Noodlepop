namespace Noodlepop.FiniteStateMachine
{
    public class FiniteStateMachine
    {
        private IState _currentState;

        public IState CurrentState => _currentState;

        public void ChangeState(IState newState)
        {
            _currentState?.Exit();
            _currentState = newState;
            _currentState.Enter();
        }

        public void ProcessState()
        {
            _currentState?.Process();
        }
    }
}