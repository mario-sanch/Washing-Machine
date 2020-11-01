using FSMDomain.Concrete_States;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSMDomain
{
    public abstract class MachineBaseState
    {
        public abstract string Image { get; set; }
        public abstract string Description { get; set; }
        public abstract IEnumerable<MachineStates> PossibleNextState { get; set; }
        public abstract void ExecuteBahavior(MachineContext machineContext, string selection);

        public abstract void Update(MachineContext machineContext, string selection);
    }
}
