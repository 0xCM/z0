//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct Imm<W,T> : IAsmImmArg<Imm<W,T>, W,T>
        where W : unmanaged, INumericWidth
        where T : unmanaged
    {
        public T Data;

        public static W Width => default;

        public T Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ulong Imm64
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,ulong>(Data);
        }

        public uint Imm32
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,uint>(Data);
        }

        public ushort Imm16
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,ushort>(Data);
        }

        public byte Imm8
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,byte>(Data);
        }

        [MethodImpl(Inline)]
        public static implicit operator Imm<W,T>(byte src)
            => new Imm<W,T>(Cast.to<byte,T>(src));

        [MethodImpl(Inline)]
        public static implicit operator Imm<W,T>(ushort src)
            => new Imm<W,T>(Cast.to<ushort,T>(src));


        [MethodImpl(Inline)]
        public static implicit operator Imm<W,T>(uint src)
            => new Imm<W,T>(Cast.to<uint,T>(src));

        [MethodImpl(Inline)]
        public static implicit operator Imm<W,T>(ulong src)
            => new Imm<W,T>(Cast.to<ulong,T>(src));

        [MethodImpl(Inline)]

        public Imm(T src)
            => Data = src;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Data);
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
            => Hex.format(Data, Width);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public int CompareTo(Imm<W,T> src)
            => Imm64 == src.Imm64 ? 0 : Imm64 < src.Imm64 ? -1 : 1;
    }
}