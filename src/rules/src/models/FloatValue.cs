//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using Z0.Lang;

    partial struct Rules
    {
        public readonly struct FloatValue : INumericValue<FloatKind>
        {
            public FloatKind Kind {get;}

            public byte[] Content {get;}

            [MethodImpl(Inline)]
            public FloatValue(FloatKind kind, byte[] def)
            {
                Kind = kind;
                Content = def;
            }
        }
    }
}