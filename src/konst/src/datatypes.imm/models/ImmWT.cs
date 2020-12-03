//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [DataType]
    public readonly struct Imm<W,T> : IImmValue<Imm<W,T>,W,T>
        where W : unmanaged, INumericWidth
        where T : unmanaged
    {
        public T Content {get;}

        public static W Width => default;

        public ulong Imm64
        {
            [MethodImpl(Inline)]
            get => NumericCast.force<T,ulong>(Content);
        }

        public uint Imm32
        {
            [MethodImpl(Inline)]
            get => NumericCast.force<T,uint>(Content);
        }

        public ushort Imm16
        {
            [MethodImpl(Inline)]
            get => NumericCast.force<T,ushort>(Content);
        }

        public byte Imm8
        {
            [MethodImpl(Inline)]
            get => NumericCast.force<T,byte>(Content);
        }

        [MethodImpl(Inline)]

        public Imm(T src)
            => Content = src;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Content);
        }

        public override int GetHashCode()
            => (int)Hash;


        [MethodImpl(Inline)]
        public bool Equals(Imm<W,T> src)
            => Imm64 == src.Imm64;

        public override bool Equals(object obj)
            => obj is Imm<W,T> x && Equals(x);

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Content, Width);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public int CompareTo(Imm<W,T> src)
            => Imm64 == src.Imm64 ? 0 : Imm64 < src.Imm64 ? -1 : 1;

        [MethodImpl(Inline)]
        public static implicit operator Imm<W,T>(byte src)
            => new Imm<W,T>(NumericCast.force<byte,T>(src));

        [MethodImpl(Inline)]
        public static implicit operator Imm<W,T>(ushort src)
            => new Imm<W,T>(NumericCast.force<ushort,T>(src));

        [MethodImpl(Inline)]
        public static implicit operator Imm<W,T>(uint src)
            => new Imm<W,T>(NumericCast.force<uint,T>(src));

        [MethodImpl(Inline)]
        public static implicit operator Imm<W,T>(ulong src)
            => new Imm<W,T>(NumericCast.force<ulong,T>(src));
    }
}