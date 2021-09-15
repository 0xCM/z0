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

        public NativeSizeCode Code {get;}

        public BitWidth Width
        {
            [MethodImpl(Inline)]
            get => asm.width(Code);
        }

        [MethodImpl(Inline)]
        public NativeSize(AsmSizeClass kind)
        {
            Code = (NativeSizeCode)kind;
        }

        [MethodImpl(Inline)]
        public NativeSize(NativeSizeCode kind)
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
        public static implicit operator NativeSize(NativeSizeCode src)
            => new NativeSize(src);

        [MethodImpl(Inline)]
        public static implicit operator NativeSizeCode(NativeSize src)
            => (NativeSizeCode)src.Code;

        [MethodImpl(Inline)]
        public static implicit operator RegWidth(NativeSize src)
            => (NativeSizeCode)src.Code;

        [MethodImpl(Inline)]
        public static implicit operator NativeSize(RegWidth src)
            => src.Size;

        [MethodImpl(Inline)]
        public static implicit operator NativeSize(AddressSize src)
            => src.Measure;
    }
}