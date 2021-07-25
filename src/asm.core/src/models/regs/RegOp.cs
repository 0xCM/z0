//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = AsmRegs;

    /// <summary>
    /// Specifies a register operand
    /// </summary>
    public readonly struct RegOp : IRegOp
    {
        readonly ushort Data;

        [MethodImpl(Inline)]
        internal RegOp(ushort src)
        {
            Data = src;
        }

        internal ushort Bitfield
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public AsmOpClass OpClass
        {
            [MethodImpl(Inline)]
            get => AsmOpClass.R;
        }

        public RegWidthCode Width
        {
            [MethodImpl(Inline)]
            get => api.width(this);
        }

        public RegClassCode RegClass
        {
            [MethodImpl(Inline)]
            get => api.@class(this);
        }

        public RegIndexCode Index
        {
            [MethodImpl(Inline)]
            get => api.index(this);
        }

        public RegName Name
        {
            [MethodImpl(Inline)]
            get => api.name(this);
        }
        public string Format()
            => api.format(Name);


        public override string ToString()
            =>  Format();

        [MethodImpl(Inline)]
        public static implicit operator RegOp(RegKind kind)
            => new RegOp((ushort)kind);
    }
}