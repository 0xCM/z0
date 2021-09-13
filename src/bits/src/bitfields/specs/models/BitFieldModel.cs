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

    public readonly struct BitfieldModel : IBitfieldModel
    {
        /// <summary>
        /// The bitfield name
        /// </summary>
        public Identifier Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        public uint SegCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint TotalWidth {get;}

        readonly Index<BitfieldSeg> Data;

        [MethodImpl(Inline)]
        public BitfieldModel(Identifier name, Index<BitfieldSeg> segs, uint width)
        {
            Name = name;
            SegCount = segs.Count;
            TotalWidth = width;
            Data = segs;
        }

        public Span<BitfieldSeg> Segments
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        [MethodImpl(Inline)]
        public ref BitfieldSeg Seg(uint i)
            => ref Data[i];

        public ref BitfieldSeg this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Seg(i);
        }

        [MethodImpl(Inline)]
        public uint SegWidth(uint i)
            => Seg(i).Width;

        [MethodImpl(Inline)]
        public uint SegStart(uint i)
            => Seg(i).Offset;

        [MethodImpl(Inline)]
        public uint SegEnd(uint i)
            => Seg(i).Width;


        public string Format()
        {
            const string SegPattern = "{0},";
            var dst = text.buffer();
            var decl = string.Format("{0}[{1},{2}] " , Name, TotalWidth,SegCount);
            dst.AppendLine(decl + Chars.LBrace);
            var indent = 2u;
            for(var i=0; i<SegCount; i++)
            {
                dst.IndentLineFormat(indent, SegPattern, skip(Segments,i).Format());
            }
            indent -= 2;
            dst.IndentLine(indent,Chars.RBrace);
            return dst.Emit();
        }
    }
}