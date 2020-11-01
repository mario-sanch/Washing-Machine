#region Libraries
using FSMDomain.Concrete_States;
using FSMDomain.extensions;
using System.Collections.Generic;
#endregion

namespace FSMDomain
{
    public class ExprimeJabonState : MachineBaseState
    {
        #region Properties
        public override string Description { get; set; }
        public override IEnumerable<MachineStates> PossibleNextState { get; set; }
        public override string Image { get; set; }
        #endregion

        #region Constructors
        public ExprimeJabonState()
        {
            this.Description = "Exprimiendo Jabon";
            this.PossibleNextState = GetPossibleNextState();
            this.Image = "exprime-jabon.png";
        }
        #endregion

        #region Private Methods
        private IEnumerable<MachineStates> GetPossibleNextState()
        {
            return new List<MachineStates>
            {
                MachineStates.Enjuagar,
                MachineStates.Apagar
            };
        }
        #endregion

        #region Public Methods
        public override void ExecuteBahavior(MachineContext machineContext, string selection)
        {
            Update(machineContext, selection);
        }

        public override void Update(MachineContext machine, string selection)
        {
            if (selection.IsEnjuagando())
                machine.TransitionToState(machine.EnjuagaState);

            if (selection.IsApagado())
                machine.TransitionToState(machine.OffState);
        }
        #endregion
    }
}