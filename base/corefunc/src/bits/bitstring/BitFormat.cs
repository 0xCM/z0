//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    /// <summary>
    /// Controls formatting when bitstring content is rendered as text
    /// </summary>
    public readonly struct BitFormat
    {        
        /// <summary>
        /// Indicates whether leading zeros should be trimmed
        /// </summary>
        public readonly bool TrimLeadingZeros;

        /// <summary>
        /// Indicates whether the '0b' prefix should be emitted
        /// </summary>
        public readonly bool SpecifierPrefix;

        /// <summary>
        /// Optional contiguous digit sequence width; if unspecified the bistring will be formatted without blocks
        /// </summary>
        public readonly int BlockWidth;

        /// <summary>
        /// The character with which to intersperse blocks; if unspecified, a space will be used
        /// </summary>
        public readonly char BlockSep;

        /// <summary>
        /// The optional row width, applicable when formatting rectangular regions of bits
        /// </summary>
        public readonly int RowWidth;        

        public static BitFormat Default 
            => new BitFormat(false);

        public static BitFormat Tlz
            => new BitFormat(true);

        [MethodImpl(Inline)]
        public static implicit operator BitFormat(int blockwidth)
            => Blocked(blockwidth);

        [MethodImpl(Inline)]
        public static BitFormat Blocked(int width, char? sep = null)
            => new BitFormat(blockWidth: width, blocksep: sep);

        [MethodImpl(Inline)]
        public static BitFormat RowBlocked(int blockWidth, int rowWidth, char? blockSep = null)
            => new BitFormat(blockWidth: blockWidth, rowWidth:rowWidth, blocksep: blockSep);

        [MethodImpl(Inline)]
        public BitFormat(bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null, int? rowWidth = null)
        {
            this.TrimLeadingZeros = tlz;
            this.SpecifierPrefix = false;
            this.BlockWidth = blockWidth ?? 0;
            this.BlockSep = blocksep ?? AsciSym.Space;
            this.RowWidth = rowWidth ?? 0;
        }
    }

}