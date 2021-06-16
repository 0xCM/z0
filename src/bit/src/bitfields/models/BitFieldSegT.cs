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
    public readonly struct BitfieldSeg<K> : IBitfieldSeg<K,byte>
        where K : unmanaged
    {
        public K SegId {get;}

        /// <summary>
        /// The index, relative to the containing section, of the first bit in the segment
        /// </summary>
        public byte Min {get;}

        /// <summary>
        /// The index, relative to the containing section, of the last bit in the segment
        /// </summary>
        public byte Max {get;}

        [MethodImpl(Inline)]
        public BitfieldSeg(K id, byte min, byte max)
        {
            SegId = id;
            Min = min;
            Max = max;
        }


        public byte Width
        {
            [MethodImpl(Inline)]
            get => api.width(this);
        }

        public string Format()
            => string.Format("{0}[{1},{2}]", SegId, Min, Max);


        public override string ToString()
            => Format();
    }
}