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
    [StructLayout(LayoutKind.Sequential, Size = 10, Pack =1)]
    public readonly struct BitfieldSeg : IBitfieldSeg<byte>
    {
        /// <summary>
        /// The segment name
        /// </summary>
        public StringAddress Name {get;}

        /// <summary>
        /// The index, relative to the containing section, of the first bit in the segment
        /// </summary>
        public byte Min {get;}

        /// <summary>
        /// The index, relative to the containing section, of the last bit in the segment
        /// </summary>
        public byte Max {get;}

        [MethodImpl(Inline)]
        public BitfieldSeg(StringAddress name, byte min, byte max)
        {
            Name = name;
            Min = min;
            Max = max;
        }

        public byte Width
        {
            [MethodImpl(Inline)]
            get => api.width(this);
        }

        [MethodImpl(Inline)]
        public uint Render(ref uint offset, Span<char> dst, SegRenderStyle style = default)
            => api.render(this, ref offset, dst, style);

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}