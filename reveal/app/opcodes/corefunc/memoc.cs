//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;    
    using static zfunc;

    /// <summary>
    /// Opcodes for memory-related operations
    /// </summary>
    [OpCodeProvider]
    public static class memory
    {


        static N64 n64 => default;


        public static int blockalign_64x8u_var(int cellcount)
            => DataBlocks.minblocks<byte>(n64,cellcount);

        public static int blockalign_64x8u_16()
            => DataBlocks.minblocks<byte>(n64,16);

        public static int blockalign_64x8u_17()
            => DataBlocks.minblocks<byte>(n64,17);

        public static ReadOnlySpan<char> Chars
            => new char[]{'0','1','2','3','4','5'};

        public static ReadOnlySpan<byte> Bytes
            => new byte[]{20,30,40,50,60,70,80,90};
            

        public const string Str = "0123456789ABCDEF";

        public static string ContStr
            => Str;

        public static ReadOnlySpan<char> CharSpan
            => Str;
        
        public static char digit_1()
            => skip(CharSpan, 5);

        public static char digit_2()
            => Str[5];

        public static char digit(int i)
            => (char)skip(Bytes, i);

        public static char bdigit(bit b)
            => b.ToChar();

    }


}