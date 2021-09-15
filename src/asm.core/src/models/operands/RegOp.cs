//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static BitFlow;

    using api = AsmRegs;

    /// <summary>
    /// Specifies a register operand
    /// </summary>
    [Blittable(SZ)]
    public readonly struct RegOp : IRegOp
    {
        public const uint SZ = 2;

        readonly ushort Data;

        [MethodImpl(Inline)]
        internal RegOp(ushort src)
        {
            Data = src;
        }

        public ushort Bitfield
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public AsmOpClass OpClass
        {
            [MethodImpl(Inline)]
            get => AsmOpClass.R;
        }

        public bit IsInvalid
        {
            [MethodImpl(Inline)]
            get => Data == ushort.MaxValue;
        }

        public NativeSizeCode WidthCode
        {
            [MethodImpl(Inline)]
            get => AsmRegs.width(this);
        }

        public RegClassCode RegClassCode
        {
            [MethodImpl(Inline)]
            get => AsmRegs.@class(this);
        }

        public RegIndexCode Index
        {
            [MethodImpl(Inline)]
            get => AsmRegs.index(this);
        }

        public RegWidth RegWidth
        {
            [MethodImpl(Inline)]
            get => WidthCode;
        }

        public RegKind RegKind
        {
            [MethodImpl(Inline)]
            get => (RegKind)Data;
        }

        public RegClass RegClass
        {
            [MethodImpl(Inline)]
            get => RegClassCode;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => OpClass == 0;
        }

        public text7 Name
        {
            [MethodImpl(Inline)]
            get => api.name(this);
        }
        public string Format()
            => Name.Format().Trim();

        public override string ToString()
            =>  Format();

        [MethodImpl(Inline)]
        public static implicit operator RegOp(RegKind kind)
            => new RegOp((ushort)kind);

        public static RegOp Invalid
        {
            [MethodImpl(Inline)]
            get => new RegOp(ushort.MaxValue);
        }
    }
}