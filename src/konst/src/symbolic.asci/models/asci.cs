//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct asci : IBytes<asci>
    {
        readonly BinaryCode Data;

        [MethodImpl(Inline)]
        public asci(BinaryCode src)
            => Data = src;

        [MethodImpl(Inline)]
        public asci(string src)
        {
            var len = text.length(src);
            if(len != 0)
            {
                var buffer = sys.alloc<byte>(len);
                Asci.encode(src, buffer);
                Data = buffer;
            }
            else
            {
                Data = BinaryCode.Empty;
            }
        }

        public Span<AsciSymbol> Symbols
        {
            [MethodImpl(Inline)]
            get => recover<byte,AsciSymbol>(Data.Edit);
        }

        public Span<AsciCharCode> Codes
        {
            [MethodImpl(Inline)]
            get => recover<byte,AsciCharCode>(Data.Edit);
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

        public int Capacity
            => Length;

        public bool IsEmpty
            => Data.IsEmpty;

        [MethodImpl(Inline)]
        public string Format()
            => Digital.format(Data);


        [MethodImpl(Inline)]
        public bool Equals(asci src)
            => Data.Equals(src.Data);

        public override bool Equals(object src)
            => src is asci x && Equals(x);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Data.GetHashCode();

        ReadOnlySpan<byte> IByteSeq.View
            => Data.View;

        [MethodImpl(Inline)]
        public static implicit operator asci(string src)
            => new asci(src);

        [MethodImpl(Inline)]
        public static implicit operator asci(byte[] src)
            => new asci(src);

        [MethodImpl(Inline)]
        public static implicit operator asci(BinaryCode src)
            => new asci(src);
    }
}