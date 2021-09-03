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
    public readonly struct NativeSize
    {
        public const uint SZ = PrimalSizes.U8;

        public NativeWidthCode Code {get;}

        public BitWidth Width
        {
            [MethodImpl(Inline)]
            get => asm.width(Code);
        }

        [MethodImpl(Inline)]
        public NativeSize(AsmSizeClass kind)
        {
            Code = (NativeWidthCode)kind;
        }

        [MethodImpl(Inline)]
        public NativeSize(NativeWidthCode kind)
        {
            Code = kind;
        }

        public string Format()
            => Width.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator NativeSize(AsmSizeClass src)
            => new NativeSize(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmSizeClass(NativeSize src)
            => (AsmSizeClass)src.Code;

        [MethodImpl(Inline)]
        public static implicit operator NativeSize(NativeWidthCode src)
            => new NativeSize(src);

        [MethodImpl(Inline)]
        public static implicit operator NativeWidthCode(NativeSize src)
            => (NativeWidthCode)src.Code;

        [MethodImpl(Inline)]
        public static implicit operator RegWidth(NativeSize src)
            => (NativeWidthCode)src.Code;

        [MethodImpl(Inline)]
        public static implicit operator NativeSize(RegWidth src)
            => new NativeSize((AsmSizeClass)src.Code);

        [MethodImpl(Inline)]
        public static implicit operator NativeSize(AddressSize src)
            => src.Measure;
    }
}