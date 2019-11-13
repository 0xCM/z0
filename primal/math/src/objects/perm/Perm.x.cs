//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static zfunc;    

    public static class PermX
    {
        /// <summary>
        /// Shuffles bitstring content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        public static BitString Permute(this BitString src, Perm p)
        {
            var dst = BitString.Alloc(p.Length);
            for(var i = 0; i < p.Length; i++)
                dst[i] = src[p[i]];
            return dst;
        }

        /// <summary>
        /// Shuffles span content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        public static Span<T> Permute<T>(this ReadOnlySpan<T> src, Perm p)
        {
            Span<T> dst = new T[src.Length];
            for(var i=0; i<p.Length; i++)
                dst[i] = src[p[i]];                
            return dst;
        }

        /// <summary>
        /// Shuffles span content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        [MethodImpl(Inline)]
        public static Span<T> Permute<T>(this Span<T> src, Perm p)
            => src.ReadOnly().Permute(p);

        /// <summary>
        /// Formats the terms of a permutation
        /// </summary>
        /// <param name="terms">The permutation terms</param>
        /// <param name="colwidth">The width of each column</param>
        /// <typeparam name="T">The term type</typeparam>
        public static string FormatAsPerm<T>(this ReadOnlySpan<T> terms,  int? colwidth = null)
        {
            var line1 = sbuild();
            var line2 = sbuild();
            var pad = colwidth ?? 3;
            var leftBoundary = $"{AsciSym.Pipe}".PadRight(2);
            var rightBoundary = $"{AsciSym.Pipe}";
            
            line1.Append(leftBoundary);
            line2.Append(leftBoundary);
            for(var i=0; i < terms.Length; i++)
            {
                line1.Append($"{i}".PadRight(pad));
                line2.Append($"{terms[i]}".PadRight(pad));
            }
            line1.Append(rightBoundary);
            line2.Append(rightBoundary);
            
            return line1.ToString() + eol() + line2.ToString();
        }

        /// <summary>
        /// Formats the terms of a permutation
        /// </summary>
        /// <param name="terms">The permutation terms</param>
        /// <param name="colwidth">The width of each column</param>
        /// <typeparam name="T">The term type</typeparam>
        public static string FormatAsPerm<T>(this Span<T> terms,  int? colwidth = null)
            => terms.ReadOnly().FormatAsPerm(colwidth);

        /// <summary>
        /// Applies a sequence of transpositions to source span elements
        /// </summary>
        /// <param name="src">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Swap<T>(this Span<T> src, params Swap[] swaps)           
            where T : unmanaged
        {
            var len = swaps.Length;
            ref var srcmem = ref head(src);
            ref var swapmem = ref head(swaps);
            for(var k = 0; k < len; k++)
            {
                (var i, var j) = skip(in swapmem, k);
                swap(ref seek(ref srcmem, i), ref seek(ref srcmem, j));
            }
            return src;
        }

        /// <summary>
        /// Applies a sequence of transpositions to source span elements
        /// </summary>
        /// <param name="src">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> Swap<T>(this Span128<T> src, params Swap[] swaps)           
            where T : unmanaged
        {
             if(swaps == null || swaps.Length == 0)
                return src;
                
             src.Unblocked.Swap(swaps);
             return src;
        }        

        /// <summary>
        /// Applies a sequence of transpositions to source span elements
        /// </summary>
        /// <param name="src">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Swap<T>(this Span256<T> src, params Swap[] swaps)           
            where T : unmanaged
        {
             if(swaps == null || swaps.Length == 0)
                return src;

             src.Unblocked.Swap(swaps);
             return src;
        }
                
        public static Swap[] Unsized<N>(this Swap<N>[] src)
            where N : unmanaged, ITypeNat
        {
            var dst = new Swap[src.Length];
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        /// <summary>
        /// Formats a sequence of successive transpositions (a chain)
        /// </summary>
        /// <param name="src">The transpositions</param>
        [MethodImpl(Inline)]
        public static string Format(this Swap[] src)
            => string.Join(" -> ", src.Map(x => x.Format()));
    
        /// <summary>
        /// Shuffles a copy of the source permutation, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        [MethodImpl(Inline)]
        public static Perm Shuffle(this IPolyrand random, in Perm src)
        {
            var copy = src.Replicate();
            copy.Shuffle(random);
            return copy;
        }

        /// <summary>
        /// Shuffles a copy of the source permutatiion, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        /// <typeparam name="N">The permutation length</typeparam>
        [MethodImpl(Inline)]
        public static Perm<N> Shuffle<N>(this IPolyrand random, in Perm<N> src)
            where N : unmanaged, ITypeNat
        {
            var copy = src.Replicate();
            copy.Shuffle(random);
            return copy;
        }
        
        public static Option<Perm4> Symbol(this Perm4 src, int index)
        {            
            if(index >=0 && index <= 3)
            {
                var start = (byte)(index * 2);
                var end = (byte)(start + 1);
                var value = BitMask.between((byte)src, start, end);
                switch(value)
                {
                    case 0: return Perm4.A;
                    case 1: return Perm4.B;
                    case 2: return Perm4.C;
                    case 3: return Perm4.D;
                    default:
                        return default;
                }
            }
            return default;
        }

        /// <summary>
        /// Usefully formats the permutation spec
        /// </summary>
        /// <param name="src">The permutation spec</param>
        [MethodImpl(Inline)]
        public static string Format(this Perm4 src)
            => $"{src} = {((byte)src).ToBitString()} = {((byte)src).FormatHex()}"; 
    }
}