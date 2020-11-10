//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static Symbolic;

    [ApiHost(ApiNames.Rules, true)]
    public readonly partial struct SymbolicRules
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolicRule<T> rule<T>(RuleId id, RuleOperand<T>[] operands, RuleEffect<T> effect)
            => new SymbolicRule<T>(id, operands, effect);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolicRange<T> range<T>(RuleId id, T min, T max)
            where T : unmanaged
                => new SymbolicRange<T>(id, min,max);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RuleEffect<T> effect<T>(T[] spec)
            => new RuleEffect<T>(spec);
    }
}