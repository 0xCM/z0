//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AddressSize
    {
        public NativeSize Measure {get;}

        [MethodImpl(Inline)]
        public AddressSize(NativeSize value)
        {
            Measure = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator AddressSize(NativeSize size)
            => new AddressSize(size);

        [MethodImpl(Inline)]
        public static implicit operator AddressSize(NativeWidthCode code)
            => asm.asmsize(asm.width(code));
    }
}