//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct GridStorage
    {
        /// <summary>
        /// The the total number of segment-aligned bits allocated for storage
        /// </summary>
        public readonly uint Bits;

        /// <summary>
        /// The the total number of segments allocated for storage
        /// </summary>
        public readonly uint Segments;

        [MethodImpl(Inline)]
        public GridStorage(uint bits, uint segments)
        {
            Bits = bits;
            Segments = segments;
        }

        /// <summary>
        /// The the total number of segment-aligned bytes allocated for storage
        /// </summary>
        public uint Bytes
        {
            [MethodImpl(Inline)]
            get => Bits/8;
        }

        [MethodImpl(Inline)]
        public bool Equals(GridStorage src)
            => src.Bits == Bits && src.Segments == Segments;

        [MethodImpl(Inline)]
        public override int GetHashCode()
            => HashCode.Combine(Bits,Segments);
    }
}