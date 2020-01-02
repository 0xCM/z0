//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using Z0.Logix;
    
    using static zfunc;

    /// <summary>
    /// Encapsulates the set of all rules (input : E, source : S) -> target : S that define state machine transitions
    /// </summary>
    public class MachineTransition<E,S> : IFsmFunction<E,S>
    {
        public MachineTransition(IEnumerable<ITransitionRule<E,S>> rules)
        {
            this.RuleIndex = rules.Select(x => (Fsm.TransitionRuleKey(x.Trigger,x.Source).Hash, x)).ToDictionary();
        }

        public MachineTransition(IEnumerable<TransitionRule<E,S>> rules)
        {
            this.RuleIndex = rules.Select(x => (Fsm.TransitionRuleKey(x.Trigger,x.Source).Hash, x as ITransitionRule<E,S>)).ToDictionary();
        }

        readonly Dictionary<int,ITransitionRule<E,S>> RuleIndex;
    
        [MethodImpl(Inline)]
        public Option<S> Eval(E input, S source)        
            => Rule(Fsm.TransitionRuleKey(input,source)).TryMap(r => r.Target);
        
        public Option<ITransitionRule<E,S>> Rule(IRuleKey key)
        {
            if(RuleIndex.TryGetValue(key.Hash, out ITransitionRule<E,S> dst))
                return some(dst);
            else
                return default;
        }

        Option<IFsmRule> IFsmFunction.Rule(IRuleKey key)
            => Rule(key).TryMap(r => r as IFsmRule);

        /// <summary>
        /// Specifies the set of events that can effect a transition
        /// </summary>
        public IEnumerable<E> Triggers
            => RuleIndex.Values.Select(x => x.Trigger).Distinct();

    }

 
}