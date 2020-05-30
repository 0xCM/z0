//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Control;
    using static Seed;
    using static Typed;

    using API = ResourceTools;

    readonly struct AsciDataStrings
    {
        string S000
            => "00000000000000000000000000000000 !\"#$%&0()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[0]^_`abcdefghijklmnopqrstuvwxyz{|}~0";

        public ReadOnlySpan<char> C000
            => S000;

        string S001
            => "0123456789ABCDEF";

        public ReadOnlySpan<char> C001
            => S001;

        const int TextResCount = 2;

        static ReadOnlySpan<byte> B000
            => new byte[256]{
            0,0,    1,0,    2,0,    3,0,    4,0,    5,0,    6,0,    7,0,    
            8,0,    9,0,    10,0,    11,0,    12,0,    13,0,    14,0,    15,0,    
            16,0,    17,0,    18,0,    19,0,    20,0,    21,0,    22,0,    23,0,    
            24,0,    25,0,    26,0,    27,0,    28,0,    29,0,    30,0,    31,0,    
            32,0,    33,0,    34,0,    35,0,    36,0,    37,0,    38,0,    39,0,    
            40,0,    41,0,    42,0,    43,0,    44,0,    45,0,    46,0,    47,0,    
            48,0,    49,0,    50,0,    51,0,    52,0,    53,0,    54,0,    55,0,    
            56,0,    57,0,    58,0,    59,0,    60,0,    61,0,    62,0,    63,0,    
            64,0,    65,0,    66,0,    67,0,    68,0,    69,0,    70,0,    71,0,    
            72,0,    73,0,    74,0,    75,0,    76,0,    77,0,    78,0,    79,0,    
            80,0,    81,0,    82,0,    83,0,    84,0,    85,0,    86,0,    87,0,    
            88,0,    89,0,    90,0,    91,0,    92,0,    93,0,    94,0,    95,0,    
            96,0,    97,0,    98,0,    99,0,    100,0,    101,0,    102,0,    103,0,    
            104,0,    105,0,    106,0,    107,0,    108,0,    109,0,    110,0,    111,0,    
            112,0,    113,0,    114,0,    115,0,    116,0,    117,0,    118,0,    119,0,    
            120,0,    121,0,    122,0,    123,0,    124,0,    125,0,    126,0,    127,0,    
        };

        static ReadOnlySpan<byte> B001 
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

        const int ByteResCount = 2;

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Bytes(int index)
            => API.resource<byte>(skip(ByteResources,index), skip(ByteResourcLength,index));

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Text(int index)
            => API.resource<char>(skip(TextResources,index),skip(TextResourcLength,index));

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Bytes(N0 index)
            => B000;

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Bytes(N1 index)
            => B001;

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Text(N0 index)
            => C000;

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Text(N1 index)
            => C001;

        ReadOnlySpan<int> ByteResourcLength
        {
            [MethodImpl(Inline)]
            get => new int[2]{B000.Length, B001.Length};
        }

        ReadOnlySpan<int> TextResourcLength
        {
            [MethodImpl(Inline)]
            get => new int[2]{C000.Length, C001.Length};
        }

        ReadOnlySpan<ulong> ByteResources
        {
            [MethodImpl(Inline)]
            get => new ulong[2]{API.location(head(B000)), API.location(head(B001))};
        }

        ReadOnlySpan<ulong> TextResources
        {
            [MethodImpl(Inline)]
            get => new ulong[2]{API.location(head(C000)), API.location(head(C001))};
        }

        ReadOnlySpan<ResIdentity<byte>> ByteResInfo
            => new ResIdentity<byte>[ByteResCount]{
                ResIdentity.Define<byte>(
                    name: nameof(B000), 
                    location: API.location(head(B000)),
                    length: B000.Length),
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