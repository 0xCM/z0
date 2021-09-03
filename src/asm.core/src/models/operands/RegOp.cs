//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Blit;

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

        public NativeWidthCode WidthCode
        {
            [MethodImpl(Inline)]
            get => AsmRegBits.width(this);
        }

        public RegClassCode RegClassCode
        {
            [MethodImpl(Inline)]
            get => AsmRegBits.@class(this);
        }

        public RegIndexCode Index
        {
            [MethodImpl(Inline)]
            get => AsmRegBits.index(this);
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
    }
}