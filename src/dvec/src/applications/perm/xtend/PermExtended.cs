//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;    

    using API = Permute;

    public static class PermExtended
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

        [MethodImpl(Inline)]
        public static Perm16 ToPermSpec(this Vector128<byte> src)
            => API.vinit(src);

        [MethodImpl(Inline)]
        public static Perm32 ToPermSpec(this Vector256<byte> src)
            => API.vinit(src);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Symbols(this Perm4L src)
            => API.symbols(src);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Symbols(this Perm8L src)
            => API.symbols(src);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Symbols(this Perm16L src)
            => API.symbols(src);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Symbols(this Perm2x4 src)
            => API.symbols(src);
            
        /// <summary>
        /// Applies a sequence of transpositions to a blocked container
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
                
             src.Data.Swap(swaps);
             return src;
        }        

        /// <summary>
        /// Applies a sequence of transpositions to a blocked container
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

             src.Data.Swap(swaps);
             return src;
        }

        /// <summary>
        /// Formats a permutation literal as one would hope
        /// </summary>
        /// <param name="src">The literal definition</param>
        public static string Format(this Perm4L src)
            => API.symbols(src).ToString();

        /// <summary>
        /// Formats a permutation literal as one would hope
        /// </summary>
        /// <param name="src">The literal definition</param>
        public static string Format(this Perm8L src)
            => API.symbols(src).ToString();

        /// <summary>
        /// Formats a permutation literal as one would hope
        /// </summary>
        /// <param name="src">The literal definition</param>
        public static string Format(this Perm16L src)
            => API.symbols(src).ToString();

        public static string FormatBlock(this Perm4L src, bool bracketed = true)
        {
            var bs = BitString.scalar((byte)src);
            var data = bs.Format(false,false,2, Chars.Space);
            return bracketed ? text.bracket(data) : data;
        }

        /// <summary>
        /// Formats the value as a permutation map, i.e., [00 01 10 11]: ABCD -> ABDC
        /// </summary>
        /// <param name="src">The permutation spec</param>
        public static string FormatMap(this Perm4L src)
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

            var bs = BitString.scalar((byte)src);
            var block = src.FormatBlock();
            var domain = $"{Perm4L.A}{Perm4L.B}{Perm4L.C}{Perm4L.D}";
            var codomain = letters(bs);
            var mapping = $"{block}: {domain} -> {codomain}";
            return mapping;
        }             
    }
}