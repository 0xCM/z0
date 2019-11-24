//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    /// <summary>
    /// Defines bitmasking and selection functions
    /// </summary>
    public static partial class BitMask
    {        
        /// <summary>
        /// Defines an 8 bit pattern where the lsb is enabled
        /// </summary>
        public const byte Lsb8x1 = 1 << 0;

        /// <summary>
        /// Defines a 8 bit pattern of the form [0001 0001] where the lsb  of each 4-bit segment is enabled
        /// </summary>
        public const byte Lsb8x2  = 1 << 0  | 1 << 4;

        /// <summary>
        /// Defines an 8-bit pattern of the form [01 01 01 01] where the lsb of each 2-bit segment is enabled
        /// </summary>
        public const byte Lsb8x4 = 1 | 1 << 2 | 1 << 4 | 1 << 6;

        /// <summary>
        /// Defines a 16-bit pattern where the lsb is enabled
        /// </summary>
        public const ushort Lsb16x1 = 1;

        /// <summary>
        /// Defines a 16 bit pattern of the form [0b00000001, 0b00000001]
        /// </summary>
        public const ushort Lsb16x2 = (ushort)Lsb8x1 | (ushort) Lsb8x1 << 8;

        /// <summary>
        /// Defines a 16 bit pattern of the form [0001 ... 0001] where the lsb of each 4-bit segment is enabled
        /// </summary>
        public const ushort Lsb16x4 = (ushort)Lsb8x2  | (ushort)Lsb8x2 << 8;

        /// <summary>
        /// Defines a 16-bit pattern of the form [01 01 ... 01 01] where the lsb of each 2-bit segment is enabled
        /// </summary>
        public const ushort Lsb16x8 = (ushort)Lsb8x4 | (ushort)Lsb8x4 << 8;

        /// <summary>
        /// Defines a 32-bit pattern where the lsb is enabled
        /// </summary>
        public const uint Lsb32x1 = 1;

        /// <summary>
        /// Defines a 32-bit pattern of the form [00000000_00000001 00000000_00000001] where the lsb of each 16-bit segment is enabled
        /// </summary>
        public const uint Lsb32x2 = (uint)Lsb16x1 | (uint)Lsb16x1 << 16;

        /// <summary>
        /// Defines a 32 bit pattern of the form [0b00000001, ..., 0b00000001] where the least bit of each 8-bit segment is enaabled
        /// </summary>
        public const uint Lsb32x4 = (uint) Lsb16x2 | (uint) Lsb16x2 << 16;

        /// <summary>
        /// Defines a 32 bit pattern of the form [0001 ... 0001] where the lsb of each 4-bit segment is enabled
        /// </summary>
        public const uint Lsb32x8 = (uint)Lsb16x4 | (uint)Lsb16x4 << 16;

        /// <summary>
        /// Defines a 32-bit pattern of the form [01 01 ... 01 01] where the lsb of each 2-bit segment is enabled
        /// </summary>
        public const uint Lsb32x16 = (uint)Lsb16x8 | (uint)Lsb16x8 << 16;

        /// <summary>
        /// Defines a 64-bit pattern where the least significant bit is enabled
        /// </summary>
        public const ulong Lsb64x1 = 1;

        /// <summary>
        /// Defines a 64-bit pattern where the lsb of each 32-bit segment is enabled
        /// </summary>
        public const ulong Lsb64x2 = (ulong)Lsb32x1 | (ulong) Lsb32x1 << 32;

        /// <summary>
        /// Defines a 64-bit pattern of the form [00000000_00000001 ... 00000000_00000001] where the lsb of each 16-bit segment is enabled
        /// </summary>
        public const ulong Lsb64x4 = (ulong)Lsb32x2 | (ulong)Lsb32x2 << 32;

        /// <summary>
        /// Defines a 64 bit pattern of the form [0b00000001, ..., 0b00000001]
        /// </summary>
        public const ulong Lsb64x8 = (ulong)Lsb32x4 | (ulong)Lsb32x4 << 32;
                         
        /// <summary>
        /// Defines a 64 bit pattern of the form [0001 ... 0001] where the lsb of each 4-bit segment is enabled
        /// </summary>
        public const ulong Lsb64x16 = (ulong)Lsb32x8 | (ulong)Lsb32x8 << 32;

        /// <summary>
        /// Defines a 64-bit pattern of the form [01 01 ... 01 01] where the lsb of each 2-bit segment is enabled
        /// </summary>
        public const ulong Lsb64x32 = (ulong)Lsb32x16 | (ulong)Lsb32x16 << 32;
            
        /// <summary>
        /// Defines an 8 bit pattern where the msb is enabled
        /// </summary>
        public const byte Msb8x1 = 128 << 0; 

        /// <summary>
        /// Defines a 16 bit pattern of the form [10000000 10000000]
        /// </summary>
        public const ushort Msb16x2  = (ushort)Msb8x1 | (ushort)Msb8x1 << 8 ; 

        /// <summary>
        /// Defines a 32 bit pattern of the form [10000000 ... 10000000]
        /// </summary>
        public const uint Msb32x4  = (uint)Msb16x2 | (uint)Msb16x2 << 16;

        /// <summary>
        /// Defines a 64 bit pattern of the form [10000000 ... 10000000]
        /// </summary>
        public const ulong Msb64x8  = (ulong) Msb32x4 | (ulong)Msb32x4 << 32;

        /// <summary>
        /// Defines a 16-bit pattern where the msb is enabled
        /// </summary>
        public const ushort Msb16x1 = 1 << 15;

        /// <summary>
        /// Defines a 32-bit pattern where the msb is enabled
        /// </summary>
        public const uint Msb32x1 = 1u << 31;

        /// <summary>
        /// Defines a 64-bit pattern where the most significant bit is enabled
        /// </summary>
        public const ulong Msb64x1 = 1ul << 63;

        /// <summary>
        /// Defines an 8-bit pattern of the form [10 10 10 10] where the msb of each 2-bit segment is enabled
        /// </summary>
        public const byte Msb8x4 = Lsb8x4 << 1;

        /// <summary>
        /// Defines a 16-bit pattern of the form [10 10 ... 10 10] where the msb of each 2-bit segment is enabled
        /// </summary>
        public const ushort Msb16x8 = Lsb16x8 << 1;

        /// <summary>
        /// Defines an 32-bit pattern of the form [10 10 ... 10 10] where the msb of each 2-bit segment is enabled
        /// </summary>
        public const uint Msb32x2 = Lsb32x16 << 1;

        /// <summary>
        /// Defines an 64-bit pattern of the form [10 10 ... 10 10] where the msb of each 2-bit segment is enabled
        /// </summary>
        public const ulong Msb64x2 = Lsb64x32 << 1;


        [MethodImpl(Inline)]
        public static bit testg<T>(T a, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return test_u(a,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return test_i(a,pos);
            else 
                return test_f(a,pos);
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref sbyte enable(ref sbyte src, int pos)
        {              
            src |= (sbyte)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref byte enable(ref byte src, int pos)
        {
            src |= (byte)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref short enable(ref short src, int pos)
        {
            src |= (short)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref ushort enable(ref ushort src, int pos)
        {
            src |= (ushort)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref int enable(ref int src, int pos)
        {
            src |= (1 << pos);
            return ref src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref uint enable(ref uint src, int pos)
        {
            src |= (1u << pos);
            return ref src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref long enable(ref long src, int pos)
        {
            src |= (1L << pos);
            return ref src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref ulong enable(ref ulong src, int pos)
        {
            src |= (1ul << pos);
            return ref src;
        }          

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref float enable(ref float src, int pos)
        {
            var srcBits = BitConverter.SingleToInt32Bits(src);
            srcBits |= 1 << pos;
            src = BitConverter.Int32BitsToSingle(srcBits);            
            return ref src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ref double enable(ref double src, int pos)
        {               
            var srcBits = BitConverter.DoubleToInt64Bits(src);
            srcBits |= 1L << pos;
            src = BitConverter.Int64BitsToDouble(srcBits);                           
            return ref src;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static sbyte enable(sbyte src, int pos)
        =>  src |= (sbyte)(1 << pos);
            
        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static byte enable(byte src, int pos)
        =>  src |= (byte)(1 << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static short enable(short src, int pos)
        =>  src |= (short)(1 << pos);
            
        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ushort enable(ushort src, int pos)
        =>  src |= (ushort)(1 << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static int enable(int src, int pos)
            =>  src |= (1 << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static uint enable(uint src, int pos)
            =>  src |= (1u << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static long enable(long src, int pos)
            =>  src |= (1L << pos);

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static ulong enable(ulong src, int pos)
            =>  src |= (1ul << pos);

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static sbyte disable(sbyte src, int pos)        
            => (sbyte)(src & (byte)~((sbyte)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static byte disable(byte src, int pos)        
            => (byte)(src & (byte)~((byte)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static short disable(short src, int pos)        
            => (short)(src & (short)~((short)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ushort disable(ushort src, int pos)        
            => (ushort)(src & (ushort)~((ushort)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static int disable(int src, int pos)        
            => src & ~((1 << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static uint disable(uint src, int pos)        
            => src & ~((1u << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static long disable(long src, int pos)        
            => src & ~((1L << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ulong disable(ulong src, int pos)        
            => src & ~((1ul << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref byte disable(ref byte src, int pos)
        {
            src &= (byte)~((byte)(1 << pos));
            return ref src;
        }

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref sbyte disable(ref sbyte src, int pos)
        {
            var m = (sbyte)(1 << pos);
            src &= (sbyte)~m;
            return ref src;
        }

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref short disable(ref short src, int pos)
        {
            var m = (short)(1 << pos);
            src &= (short)~m;
            return ref src;
        }

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref ushort disable(ref ushort src, int pos)
        {
            var m = (ushort)(1 << pos);
            src &= (ushort)~m;
            return ref src;
        }

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref int disable(ref int src, int pos)
        {
            var m = 1 << pos;
            src &= ~m;
            return ref src;
        }

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref uint disable(ref uint src, int pos)
        {
            src &= ~(1u << pos);
            return ref src;
        }

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref long disable(ref long src, int pos)
        {
            var m = 1L << pos;
            src &= ~m;
            return ref src;
        }

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref ulong disable(ref ulong src, int pos)
        {
            var m = 1ul << pos;
            src &= ~m;
            return ref src;
        }

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref float disable(ref float src, int pos)
        {
            ref var bits = ref Unsafe.As<float,int>(ref src);
            var m = 1 << pos;
            bits &= ~m;
            return ref src;
        } 

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static ref double disable(ref double src, int pos)
        {
            ref var bits = ref Unsafe.As<double,long>(ref src);
            var m = 1L << pos;
            bits &= ~m;
            return ref src;
        } 

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(sbyte src, int pos)
            => (src & (1 << pos)) != 0;
            
        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(byte src, int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(short src, int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(ushort src, int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(int src, int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(uint src, int pos)
            => (src & (1u << pos)) != 0u;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(long src, int pos)
            => (src & (1L << pos)) != 0L;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(ulong src, int pos)
            => (src & (1ul << pos)) != 0ul;


        [MethodImpl(Inline)]
        static bit test_u<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return test(uint8(src), pos);
            else if(typeof(T) == typeof(ushort))
                return test(As.uint16(src), pos);
            else if(typeof(T) == typeof(uint))
                return test(As.uint32(src), pos);
            else 
                return test(As.uint64(src), pos);            
        }

        [MethodImpl(Inline)]
        static bit test_i<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return test(As.int8(src), pos);
            else if(typeof(T) == typeof(short))
                return test(As.int16(src), pos);
            else if(typeof(T) == typeof(int))
                return test(As.int32(src), pos);
            else 
                return test(As.int64(src), pos);
        }

        [MethodImpl(Inline)]
        static bit test_f<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return test(As.float32(src), pos);
            else if(typeof(T) == typeof(short))
                return test(As.float64(src), pos);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(float src, int pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(double src, int pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(sbyte src, byte pos)
            => (src & (1 << pos)) != 0;
            
        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(byte src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(short src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(ushort src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(int src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(uint src, byte pos)
            => (src & (1u << pos)) != 0u;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(long src, byte pos)
            => (src & (1L << pos)) != 0L;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(ulong src, byte pos)
            => (src & (1ul << pos)) != 0ul;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(float src, byte pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test(double src, byte pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        
        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref byte setif(in byte src, int srcpos, ref byte dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, srcpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref sbyte setif(in sbyte src, int srcpos, ref sbyte dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, srcpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static short setif(short src, int srcpos, ref short dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, srcpos);
            return dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref ushort setif(ushort src, int srcpos, ref ushort dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ushort setif(ushort src, int srcpos, ushort dst, int dstpos)        
        {
            if(test(src, srcpos))
                return enable(dst, dstpos);
            else
                return dst;            
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static int setif(int src, int srcpos, ref int dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return dst;
        }

        /// <summary>
        /// Enables a specified bit in the target if a specified bit is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static uint setif(uint src, int srcpos, uint dst, int dstpos)        
        {
            if(test(src, srcpos))
                return enable(dst, dstpos);
            else
                return dst;
        }

        /// <summary>
        /// Enables a specified bit in the target if a specified bit is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ulong setif(ulong src, int srcpos, ulong dst, int dstpos)        
        {
            if(test(src, srcpos))
                return enable(dst, dstpos);
            else
                return dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static long setif(long src, int srcpos, long dst, int dstpos)        
        {
            if(test(src, srcpos))
                return enable(dst, dstpos);
            else
                return dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref ulong setif(in ulong src, int srcpos, ref ulong dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref float setif(in float src, int srcpos, ref float dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref double setif(in double src, int srcpos, ref double dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static sbyte toggle(sbyte src, int pos)
            => src ^= (sbyte)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static byte toggle(byte src, int pos)
            => src ^= (byte)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static short toggle(short src, int pos)
            => src ^= (short)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ushort toggle(ushort src, int pos)
            => src ^= (ushort)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static int toggle(int src, int pos)
            => src ^= (1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static uint toggle(uint src, int pos)
            => src ^= (1u << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static long toggle(long src, int pos)
            => src ^= (1L << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ulong toggle(ulong src, int pos)
            => src ^= (1ul << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static float toggle(float src, int pos)
        {
            ref var bits = ref Unsafe.As<float,int>(ref src);
            bits ^= (1 << pos);
            return src;
        }

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static double toggle(double src, int pos)
        {
            ref var bits = ref Unsafe.As<double,long>(ref src);
            bits ^= (1L << pos);
            return src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref sbyte toggle(ref sbyte src, int pos)
        {
            src ^= (sbyte)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref byte toggle(ref byte src, int pos)
        {
            src ^= (byte)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref short toggle(ref short src, int pos)
        {
            src ^= (short)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref ushort toggle(ref ushort src, int pos)
        {
            src ^= (ushort)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref int toggle(ref int src, int pos)
        {
            src ^= (1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref uint toggle(ref uint src, int pos)
        {
            src ^= (1u << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref long toggle(ref long src, int pos)
        {
            src ^= (1L << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref ulong toggle(ref ulong src, int pos)
        {
            src ^= (1ul << pos);
            return ref src;
        } 

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref float toggle(ref float src, int pos)
        {
            ref var bits = ref Unsafe.As<float,int>(ref src);
            bits ^= (1 << pos);
            return ref src;
        } 

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref double toggle(ref double src, int pos)
        {
            ref var bits = ref Unsafe.As<double,long>(ref src);
            bits ^= (1L << pos);
            return ref src;
        } 

    }   
}