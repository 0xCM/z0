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

    public readonly struct xmm<N> : IXmmRegOp<xmm<N>,N>
        where N : unmanaged, ITypeNat
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm(Fixed128 value)
        {
            Content = value;
        }

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => RegisterBitField.join((RegisterCode)value<N>(), RegisterClass.XMM, RegisterWidth.W128);
        }
    }
}