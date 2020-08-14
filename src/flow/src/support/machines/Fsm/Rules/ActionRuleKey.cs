//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
  
    /// <summary>
    /// Identifies an action rule for lookup purposes
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    public readonly struct ActionRuleKey<S> : IRuleKey
    {
        [MethodImpl(Inline)]
        public static implicit operator ActionRuleKey<S>(S source)
            => new ActionRuleKey<S>(source);
        
        [MethodImpl(Inline)]
        public ActionRuleKey(S source)
        {
            Source = source;
            Hash = source.GetHashCode();
        }

        public readonly int Hash {get;}

        public readonly S Source;

        public readonly override string ToString() 
            => $"({Source})";
    }
}