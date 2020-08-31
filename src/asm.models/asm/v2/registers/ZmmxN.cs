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
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public Zmm(FixedCell512 value)
        {
            Content = value;
        }

        public RegisterKind Kind
        {
            [MethodImpl(Inline)]
            get => RegisterBits.join((RegisterCode)value<N>(), RegisterClass.YMM, RegisterWidth.W512);
        }
    }
}