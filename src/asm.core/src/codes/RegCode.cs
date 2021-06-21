//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;

    public readonly struct RegCode : ITextual
    {
        [MethodImpl(Inline)]
        public static RegCode from(byte value)
            => from((RegIndex)value);

        [MethodImpl(Inline)]
        public static RegCode from(RegIndex factor)
            => new RegCode(factor);

        public RegIndex Factor {get;}

        [MethodImpl(Inline)]
        public RegCode(RegIndex kind)
            => Factor = kind;

        public byte Value
        {
            [MethodImpl(Inline)]
            get => (byte) Factor;
        }

       public string Format()
            => BitRender.format(n5,Value);

       public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static MemoryAddress operator *(RegCode scale, MemoryAddress address)
            => (ulong)scale.Factor * address;

        [MethodImpl(Inline)]
        public static MemoryAddress operator *(MemoryAddress address, RegCode scale)
            => (ulong)scale.Factor * address;

        public static RegCode Empty
            => new RegCode(0);

        [MethodImpl(Inline)]
        public static implicit operator RegCode(int src)
            => from((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator byte(RegCode src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator RegCode(RegIndex src)
            => new RegCode(src);

        [MethodImpl(Inline)]
        public static implicit operator RegIndex(RegCode src)
            => src.Factor;
    }
}