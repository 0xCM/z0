//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Specifies the bits to be extracted from a source
    /// </summary>
    public readonly struct BitExtractSpec
    {
        [MethodImpl(Inline)]
        public static BitExtractSpec define(byte start, byte count)
            => new BitExtractSpec(start, count);

        public ushort Data {get;}

        [MethodImpl(Inline)]
        public BitExtractSpec(byte start, byte count)
            => Data = math.and((ushort)start, math.sll((ushort)count, 8));

        /// <summary>
        /// The source-relative index of the first bit
        /// </summary>
        public byte Start
        {
            [MethodImpl(Inline)]
            get => (byte)Data;
        }

        /// <summary>
        /// The number of bits to extract
        /// </summary>
        public byte Count
        {
            [MethodImpl(Inline)]
            get => (byte)math.srl(Data, 8);
        }

        [MethodImpl(Inline)]
        public static implicit operator BitExtractSpec((byte start, byte count) src)
            => new BitExtractSpec(src.start, src.count);

        [MethodImpl(Inline)]
        public static implicit operator ushort(BitExtractSpec src)
            => src.Data;
    }
}