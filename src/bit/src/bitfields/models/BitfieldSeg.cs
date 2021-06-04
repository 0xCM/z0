//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = BitfieldSpecs;

    public readonly struct BitfieldSeg : IBitfieldSeg<byte>
    {
        /// <summary>
        /// The segment name
        /// </summary>
        public StringAddress Name {get;}

        /// <summary>
        /// The index, relative to the containing section, of the first bit in the segment
        /// </summary>
        public byte FirstIndex {get;}

        /// <summary>
        /// The index, relative to the containing section, of the last bit in the segment
        /// </summary>
        public byte LastIndex {get;}

        [MethodImpl(Inline)]
        public BitfieldSeg(StringAddress name, byte min, byte max)
        {
            Name = name;
            FirstIndex = min;
            LastIndex = max;
        }

        public byte Width
        {
            [MethodImpl(Inline)]
            get => api.width(this);
        }
    }
}