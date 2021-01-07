//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RuleOperand
    {
        public TextBlock Value {get;}

        [MethodImpl(Inline)]
        public RuleOperand(string value)
            => Value = value;

        public string Format()
            => Value.Format();
    }

}