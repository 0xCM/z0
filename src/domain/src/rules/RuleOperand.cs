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

    public readonly struct RuleOperand
    {
        public string Data {get;}

        [MethodImpl(Inline)]
        public RuleOperand(string src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator RuleOperand(string src)
            => new RuleOperand(src);
    }
}