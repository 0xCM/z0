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

    [ApiHost]
    public readonly struct Rules
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Rule<T> rule<T>(RuleId id, RuleOperand<T>[] operands, RuleEffect<T> effect)
            => new Rule<T>(id, operands, effect);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RuleEffect<T> effect<T>(T[] spec)
            => new RuleEffect<T>(spec);
    }
}