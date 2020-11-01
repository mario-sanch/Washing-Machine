using System;

namespace FSMDomain
{
    public class MachineContext
    {
        #region States
        public readonly LlenarState LlenarState = new LlenarState();
        public readonly RestriegaState RestriegaState = new RestriegaState();
        public readonly ExprimeJabonState ExprimeJabonState = new ExprimeJabonState();
        public readonly EnjuagaState EnjuagaState = new EnjuagaState();
        public readonly ExprimeAguaState ExprimeAguaState = new ExprimeAguaState();
        public readonly OffState OffState = new OffState();
        #endregion

        private MachineBaseState currentState;

        public MachineBaseState CurrentState
        {
            get
            {
                return this.currentState;
            }
        }

        public void Start()
        {
            TransitionToState(new OffState());
        }

        public void TransitionToState(MachineBaseState state)
        {
            this.currentState = state;
        }
    }
}