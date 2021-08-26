//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Blit;

    [Blittable(SZ)]
    public readonly struct RegOp<T> : IRegOp<T>
        where T : unmanaged, IRegOp
    {
        public const uint SZ = 2;

        readonly T Data;

        [MethodImpl(Inline)]
        public RegOp(T src)
        {
            Data = src;
        }

        public ushort Bitfield
        {
            [MethodImpl(Inline)]
            get => u16(Data);
        }

        public RegIndexCode Index
        {
            [MethodImpl(Inline)]
            get => Data.Index;
        }

        public RegClassCode RegClassCode
        {
            [MethodImpl(Inline)]
            get => Data.RegClassCode;
        }

        public AsmWidthCode WidthCode
        {
            [MethodImpl(Inline)]
            get => Data.WidthCode;
        }

        public RegWidth RegWidth
        {
            [MethodImpl(Inline)]
            get => WidthCode;
        }

        public RegClass RegClass
        {
            [MethodImpl(Inline)]
            get => RegClassCode;
        }

        public AsmOpClass OpClass
        {
            [MethodImpl(Inline)]
            get => AsmOpClass.R;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => OpClass == 0;
        }

        public text7 Name
        {
            [MethodImpl(Inline)]
            get => AsmRegNames.name(this);
        }

        public string Format()
            => string.Format("{0}/{1}/{2}", Index, RegClassCode, WidthCode);

        public override string ToString()
            =>  Format();
    }
}