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

        [MethodImpl(Inline), Op]
        public static Rule rule(RuleId id, RuleOperand[] operands, RuleEffect effect)
            => new Rule(id, operands,effect);

        [MethodImpl(Inline), Op]
        public static RuleEffect effect(string spec)
            => new RuleEffect(spec);
    }
}