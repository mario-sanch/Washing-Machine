#region Libraries
using FSMDomain.Concrete_States;
using FSMDomain.extensions;
using System.Collections.Generic;
#endregion

namespace FSMDomain
{
    public class RestriegaState : MachineBaseState
    {
        #region Properties
        public override string Description { get; set; }
        public override IEnumerable<MachineStates> PossibleNextState { get; set; }
        public override string Image { get; set; }
        #endregion

        #region Constructors
        public RestriegaState()
        {
            this.Description = "Restregando";
            this.PossibleNextState = GetPossibleNextState();
            this.Image = "restriega.jpg";
        }
        #endregion

        #region Private Methods
        private IEnumerable<MachineStates> GetPossibleNextState()
        {
            return new List<MachineStates>
            {
                MachineStates.Exprimir_jabon,
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
            if (selection.IsExprimiendoJabon())
                machine.TransitionToState(machine.ExprimeJabonState);

            if (selection.Equals(MachineStates.Apagar.ToString()))
                machine.TransitionToState(machine.OffState);
        }
        #endregion
    }
}