//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct XedRule : ITextual
    {
        public readonly string Expression;

        [MethodImpl(Inline)]
        public XedRule(string src)
        {
            Expression = src;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Expression;

        public override string ToString()
            => Expression;
    }
}