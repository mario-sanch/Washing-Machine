#region Libraries
using FSMDomain.Concrete_States;
using System.Collections.Generic;
#endregion

namespace FSMDomain
{
    public class LlenarState : MachineBaseState
    {
        #region Properties
        public override string Description { get; set; }
        public override IEnumerable<MachineStates> PossibleNextState { get; set; }
        public override string Image { get; set; }
        #endregion

        #region Constructors
        public LlenarState()
        {
            this.Description = "Llenando";
            this.PossibleNextState = GetPossibleNextState();
            this.Image = "llena.jpg";
        }
        #endregion

        #region Private Methods
        private IEnumerable<MachineStates> GetPossibleNextState()
        {
            return new List<MachineStates>
            {
                MachineStates.Restregar
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
            machine.TransitionToState(machine.RestriegaState);
        }
        #endregion
    }
}