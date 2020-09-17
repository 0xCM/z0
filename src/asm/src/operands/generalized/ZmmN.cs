//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct Zmm<N> : IZmmOperand<Zmm<N>,N>
        where N : unmanaged, ITypeNat
    {
        public Cell512 Content {get;}

        [MethodImpl(Inline)]
        public Zmm(Cell512 value)
        {
            Content = value;
        }

        public RegisterKind Kind
        {
            [MethodImpl(Inline)]
            get => AsmRegisterBits.join(nat<N,RegisterCode>(), RegisterClass.YMM, RegisterWidth.W512);
        }
    }
}