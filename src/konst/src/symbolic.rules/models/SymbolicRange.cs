//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SymbolicRange<T> : ISymbolicRuleSpec<SymbolicRange<T>>
        where T : unmanaged
    {
        public RuleId RuleId { get; }

        public T Min { get; }

        public T Max { get; }

        [MethodImpl(Inline)]
        public SymbolicRange(RuleId id, T min, T max)
        {
            RuleId = id;
            Min = min;
            Max = max;
        }
    }
    
}