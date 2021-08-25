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

    /// <summary>
    /// Defines an identified, contiguous bitsequence, represented symbolically as {Identifier}:[Min,Max]
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct BitfieldSeg : IBitfieldSeg
    {
        /// <summary>
        /// The segment name
        /// </summary>
        public Identifier SegName {get;}

        /// <summary>
        /// The 0-based position of the segment within the field
        /// </summary>
        public uint SegPos {get;}

        /// <summary>
        /// The index of the first bit in the segment
        /// </summary>
        public uint Offset {get;}

        /// <summary>
        /// The index, of the last bit in the segment
        /// </summary>
        public uint Width {get;}

        [MethodImpl(Inline)]
        public BitfieldSeg(Identifier name, uint pos,  uint offset, uint width)
        {
            SegName = name;
            SegPos = pos;
            Offset = offset;
            Width = width;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}