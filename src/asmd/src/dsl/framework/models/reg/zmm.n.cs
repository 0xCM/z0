//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    public readonly struct zmm<N> : IZmmOperand<zmm<N>,N>
        where N : unmanaged, ITypeNat
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm(Fixed512 value)
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