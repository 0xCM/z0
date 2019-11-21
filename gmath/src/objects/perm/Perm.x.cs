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
            var dst = BitString.alloc(p.Length);
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
        public static Block128<T> Swap<T>(this Block128<T> src, params Swap[] swaps)           
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
        public static Block256<T> Swap<T>(this Block256<T> src, params Swap[] swaps)           
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

        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatBlock<N4, byte> Digits(this Perm4 src)
        {
            var scalar = (byte)src;
            var dst = NatBlock.alloc<N4,byte>();
            dst[0] = BitMask.between(scalar, 0, 1);
            dst[1] = BitMask.between(scalar, 2, 3);
            dst[2] = BitMask.between(scalar, 4, 5);
            dst[3] = BitMask.between(scalar, 6, 7);
            return dst;
        }

        public static string FormatBlock(this Perm4 src, bool bracketed = true)
        {
            var bs = BitString.from((byte)src);
            var data = bs.Format(false,false,2, AsciSym.Space);
            return bracketed ? bracket(data) : data;
        }

        /// <summary>
        /// Determines whether a perm value is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        public static bool IsSymbol(this Perm4 src)
            => src == Perm4.A || src == Perm4.B || src == Perm4.C || src == Perm4.D;        
        
        /// <summary>
        /// Usefully formats the permutation spec
        /// </summary>
        /// <param name="src">The permutation spec</param>
        [MethodImpl(Inline)]
        public static string Format(this Perm4 src)
            => $"{src} = {((byte)src).ToBitString()} = {((byte)src).FormatHex()}"; 

        
        /// <summary>
        /// Formats the value as a permutation map, i.e., [00 01 10 11]: ABCD -> ABDC
        /// </summary>
        /// <param name="src">The permutation spec</param>
        public static string FormatMap(this Perm4 src)
        {
            static char letter(bit x, bit y)
            {
                if(x && y)
                    return 'D';
                else if(!x && !y)
                    return 'A';
                else if(x && !y)
                    return 'B';
                else
                    return 'C';
            }

            static string letters(BitString bs)
            {
                Span<char> letters = stackalloc char[4];
                int i=0, j=0;
                letters[i++] = letter(bs[j++], bs[j++]);
                letters[i++] = letter(bs[j++], bs[j++]);
                letters[i++] = letter(bs[j++], bs[j++]);            
                letters[i++] = letter(bs[j++], bs[j++]);            
                return new string(letters);
            }

            var bs = BitString.from((byte)src);
            var block = src.FormatBlock();
            var domain = $"{Perm4.A}{Perm4.B}{Perm4.C}{Perm4.D}";
            var codomain = letters(bs);
            var mapping = $"{block}: {domain} -> {codomain}";
            return mapping;
        }             
    }
}