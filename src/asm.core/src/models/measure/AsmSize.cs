//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Blittable(SZ)]
    public readonly struct AsmSize
    {
        public const uint SZ = PrimalSizes.U8;

        public AsmSizeClass Class {get;}

        public BitWidth Width
        {
            [MethodImpl(Inline)]
            get => Pow2.pow((byte)Class) << 3;
        }

        [MethodImpl(Inline)]
        public AsmSize(AsmSizeClass kind)
        {
            Class = kind;
        }

        [MethodImpl(Inline)]
        public AsmSize(AsmWidthCode kind)
        {
            Class = (AsmSizeClass)kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSize(AsmSizeClass src)
            => new AsmSize(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmSizeClass(AsmSize src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator AsmSize(AsmWidthCode src)
            => new AsmSize(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmWidthCode(AsmSize src)
            => (AsmWidthCode)src.Class;

        [MethodImpl(Inline)]
        public static implicit operator RegWidth(AsmSize src)
            => (AsmWidthCode)src.Class;

        [MethodImpl(Inline)]
        public static implicit operator AsmSize(RegWidth src)
            => new AsmSize((AsmSizeClass)src.Code);

        [MethodImpl(Inline)]
        public static implicit operator AsmSize(AsmAddressWidth src)
            => new AsmSize(src.Width);
    }
}