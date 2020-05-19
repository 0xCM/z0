//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    using HC = HexDigitCode;
    using HS = HexSymbol;
    using HCL = HexCodeLower;
    using HCU = HexCodeUpper;
    using HSU = HexSymbolUpper;
    using HSL = HexSymbolLower;

    [ApiHost]
    public class HexDigits : IApiHost<HexDigits>
    {        
        [MethodImpl(Inline), Op]
        public static int render(ReadOnlySpan<byte> src, Span<char> dst)
        {
            var j = 0;
            for(int i = 0; i<src.Length; i++, j+=3)
            {
                ref readonly var code = ref skip(src, i);
                
                seek(dst, j) = HexDigits.letter(UpperCased.Case, code >> 4);
                seek(dst, j + 1) = HexDigits.letter(UpperCased.Case, 0xF & code);
                seek(dst, j + 2) = Chars.Space;
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static int hexlen(ReadOnlySpan<byte> src)
            => src.Length*3;

        [Op]
        public static string render(ReadOnlySpan<byte> src)
        {
            Span<char> digits = stackalloc char[hexlen(src)];
            render(src,digits);
            return digits.ToString();
        }

        [MethodImpl(Inline), Op]
        public static int render(ReadOnlySpan<HexCodeUpper> src, Span<char> dst)
        {
            var j = 0;
            for(int i = 0; i<src.Length; i+=2, j+=3)
            {
                seek(dst, j) = (char)skip(src, i);
                seek(dst, j + 1) = (char)skip(src, i + 1);
                seek(dst, j + 2) = Chars.Space;
            }

            return j;        
        }

        [MethodImpl(Inline), Op]
        public static int codes(ReadOnlySpan<byte> src, Span<HexCodeUpper> dst)
        {
            var j = 0;
            for(int i = 0; i<src.Length; i++, j+=2)
            {
                ref readonly var data = ref skip(src, i);                
                seek(dst, j) = code(UpperCased.Case, data >> 4);
                seek(dst, j + 1) = code(UpperCased.Case, 0xF & data);
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static HexCodeUpper code(UpperCased casing, int index)
            => (HexCodeUpper)skip(UpperCodes, index);

        [MethodImpl(Inline), Op]
        public static HexCodeLower code(LowerCased casing, int index)
            => (HexCodeLower)skip(LowerCodes, index);

        [MethodImpl(Inline), Op]
        public static HexSymbolUpper symbol(UpperCased casing, int index)
            => (HexSymbolUpper)code(casing, index);

        [MethodImpl(Inline), Op]
        public static HexSymbolLower symbol(LowerCased casing, int index)
            => (HexSymbolLower)code(casing, index);

        [MethodImpl(Inline), Op]
        public static char letter(UpperCased casing, int index)
            => (char)symbol(casing, index);

        [MethodImpl(Inline), Op]
        public static char letter(LowerCased casing, int index)
            => (char)symbol(casing, index);
        
        [MethodImpl(Inline), Op]
        static char hexchar_direct(UpperCased casing, int index)
            => UpperCharArray[index];

        [MethodImpl(Inline), Op]
        static char hexchar_direct(LowerCased casing, int index)
            => LowerCharArray[index];

        [MethodImpl(Inline), Op]
        static HexSymbolUpper symbol_direct(UpperCased casing, int index)
            => skip(UpperSymbols, index);

        [MethodImpl(Inline), Op]
        static HexSymbolLower symbol_direct(LowerCased casing, int index)
            => skip(LowerSymbols, index);

        /// <summary>
        /// Defines a 16-element sequence with terms that correspond to the uppercase hex symbolic literals
        /// </summary>
        static ReadOnlySpan<HexSymbolUpper> UpperSymbols 
        {
            [MethodImpl(Inline)]
            get => cast<HexSymbolUpper>(UpperSymbolBytes);
        }

        /// <summary>
        /// Defines a 16-element sequence with terms that correspond to the lowercase hex symbolic literals
        /// </summary>
        static ReadOnlySpan<HexSymbolLower> LowerSymbols 
        {
            [MethodImpl(Inline)]
            get => cast<HexSymbolLower>(LowerSymbolBytes);
        }

        /// <summary>
        /// Defines a 16-byte sequence with terms that correspond to the ASCI codes the hex digits {0..9,A..F}
        /// </summary>
        static ReadOnlySpan<byte> UpperCodes
            => new byte[]{
                (byte)HC.x0, (byte)HC.x1, (byte)HC.x2, (byte)HC.x3, 
                (byte)HC.x4, (byte)HC.x5, (byte)HC.x6, (byte)HC.x7,
                (byte)HC.x8, (byte)HC.x9, 
                (byte)HCU.A,  (byte)HCU.B, (byte)HCU.C, (byte)HCU.D, (byte)HCU.E, (byte)HCU.F,
                };

        /// <summary>
        /// Defines a 16-byte sequence with terms that correspond to the ASCI codes for hex digits {0..9,a..f}
        /// </summary>
        static ReadOnlySpan<byte> LowerCodes
            => new byte[]{
                (byte)HC.x0, (byte)HC.x1, (byte)HC.x2, (byte)HC.x3, 
                (byte)HC.x4, (byte)HC.x5, (byte)HC.x6, (byte)HC.x7,
                (byte)HC.x8, (byte)HC.x9, 
                (byte)HCL.a,  (byte)HCL.b, (byte)HCL.c, (byte)HCL.d, (byte)HCL.e, (byte)HCL.f,
                };

        /// <summary>
        /// Defines a 16-character sequence with terms that correspond to the ASCI characters for hex digits {0..9,A..F}
        /// </summary>
        static ReadOnlySpan<char> UpperChars
        {
            [MethodImpl(Inline)]
            get => UpperCharArray;
        }

        /// <summary>
        /// Defines a 16-character sequence with terms that correspond to the ASCI characters for hex digits {0..9,a..f}
        /// </summary>
        static ReadOnlySpan<char> LowerChars
        {
            [MethodImpl(Inline)]
            get => LowerCharArray;
        }

        static char[] UpperCharArray 
            => new char[16]{'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};

        static char[] LowerCharArray 
            => new char[16]{'0','1','2','3','4','5','6','7','8','9','a','b','d','d','e','f'};
        
        static ReadOnlySpan<byte> UpperSymbolBytes
            => new byte[]{
                (byte)HS.x0, 0, (byte)HS.x1, 0, (byte)HS.x2, 0, (byte)HS.x3, 0,
                (byte)HS.x4, 0, (byte)HS.x5, 0, (byte)HS.x6, 0, (byte)HS.x7, 0,
                (byte)HS.x8, 0, (byte)HS.x9, 0, 
                (byte)HSU.A,  0,  (byte)HSU.B, 0, 
                (byte)HSU.C,  0, (byte)HSU.D,  0, (byte)HSU.E,  0,  (byte)HSU.F, 0,
                };

        static ReadOnlySpan<byte> LowerSymbolBytes
            => new byte[]{
                (byte)HS.x0, 0, (byte)HS.x1, 0, (byte)HS.x2, 0, (byte)HS.x3, 0,
                (byte)HS.x4, 0, (byte)HS.x5, 0, (byte)HS.x6, 0, (byte)HS.x7, 0,
                (byte)HS.x8, 0, (byte)HS.x9, 0,                 
                (byte)HSL.a,  0,  (byte)HSL.b, 0, 
                (byte)HSL.c,  0, (byte)HSL.d,  0, (byte)HSL.e,  0,  (byte)HSL.f, 0,
                };

    }
}