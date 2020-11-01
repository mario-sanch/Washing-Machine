#region Libraries
using FSMDomain.Concrete_States;
using FSMDomain.extensions;
using System.Collections.Generic;
#endregion

namespace FSMDomain
{
    public class EnjuagaState : MachineBaseState
    {
        #region Properties
        public override string Description { get; set; }
        public override IEnumerable<MachineStates> PossibleNextState { get; set; }
        public override string Image { get; set; }
        #endregion

        #region Constructors
        public EnjuagaState()
        {
            this.Description = "Enjuague";
            this.PossibleNextState = GetPossibleNextState();
            this.Image = "enjuaga.jpg";
        }
        #endregion

        #region Private Methods
        private IEnumerable<MachineStates> GetPossibleNextState()
        {
            return new List<MachineStates>
            {
                MachineStates.Exprimir_agua,
                MachineStates.Apagar
            };
        }
        #endregion

        #region Public Methods
        public override void ExecuteBahavior(MachineContext machine, string selection)
        {
            Update(machine, selection);
        }

        public override void Update(MachineContext machine, string selection)
        {
            if (selection.IsExprimiendoAgua())
                machine.TransitionToState(machine.ExprimeAguaState);

            if (selection.IsApagado())
                machine.TransitionToState(machine.OffState);
        }
        #endregion
    }
}