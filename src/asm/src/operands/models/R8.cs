//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct R8 : IRegOperand<R8,W8,byte>
    {
        public readonly byte Content  {get;}

        public readonly RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public R8(byte value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }
    }
}