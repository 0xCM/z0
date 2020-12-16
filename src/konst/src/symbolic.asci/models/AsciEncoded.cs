//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    public readonly struct AsciEncoded : IBytes<AsciEncoded>
    {
        public BinaryCode Data {get;}

        [MethodImpl(Inline)]
        public AsciEncoded(BinaryCode src)
            => Data = src;

        [MethodImpl(Inline)]
        public AsciEncoded(string src)
        {
            var buffer = sys.alloc<byte>(src.Length);
            asci.encode(src,buffer);
            Data = buffer;
        }

        public ReadOnlySpan<AsciSymbol> View
        {
            [MethodImpl(Inline)]
            get => z.recover<byte,AsciSymbol>(Bytes);
        }

        public Span<AsciSymbol> Edit
        {
            [MethodImpl(Inline)]
            get => recover<byte,AsciSymbol>(Bytes);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public int Capacity
            => Length;

        public bool IsEmpty
            => Data.IsEmpty;

        [MethodImpl(Inline)]
        public string Format()
            => Digital.format(Data);

        [MethodImpl(Inline)]
        public bool Equals(AsciEncoded src)
            => Data.Equals(src.Data);

        ReadOnlySpan<byte> IByteSeq.View
            => Bytes;

        [MethodImpl(Inline)]
        public static implicit operator AsciEncoded(string src)
            => new AsciEncoded(src);

        [MethodImpl(Inline)]
        public static implicit operator AsciEncoded(byte[] src)
            => new AsciEncoded(src);
    }
}