//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Registers;

    using K = RegisterKind;

    public readonly struct XmmReg : IXmmRegOp<Fixed128>
    {
        public RegisterKind Kind {get;}     

        [MethodImpl(Inline)]
        public static implicit operator XmmReg(XMM0 src)
            => new XmmReg(K.XMM0);

        [MethodImpl(Inline)]
        public static implicit operator XmmReg(XMM1 src)
            => new XmmReg(K.XMM1);

        [MethodImpl(Inline)]
        public static implicit operator XmmReg(XMM2 src)
            => new XmmReg(K.XMM2);

        [MethodImpl(Inline)]
        public static implicit operator XmmReg(XMM3 src)
            => new XmmReg(K.XMM3);

        [MethodImpl(Inline)]
        public static implicit operator XmmReg(XMM4 src)
            => new XmmReg(K.XMM4);

        [MethodImpl(Inline)]
        public static implicit operator XmmReg(XMM5 src)
            => new XmmReg(K.XMM5);

        [MethodImpl(Inline)]
        public static implicit operator XmmReg(XMM6 src)
            => new XmmReg(K.XMM6);

        [MethodImpl(Inline)]
        public static implicit operator XmmReg(XMM7 src)
            => new XmmReg(K.XMM7);

        [MethodImpl(Inline)]
        public XmmReg(RegisterKind kind)
        {
            this.Kind = kind;
        }        
    }
}