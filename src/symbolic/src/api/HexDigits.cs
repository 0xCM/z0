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

    using HCL = HexDigitCodeLo;
    using HCU = HexDigitCodeUp;
    using HSU = HexDigitSymbolUp;
    using HSL = HexDigitSymbolLo;

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
        public static int render(ReadOnlySpan<HexDigitCodeUp> src, Span<char> dst)
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
        public static int codes(ReadOnlySpan<byte> src, Span<HexDigitCodeUp> dst)
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
        public static HexDigitCodeUp code(UpperCased casing, int index)
            => (HexDigitCodeUp)skip(UpperCodes, index);

        [MethodImpl(Inline), Op]
        public static HexDigitCodeLo code(LowerCased casing, int index)
            => (HexDigitCodeLo)skip(LowerCodes, index);

        [MethodImpl(Inline), Op]
        public static HexDigitSymbolUp symbol(UpperCased casing, int index)
            => (HexDigitSymbolUp)code(casing, index);

        [MethodImpl(Inline), Op]
        public static HexDigitSymbolLo symbol(LowerCased casing, int index)
            => (HexDigitSymbolLo)code(casing, index);

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
        static HexDigitSymbolUp symbol_direct(UpperCased casing, int index)
            => skip(UpperSymbols, index);

        [MethodImpl(Inline), Op]
        static HexDigitSymbolLo symbol_direct(LowerCased casing, int index)
            => skip(LowerSymbols, index);

        /// <summary>
        /// Defines a 16-element sequence with terms that correspond to the uppercase hex symbolic literals
        /// </summary>
        static ReadOnlySpan<HexDigitSymbolUp> UpperSymbols 
        {
            [MethodImpl(Inline)]
            get => cast<HexDigitSymbolUp>(UpperSymbolBytes);
        }

        /// <summary>
        /// Defines a 16-element sequence with terms that correspond to the lowercase hex symbolic literals
        /// </summary>
        static ReadOnlySpan<HexDigitSymbolLo> LowerSymbols 
        {
            [MethodImpl(Inline)]
            get => cast<HexDigitSymbolLo>(LowerSymbolBytes);
        }

        /// <summary>
        /// Defines a 16-byte sequence with terms that correspond to the ASCI codes the hex digits {0..9,A..F}
        /// </summary>
        static ReadOnlySpan<byte> UpperCodes
            => new byte[]{
                (byte)HCU.x0, (byte)HCU.x1, (byte)HCU.x2, (byte)HCU.x3, 
                (byte)HCU.x4, (byte)HCU.x5, (byte)HCU.x6, (byte)HCU.x7,
                (byte)HCU.x8, (byte)HCU.x9, 
                (byte)HCU.A,  (byte)HCU.B, (byte)HCU.C, (byte)HCU.D, (byte)HCU.E, (byte)HCU.F,
                };

        /// <summary>
        /// Defines a 16-byte sequence with terms that correspond to the ASCI codes for hex digits {0..9,a..f}
        /// </summary>
        static ReadOnlySpan<byte> LowerCodes
            => new byte[]{
                (byte)HCL.x0, (byte)HCL.x1, (byte)HCL.x2, (byte)HCL.x3, 
                (byte)HCL.x4, (byte)HCL.x5, (byte)HCL.x6, (byte)HCL.x7,
                (byte)HCL.x8, (byte)HCL.x9, 
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
                (byte)HSU.x0, 0, (byte)HSU.x1, 0, (byte)HSU.x2, 0, (byte)HSU.x3, 0,
                (byte)HSU.x4, 0, (byte)HSU.x5, 0, (byte)HSU.x6, 0, (byte)HSU.x7, 0,
                (byte)HSU.x8, 0, (byte)HSU.x9, 0, 
                (byte)HSU.A,  0,  (byte)HSU.B, 0, 
                (byte)HSU.C,  0, (byte)HSU.D,  0, (byte)HSU.E,  0,  (byte)HSU.F, 0,
                };

        static ReadOnlySpan<byte> LowerSymbolBytes
            => new byte[]{
                (byte)HSL.x0, 0, (byte)HSL.x1, 0, (byte)HSL.x2, 0, (byte)HSL.x3, 0,
                (byte)HSL.x4, 0, (byte)HSL.x5, 0, (byte)HSL.x6, 0, (byte)HSL.x7, 0,
                (byte)HSL.x8, 0, (byte)HSL.x9, 0,                 
                (byte)HSL.a,  0,  (byte)HSL.b, 0, 
                (byte)HSL.c,  0, (byte)HSL.d,  0, (byte)HSL.e,  0,  (byte)HSL.f, 0,
                };

    }
}