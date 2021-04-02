//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct FloatValue : INumericValue<FloatKind>
    {
        public FloatKind Kind {get;}

        public BinaryCode Content {get;}

        [MethodImpl(Inline)]
        public FloatValue(FloatKind kind, BinaryCode def)
        {
            Kind = kind;
            Content = def;
        }
    }
}