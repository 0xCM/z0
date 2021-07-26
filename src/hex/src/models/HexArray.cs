//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;

    using static Root;
    using static core;

    public readonly struct HexArray
    {
        public static Outcome parse(string src, out HexArray dst)
        {
            dst = HexArray.Empty;
            var l = text.index(src, Chars.LBracket);
            if(l < 0)
                return (false, string.Format("Missing left bracket"));

            var r = text.index(src, Chars.RBracket);
            if(r < l)
                return (false, string.Format("Missing/bad right bracket"));

            var data =  text.segment(src, l + 1, r - 1);
            var cells = data.SplitClean(Chars.Comma).ToReadOnlySpan();
            var count = cells.Length;
            var buffer = alloc<byte>(count);
            ref var target = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(cells,i);
                if(!HexNumericParser.parse8u(cell, out seek(target,i)))
                    return (false, cell);
            }
            dst = buffer;
            return true;
        }

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

        public string Format()
            => RP.bracket(HexFormatter.array(Data.View));

        public override string ToString()
            => Format();

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