//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    

    partial class xfunc
    {
        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this byte src, bool tlz = false, bool specifier = false, int? blockWidth = null,         
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString().Format(tlz, specifier, blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this sbyte src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString().Format(tlz, specifier, blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this short src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString().Format(tlz, specifier, blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this ushort src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString().Format(tlz, specifier,blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this uint src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString().Format(tlz, specifier,blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this int src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString().Format(tlz, specifier, blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this ulong src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString().Format(tlz, specifier,blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this long src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString().Format(tlz, specifier, blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static string FormatBits<T>(this ReadOnlySpan<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged
        {
            var sb = text();
            for(var i=0; i<src.Length; i++)
            {
                var bs = BitString.scalar(src[i]).Format(tlz,specifier,blockWidth, blocksep, rowWidth);
                sb.Append(bs);
                if(i != src.Length - 1)
                    sb.Append(AsciSym.Space);                    
            }
            return sb.ToString();
        }

        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatBits<T>(this Span<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged
                    => src.ReadOnly().FormatBits(tlz, specifier, blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatBits<N,T>(this NatSpan<N,T> src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged
                where N : unmanaged, ITypeNat
                    => src.Unsized.FormatBits(tlz,specifier,blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatBits(this ReadOnlySpan<bit> src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ToBitString().Format(tlz, specifier, blockWidth, blocksep, rowWidth);
            
        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatBits(this Span<bit> src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                => src.ReadOnly().FormatBits(tlz, specifier, blockWidth, blocksep, rowWidth);

        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="N">The natural length type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatBits<N>(this NatSpan<N,bit> src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where N : unmanaged, ITypeNat
                    => src.Unsized.FormatBits(tlz, specifier, blockWidth, blocksep, rowWidth);
                 
        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBits<T>(this Vector128<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged        
                    => src.ToBitString().Format(tlz, specifier, blockWidth ?? bitsize<T>(), blocksep ,rowWidth);
        
        /// <summary>
        /// Formats vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBits<T>(this Vector256<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null)
                where T : unmanaged        
                    => src.ToBitString().Format(tlz, specifier, blockWidth ?? bitsize<T>(), blocksep ,rowWidth);

        /// <summary>
        /// Block-formats the vector, e.g. [01010101 01010101 ... 01010101] where the size of each block is the bit-width of a component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBitBlocks<T>(this Vector128<T> src)
            where T : unmanaged        
                => bracket(src.ToBitString().Format(false, false, bitsize<T>(), AsciSym.Space,null));

        /// <summary>
        /// Block-formats the vector, e.g. [01010101 01010101 ... 01010101] where the size of each block is the bit-width of a component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]   
        public static string FormatBitBlocks<T>(this Vector256<T> src)
            where T : unmanaged        
                => bracket(src.ToBitString().Format(false, false, bitsize<T>(), AsciSym.Space,null));

    }
}