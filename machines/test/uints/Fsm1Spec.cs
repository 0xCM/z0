//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Threading;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Z0.Machines;

    using static zfunc;

    using static Fsm1Spec;
    using static Fsm1Spec.States;
    using static Fsm1Spec.Events;
    using static Fsm1Spec.Outputs;

    public abstract class FsmSpec<E,S,O>
    {
        public virtual IEnumerable<TransitionRule<E,S>> TransRules {get;}
        public virtual IEnumerable<OutputRule<E,S,O>> OutputRules{get;}

        public MachineTransition<E,S> TransFunc
            => TransRules.ToFunction();

    }

    public class Fsm1Spec : FsmSpec<Events,States,Outputs>
    {
        public enum States : byte
        {
            S0, S1, S2, S3, S4, S5
        }

        public enum Events: byte
        {
            E1 , E2, E3, E4, E5, E6, E7
        }

        public enum Outputs : byte
        {            
            O0, O1, O2, O3, O4, O5, O6, O7, O8, O9, O10
        }


        public override IEnumerable<OutputRule<Events,States,Outputs>> OutputRules
        {
            get
            {
                yield return (E1, S1, O0);
                yield return (E2, S2, O1);
                yield return (E3, S3, O2);
                yield return (E4, S4, O3);
                yield return (E4, S5, O4);
            }
        }

        public override IEnumerable<TransitionRule<Events,States>> TransRules
        {
            get
            {
                yield return (E1, S0, S1);
                yield return (E1, S1, S2);
                yield return (E1, S2, S3);
                yield return (E1, S3, S4);
                yield return (E1, S4, S5);
            }
        }
        
    }
}