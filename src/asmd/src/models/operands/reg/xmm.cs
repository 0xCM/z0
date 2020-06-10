//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    using K = RegisterKind;

    partial class Regs
    {        
        public readonly struct xmm<R,N> : IXmmRegOp<xmm<R,N>, N>
            where R : unmanaged, IXmmRegOp
            where N : unmanaged, ITypeNat                      
        {
            public Fixed128 Value {get;}

            [MethodImpl(Inline)]
            public xmm(Fixed128 value)
            {
                Value = value;
            }
            
            public RegisterCode Code 
            {
                [MethodImpl(Inline)]
                get => (RegisterCode)value<N>();
            }

            public RegisterKind Kind 
            {
                [MethodImpl(Inline)]
                get => RegisterBitField.join(Code, RegisterClass.XMM, RegisterWidth.W128);
            }
        }

        public readonly struct xmm : IXmmRegOp
        {
            public Fixed128 Value {get;}
            
            public RegisterKind Kind {get;}     

            public RegisterCode Code 
            {
                [MethodImpl(Inline)]
                get => RegisterBitField.code(Kind);
            }

            [MethodImpl(Inline)]
            public xmm(Fixed128 value, RegisterKind kind)
            {
                Value = value;
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm0 src)
                => new xmm(src.Value, K.XMM0);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm1 src)
                => new xmm(src.Value, K.XMM1);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm2 src)
                => new xmm(src.Value, K.XMM2);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm3 src)
                => new xmm(src.Value, K.XMM3);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm4 src)
                => new xmm(src.Value, K.XMM4);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm5 src)
                => new xmm(src.Value, K.XMM5);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm6 src)
                => new xmm(src.Value, K.XMM6);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm7 src)
                => new xmm(src.Value, K.XMM7);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm8 src)
                => new xmm(src.Value, K.XMM8);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm9 src)
                => new xmm(src.Value, K.XMM9);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm10 src)
                => new xmm(src.Value, K.XMM10);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm11 src)
                => new xmm(src.Value, K.XMM11);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm12 src)
                => new xmm(src.Value, K.XMM12);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm13 src)
                => new xmm(src.Value, K.XMM13);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm14 src)
                => new xmm(src.Value, K.XMM14);

            [MethodImpl(Inline)]
            public static implicit operator xmm(xmm15 src)
                => new xmm(src.Value, K.XMM15);

            [MethodImpl(Inline)]
            public static implicit operator xmm0(xmm src)
                => new xmm0(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm1(xmm src)
                => new xmm1(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm2(xmm src)
                => new xmm2(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm3(xmm src)
                => new xmm3(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm4(xmm src)
                => new xmm4(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm5(xmm src)
                => new xmm5(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm6(xmm src)
                => new xmm6(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm7(xmm src)
                => new xmm7(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm8(xmm src)
                => new xmm8(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm9(xmm src)
                => new xmm9(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm10(xmm src)
                => new xmm10(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm11(xmm src)
                => new xmm11(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm12(xmm src)
                => new xmm12(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm13(xmm src)
                => new xmm13(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm14(xmm src)
                => new xmm14(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator xmm15(xmm src)
                => new xmm15(src.Value);
        }
    }
}