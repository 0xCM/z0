//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using K = RegisterKind;

    public readonly struct Xmm : IXmmOperand
    {
        public FixedCell128 Content {get;}

        public RegisterKind Kind {get;}

        public RegisterCode Code
        {
            [MethodImpl(Inline)]
            get => RegisterBits.code(Kind);
        }

        [MethodImpl(Inline)]
        public Xmm(FixedCell128 value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm0 src)
            => new Xmm(src.Content, K.XMM0);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm1 src)
            => new Xmm(src.Content, K.XMM1);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm2 src)
            => new Xmm(src.Content, K.XMM2);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm3 src)
            => new Xmm(src.Content, K.XMM3);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm4 src)
            => new Xmm(src.Content, K.XMM4);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm5 src)
            => new Xmm(src.Content, K.XMM5);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm6 src)
            => new Xmm(src.Content, K.XMM6);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm7 src)
            => new Xmm(src.Content, K.XMM7);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm8 src)
            => new Xmm(src.Content, K.XMM8);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm9 src)
            => new Xmm(src.Content, K.XMM9);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm10 src)
            => new Xmm(src.Content, K.XMM10);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm11 src)
            => new Xmm(src.Content, K.XMM11);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm12 src)
            => new Xmm(src.Content, K.XMM12);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm13 src)
            => new Xmm(src.Content, K.XMM13);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm14 src)
            => new Xmm(src.Content, K.XMM14);

        [MethodImpl(Inline)]
        public static implicit operator Xmm(xmm15 src)
            => new Xmm(src.Content, K.XMM15);

        [MethodImpl(Inline)]
        public static implicit operator xmm0(Xmm src)
            => new xmm0(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm1(Xmm src)
            => new xmm1(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm2(Xmm src)
            => new xmm2(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm3(Xmm src)
            => new xmm3(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm4(Xmm src)
            => new xmm4(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm5(Xmm src)
            => new xmm5(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm6(Xmm src)
            => new xmm6(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm7(Xmm src)
            => new xmm7(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm8(Xmm src)
            => new xmm8(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm9(Xmm src)
            => new xmm9(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm10(Xmm src)
            => new xmm10(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm11(Xmm src)
            => new xmm11(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm12(Xmm src)
            => new xmm12(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm13(Xmm src)
            => new xmm13(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm14(Xmm src)
            => new xmm14(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator xmm15(Xmm src)
            => new xmm15(src.Content);
    }
}