//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Controls formatting when bitstring content is rendered as text
    /// </summary>
    public readonly struct BitFormatConfig 
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
        /// The maximum number of bits to be extracted/formatted from the source
        /// </summary>
        public readonly int MaxBitCount;

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

        /// <summary>
        /// The number of leading zeroes to pad
        /// </summary>
        public readonly int ZPad;     

        public static BitFormatConfig Default 
            => BitFormatConfig.Define(false);

        public static BitFormatConfig Tlz
            => BitFormatConfig.Define(true);

        [MethodImpl(Inline)]
        public static implicit operator BitFormatConfig(int blockwidth)
            => Blocked(blockwidth);

        [MethodImpl(Inline)]
        public static BitFormatConfig Limited(int maxbits, int? zpad = null)
            => BitFormatConfig.Define(true, maxbits: maxbits, zpad:zpad);

        [MethodImpl(Inline)]
        public static BitFormatConfig Blocked(int width, char? sep = null, int? maxbits = null, bool specifier = false)
            => BitFormatConfig.Define(blockWidth: width, blocksep: sep, maxbits:maxbits, specifier: specifier);

        [MethodImpl(Inline)]
        public static BitFormatConfig RowBlocked(int blockWidth, int rowWidth, char? blockSep = null)
            => BitFormatConfig.Define(blockWidth: blockWidth, rowWidth:rowWidth, blocksep: blockSep);

        [MethodImpl(Inline)]
        public static BitFormatConfig Define(bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null, int? maxbits = null, int? zpad = null)
                => new BitFormatConfig(tlz, specifier, blockWidth, blocksep, rowWidth, maxbits,zpad);

        [MethodImpl(Inline)]
        BitFormatConfig(bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null, int? rowWidth = null, 
            int? maxbits = null, int? zpad = null)
        {
            this.TrimLeadingZeros = tlz;
            this.SpecifierPrefix = specifier;
            this.BlockWidth = blockWidth ?? 0;
            this.BlockSep = blocksep ?? Chars.Space;
            this.RowWidth = rowWidth ?? 0;
            this.MaxBitCount = maxbits ?? int.MaxValue;
            this.ZPad = zpad ?? 0;
        }
        
        public BitFormatConfig WithSpecifier()
            => BitFormatConfig.Define(TrimLeadingZeros,true,BlockWidth,BlockSep,RowWidth,MaxBitCount);
    }
}