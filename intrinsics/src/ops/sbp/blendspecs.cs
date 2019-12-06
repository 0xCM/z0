//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
        
    using static zfunc;
    
    /// <summary>
    /// Defines control mask values for constucting a 128-bit target by blending 8 16-bit segments from two source vectors
    /// </summary>
    [Flags]
    public enum Blend8x16 : byte
    {    
        LLLLLLLL = 0b00000000,

        RRRRRRRR = 0b11111111,

        LRLRLRLR = 0b10101010,

        RLRLRLRL = 0b01010101,

        LLRRLLRR = 0b11001100,

        RRLLRRLL = 0b00110011,

        LLLLRRRR = 0b11110000,

        RRRRLLLL = 0b00001111
    }

    [Flags]
    public enum Blend16x16 : ushort
    {    
        LLLLLLLLLLLLLLLL = 0b0000000000000000,

        RRRRRRRRRRRRRRRR = 0b1111111111111111,

        RLRLRLRLRLRLRLRL = 0b0101010101010101,

        LRLRLRLRLRLRLRLR = 0b1010101010101010,

        LLRRLLRRLLRRLLRR = 0b1100110011001100,

        RRLLRRLLRRLLRRLL = 0b0011001100110011,

        LLLLRRRRLLLLRRRR = 0b1111000011110000,

        RRRRLLLLRRRRLLLL = 0b0000111100001111,

    }

    /// <summary>
    /// Defines control mask values for constucting a 128-bit target by blending 4 32-bit segments from two 128-bit sources
    /// </summary>
    [Flags]
    public enum Blend4x32 : byte
    {

        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [0 1 2 3]
        /// </summary>
        LLLL = 0b0000,

        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [0 1 2 7]
        /// </summary>
        LLLR = 0b1000,

        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [4 1 2 3]
        /// </summary>
        RLLL = 0b0001,

        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [0 1 6 3]
        /// </summary>
        LLRL = 0b0100,

        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [0 1 6 7]
        /// </summary>
        LLRR = 0b1100,

        LRLL = 0b0010,

        RLRL = 0b0101,

        LRRL = 0b0110,

        RRRL = 0b0111,

        RLLR = 0b1001,

        LRLR = 0b1010,

        RLRR = 0b1011,

        RRLL = 0b0011,

        RRLR = 0b1101,
        
        LRRR = 0b1110,
        
        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [4 5 6 7]
        /// </summary>
        RRRR = 0b1111
    }

    /// <summary>
    /// Defines control mask values for constucting a 256-bit target by blending 8 32-bit segments from two source vectors
    /// </summary>
    [Flags]
    public enum Blend8x32 : byte
    {
        LLLLLLLL = 0b00000000,

        RRRRRRRR = 0b11111111,

        LRLRLRLR = 0b10101010,

        RLRLRLRL = 0b01010101,

        LLRRLLRR = 0b11001100,

        RRLLRRLL = 0b00110011,

        LLLLRRRR = 0b11110000,

        RRRRLLLL = 0b00001111
    }

    /// <summary>
    /// Defines control mask values for constucting a 128-bit target by blending 2 64-bit segments from two source vectors
    /// </summary>
    [Flags]
    public enum Blend2x64 : byte
    {

         LL = 0b00,

         RR = 0b11,

         LR = 0b10,

         RL = 0b01,
    }

    /// <summary>
    /// Defines control mask values for constucting a 256-bit target by blending 4 64-bit segments from two source vectors
    /// </summary>
    [Flags]
    public enum Blend4x64 : byte
    {
         LLLL = 0b0000,

         RRRR = 0b1111,

         LRLR = 0b1010,

         RLRL = 0b0101,

         LLRR = 0b1100,

         RRLL = 0b0011,       
    }

    public static class BlendSpecX
    { 
        [MethodImpl(Inline)]
        static char symbol(bit b)
            => b ? 'R' : 'L';

        static string format<T>(T spec, int len)
            where T : unmanaged, Enum
        {
            Span<char> dst = stackalloc char[len];
            
            var bs = spec.ToBitString();
            for(var i=0; i<dst.Length; i++)
                dst[i] = symbol(bs[i]);

            return new string(dst);
        }

        [MethodImpl(Inline)]
        public static string Format(this Blend8x16 spec)                
            => format(spec,8);

        [MethodImpl(Inline)]
        public static string Format(this Blend4x32 spec)                
            => format(spec,4);

        [MethodImpl(Inline)]
        public static string Format(this Blend8x32 spec)                
            => format(spec,8);

        [MethodImpl(Inline)]
        public static string Format(this Blend2x64 spec)                
            => format(spec,2);

        public static string Format(this Blend4x64 spec)
            => format(spec,4);

    }
}