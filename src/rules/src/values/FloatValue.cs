//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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