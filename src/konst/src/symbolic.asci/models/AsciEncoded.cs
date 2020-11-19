//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AsciEncoded : IBytes<AsciEncoded>, IEncoded<AsciEncoded>
    {
        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public AsciEncoded(BinaryCode src)
            => Encoded = src;

        [MethodImpl(Inline)]
        public AsciEncoded(string src)
        {
            var buffer = sys.alloc<byte>(src.Length);
            asci.encode(src,buffer);
            Encoded = buffer;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsciEncoded(string src)
            => new AsciEncoded(src);

        [MethodImpl(Inline)]
        public static implicit operator AsciEncoded(byte[] src)
            => new AsciEncoded(src);

        public ReadOnlySpan<AsciSymbol> View
        {
            [MethodImpl(Inline)]
            get => z.recover<byte,AsciSymbol>(Bytes);
        }

        public Span<AsciSymbol> Edit
        {
            [MethodImpl(Inline)]
            get => z.recover<byte,AsciSymbol>(Bytes);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Encoded.Length;
        }

        Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Encoded.Data;
        }

        public int Capacity
            => Length;

        public bool IsEmpty
            => Encoded.IsEmpty;

        [MethodImpl(Inline)]
        public string Format()
            => Digital.format(Encoded);

        [MethodImpl(Inline)]
        public bool Equals(AsciEncoded src)
            => Encoded.Equals(src.Encoded);

        ReadOnlySpan<byte> IBytes.View
            => Bytes;
    }
}