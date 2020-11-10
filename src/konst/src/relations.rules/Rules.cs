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

    [ApiHost(ApiNames.Rules, true)]
    public readonly partial struct Rules
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rule<T> rule<T>(RuleId id, RuleOperand<T>[] operands, RuleEffect<T> effect)
            => new Rule<T>(id, operands, effect);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RuleEffect<T> effect<T>(T[] spec)
            => new RuleEffect<T>(spec);

    }
}