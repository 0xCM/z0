//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace alg.asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0;

    using static Z0.memory;
    using static Z0.Part;

    [ApiHost]
    public readonly struct algorithms
    {

        [MethodImpl(Inline)]
        public static section<T> section<T>(T min, T max)
            => new section<T>(min,max);

        /// <summary>
        /// Parses an expression of the form {identifier}[max:min]
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ref section<T> parse<T>(asci src, out section<T> dst)
        {
            dst = default;
            var index = 0;
            var count = src.Length;
            var codes = src.Codes;
            var foundIdentifierStart = bit.Off;
            var foundIdentifier = bit.Off;
            var foundLeftBracket = bit.Off;
            var foundRightBracket = bit.Off;
            var foundRangeSeparator = bit.Off;
            var parsingIdentifier = bit.Off;

            var identifier = asci16.Null;
            while(index-- < count)
            {
                ref readonly var current = ref skip(codes,index);
                if(AsciTest.whitespace(current))
                    continue;

                if(!foundIdentifierStart && AsciTest.letter(current))
                {
                    foundIdentifierStart = true;
                    parsingIdentifier = true;
                }

                if(parsingIdentifier)
                {

                }

            }


            return ref dst;
        }
    }

    /// <summary>
    /// Represents a closed interval of bits from an operand and corresponds to the notation [max:min]
    /// </summary>
    public readonly struct section<T>
    {
        public T Min {get;}

        public T Max {get;}

        [MethodImpl(Inline)]
        public section(T min, T max)
        {
            Min = min;
            Max = max;
        }


        [MethodImpl(Inline)]
        public static implicit operator section<T>((T min, T max) src)
            => new section<T>(src.min, src.max);

    }

    public readonly struct functions
    {
        public static T SaturateSignedWordToSignedByte<T>()
        {
            return default;
        }
    }

/*

### VPACKSSWB instruction (VEX.128 encoded version)

DEST[7:0]←SaturateSignedWordToSignedByte (SRC1[15:0]);
DEST[15:8]←SaturateSignedWordToSignedByte (SRC1[31:16]);
DEST[23:16]←SaturateSignedWordToSignedByte (SRC1[47:32]);
DEST[31:24]←SaturateSignedWordToSignedByte (SRC1[63:48]);
DEST[39:32]←SaturateSignedWordToSignedByte (SRC1[79:64]);
DEST[47:40]←SaturateSignedWordToSignedByte (SRC1[95:80]);
DEST[55:48]←SaturateSignedWordToSignedByte (SRC1[111:96]);
DEST[63:56]←SaturateSignedWordToSignedByte (SRC1[127:112]);
DEST[71:64]←SaturateSignedWordToSignedByte (SRC2[15:0]);
DEST[79:72]←SaturateSignedWordToSignedByte (SRC2[31:16]);
DEST[87:80]←SaturateSignedWordToSignedByte (SRC2[47:32]);
DEST[95:88]←SaturateSignedWordToSignedByte (SRC2[63:48]);
DEST[103:96]←SaturateSignedWordToSignedByte (SRC2[79:64]);
DEST[111:104]←SaturateSignedWordToSignedByte (SRC2[95:80]);
DEST[119:112]←SaturateSignedWordToSignedByte (SRC2[111:96]);
DEST[127:120]←SaturateSignedWordToSignedByte (SRC2[127:112]);
DEST[MAXVL-1:128] ← 0;

*/

}