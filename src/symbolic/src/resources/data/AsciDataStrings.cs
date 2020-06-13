//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Control;
    using static Konst;
    using static Typed;

    using API = SymbolicData;

    readonly struct AsciDataStrings
    {
        string S000
            => "00000000000000000000000000000000 !\"#$%&0()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[0]^_`abcdefghijklmnopqrstuvwxyz{|}~0";

        public ReadOnlySpan<char> C000
            => S000;

        static string LettersLoString
            => "abcdefghijklmnopqrstuvwxyz";

        static string LettersUpString
            => "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static ReadOnlySpan<char> LettersLo
            => LettersLoString;

        public static ReadOnlySpan<char> LettersUp
            => LettersUpString;


        string S001
            => "0123456789ABCDEF";

        public ReadOnlySpan<char> C001
            => S001;

        const int TextResCount = 2;

        const byte DDD = Pow2.T07;

        public ReadOnlySpan<byte> CharBytes
            => new byte[256]{
            0,0,     1,0,    2,0,     3,0,     4,0,     5,0,     6,0,     7,0,      // [2^0 - 1,    2^4 - 1]
            8,0,     9,0,    10,0,    11,0,    12,0,    13,0,    14,0,    15,0,     // [2^4,        2^5 - 1]
            16,0,    17,0,   18,0,    19,0,    20,0,    21,0,    22,0,    23,0,     // [2^5,        2^5 + 15]
            24,0,    25,0,   26,0,    27,0,    28,0,    29,0,    30,0,    31,0,     // [2^5 + 16,   2^6 - 1]
            32,0,    33,0,   34,0,    35,0,    36,0,    37,0,    38,0,    39,0,     // [2^6,        2^6 + 15]
            40,0,    41,0,   42,0,    43,0,    44,0,    45,0,    46,0,    47,0,     // 
            48,0,    49,0,   50,0,    51,0,    52,0,    53,0,    54,0,    55,0,     // 
            56,0,    57,0,   58,0,    59,0,    60,0,    61,0,    62,0,    63,0,     // [_,          2^7 - 1]
            64,0,    65,0,   66,0,    67,0,    68,0,    69,0,    70,0,    71,0,     // [2^7,        _]
            72,0,    73,0,   74,0,    75,0,    76,0,    77,0,    78,0,    79,0,     // 
            80,0,    81,0,   82,0,    83,0,    84,0,    85,0,    86,0,    87,0,     // 
            88,0,    89,0,   90,0,    91,0,    92,0,    93,0,    94,0,    95,0,     // 
            96,0,    97,0,   98,0,    99,0,    100,0,   101,0,   102,0,   103,0,    // 
            104,0,   105,0,  106,0,   107,0,   108,0,   109,0,   110,0,   111,0,    // 
            112,0,   113,0,  114,0,   115,0,   116,0,   117,0,   118,0,   119,0,    // 
            120,0,   121,0,  122,0,   123,0,   124,0,   125,0,   126,0,   127,0,    // [_,          2^8 - 1]
        };

        public ReadOnlySpan<byte> CharCodes
            => new byte[128]{
            0,   1,  2,   3,   4,   5,   6,   7,
            8,   9,  10,  11,  12,  13,  14,  15,
            16,  17, 18,  19,  20,  21,  22,  23,
            24,  25, 26,  27,  28,  29,  30,  31,
            32,  33, 34,  35,  36,  37,  38,  39,
            40,  41, 42,  43,  44,  45,  46,  47,
            48,  49, 50,  51,  52,  53,  54,  55,
            56,  57, 58,  59,  60,  61,  62,  63,
            64,  65, 66,  67,  68,  69,  70,  71,
            72,  73, 74,  75,  76,  77,  78,  79,
            80,  81, 82,  83,  84,  85,  86,  87,
            88,  89, 90,  91,  92,  93,  94,  95,
            96,  97, 98,  99,  100, 101, 102, 103,
            104, 105,106, 107, 108, 109, 110, 111,
            112, 113,114, 115, 116, 117, 118, 119,
            120, 121,122, 123, 124, 125, 126, 127,
        };

        static ReadOnlySpan<byte> B001 
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

        const int ByteResCount = 2;

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> charbytes(N0 index)
            => CharBytes;        

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> bytes(byte offset, byte count)
            => CharBytes.Slice(offset, count);        

        /// <summary>
        /// Returns the acsci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of codes to select</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<AsciCharCode> codes(sbyte offset, sbyte count)
            => Control.cast<AsciCharCode>(CharCodes.Slice(offset,count));

        /// <summary>
        /// Returns the acsci characters corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<char> chars(sbyte offset, sbyte count)
            => Spans.cast<char>(CharBytes).Slice(offset, count);
            
            //=> Control.cast<char>(CharBytes).Slice(offset, count);

        /// <summary>
        /// Returns the acsci symbols corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<AsciChar> symbols(sbyte offset, sbyte count)
            => Control.cast<char,AsciChar>(chars(offset,count));

        /// <summary>
        /// Returns the uint16 asci scalar values corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<ushort> scalars(sbyte offset, sbyte count)
            => Control.cast<char,ushort>(chars(offset,count));

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Text(N0 index)
            => C000;

        ReadOnlySpan<int> ByteResourcLength
        {
            [MethodImpl(Inline)]
            get => new int[2]{CharBytes.Length, B001.Length};
        }

        ReadOnlySpan<int> TextResourcLength
        {
            [MethodImpl(Inline)]
            get => new int[2]{C000.Length, C001.Length};
        }

        ReadOnlySpan<ulong> ByteResources
        {
            [MethodImpl(Inline)]
            get => new ulong[2]{API.location(head(CharBytes)), API.location(head(B001))};
        }

        ReadOnlySpan<ulong> TextResources
        {
            [MethodImpl(Inline)]
            get => new ulong[2]{API.location(head(C000)), API.location(head(C001))};
        }

        ReadOnlySpan<ResIdentity<byte>> ByteResInfo
            => new ResIdentity<byte>[ByteResCount]{
                ResIdentity.Define<byte>(
                    name: nameof(CharBytes), 
                    location: API.location(head(CharBytes)),
                    length: CharBytes.Length),
                ResIdentity.Define<byte>(
                    name: nameof(B001), 
                    location: API.location(head(B001)),
                    length: B001.Length),
                };

        ReadOnlySpan<ResIdentity<char>> TextResInfo
            => new ResIdentity<char>[TextResCount]{
                ResIdentity.Define<char>(
                    name: nameof(S000), 
                    location: API.location(head(C000)),
                    length: S000.Length),
                ResIdentity.Define<char>(
                    name: nameof(S001), 
                    location: API.location(head(C001)),
                    length: S001.Length),
                };            
    }
}