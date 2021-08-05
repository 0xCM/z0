//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct HexArray
    {
        readonly Index<byte> Data;

        [MethodImpl(Inline)]
        public HexArray(byte[] data)
        {
            Data = data;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Size != 0;
        }

        public string Format(bool enclose)
        {
            var content = HexFormatter.array(Data.View);
            return enclose ? RP.bracket(content) : content;
        }

        public override string ToString()
            => Format(false);

        [MethodImpl(Inline)]
        public static implicit operator HexArray(byte[] src)
            => new HexArray(src);

        public static HexArray Empty
        {
            [MethodImpl(Inline)]
            get => Array.Empty<byte>();
        }
    }
}