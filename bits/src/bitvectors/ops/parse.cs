//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;

    using static zfunc;

    partial class BitVector
    {
        /// <summary>
        /// Parses a 8-bit primal bitvector from a 0-1 string
        /// </summary>
        /// <param name="src">The source text</param>
        public static BitVector8 parse(N8 n, string src)
            => Bits.packseq(BitString.parse(src).BitSeq, out byte _);

        /// <summary>
        /// Parses a 16-bit primal bitvector from a 0-1 string
        /// </summary>
        /// <param name="src">The source text</param>
        public static BitVector16 parse(N16 n, string src)
            => Bits.packseq(BitString.parse(src).BitSeq, out ushort _);

        /// <summary>
        /// Parses a 32-bit primal bitvector from a 0-1 string
        /// </summary>
        /// <param name="src">The source text</param>
        public static BitVector32 parse(N32 n, string src)
            => Bits.packseq(BitString.parse(src).BitSeq, out uint _);

        /// <summary>
        /// Parses a 64-bit primal bitvector from a 0-1 string
        /// </summary>
        /// <param name="src">The source text</param>
        public static BitVector64 parse(N64 n, string src)
            => Bits.packseq(BitString.parse(src).BitSeq, out ulong _);        
    }
}