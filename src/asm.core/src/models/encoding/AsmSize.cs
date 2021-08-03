//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    public readonly struct AsmSize
    {
        public AsmSizeKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmSize(AsmSizeKind kind)
        {
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSize(AsmSizeKind src)
            => new AsmSize(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmSizeKind(AsmSize src)
            => src.Kind;
    }
}