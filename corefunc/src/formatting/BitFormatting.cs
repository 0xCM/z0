//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    public static class BitFormatting
    {
        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        public static string FormatBits(this byte src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockWidth = null,         
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString(maxbits).Format(tlz, specifier, blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        public static string FormatBits(this sbyte src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString(maxbits).Format(tlz, specifier, blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockwidth">The number of binary digits per block, if specified</param>
        public static string FormatBits(this short src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockwidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString(maxbits).Format(tlz, specifier, blockwidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockwidth">The number of binary digits per block, if specified</param>
        public static string FormatBits(this ushort src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockwidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString(maxbits).Format(tlz, specifier,blockwidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockwidth">The number of binary digits per block, if specified</param>
        public static string FormatBits(this uint src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockwidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString(maxbits).Format(tlz, specifier,blockwidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockwidth">The number of binary digits per block, if specified</param>
        public static string FormatBits(this int src, int? maxbits = null,  bool tlz = false, bool specifier = false, int? blockwidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString(maxbits).Format(tlz, specifier, blockwidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockwidth">The number of binary digits per block, if specified</param>
        public static string FormatBits(this ulong src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockwidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString(maxbits).Format(tlz, specifier,blockwidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        public static string FormatBits(this long src, int? maxbits = null, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString(maxbits).Format(tlz, specifier, blockWidth, blocksep, rowWidth);
                 
        /// <summary>
        /// Block-formats the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="blocksize">The length of a block in bits; defaults to 8</param>
        /// <param name="specifier">If true, output will begin with the '0b' binary specifier</param>
        /// <param name="underscores">If true, the underscore character '_' will be used to delimit blocks, otherwise, spaces will be used</param>
        static string BlockedBits<T>(T src, int? blocksize = null, int? maxbits = null, bool specifier = false, bool underscores = false)
            where T : unmanaged
            => text.bracket(BitString.scalar(src,maxbits).Format(false, specifier, blocksize ?? 8, underscores ? AsciSym.Underscore : AsciSym.Space, null));

        /// <summary>
        /// Block-formats the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="blocksize">The length of a block in bits; defaults to 8</param>
        /// <param name="specifier">If true, output will begin with the '0b' binary specifier</param>
        /// <param name="underscores">If true, the underscore character '_' will be used to delimit blocks, otherwise, spaces will be used</param>
        public static string FormatBlockedBits(this byte src, int? blocksize = null, int? maxbits = null, bool specifier = false, bool underscores = false)
            =>  BlockedBits(src, blocksize, maxbits, specifier, underscores);

        /// <summary>
        /// Block-formats the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="blocksize">The length of a block in bits; defaults to 8</param>
        /// <param name="specifier">If true, output will begin with the '0b' binary specifier</param>
        /// <param name="underscores">If true, the underscore character '_' will be used to delimit blocks, otherwise, spaces will be used</param>
        public static string FormatBlockedBits(this ushort src, int? blocksize = null, int? maxbits = null, bool specifier = false, bool underscores = false)
            =>  BlockedBits(src, blocksize, maxbits, specifier, underscores);

        /// <summary>
        /// Block-formats the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="blocksize">The length of a block in bits; defaults to 8</param>
        /// <param name="specifier">If true, output will begin with the '0b' binary specifier</param>
        /// <param name="underscores">If true, the underscore character '_' will be used to delimit blocks, otherwise, spaces will be used</param>
        public static string FormatBlockedBits(this uint src, int? blocksize = null, int? maxbits = null,  bool specifier = false, bool underscores = false)
            =>  BlockedBits(src, blocksize, maxbits, specifier, underscores);

        /// <summary>
        /// Block-formats the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="blocksize">The length of a block in bits; defaults to 8</param>
        /// <param name="specifier">If true, output will begin with the '0b' binary specifier</param>
        /// <param name="underscores">If true, the underscore character '_' will be used to delimit blocks, otherwise, spaces will be used</param>
        public static string FormatBlockedBits(this ulong src, int? blocksize = null, int? maxbits = null,  bool specifier = false, bool underscores = false)
            =>  BlockedBits(src, blocksize, maxbits, specifier, underscores);

        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static string FormatBits<T>(this ReadOnlySpan<T> src, int? maxbits = null,  bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged
                => BitString.scalars(src).Truncate(maxbits ?? int.MaxValue).Format(tlz, specifier, blockWidth, blocksep, rowWidth); 

        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static string FormatBits<T>(this Span<T> src, int? maxbits = null,  bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged
                    => src.ReadOnly().FormatBits(maxbits,tlz, specifier, blockWidth, blocksep, rowWidth);

        public static string FormatBits<T>(this T src)
            where T : unmanaged, IFixed
                => BitConvert.GetBytes(in src).FormatBits();

        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static string FormatBits<N,T>(this NatSpan<N,T> src, int? maxbits = null,   bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged
                where N : unmanaged, ITypeNat
                    => src.Data.FormatBits(maxbits, tlz,specifier,blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the content as a bitstring
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static string Format(this ReadOnlySpan<bit> src, BitFormatConfig? fmt = null)
            => src.ToBitString().Format(fmt);
            
        /// <summary>
        /// Formats the content as a bitstring
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static string Format(this Span<bit> src,  BitFormatConfig? fmt = null)
            => src.ReadOnly().Format(fmt);                     
    }
}