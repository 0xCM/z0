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
        public static Span<T> Swap<T>(this Span<T> src, params Swap[] swaps)           
            where T : unmanaged
        {
            for(var k = 0; k< swaps.Length; k++)
            {
                (var i, var j) = swaps[k];
                swap(ref src[i], ref src[j]);
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
                
        /// <summary>
        /// Effects (i j) -> ((i + 1) (j+ 1))
        /// </summary>
        [MethodImpl(Inline)]
        public static ref Swap Inc(this ref Swap src)
        {
            ++src;
            return ref src;
        }

        /// <summary>
        /// Effects (i j) -> ((i - 1) (j - 1)) where decremented indices are clamped to 0 
        /// </summary>
        [MethodImpl(Inline)]
        public static ref Swap Dec(this ref Swap src)
        {
            --src;
            return ref src;
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

         [MethodImpl(Inline)]
        public static bool Includes(this Perm16 src, int index)
            => (((int)src & (4 << index)) != 0);

        public static PermCycle Cycle(this Perm16 src)
        {            
            Span<PermTerm> terms = stackalloc PermTerm[16];
            var counter = 0;
            for(var i=0; i<16; i++)   
            {
                if(src.Includes(i))
                    terms[counter] = new PermTerm(counter,i);
                counter++;
            }
            return new PermCycle(terms.Slice(0, counter));

        }

        /// <summary>
        /// Maps a permutation on 16 symbols to its canonical scalar representation
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm16 ToSpec(this Perm<N16> src)
        {
            var dst = 0ul;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=3)
                dst |= (ulong)src[i] << offset;                        
            return (Perm16)dst;
        }

        /// <summary>
        /// Reifies a permutation of length 16 from its canonical scalar representative 
        /// </summary>
        /// <param name="spec">The representative</param>
        public static Perm<N16> ToPerm(this Perm16 spec)
        {
            ulong data = (ulong)spec;
            var dst = Perm<N16>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=4)
                dst[i] = (int)BitMask.between(data, (byte)offset, (byte)(offset + 3));
            return dst;
        }


        static readonly Dictionary<int,Perm4> Perm4FromOrderIndex = new Dictionary<int, Perm4>
        {
            [0] = Perm4.ABCD, [1] = Perm4.ABDC, [2] = Perm4.ACBD, 
            [3] = Perm4.ACDB, [4] = Perm4.ADBC, [5] = Perm4.ADCB,             
            
            [6] = Perm4.BACD, [7] = Perm4.BADC, [8] = Perm4.BCAD, 
            [9] = Perm4.BCDA, [10] = Perm4.BDAC, [11] = Perm4.BDCA,            
            
            [12] = Perm4.CABD, [13] = Perm4.CADB, [14] = Perm4.CBAD, 
            [15] = Perm4.CBDA, [16] = Perm4.CDAB, [17] = Perm4.CDBA,            
            
            [18] = Perm4.DABC, [19] = Perm4.DACB, [20] = Perm4.DBAC,             
            [21] = Perm4.DBCA, [22] = Perm4.DCAB, [23] = Perm4.DCBA,            
        };

        static readonly Dictionary<Perm4,int> Perm4ToOrderIndex = new Dictionary<Perm4,int>
        {
            [Perm4.ABCD] = 0, [Perm4.ABDC] = 1, [Perm4.ACBD] = 2, 
            [Perm4.ACDB] = 3, [Perm4.ADBC] = 4, [Perm4.ADCB] = 5,             
            
            [Perm4.BACD] = 6, [Perm4.BADC] = 7, [Perm4.BCAD] = 8, 
            [Perm4.BCDA] = 9, [Perm4.BDAC] = 10, [Perm4.BDCA] = 11,            
            
            [Perm4.CABD] = 12, [Perm4.CADB] = 13, [Perm4.CBAD] = 14, 
            [Perm4.CBDA] = 15, [Perm4.CDAB] = 16, [Perm4.CDBA] = 17,            
            
            [Perm4.DABC] = 18, [Perm4.DACB] = 19, [Perm4.DBAC] = 20,             
            [Perm4.DBCA] = 21, [Perm4.DCAB] = 22, [Perm4.DCBA] = 23,            
        };

        [MethodImpl(Inline)]
        public static Perm4 Next(this Perm4 src)
        {
            if(Perm4ToOrderIndex.TryGetValue(src, out int i) && i < 23)
                    return Perm4FromOrderIndex[i + 1];
            return Perm4.First;
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

        public static Perm4[] Symbols(this Perm4 src)
        {            
            var dst = new Perm4[4];
            for(var i=0; i<4; i++)
            {
                var sym = src.Symbol(i);
                if(!sym)
                    return new Perm4[0]{};
                sym.OnSome(s => dst[i] = s);
            }
            return dst;
        }

        /// <summary>
        /// Computes the digigs corresponding to each 2-segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static Span<N4, byte> Digits(this Perm4 src)
        {
            var scalar = (byte)src;
            var dst = NatSpan.alloc<N4,byte>();
            dst[0] = BitMask.between(scalar, 0, 1);
            dst[1] = BitMask.between(scalar, 2, 3);
            dst[2] = BitMask.between(scalar, 4, 5);
            dst[3] = BitMask.between(scalar, 6, 7);
            return dst;
        }

        /// <summary>
        /// Maps a permutation on 8 symbols to its canonical scalar specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm4 ToSpec(this Perm<N4> src)
        {
            var dst = 0u;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=2)
                dst |= (uint)src[i] << offset;                        
            return (Perm4)dst;
        }

        /// <summary>
        /// Usefully formats the permutation spec
        /// </summary>
        /// <param name="src">The permutation spec</param>
        [MethodImpl(Inline)]
        public static string Format(this Perm4 src)
            => $"{src} = {((byte)src).ToBitString()} = {((byte)src).FormatHex()}"; 

       /// <summary>
        /// Reifies a permutation of length 8 from its canonical scalar specification
        /// </summary>
        /// <param name="spec">The representative</param>
        public static Perm<N8> ToPerm(this Perm8 spec)
        {
            uint data = (uint)spec;
            var dst = Perm<N8>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=3)
                dst[i] = (int)BitMask.between(data, (byte)offset, (byte)(offset + 2));
            return dst;
        }

        /// <summary>
        /// Maps a permutation on 8 symbols to its canonical scalar specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm8 ToSpec(this Perm<N8> src)
        {
            var dst = 0u;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=3)
                dst |= (uint)src[i] << offset;                        
            return (Perm8)dst;
        }

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
                // => (x,y) switch 
                // {
                //     (false,false) => 'A',
                //     (bit.On,bit.Off) => 'B',
                //     (bit.Off,bit.On) => 'C',  
                //     (bit.On,bit.On) => 'D',
                //     _ => '0'
                // };

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

            var bs = BitString.FromScalar((byte)src);
            var block = bracket(bs.Format(false,false,2, AsciSym.Space));
            var domain = $"{Perm4.A}{Perm4.B}{Perm4.C}{Perm4.D}";
            var codomain = letters(bs);
            var mapping = $"{block}: {domain} -> {codomain}";
            return mapping;
        }
     
    }
}