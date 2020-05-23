//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using static Seed;    
    using static Memories;

    [ApiHost]
    public class PermSymbolic : IApiHost<PermSymbolic>
    {
        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 4-symbol permutation
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        [MethodImpl(Inline), Op]
        public static Span<Perm4L> literals(Perm4L src)
        {            
            const int length = 4;

            var dst = new Perm4L[length];
            for(var i=0; i < length; i++)
                if(!PermSymbolic.literal(src,i, out dst[i]))
                    return Span<Perm4L>.Empty;

            return dst;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define an 8-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        /// <param name="dst">The literal receiver</param>
        [MethodImpl(Inline), Op]
        public static bit literals(Perm8L src, Span<Perm8L> dst)
        {
            const int length = 8;

            for(var i=0; i< length; i++)
                if(!PermSymbolic.literal(src, i, out dst[i]))
                    return false;
            
            return true;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define an 8-symbol permutation
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        [MethodImpl(Inline), Op]
        public static Span<Perm8L> literals(Perm8L src)
        {            
            const int length = 8;
            
            Span<Perm8L> dst = new Perm8L[length];
            if(!literals(src, dst))
                return Span<Perm8L>.Empty;

            return dst;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 16-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        /// <param name="dst">The literal receiver</param>
        [MethodImpl(Inline), Op]
        public static bit literals(Perm16L src, Span<Perm16L> dst)
        {
            const int length = 16;

            for(var i=0; i< length; i++)
                if(!PermSymbolic.literal(src, i, out dst[i]))
                    return false;
            
            return true;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 16-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        [MethodImpl(Inline), Op]
        public static Span<Perm16L> literals(Perm16L src)
        {            
            Span<Perm16L> dst = new Perm16L[16];
            if(!literals(src,dst))
                return Span<Perm16L>.Empty;            
            return dst;
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bit literal(Perm4L src, int index, out Perm4L dst)
        {
            const int segwidth = 2;             
            var first = (byte)(index * segwidth);
            var last = (byte)(first + segwidth - 1);

            dst = (Perm4L)BitOps.extract((byte)src, first, last);
            return dst.IsSymbol();
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bit literal(Perm8L src, int index, out Perm8L dst)
        {
            const int segwidth = 3; 
            var first = (byte)(index * segwidth);
            var last = (byte)(first + segwidth - 1);

            dst = (Perm8L)BitOps.extract((uint)src, first, last);
            return dst.IsSymbol();
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bit literal(Perm16L src, int index, out Perm16L dst)
        {
            const int segwidth = 4;     
            var first = (byte)(index * segwidth);
            var last = (byte)(first + segwidth - 1);

            dst = (Perm16L)BitOps.extract((ulong)src, first, last);
            return dst.IsSymbol();
        }

        [MethodImpl(Inline), Op]
        public static Perm16 define(N16 n, Vector128<byte> data)
            => Perm16.Init(data);


        [MethodImpl(Inline), Op]
        public static Perm32 define(N32 n, Vector256<byte> data)
            => Perm32.Init(data);

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec as
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> digits(Perm16 spec)
            => dvec.vshuf16x8(Data.vincrements<byte>(n128), spec.data);

        /// <summary>
        /// Computes the digits corresponding to each 5-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> digits(Perm32 spec)
            => dvec.vshuf32x8(Data.vincrements<byte>(n256),spec.data);

        /// <summary>
        /// Enumerates all permutation map format strings on 4 symbols
        /// </summary>
        public static IEnumerable<(Perm4L perm, string format)> Exhaust(N4 n)
            => from perm in Enums.valarray<Perm4L>()
                    where !perm.IsSymbol()
                    let maps = (perm, format:perm.FormatMap())
                    orderby maps.perm descending
                    select maps;

        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<byte> digits(Perm4L src, Span<byte> dst)
        {
            var scalar = (byte)src;
            seek(dst,0) = BitOps.extract(scalar, 0, 1);
            seek(dst,1) = BitOps.extract(scalar, 2, 3);
            seek(dst,2) = BitOps.extract(scalar, 4, 5);
            seek(dst,3) = BitOps.extract(scalar, 6, 7);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> digits(Perm4L src)
            => digits(src,new byte[4]);

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<OctalDigit> digits(Perm8L src, Span<OctalDigit> dst)
        {
            //[0 1 2 | 3 4 5 | 6 7 8 | ... | 21 22 23] -> 256x32
            var scalar = (uint)src;
            seek(dst,0) = (OctalDigit)BitOps.extract(scalar, 0, 2);
            seek(dst,1) = (OctalDigit)BitOps.extract(scalar, 3, 5);
            seek(dst,2) = (OctalDigit)BitOps.extract(scalar, 6, 8);
            seek(dst,3) = (OctalDigit)BitOps.extract(scalar, 9, 11);
            seek(dst,4) = (OctalDigit)BitOps.extract(scalar, 12, 14);
            seek(dst,5) = (OctalDigit)BitOps.extract(scalar, 15, 17);
            seek(dst,6) = (OctalDigit)BitOps.extract(scalar, 18, 20);
            seek(dst,7) = (OctalDigit)BitOps.extract(scalar, 21, 23);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<OctalDigit> digits(Perm8L src)
            => digits(src, new OctalDigit[8]);

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<HexDigit> digits(Perm16L src, Span<HexDigit> dst)
        {
            var scalar = (ulong)src;
            seek(dst,0) = (HexDigit)BitOps.extract(scalar, 0, 3);
            seek(dst,1) = (HexDigit)BitOps.extract(scalar, 4, 7);
            seek(dst,2) = (HexDigit)BitOps.extract(scalar, 8, 11);
            seek(dst,3) = (HexDigit)BitOps.extract(scalar, 12, 15);
            seek(dst,4) = (HexDigit)BitOps.extract(scalar, 16, 19);
            seek(dst,5) = (HexDigit)BitOps.extract(scalar, 20, 23);
            seek(dst,6) = (HexDigit)BitOps.extract(scalar, 24, 27);
            seek(dst,7) = (HexDigit)BitOps.extract(scalar, 28, 31);
            seek(dst,8) = (HexDigit)BitOps.extract(scalar, 32, 35);
            seek(dst,9) = (HexDigit)BitOps.extract(scalar, 36, 39);
            seek(dst,10) = (HexDigit)BitOps.extract(scalar, 40, 43);
            seek(dst,11) = (HexDigit)BitOps.extract(scalar, 44, 47);
            seek(dst,12) = (HexDigit)BitOps.extract(scalar, 48, 53);
            seek(dst,13) = (HexDigit)BitOps.extract(scalar, 52, 55);
            seek(dst,14) = (HexDigit)BitOps.extract(scalar, 56, 59);
            seek(dst,15) = (HexDigit)BitOps.extract(scalar, 60, 63);
            return dst;
        }
        
        [MethodImpl(Inline), Op]
        public static Span<HexDigit> digits(Perm16L src)        
            => digits(src, new HexDigit[16]);

        /// <summary>
        /// Creates value-to-symbol index
        /// </summary>
        /// <typeparam name="E">The enumeration type that defines the symbols</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static IDictionary<T,char> index<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var values = Enums.dictionary<E,T>();
            var index = new Dictionary<T,char>();
            foreach(var kvp in values)
                index[kvp.Key] = kvp.Value.ToString().Last();
            return index;
        }

        /// <summary>
        /// Assumes that 
        /// 1. The source data source is a tape upon which fixed-width symbols are sequentially recorded
        /// 2. The symbol alphabet is defined by the last character of the literals defined by an enumeration
        /// With these preconditions, the operation returns the ordered sequence of symbols written to the tape
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="segwidth">The number of bits designated to represent/define a symbol value</param>
        /// <param name="maxbits">The maximum number bits to use if less than the bit width of the vector</param>
        /// <typeparam name="E">The enumeration type that defines the symbols</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static ReadOnlySpan<char> symbols<E,T>(T src, int segwidth, int? maxbits = null)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var index = index<E,T>();
            var bitcount = maxbits ?? bitsize<T>();
            var count = BitCalcs.mincells(segwidth, bitcount);
            Span<char> symbols = new char[count];
            for(int i=0, bitpos = 0; i<count; i++, bitpos += segwidth)
            {
                var key = gbits.extract(src, (byte)bitpos, (byte)(bitpos + segwidth - 1));                
                if(index.TryGetValue(key, out var value))
                    symbols[i] = value;
                else
                    throw new Exception($"The value {key}:{typeof(T).DisplayName()} does not exist in the index");
            }
            return symbols;
        }
         
        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm4L src)
            => symbols<Perm4Sym,byte>((byte)src,2);

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm8L src)
            => symbols<Perm8Sym,uint>((uint)src,3,24);

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm16L src)
            => symbols<Perm16Sym,ulong>((ulong)src,4);

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm2x4 src)
            => symbols<Perm4Sym,byte>((byte)src,4);

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bit test(Perm4L src)
            => (byte)src <= 3;

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bit test(Perm8L src)
            => (uint)src <= 7;

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bit test(Perm16L src)
            => (ulong)src <= 15;
 
        [MethodImpl(Inline)]
        static uint assemble4(uint x0, uint x1, uint x2, uint x3)
            => x0 | x1 << 2 | x2 << 4 | x3 << 6;

        [MethodImpl(Inline)]
        static ulong assemble16(
            ulong x0, ulong x1, ulong x2, ulong x3, 
            ulong x4, ulong x5, ulong x6, ulong x7, 
            ulong x8, ulong x9, ulong xA, ulong xB, 
            ulong xC, ulong xD, ulong xE, ulong xF) 
              => x0 | x1 << 4  | x2 << 8  | x3 << 12 
                    | x4 << 16 | x5 << 20 | x6 << 24 | x7 << 28 
                    | x8 << 32 | x9 << 36 | xA << 40 | xB << 44 
                    | xC << 48 | xD << 52 | xE << 56 | xF << 60;                   

        /// <summary>
        /// Constructs a permutation of length four from four ordered symbols
        /// </summary>
        [MethodImpl(Inline),Op]
        public static Perm4L assemble(Perm4L x0, Perm4L x1, Perm4L x2, Perm4L x3)
            => (Perm4L)assemble4((uint)x0, (uint)x1, (uint)x2, (uint)x3);

        /// <summary>
        /// Constructs a permutation of length 8 from 8 ordered symbols
        /// </summary>
        [MethodImpl(Inline),Op]
        public static Perm8L assemble(
            Perm8L x0, Perm8L x1, Perm8L x2, Perm8L x3, 
            Perm8L x4, Perm8L x5, Perm8L x6, Perm8L x7)
        {               
            var dst = (uint)x0       | (uint)x1 << 3  | (uint)x2 << 6  | (uint)x3 << 9 
                    | (uint)x4 << 12 | (uint)x5 << 15 | (uint)x6 << 18 | (uint)x7 << 21; 
            return (Perm8L)dst;
        }

        /// <summary>
        /// Constructs a permutation of length 16 from 16 ordered symbols
        /// </summary>
        [MethodImpl(Inline),Op]
        public static Perm16L assemble(
            Perm16L x0, Perm16L x1, Perm16L x2, Perm16L x3, 
            Perm16L x4, Perm16L x5, Perm16L x6, Perm16L x7, 
            Perm16L x8, Perm16L x9, Perm16L xA, Perm16L xB, 
            Perm16L xC, Perm16L xD, Perm16L xE, Perm16L xF) 
                => (Perm16L)assemble16(
                        (ulong)x0,(ulong)x1,(ulong)x2,(ulong)x3,
                        (ulong)x4,(ulong)x5,(ulong)x6,(ulong)x7,
                        (ulong)x8,(ulong)x9,(ulong)xA,(ulong)xB,
                        (ulong)xC,(ulong)xD,(ulong)xE,(ulong)xF
                        );

        /// <summary>
        /// Defines the canonical literal representation of the reversal of the identity permutation on 4 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline), Op]
        public static Perm4L reversed(N4 n)
            => Perm4L.DCBA;

        /// <summary>
        /// Defines the canonical literal representation of the reversal of the identity permutation on 8 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline), Op]
        public static Perm8L reversed(N8 n)
            => assemble(
                Perm8L.H, Perm8L.G, Perm8L.F, Perm8L.E,
                Perm8L.D, Perm8L.C, Perm8L.B, Perm8L.A);

        /// <summary>
        /// Returns the canonical literal representation of the reversal of the identity permutation on 16 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline), Op]
        public static Perm16L reversed(N16 n)
            => assemble(
                Perm16L.XF,Perm16L.XE,Perm16L.XD,Perm16L.XC,
                Perm16L.XB,Perm16L.XA,Perm16L.X9,Perm16L.X8,
                Perm16L.X7,Perm16L.X6,Perm16L.X5,Perm16L.X4,
                Perm16L.X3,Perm16L.X2,Perm16L.X1,Perm16L.X0);

        /// <summary>
        /// Defines the identity permutation on 4 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline), Op]
        public static Perm4L identity(N4 n)
            => Perm4L.ABCD;

        /// <summary>
        /// Defines the identity permutation on 8 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline), Op]
        public static Perm8L identity(N8 n)
            => assemble(
                Perm8L.A, Perm8L.B, Perm8L.C, Perm8L.D,
                Perm8L.E, Perm8L.F, Perm8L.G, Perm8L.H);

        /// <summary>
        /// Defines the identity permutation on 16 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline), Op]
        public static Perm16L identity(N16 n)
            => assemble(
                Perm16L.X0, Perm16L.X1, Perm16L.X2, Perm16L.X3,
                Perm16L.X4, Perm16L.X5, Perm16L.X6, Perm16L.X7,
                Perm16L.X8, Perm16L.X9, Perm16L.XA, Perm16L.XB,
                Perm16L.XC, Perm16L.XD, Perm16L.XE, Perm16L.XF);
    }
}