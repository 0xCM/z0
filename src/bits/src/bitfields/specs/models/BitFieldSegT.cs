//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    using api = BitfieldSpecs;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct BitfieldSeg<K>
        where K : unmanaged
    {
        public static string format(in BitfieldSeg<K> src)
        {
            var i = api.endpos((byte)src.Offset,(byte)src.Width);
            if(i == 0)
                return string.Format("{0}[{1}]", src.SegName, src.Offset);
            else
                return string.Format("{0}[{1}:{2}]", src.SegName, src.Offset, i);
        }

        /// <summary>
        /// The segment name
        /// </summary>
        public Identifier SegName {get;}

        /// <summary>
        /// The 0-based position of the segment within the field
        /// </summary>
        public uint SegPos {get;}

        /// <summary>
        /// The segment position within the field
        /// </summary>
        public K SegId {get;}

        /// <summary>
        /// The index of the first bit in the segment
        /// </summary>
        public uint Offset {get;}

        /// <summary>
        /// The index of the last bit in the segment
        /// </summary>
        public uint Width {get;}

        [MethodImpl(Inline)]
        public BitfieldSeg(K id, uint pos, uint offset, uint width)
        {
            SegPos = pos;
            SegName = id.ToString();
            SegId = id;
            Offset = offset;
            Width = width;
        }

        public string Format()
            => format(this);


        public override string ToString()
            => Format();
    }
}