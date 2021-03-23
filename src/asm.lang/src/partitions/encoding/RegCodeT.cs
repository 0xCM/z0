//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RegCode<T>
        where T : unmanaged, IBitNumber
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public RegCode(T value)
        {
            Value = value;
        }

        public ReadOnlySpan<bit> Bits
        {
            [MethodImpl(Inline)]
            get => Value.Bits;
        }

        public string Format()
            => Value.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator RegCode<T>(T src)
            => new RegCode<T>(src);
    }
}