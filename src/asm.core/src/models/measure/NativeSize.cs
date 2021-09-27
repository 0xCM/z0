//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct NativeSize
    {
        public readonly NativeSizeCode Code;

        public BitWidth Width
        {
            [MethodImpl(Inline)]
            get => asm.width(Code);
        }

        [MethodImpl(Inline)]
        public NativeSize(AsmSizeKeyword kind)
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
        public static implicit operator NativeSize(AsmSizeKeyword src)
            => new NativeSize(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmSizeKeyword(NativeSize src)
            => (AsmSizeKeyword)src.Code;

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