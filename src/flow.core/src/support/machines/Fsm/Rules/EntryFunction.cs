//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a set of rules that define actions associated with state entry
    /// </summary>
    public class EntryFunction<S,A> : IFsmFunction
    {
        public EntryFunction(IEnumerable<IFsmActionRule<A>> rules)
        {
            this.RuleIndex = rules.Select(rule => (rule.RuleId, rule)).ToDictionary();
        }
        
        readonly Dictionary<int, IFsmActionRule<A>> RuleIndex;
        
        public Option<A> Eval(S source)
            => Rule(Fsm.EntryRuleKey(source)).TryMap(r => r.Action);

        public Option<IFsmActionRule<A>> Rule(IRuleKey key)
        {
            if(RuleIndex.TryGetValue(key.Hash, out IFsmActionRule<A> dst))
                return some(dst);
            else
                return default;
        }

        Option<IFsmRule> IFsmFunction.Rule(IRuleKey key)
            => Rule(key).TryMap(r => r as IFsmRule);
    }
}