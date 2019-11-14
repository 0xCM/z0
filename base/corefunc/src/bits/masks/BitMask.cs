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

    /// <summary>
    /// Defines bitmasking and selection functions
    /// </summary>
    public static partial class BitMask
    {
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


        public const uint Lsb32x8 = 1u | (1u << 8) | (1u << 16) | (1u << 24);

        public const ulong Lsb64x8 = 1ul | (1ul << 8) | (1ul << 16) | (1ul << 24) | (1ul << 32) | (1ul << 40) | (1ul << 48) | (1ul << 56);

        public const ulong Msb64x8 = 128ul | (128ul << 8) | (128ul << 16) | (128ul << 24) | (128ul << 32) | (128ul << 40) | (128ul << 48) | (128ul << 56);

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
                return test(As.uint8(src), pos);
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
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref byte set(ref byte src, byte pos, bit state)            
        {
            var c = ~(byte)state + 1;
            src ^= (byte)((c ^ src) & (1 << pos));
            return ref src;
        }
        
        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref sbyte set(ref sbyte src, byte pos, bit state)            
        {
            var c = ~(sbyte)state + 1;
            src ^= (sbyte)((c ^ src) & (1 << pos));
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref short set(ref short src, byte pos, bit state)            
        {
            var c = ~(short)state + 1;
            src ^= (short)((c ^ src) & (1 << pos));
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref ushort set(ref ushort src, byte pos, bit state)            
        {
            var c = ~(ushort)state + 1;
            src ^= (ushort)((c ^ src) & (1 << pos));
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref int set(ref int src, byte pos, bit state)            
        {
            var c = ~(int)state + 1;
            src ^= (c ^ src) & (1 << pos);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref uint set(ref uint src, byte pos, bit state)            
        {
            var c = ~(uint)state + 1u;
            src ^= (c ^ src) & (1u << pos);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref long set(ref long src, byte pos, bit state)            
        {
            var c = ~(long)state + 1L;
            src ^= (c ^ src) & (1L << pos);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref ulong set(ref ulong src, byte pos, bit state)
        {
            var c = ~(ulong)state + 1ul;
            src ^= (c ^ src) & (1ul << pos);
            return ref src;
        }
        
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
        public static ref short setif(in short src, int srcpos, ref short dst, int dstpos)        
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
        public static ref ushort setif(in ushort src, int srcpos, ref ushort dst, int dstpos)        
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
        public static ref int setif(in int src, int srcpos, ref int dst, int dstpos)        
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
        public static ref uint setif(in uint src, int srcpos, ref uint dst, int dstpos)        
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
        public static ref long setif(in long src, int srcpos, ref long dst, int dstpos)        
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