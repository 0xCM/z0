//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;


    public static class BitStore
    {
        [MethodImpl(Inline)]
        public static Span<byte> bitseq2<T>(T src)
            where T : unmanaged
        {
            var n = bitsize<T>();
            Span<byte> dst = new byte[n];
            ref var loc = ref head(dst);
            for(var i=0; i<n; i++)
                seek(ref loc, i) = (byte)BitMask.testg(src,i);
            return dst;
        }


        /// <summary>
        /// Selects an identified bit sequence
        /// </summary>
        /// <param name="index">A value from 0 - 255 indicating the byte of interest</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> select(byte index)
            => BitSeqData.Slice(index*8,8);

        /// <summary>
        /// Selects unpacked bits from a block of 8*256 bytes, where each byte represents 1 bit
        /// </summary>
        /// <param name="offset">The bit offset index</param>
        /// <param name="length">The number of bits to select</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> select(int offset, int length)
            => BitSeqData.Slice(offset,length);


        /// <summary>
        /// Constructs a sequence of 8 bytes {bi} := [b7,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> select_alt(byte value)        
            => U8Index[value].bitseq;        


        /// <summary>
        /// Constructs a span of bytes where each byte, ordered from lo to hi, 
        /// represents a single bit in the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return bitseq_u(in src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return bitseq_i(in src);
            else 
                return bitseq_f(in src);
        }        

        /// <summary>
        /// Describes an identified byte
        /// </summary>
        /// <param name="value">The value of the byte to describe</param>
        [MethodImpl(Inline)]
        public static ByteInfo info(byte value)
        {
            ref readonly var b = ref U8Index[value];
            return new ByteInfo(b.index, b.bitseq, b.bitchars, b.text);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> bitseq_f<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return ReadSeq(float32(src));
            else if(typeof(T) == typeof(double))
                return ReadSeq(float64(src));
            else            
                throw unsupported<T>();            
        }        

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> bitseq_i<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return ReadSeq(int8(src));
            else if(typeof(T) == typeof(short))
                return ReadSeq(int16(src));
            else if(typeof(T) == typeof(int))
                return ReadSeq(int32(src));
            else 
                return ReadSeq(int64(src));
        }        

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> bitseq_u<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return select_alt(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return ReadSeq(uint16(src));
            else if(typeof(T) == typeof(uint))
                return ReadSeq(uint32(src));
            else 
                return ReadSeq(uint64(src));
        }   
            
        /// <summary>
        /// Constructs a sequence of 8 characters {ci} := [c7,...c0] over the domain {'0','1'} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(byte index)
            => U8Index[index].bitchars;

        /// <summary>
        /// Constructs a sequence of 8 characters {ci} := [c7,...c0] over the domain {'0','1'} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(sbyte index)
            => I8Index[index + SByte.MaxValue + 1].bitchars;

        [MethodImpl(Inline)]
        public static string BitText(byte index)
            => U8Index[index].text;

        [MethodImpl(Inline)]
        public static string BitText(sbyte index)
            => I8Index[index + SByte.MaxValue + 1].text;

        /// <summary>
        /// Constructs a sequence of 8 bytes {bi} := [b7,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled. The uppermost bit b7 determines
        /// the sign
        /// </summary>
        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> ReadSeq(sbyte src)
            => select_alt((byte)src);

        /// <summary>
        /// Constructs a sequence of 16 bytes {bi} := [b15,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> ReadSeq(ushort src)
        {
            (var lo, var hi) = ((byte)src, (byte)(src >> 8));
            Span<byte> dst = new byte[16];
            select_alt(lo).CopyTo(dst,0);
            select_alt(hi).CopyTo(dst,8);
            return dst;            
        }

        /// <summary>
        /// Constructs a sequence of 16 bytes {bi} := [b15,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> ReadSeq(short src)
            => ReadSeq((ushort)src);

        /// <summary>
        /// Constructs a sequence of 32 bytes {bi} := [b31,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>        
        static ReadOnlySpan<byte> ReadSeq(uint src)
        {
            (var lo, var hi) = ((ushort)(src), (ushort)(src >> 16));
            Span<byte> dst = new byte[32];
            ReadSeq(lo).CopyTo(dst,0);
            ReadSeq(hi).CopyTo(dst,16);
            return dst;            
        }

        /// <summary>
        /// Constructs a sequence of 32 bytes {bi} := [b31,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> ReadSeq(int src)
            => ReadSeq((uint)src);

        /// <summary>
        /// Constructs a sequence of 32 bytes {bi} := [b31,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> ReadSeq(float value)
            => ReadSeq(BitConverter.SingleToInt32Bits(value));

        /// <summary>
        /// Constructs a sequence of 64 bytes {bi} := [b63,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        static ReadOnlySpan<byte> ReadSeq(ulong src)
        {
            (var lo, var hi) =  ((uint)src, (uint)(src >> 32));
            Span<byte> dst = new byte[64];
            ReadSeq(lo).CopyTo(dst,0);
            ReadSeq(hi).CopyTo(dst,32);
            return dst;            
        }

        /// <summary>
        /// Constructs a sequence of 64 bytes {bi} := [b63,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> ReadSeq(long src)
            => ReadSeq((ulong)src);

        /// <summary>
        /// Constructs a sequence of 64 bytes {bi} := [b63,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> ReadSeq(double src)
            => ReadSeq(BitConverter.DoubleToInt64Bits(src));
 
        static (byte index, byte[] bitseq, char[] bitchars, string text)[] U8Index
            = DefineU8Index();        

        static (sbyte index, sbyte[] bitseq, char[] bitchars, string text)[] I8Index
            = DefineI8Index();        

        [MethodImpl(Inline)]
        public static int PopCount(byte a)
            => skip(in head(PopCounts), a);
         
        static ReadOnlySpan<byte> PopCounts => new byte[]
        {
            0x00, 0x01, 0x01, 0x02, 0x01, 0x02, 0x02, 0x03,
            0x01, 0x02, 0x02, 0x03, 0x02, 0x03, 0x03, 0x04,
            0x01, 0x02, 0x02, 0x03, 0x02, 0x03, 0x03, 0x04,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x01, 0x02, 0x02, 0x03, 0x02, 0x03, 0x03, 0x04,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x01, 0x02, 0x02, 0x03, 0x02, 0x03, 0x03, 0x04,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x04, 0x05, 0x05, 0x06, 0x05, 0x06, 0x06, 0x07,
            0x01, 0x02, 0x02, 0x03, 0x02, 0x03, 0x03, 0x04,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x04, 0x05, 0x05, 0x06, 0x05, 0x06, 0x06, 0x07,
            0x02, 0x03, 0x03, 0x04, 0x03, 0x04, 0x04, 0x05,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x04, 0x05, 0x05, 0x06, 0x05, 0x06, 0x06, 0x07,
            0x03, 0x04, 0x04, 0x05, 0x04, 0x05, 0x05, 0x06,
            0x04, 0x05, 0x05, 0x06, 0x05, 0x06, 0x06, 0x07,
            0x04, 0x05, 0x05, 0x06, 0x05, 0x06, 0x06, 0x07,
            0x05, 0x06, 0x06, 0x07, 0x06, 0x07, 0x07, 0x08,
            
        };

        static ref readonly byte BitSeqHead 
        {
            [MethodImpl(Inline)]
            get => ref head(BitSeqData);
        }
        static ReadOnlySpan<byte> BitSeqData 
            => new byte[]
            {

                0,0,0,0,0,0,0,0,
                1,0,0,0,0,0,0,0,
                0,1,0,0,0,0,0,0,
                1,1,0,0,0,0,0,0,
                0,0,1,0,0,0,0,0,
                1,0,1,0,0,0,0,0,
                0,1,1,0,0,0,0,0,
                1,1,1,0,0,0,0,0,
                0,0,0,1,0,0,0,0,
                1,0,0,1,0,0,0,0,
                0,1,0,1,0,0,0,0,
                1,1,0,1,0,0,0,0,
                0,0,1,1,0,0,0,0,
                1,0,1,1,0,0,0,0,
                0,1,1,1,0,0,0,0,
                1,1,1,1,0,0,0,0,
                0,0,0,0,1,0,0,0,
                1,0,0,0,1,0,0,0,
                0,1,0,0,1,0,0,0,
                1,1,0,0,1,0,0,0,
                0,0,1,0,1,0,0,0,
                1,0,1,0,1,0,0,0,
                0,1,1,0,1,0,0,0,
                1,1,1,0,1,0,0,0,
                0,0,0,1,1,0,0,0,
                1,0,0,1,1,0,0,0,
                0,1,0,1,1,0,0,0,
                1,1,0,1,1,0,0,0,
                0,0,1,1,1,0,0,0,
                1,0,1,1,1,0,0,0,
                0,1,1,1,1,0,0,0,
                1,1,1,1,1,0,0,0,
                0,0,0,0,0,1,0,0,
                1,0,0,0,0,1,0,0,
                0,1,0,0,0,1,0,0,
                1,1,0,0,0,1,0,0,
                0,0,1,0,0,1,0,0,
                1,0,1,0,0,1,0,0,
                0,1,1,0,0,1,0,0,
                1,1,1,0,0,1,0,0,
                0,0,0,1,0,1,0,0,
                1,0,0,1,0,1,0,0,
                0,1,0,1,0,1,0,0,
                1,1,0,1,0,1,0,0,
                0,0,1,1,0,1,0,0,
                1,0,1,1,0,1,0,0,
                0,1,1,1,0,1,0,0,
                1,1,1,1,0,1,0,0,
                0,0,0,0,1,1,0,0,
                1,0,0,0,1,1,0,0,
                0,1,0,0,1,1,0,0,
                1,1,0,0,1,1,0,0,
                0,0,1,0,1,1,0,0,
                1,0,1,0,1,1,0,0,
                0,1,1,0,1,1,0,0,
                1,1,1,0,1,1,0,0,
                0,0,0,1,1,1,0,0,
                1,0,0,1,1,1,0,0,
                0,1,0,1,1,1,0,0,
                1,1,0,1,1,1,0,0,
                0,0,1,1,1,1,0,0,
                1,0,1,1,1,1,0,0,
                0,1,1,1,1,1,0,0,
                1,1,1,1,1,1,0,0,
                0,0,0,0,0,0,1,0,
                1,0,0,0,0,0,1,0,
                0,1,0,0,0,0,1,0,
                1,1,0,0,0,0,1,0,
                0,0,1,0,0,0,1,0,
                1,0,1,0,0,0,1,0,
                0,1,1,0,0,0,1,0,
                1,1,1,0,0,0,1,0,
                0,0,0,1,0,0,1,0,
                1,0,0,1,0,0,1,0,
                0,1,0,1,0,0,1,0,
                1,1,0,1,0,0,1,0,
                0,0,1,1,0,0,1,0,
                1,0,1,1,0,0,1,0,
                0,1,1,1,0,0,1,0,
                1,1,1,1,0,0,1,0,
                0,0,0,0,1,0,1,0,
                1,0,0,0,1,0,1,0,
                0,1,0,0,1,0,1,0,
                1,1,0,0,1,0,1,0,
                0,0,1,0,1,0,1,0,
                1,0,1,0,1,0,1,0,
                0,1,1,0,1,0,1,0,
                1,1,1,0,1,0,1,0,
                0,0,0,1,1,0,1,0,
                1,0,0,1,1,0,1,0,
                0,1,0,1,1,0,1,0,
                1,1,0,1,1,0,1,0,
                0,0,1,1,1,0,1,0,
                1,0,1,1,1,0,1,0,
                0,1,1,1,1,0,1,0,
                1,1,1,1,1,0,1,0,
                0,0,0,0,0,1,1,0,
                1,0,0,0,0,1,1,0,
                0,1,0,0,0,1,1,0,
                1,1,0,0,0,1,1,0,
                0,0,1,0,0,1,1,0,
                1,0,1,0,0,1,1,0,
                0,1,1,0,0,1,1,0,
                1,1,1,0,0,1,1,0,
                0,0,0,1,0,1,1,0,
                1,0,0,1,0,1,1,0,
                0,1,0,1,0,1,1,0,
                1,1,0,1,0,1,1,0,
                0,0,1,1,0,1,1,0,
                1,0,1,1,0,1,1,0,
                0,1,1,1,0,1,1,0,
                1,1,1,1,0,1,1,0,
                0,0,0,0,1,1,1,0,
                1,0,0,0,1,1,1,0,
                0,1,0,0,1,1,1,0,
                1,1,0,0,1,1,1,0,
                0,0,1,0,1,1,1,0,
                1,0,1,0,1,1,1,0,
                0,1,1,0,1,1,1,0,
                1,1,1,0,1,1,1,0,
                0,0,0,1,1,1,1,0,
                1,0,0,1,1,1,1,0,
                0,1,0,1,1,1,1,0,
                1,1,0,1,1,1,1,0,
                0,0,1,1,1,1,1,0,
                1,0,1,1,1,1,1,0,
                0,1,1,1,1,1,1,0,
                1,1,1,1,1,1,1,0,
                0,0,0,0,0,0,0,1,
                1,0,0,0,0,0,0,1,
                0,1,0,0,0,0,0,1,
                1,1,0,0,0,0,0,1,
                0,0,1,0,0,0,0,1,
                1,0,1,0,0,0,0,1,
                0,1,1,0,0,0,0,1,
                1,1,1,0,0,0,0,1,
                0,0,0,1,0,0,0,1,
                1,0,0,1,0,0,0,1,
                0,1,0,1,0,0,0,1,
                1,1,0,1,0,0,0,1,
                0,0,1,1,0,0,0,1,
                1,0,1,1,0,0,0,1,
                0,1,1,1,0,0,0,1,
                1,1,1,1,0,0,0,1,
                0,0,0,0,1,0,0,1,
                1,0,0,0,1,0,0,1,
                0,1,0,0,1,0,0,1,
                1,1,0,0,1,0,0,1,
                0,0,1,0,1,0,0,1,
                1,0,1,0,1,0,0,1,
                0,1,1,0,1,0,0,1,
                1,1,1,0,1,0,0,1,
                0,0,0,1,1,0,0,1,
                1,0,0,1,1,0,0,1,
                0,1,0,1,1,0,0,1,
                1,1,0,1,1,0,0,1,
                0,0,1,1,1,0,0,1,
                1,0,1,1,1,0,0,1,
                0,1,1,1,1,0,0,1,
                1,1,1,1,1,0,0,1,
                0,0,0,0,0,1,0,1,
                1,0,0,0,0,1,0,1,
                0,1,0,0,0,1,0,1,
                1,1,0,0,0,1,0,1,
                0,0,1,0,0,1,0,1,
                1,0,1,0,0,1,0,1,
                0,1,1,0,0,1,0,1,
                1,1,1,0,0,1,0,1,
                0,0,0,1,0,1,0,1,
                1,0,0,1,0,1,0,1,
                0,1,0,1,0,1,0,1,
                1,1,0,1,0,1,0,1,
                0,0,1,1,0,1,0,1,
                1,0,1,1,0,1,0,1,
                0,1,1,1,0,1,0,1,
                1,1,1,1,0,1,0,1,
                0,0,0,0,1,1,0,1,
                1,0,0,0,1,1,0,1,
                0,1,0,0,1,1,0,1,
                1,1,0,0,1,1,0,1,
                0,0,1,0,1,1,0,1,
                1,0,1,0,1,1,0,1,
                0,1,1,0,1,1,0,1,
                1,1,1,0,1,1,0,1,
                0,0,0,1,1,1,0,1,
                1,0,0,1,1,1,0,1,
                0,1,0,1,1,1,0,1,
                1,1,0,1,1,1,0,1,
                0,0,1,1,1,1,0,1,
                1,0,1,1,1,1,0,1,
                0,1,1,1,1,1,0,1,
                1,1,1,1,1,1,0,1,
                0,0,0,0,0,0,1,1,
                1,0,0,0,0,0,1,1,
                0,1,0,0,0,0,1,1,
                1,1,0,0,0,0,1,1,
                0,0,1,0,0,0,1,1,
                1,0,1,0,0,0,1,1,
                0,1,1,0,0,0,1,1,
                1,1,1,0,0,0,1,1,
                0,0,0,1,0,0,1,1,
                1,0,0,1,0,0,1,1,
                0,1,0,1,0,0,1,1,
                1,1,0,1,0,0,1,1,
                0,0,1,1,0,0,1,1,
                1,0,1,1,0,0,1,1,
                0,1,1,1,0,0,1,1,
                1,1,1,1,0,0,1,1,
                0,0,0,0,1,0,1,1,
                1,0,0,0,1,0,1,1,
                0,1,0,0,1,0,1,1,
                1,1,0,0,1,0,1,1,
                0,0,1,0,1,0,1,1,
                1,0,1,0,1,0,1,1,
                0,1,1,0,1,0,1,1,
                1,1,1,0,1,0,1,1,
                0,0,0,1,1,0,1,1,
                1,0,0,1,1,0,1,1,
                0,1,0,1,1,0,1,1,
                1,1,0,1,1,0,1,1,
                0,0,1,1,1,0,1,1,
                1,0,1,1,1,0,1,1,
                0,1,1,1,1,0,1,1,
                1,1,1,1,1,0,1,1,
                0,0,0,0,0,1,1,1,
                1,0,0,0,0,1,1,1,
                0,1,0,0,0,1,1,1,
                1,1,0,0,0,1,1,1,
                0,0,1,0,0,1,1,1,
                1,0,1,0,0,1,1,1,
                0,1,1,0,0,1,1,1,
                1,1,1,0,0,1,1,1,
                0,0,0,1,0,1,1,1,
                1,0,0,1,0,1,1,1,
                0,1,0,1,0,1,1,1,
                1,1,0,1,0,1,1,1,
                0,0,1,1,0,1,1,1,
                1,0,1,1,0,1,1,1,
                0,1,1,1,0,1,1,1,
                1,1,1,1,0,1,1,1,
                0,0,0,0,1,1,1,1,
                1,0,0,0,1,1,1,1,
                0,1,0,0,1,1,1,1,
                1,1,0,0,1,1,1,1,
                0,0,1,0,1,1,1,1,
                1,0,1,0,1,1,1,1,
                0,1,1,0,1,1,1,1,
                1,1,1,0,1,1,1,1,
                0,0,0,1,1,1,1,1,
                1,0,0,1,1,1,1,1,
                0,1,0,1,1,1,1,1,
                1,1,0,1,1,1,1,1,
                0,0,1,1,1,1,1,1,
                1,0,1,1,1,1,1,1,
                0,1,1,1,1,1,1,1,
                1,1,1,1,1,1,1,1,

            };

        static (byte index, byte[] bitseq, char[] bitchars, string text)[] DefineU8Index()
        {
            var dst = new (byte index, byte[] bitseq, char[] bitchars, string text)[256];
            dst[0] =   (0b00000000, new byte[]{0,0,0,0,0,0,0,0}, new char[]{'0','0','0','0','0','0','0','0'}, "00000000");
            dst[1] =   (0b00000001, new byte[]{1,0,0,0,0,0,0,0}, new char[]{'1','0','0','0','0','0','0','0'}, "00000001");
            dst[2] =   (0b00000010, new byte[]{0,1,0,0,0,0,0,0}, new char[]{'0','1','0','0','0','0','0','0'}, "00000010");
            dst[3] =   (0b00000011, new byte[]{1,1,0,0,0,0,0,0}, new char[]{'1','1','0','0','0','0','0','0'}, "00000011");
            dst[4] =   (0b00000100, new byte[]{0,0,1,0,0,0,0,0}, new char[]{'0','0','1','0','0','0','0','0'}, "00000100");
            dst[5] =   (0b00000101, new byte[]{1,0,1,0,0,0,0,0}, new char[]{'1','0','1','0','0','0','0','0'}, "00000101");
            dst[6] =   (0b00000110, new byte[]{0,1,1,0,0,0,0,0}, new char[]{'0','1','1','0','0','0','0','0'}, "00000110");
            dst[7] =   (0b00000111, new byte[]{1,1,1,0,0,0,0,0}, new char[]{'1','1','1','0','0','0','0','0'}, "00000111");
            dst[8] =   (0b00001000, new byte[]{0,0,0,1,0,0,0,0}, new char[]{'0','0','0','1','0','0','0','0'}, "00001000");
            dst[9] =   (0b00001001, new byte[]{1,0,0,1,0,0,0,0}, new char[]{'1','0','0','1','0','0','0','0'}, "00001001");
            dst[10] =  (0b00001010, new byte[]{0,1,0,1,0,0,0,0}, new char[]{'0','1','0','1','0','0','0','0'}, "00001010");
            dst[11] =  (0b00001011, new byte[]{1,1,0,1,0,0,0,0}, new char[]{'1','1','0','1','0','0','0','0'}, "00001011");
            dst[12] =  (0b00001100, new byte[]{0,0,1,1,0,0,0,0}, new char[]{'0','0','1','1','0','0','0','0'}, "00001100");
            dst[13] =  (0b00001101, new byte[]{1,0,1,1,0,0,0,0}, new char[]{'1','0','1','1','0','0','0','0'}, "00001101");
            dst[14] =  (0b00001110, new byte[]{0,1,1,1,0,0,0,0}, new char[]{'0','1','1','1','0','0','0','0'}, "00001110");
            dst[15] =  (0b00001111, new byte[]{1,1,1,1,0,0,0,0}, new char[]{'1','1','1','1','0','0','0','0'}, "00001111");
            dst[16] =  (0b00010000, new byte[]{0,0,0,0,1,0,0,0}, new char[]{'0','0','0','0','1','0','0','0'}, "00010000");
            dst[17] =  (0b00010001, new byte[]{1,0,0,0,1,0,0,0}, new char[]{'1','0','0','0','1','0','0','0'}, "00010001");
            dst[18] =  (0b00010010, new byte[]{0,1,0,0,1,0,0,0}, new char[]{'0','1','0','0','1','0','0','0'}, "00010010");
            dst[19] =  (0b00010011, new byte[]{1,1,0,0,1,0,0,0}, new char[]{'1','1','0','0','1','0','0','0'}, "00010011");
            dst[20] =  (0b00010100, new byte[]{0,0,1,0,1,0,0,0}, new char[]{'0','0','1','0','1','0','0','0'}, "00010100");
            dst[21] =  (0b00010101, new byte[]{1,0,1,0,1,0,0,0}, new char[]{'1','0','1','0','1','0','0','0'}, "00010101");
            dst[22] =  (0b00010110, new byte[]{0,1,1,0,1,0,0,0}, new char[]{'0','1','1','0','1','0','0','0'}, "00010110");
            dst[23] =  (0b00010111, new byte[]{1,1,1,0,1,0,0,0}, new char[]{'1','1','1','0','1','0','0','0'}, "00010111");
            dst[24] =  (0b00011000, new byte[]{0,0,0,1,1,0,0,0}, new char[]{'0','0','0','1','1','0','0','0'}, "00011000");
            dst[25] =  (0b00011001, new byte[]{1,0,0,1,1,0,0,0}, new char[]{'1','0','0','1','1','0','0','0'}, "00011001");
            dst[26] =  (0b00011010, new byte[]{0,1,0,1,1,0,0,0}, new char[]{'0','1','0','1','1','0','0','0'}, "00011010");
            dst[27] =  (0b00011011, new byte[]{1,1,0,1,1,0,0,0}, new char[]{'1','1','0','1','1','0','0','0'}, "00011011");
            dst[28] =  (0b00011100, new byte[]{0,0,1,1,1,0,0,0}, new char[]{'0','0','1','1','1','0','0','0'}, "00011100");
            dst[29] =  (0b00011101, new byte[]{1,0,1,1,1,0,0,0}, new char[]{'1','0','1','1','1','0','0','0'}, "00011101");
            dst[30] =  (0b00011110, new byte[]{0,1,1,1,1,0,0,0}, new char[]{'0','1','1','1','1','0','0','0'}, "00011110");
            dst[31] =  (0b00011111, new byte[]{1,1,1,1,1,0,0,0}, new char[]{'1','1','1','1','1','0','0','0'}, "00011111");
            dst[32] =  (0b00100000, new byte[]{0,0,0,0,0,1,0,0}, new char[]{'0','0','0','0','0','1','0','0'}, "00100000");
            dst[33] =  (0b00100001, new byte[]{1,0,0,0,0,1,0,0}, new char[]{'1','0','0','0','0','1','0','0'}, "00100001");
            dst[34] =  (0b00100010, new byte[]{0,1,0,0,0,1,0,0}, new char[]{'0','1','0','0','0','1','0','0'}, "00100010");
            dst[35] =  (0b00100011, new byte[]{1,1,0,0,0,1,0,0}, new char[]{'1','1','0','0','0','1','0','0'}, "00100011");
            dst[36] =  (0b00100100, new byte[]{0,0,1,0,0,1,0,0}, new char[]{'0','0','1','0','0','1','0','0'}, "00100100");
            dst[37] =  (0b00100101, new byte[]{1,0,1,0,0,1,0,0}, new char[]{'1','0','1','0','0','1','0','0'}, "00100101");
            dst[38] =  (0b00100110, new byte[]{0,1,1,0,0,1,0,0}, new char[]{'0','1','1','0','0','1','0','0'}, "00100110");
            dst[39] =  (0b00100111, new byte[]{1,1,1,0,0,1,0,0}, new char[]{'1','1','1','0','0','1','0','0'}, "00100111");
            dst[40] =  (0b00101000, new byte[]{0,0,0,1,0,1,0,0}, new char[]{'0','0','0','1','0','1','0','0'}, "00101000");
            dst[41] =  (0b00101001, new byte[]{1,0,0,1,0,1,0,0}, new char[]{'1','0','0','1','0','1','0','0'}, "00101001");
            dst[42] =  (0b00101010, new byte[]{0,1,0,1,0,1,0,0}, new char[]{'0','1','0','1','0','1','0','0'}, "00101010");
            dst[43] =  (0b00101011, new byte[]{1,1,0,1,0,1,0,0}, new char[]{'1','1','0','1','0','1','0','0'}, "00101011");
            dst[44] =  (0b00101100, new byte[]{0,0,1,1,0,1,0,0}, new char[]{'0','0','1','1','0','1','0','0'}, "00101100");
            dst[45] =  (0b00101101, new byte[]{1,0,1,1,0,1,0,0}, new char[]{'1','0','1','1','0','1','0','0'}, "00101101");
            dst[46] =  (0b00101110, new byte[]{0,1,1,1,0,1,0,0}, new char[]{'0','1','1','1','0','1','0','0'}, "00101110");
            dst[47] =  (0b00101111, new byte[]{1,1,1,1,0,1,0,0}, new char[]{'1','1','1','1','0','1','0','0'}, "00101111");
            dst[48] =  (0b00110000, new byte[]{0,0,0,0,1,1,0,0}, new char[]{'0','0','0','0','1','1','0','0'}, "00110000");
            dst[49] =  (0b00110001, new byte[]{1,0,0,0,1,1,0,0}, new char[]{'1','0','0','0','1','1','0','0'}, "00110001");
            dst[50] =  (0b00110010, new byte[]{0,1,0,0,1,1,0,0}, new char[]{'0','1','0','0','1','1','0','0'}, "00110010");
            dst[51] =  (0b00110011, new byte[]{1,1,0,0,1,1,0,0}, new char[]{'1','1','0','0','1','1','0','0'}, "00110011");
            dst[52] =  (0b00110100, new byte[]{0,0,1,0,1,1,0,0}, new char[]{'0','0','1','0','1','1','0','0'}, "00110100");
            dst[53] =  (0b00110101, new byte[]{1,0,1,0,1,1,0,0}, new char[]{'1','0','1','0','1','1','0','0'}, "00110101");
            dst[54] =  (0b00110110, new byte[]{0,1,1,0,1,1,0,0}, new char[]{'0','1','1','0','1','1','0','0'}, "00110110");
            dst[55] =  (0b00110111, new byte[]{1,1,1,0,1,1,0,0}, new char[]{'1','1','1','0','1','1','0','0'}, "00110111");
            dst[56] =  (0b00111000, new byte[]{0,0,0,1,1,1,0,0}, new char[]{'0','0','0','1','1','1','0','0'}, "00111000");
            dst[57] =  (0b00111001, new byte[]{1,0,0,1,1,1,0,0}, new char[]{'1','0','0','1','1','1','0','0'}, "00111001");
            dst[58] =  (0b00111010, new byte[]{0,1,0,1,1,1,0,0}, new char[]{'0','1','0','1','1','1','0','0'}, "00111010");
            dst[59] =  (0b00111011, new byte[]{1,1,0,1,1,1,0,0}, new char[]{'1','1','0','1','1','1','0','0'}, "00111011");
            dst[60] =  (0b00111100, new byte[]{0,0,1,1,1,1,0,0}, new char[]{'0','0','1','1','1','1','0','0'}, "00111100");
            dst[61] =  (0b00111101, new byte[]{1,0,1,1,1,1,0,0}, new char[]{'1','0','1','1','1','1','0','0'}, "00111101");
            dst[62] =  (0b00111110, new byte[]{0,1,1,1,1,1,0,0}, new char[]{'0','1','1','1','1','1','0','0'}, "00111110");
            dst[63] =  (0b00111111, new byte[]{1,1,1,1,1,1,0,0}, new char[]{'1','1','1','1','1','1','0','0'}, "00111111");
            dst[64] =  (0b01000000, new byte[]{0,0,0,0,0,0,1,0}, new char[]{'0','0','0','0','0','0','1','0'}, "01000000");
            dst[65] =  (0b01000001, new byte[]{1,0,0,0,0,0,1,0}, new char[]{'1','0','0','0','0','0','1','0'}, "01000001");
            dst[66] =  (0b01000010, new byte[]{0,1,0,0,0,0,1,0}, new char[]{'0','1','0','0','0','0','1','0'}, "01000010");
            dst[67] =  (0b01000011, new byte[]{1,1,0,0,0,0,1,0}, new char[]{'1','1','0','0','0','0','1','0'}, "01000011");
            dst[68] =  (0b01000100, new byte[]{0,0,1,0,0,0,1,0}, new char[]{'0','0','1','0','0','0','1','0'}, "01000100");
            dst[69] =  (0b01000101, new byte[]{1,0,1,0,0,0,1,0}, new char[]{'1','0','1','0','0','0','1','0'}, "01000101");
            dst[70] =  (0b01000110, new byte[]{0,1,1,0,0,0,1,0}, new char[]{'0','1','1','0','0','0','1','0'}, "01000110");
            dst[71] =  (0b01000111, new byte[]{1,1,1,0,0,0,1,0}, new char[]{'1','1','1','0','0','0','1','0'}, "01000111");
            dst[72] =  (0b01001000, new byte[]{0,0,0,1,0,0,1,0}, new char[]{'0','0','0','1','0','0','1','0'}, "01001000");
            dst[73] =  (0b01001001, new byte[]{1,0,0,1,0,0,1,0}, new char[]{'1','0','0','1','0','0','1','0'}, "01001001");
            dst[74] =  (0b01001010, new byte[]{0,1,0,1,0,0,1,0}, new char[]{'0','1','0','1','0','0','1','0'}, "01001010");
            dst[75] =  (0b01001011, new byte[]{1,1,0,1,0,0,1,0}, new char[]{'1','1','0','1','0','0','1','0'}, "01001011");
            dst[76] =  (0b01001100, new byte[]{0,0,1,1,0,0,1,0}, new char[]{'0','0','1','1','0','0','1','0'}, "01001100");
            dst[77] =  (0b01001101, new byte[]{1,0,1,1,0,0,1,0}, new char[]{'1','0','1','1','0','0','1','0'}, "01001101");
            dst[78] =  (0b01001110, new byte[]{0,1,1,1,0,0,1,0}, new char[]{'0','1','1','1','0','0','1','0'}, "01001110");
            dst[79] =  (0b01001111, new byte[]{1,1,1,1,0,0,1,0}, new char[]{'1','1','1','1','0','0','1','0'}, "01001111");
            dst[80] =  (0b01010000, new byte[]{0,0,0,0,1,0,1,0}, new char[]{'0','0','0','0','1','0','1','0'}, "01010000");
            dst[81] =  (0b01010001, new byte[]{1,0,0,0,1,0,1,0}, new char[]{'1','0','0','0','1','0','1','0'}, "01010001");
            dst[82] =  (0b01010010, new byte[]{0,1,0,0,1,0,1,0}, new char[]{'0','1','0','0','1','0','1','0'}, "01010010");
            dst[83] =  (0b01010011, new byte[]{1,1,0,0,1,0,1,0}, new char[]{'1','1','0','0','1','0','1','0'}, "01010011");
            dst[84] =  (0b01010100, new byte[]{0,0,1,0,1,0,1,0}, new char[]{'0','0','1','0','1','0','1','0'}, "01010100");
            dst[85] =  (0b01010101, new byte[]{1,0,1,0,1,0,1,0}, new char[]{'1','0','1','0','1','0','1','0'}, "01010101");
            dst[86] =  (0b01010110, new byte[]{0,1,1,0,1,0,1,0}, new char[]{'0','1','1','0','1','0','1','0'}, "01010110");
            dst[87] =  (0b01010111, new byte[]{1,1,1,0,1,0,1,0}, new char[]{'1','1','1','0','1','0','1','0'}, "01010111");
            dst[88] =  (0b01011000, new byte[]{0,0,0,1,1,0,1,0}, new char[]{'0','0','0','1','1','0','1','0'}, "01011000");
            dst[89] =  (0b01011001, new byte[]{1,0,0,1,1,0,1,0}, new char[]{'1','0','0','1','1','0','1','0'}, "01011001");
            dst[90] =  (0b01011010, new byte[]{0,1,0,1,1,0,1,0}, new char[]{'0','1','0','1','1','0','1','0'}, "01011010");
            dst[91] =  (0b01011011, new byte[]{1,1,0,1,1,0,1,0}, new char[]{'1','1','0','1','1','0','1','0'}, "01011011");
            dst[92] =  (0b01011100, new byte[]{0,0,1,1,1,0,1,0}, new char[]{'0','0','1','1','1','0','1','0'}, "01011100");
            dst[93] =  (0b01011101, new byte[]{1,0,1,1,1,0,1,0}, new char[]{'1','0','1','1','1','0','1','0'}, "01011101");
            dst[94] =  (0b01011110, new byte[]{0,1,1,1,1,0,1,0}, new char[]{'0','1','1','1','1','0','1','0'}, "01011110");
            dst[95] =  (0b01011111, new byte[]{1,1,1,1,1,0,1,0}, new char[]{'1','1','1','1','1','0','1','0'}, "01011111");
            dst[96] =  (0b01100000, new byte[]{0,0,0,0,0,1,1,0}, new char[]{'0','0','0','0','0','1','1','0'}, "01100000");
            dst[97] =  (0b01100001, new byte[]{1,0,0,0,0,1,1,0}, new char[]{'1','0','0','0','0','1','1','0'}, "01100001");
            dst[98] =  (0b01100010, new byte[]{0,1,0,0,0,1,1,0}, new char[]{'0','1','0','0','0','1','1','0'}, "01100010");
            dst[99] =  (0b01100011, new byte[]{1,1,0,0,0,1,1,0}, new char[]{'1','1','0','0','0','1','1','0'}, "01100011");
            dst[100] = (0b01100100, new byte[]{0,0,1,0,0,1,1,0}, new char[]{'0','0','1','0','0','1','1','0'}, "01100100");
            dst[101] = (0b01100101, new byte[]{1,0,1,0,0,1,1,0}, new char[]{'1','0','1','0','0','1','1','0'}, "01100101");
            dst[102] = (0b01100110, new byte[]{0,1,1,0,0,1,1,0}, new char[]{'0','1','1','0','0','1','1','0'}, "01100110");
            dst[103] = (0b01100111, new byte[]{1,1,1,0,0,1,1,0}, new char[]{'1','1','1','0','0','1','1','0'}, "01100111");
            dst[104] = (0b01101000, new byte[]{0,0,0,1,0,1,1,0}, new char[]{'0','0','0','1','0','1','1','0'}, "01101000");
            dst[105] = (0b01101001, new byte[]{1,0,0,1,0,1,1,0}, new char[]{'1','0','0','1','0','1','1','0'}, "01101001");
            dst[106] = (0b01101010, new byte[]{0,1,0,1,0,1,1,0}, new char[]{'0','1','0','1','0','1','1','0'}, "01101010");
            dst[107] = (0b01101011, new byte[]{1,1,0,1,0,1,1,0}, new char[]{'1','1','0','1','0','1','1','0'}, "01101011");
            dst[108] = (0b01101100, new byte[]{0,0,1,1,0,1,1,0}, new char[]{'0','0','1','1','0','1','1','0'}, "01101100");
            dst[109] = (0b01101101, new byte[]{1,0,1,1,0,1,1,0}, new char[]{'1','0','1','1','0','1','1','0'}, "01101101");
            dst[110] = (0b01101110, new byte[]{0,1,1,1,0,1,1,0}, new char[]{'0','1','1','1','0','1','1','0'}, "01101110");
            dst[111] = (0b01101111, new byte[]{1,1,1,1,0,1,1,0}, new char[]{'1','1','1','1','0','1','1','0'}, "01101111");
            dst[112] = (0b01110000, new byte[]{0,0,0,0,1,1,1,0}, new char[]{'0','0','0','0','1','1','1','0'}, "01110000");
            dst[113] = (0b01110001, new byte[]{1,0,0,0,1,1,1,0}, new char[]{'1','0','0','0','1','1','1','0'}, "01110001");
            dst[114] = (0b01110010, new byte[]{0,1,0,0,1,1,1,0}, new char[]{'0','1','0','0','1','1','1','0'}, "01110010");
            dst[115] = (0b01110011, new byte[]{1,1,0,0,1,1,1,0}, new char[]{'1','1','0','0','1','1','1','0'}, "01110011");
            dst[116] = (0b01110100, new byte[]{0,0,1,0,1,1,1,0}, new char[]{'0','0','1','0','1','1','1','0'}, "01110100");
            dst[117] = (0b01110101, new byte[]{1,0,1,0,1,1,1,0}, new char[]{'1','0','1','0','1','1','1','0'}, "01110101");
            dst[118] = (0b01110110, new byte[]{0,1,1,0,1,1,1,0}, new char[]{'0','1','1','0','1','1','1','0'}, "01110110");
            dst[119] = (0b01110111, new byte[]{1,1,1,0,1,1,1,0}, new char[]{'1','1','1','0','1','1','1','0'}, "01110111");
            dst[120] = (0b01111000, new byte[]{0,0,0,1,1,1,1,0}, new char[]{'0','0','0','1','1','1','1','0'}, "01111000");
            dst[121] = (0b01111001, new byte[]{1,0,0,1,1,1,1,0}, new char[]{'1','0','0','1','1','1','1','0'}, "01111001");
            dst[122] = (0b01111010, new byte[]{0,1,0,1,1,1,1,0}, new char[]{'0','1','0','1','1','1','1','0'}, "01111010");
            dst[123] = (0b01111011, new byte[]{1,1,0,1,1,1,1,0}, new char[]{'1','1','0','1','1','1','1','0'}, "01111011");
            dst[124] = (0b01111100, new byte[]{0,0,1,1,1,1,1,0}, new char[]{'0','0','1','1','1','1','1','0'}, "01111100");
            dst[125] = (0b01111101, new byte[]{1,0,1,1,1,1,1,0}, new char[]{'1','0','1','1','1','1','1','0'}, "01111101");
            dst[126] = (0b01111110, new byte[]{0,1,1,1,1,1,1,0}, new char[]{'0','1','1','1','1','1','1','0'}, "01111110");
            dst[127] = (0b01111111, new byte[]{1,1,1,1,1,1,1,0}, new char[]{'1','1','1','1','1','1','1','0'}, "01111111");
            dst[128] = (0b10000000, new byte[]{0,0,0,0,0,0,0,1}, new char[]{'0','0','0','0','0','0','0','1'}, "10000000");
            dst[129] = (0b10000001, new byte[]{1,0,0,0,0,0,0,1}, new char[]{'1','0','0','0','0','0','0','1'}, "10000001");
            dst[130] = (0b10000010, new byte[]{0,1,0,0,0,0,0,1}, new char[]{'0','1','0','0','0','0','0','1'}, "10000010");
            dst[131] = (0b10000011, new byte[]{1,1,0,0,0,0,0,1}, new char[]{'1','1','0','0','0','0','0','1'}, "10000011");
            dst[132] = (0b10000100, new byte[]{0,0,1,0,0,0,0,1}, new char[]{'0','0','1','0','0','0','0','1'}, "10000100");
            dst[133] = (0b10000101, new byte[]{1,0,1,0,0,0,0,1}, new char[]{'1','0','1','0','0','0','0','1'}, "10000101");
            dst[134] = (0b10000110, new byte[]{0,1,1,0,0,0,0,1}, new char[]{'0','1','1','0','0','0','0','1'}, "10000110");
            dst[135] = (0b10000111, new byte[]{1,1,1,0,0,0,0,1}, new char[]{'1','1','1','0','0','0','0','1'}, "10000111");
            dst[136] = (0b10001000, new byte[]{0,0,0,1,0,0,0,1}, new char[]{'0','0','0','1','0','0','0','1'}, "10001000");
            dst[137] = (0b10001001, new byte[]{1,0,0,1,0,0,0,1}, new char[]{'1','0','0','1','0','0','0','1'}, "10001001");
            dst[138] = (0b10001010, new byte[]{0,1,0,1,0,0,0,1}, new char[]{'0','1','0','1','0','0','0','1'}, "10001010");
            dst[139] = (0b10001011, new byte[]{1,1,0,1,0,0,0,1}, new char[]{'1','1','0','1','0','0','0','1'}, "10001011");
            dst[140] = (0b10001100, new byte[]{0,0,1,1,0,0,0,1}, new char[]{'0','0','1','1','0','0','0','1'}, "10001100");
            dst[141] = (0b10001101, new byte[]{1,0,1,1,0,0,0,1}, new char[]{'1','0','1','1','0','0','0','1'}, "10001101");
            dst[142] = (0b10001110, new byte[]{0,1,1,1,0,0,0,1}, new char[]{'0','1','1','1','0','0','0','1'}, "10001110");
            dst[143] = (0b10001111, new byte[]{1,1,1,1,0,0,0,1}, new char[]{'1','1','1','1','0','0','0','1'}, "10001111");
            dst[144] = (0b10010000, new byte[]{0,0,0,0,1,0,0,1}, new char[]{'0','0','0','0','1','0','0','1'}, "10010000");
            dst[145] = (0b10010001, new byte[]{1,0,0,0,1,0,0,1}, new char[]{'1','0','0','0','1','0','0','1'}, "10010001");
            dst[146] = (0b10010010, new byte[]{0,1,0,0,1,0,0,1}, new char[]{'0','1','0','0','1','0','0','1'}, "10010010");
            dst[147] = (0b10010011, new byte[]{1,1,0,0,1,0,0,1}, new char[]{'1','1','0','0','1','0','0','1'}, "10010011");
            dst[148] = (0b10010100, new byte[]{0,0,1,0,1,0,0,1}, new char[]{'0','0','1','0','1','0','0','1'}, "10010100");
            dst[149] = (0b10010101, new byte[]{1,0,1,0,1,0,0,1}, new char[]{'1','0','1','0','1','0','0','1'}, "10010101");
            dst[150] = (0b10010110, new byte[]{0,1,1,0,1,0,0,1}, new char[]{'0','1','1','0','1','0','0','1'}, "10010110");
            dst[151] = (0b10010111, new byte[]{1,1,1,0,1,0,0,1}, new char[]{'1','1','1','0','1','0','0','1'}, "10010111");
            dst[152] = (0b10011000, new byte[]{0,0,0,1,1,0,0,1}, new char[]{'0','0','0','1','1','0','0','1'}, "10011000");
            dst[153] = (0b10011001, new byte[]{1,0,0,1,1,0,0,1}, new char[]{'1','0','0','1','1','0','0','1'}, "10011001");
            dst[154] = (0b10011010, new byte[]{0,1,0,1,1,0,0,1}, new char[]{'0','1','0','1','1','0','0','1'}, "10011010");
            dst[155] = (0b10011011, new byte[]{1,1,0,1,1,0,0,1}, new char[]{'1','1','0','1','1','0','0','1'}, "10011011");
            dst[156] = (0b10011100, new byte[]{0,0,1,1,1,0,0,1}, new char[]{'0','0','1','1','1','0','0','1'}, "10011100");
            dst[157] = (0b10011101, new byte[]{1,0,1,1,1,0,0,1}, new char[]{'1','0','1','1','1','0','0','1'}, "10011101");
            dst[158] = (0b10011110, new byte[]{0,1,1,1,1,0,0,1}, new char[]{'0','1','1','1','1','0','0','1'}, "10011110");
            dst[159] = (0b10011111, new byte[]{1,1,1,1,1,0,0,1}, new char[]{'1','1','1','1','1','0','0','1'}, "10011111");
            dst[160] = (0b10100000, new byte[]{0,0,0,0,0,1,0,1}, new char[]{'0','0','0','0','0','1','0','1'}, "10100000");
            dst[161] = (0b10100001, new byte[]{1,0,0,0,0,1,0,1}, new char[]{'1','0','0','0','0','1','0','1'}, "10100001");
            dst[162] = (0b10100010, new byte[]{0,1,0,0,0,1,0,1}, new char[]{'0','1','0','0','0','1','0','1'}, "10100010");
            dst[163] = (0b10100011, new byte[]{1,1,0,0,0,1,0,1}, new char[]{'1','1','0','0','0','1','0','1'}, "10100011");
            dst[164] = (0b10100100, new byte[]{0,0,1,0,0,1,0,1}, new char[]{'0','0','1','0','0','1','0','1'}, "10100100");
            dst[165] = (0b10100101, new byte[]{1,0,1,0,0,1,0,1}, new char[]{'1','0','1','0','0','1','0','1'}, "10100101");
            dst[166] = (0b10100110, new byte[]{0,1,1,0,0,1,0,1}, new char[]{'0','1','1','0','0','1','0','1'}, "10100110");
            dst[167] = (0b10100111, new byte[]{1,1,1,0,0,1,0,1}, new char[]{'1','1','1','0','0','1','0','1'}, "10100111");
            dst[168] = (0b10101000, new byte[]{0,0,0,1,0,1,0,1}, new char[]{'0','0','0','1','0','1','0','1'}, "10101000");
            dst[169] = (0b10101001, new byte[]{1,0,0,1,0,1,0,1}, new char[]{'1','0','0','1','0','1','0','1'}, "10101001");
            dst[170] = (0b10101010, new byte[]{0,1,0,1,0,1,0,1}, new char[]{'0','1','0','1','0','1','0','1'}, "10101010");
            dst[171] = (0b10101011, new byte[]{1,1,0,1,0,1,0,1}, new char[]{'1','1','0','1','0','1','0','1'}, "10101011");
            dst[172] = (0b10101100, new byte[]{0,0,1,1,0,1,0,1}, new char[]{'0','0','1','1','0','1','0','1'}, "10101100");
            dst[173] = (0b10101101, new byte[]{1,0,1,1,0,1,0,1}, new char[]{'1','0','1','1','0','1','0','1'}, "10101101");
            dst[174] = (0b10101110, new byte[]{0,1,1,1,0,1,0,1}, new char[]{'0','1','1','1','0','1','0','1'}, "10101110");
            dst[175] = (0b10101111, new byte[]{1,1,1,1,0,1,0,1}, new char[]{'1','1','1','1','0','1','0','1'}, "10101111");
            dst[176] = (0b10110000, new byte[]{0,0,0,0,1,1,0,1}, new char[]{'0','0','0','0','1','1','0','1'}, "10110000");
            dst[177] = (0b10110001, new byte[]{1,0,0,0,1,1,0,1}, new char[]{'1','0','0','0','1','1','0','1'}, "10110001");
            dst[178] = (0b10110010, new byte[]{0,1,0,0,1,1,0,1}, new char[]{'0','1','0','0','1','1','0','1'}, "10110010");
            dst[179] = (0b10110011, new byte[]{1,1,0,0,1,1,0,1}, new char[]{'1','1','0','0','1','1','0','1'}, "10110011");
            dst[180] = (0b10110100, new byte[]{0,0,1,0,1,1,0,1}, new char[]{'0','0','1','0','1','1','0','1'}, "10110100");
            dst[181] = (0b10110101, new byte[]{1,0,1,0,1,1,0,1}, new char[]{'1','0','1','0','1','1','0','1'}, "10110101");
            dst[182] = (0b10110110, new byte[]{0,1,1,0,1,1,0,1}, new char[]{'0','1','1','0','1','1','0','1'}, "10110110");
            dst[183] = (0b10110111, new byte[]{1,1,1,0,1,1,0,1}, new char[]{'1','1','1','0','1','1','0','1'}, "10110111");
            dst[184] = (0b10111000, new byte[]{0,0,0,1,1,1,0,1}, new char[]{'0','0','0','1','1','1','0','1'}, "10111000");
            dst[185] = (0b10111001, new byte[]{1,0,0,1,1,1,0,1}, new char[]{'1','0','0','1','1','1','0','1'}, "10111001");
            dst[186] = (0b10111010, new byte[]{0,1,0,1,1,1,0,1}, new char[]{'0','1','0','1','1','1','0','1'}, "10111010");
            dst[187] = (0b10111011, new byte[]{1,1,0,1,1,1,0,1}, new char[]{'1','1','0','1','1','1','0','1'}, "10111011");
            dst[188] = (0b10111100, new byte[]{0,0,1,1,1,1,0,1}, new char[]{'0','0','1','1','1','1','0','1'}, "10111100");
            dst[189] = (0b10111101, new byte[]{1,0,1,1,1,1,0,1}, new char[]{'1','0','1','1','1','1','0','1'}, "10111101");
            dst[190] = (0b10111110, new byte[]{0,1,1,1,1,1,0,1}, new char[]{'0','1','1','1','1','1','0','1'}, "10111110");
            dst[191] = (0b10111111, new byte[]{1,1,1,1,1,1,0,1}, new char[]{'1','1','1','1','1','1','0','1'}, "10111111");
            dst[192] = (0b11000000, new byte[]{0,0,0,0,0,0,1,1}, new char[]{'0','0','0','0','0','0','1','1'}, "11000000");
            dst[193] = (0b11000001, new byte[]{1,0,0,0,0,0,1,1}, new char[]{'1','0','0','0','0','0','1','1'}, "11000001");
            dst[194] = (0b11000010, new byte[]{0,1,0,0,0,0,1,1}, new char[]{'0','1','0','0','0','0','1','1'}, "11000010");
            dst[195] = (0b11000011, new byte[]{1,1,0,0,0,0,1,1}, new char[]{'1','1','0','0','0','0','1','1'}, "11000011");
            dst[196] = (0b11000100, new byte[]{0,0,1,0,0,0,1,1}, new char[]{'0','0','1','0','0','0','1','1'}, "11000100");
            dst[197] = (0b11000101, new byte[]{1,0,1,0,0,0,1,1}, new char[]{'1','0','1','0','0','0','1','1'}, "11000101");
            dst[198] = (0b11000110, new byte[]{0,1,1,0,0,0,1,1}, new char[]{'0','1','1','0','0','0','1','1'}, "11000110");
            dst[199] = (0b11000111, new byte[]{1,1,1,0,0,0,1,1}, new char[]{'1','1','1','0','0','0','1','1'}, "11000111");
            dst[200] = (0b11001000, new byte[]{0,0,0,1,0,0,1,1}, new char[]{'0','0','0','1','0','0','1','1'}, "11001000");
            dst[201] = (0b11001001, new byte[]{1,0,0,1,0,0,1,1}, new char[]{'1','0','0','1','0','0','1','1'}, "11001001");
            dst[202] = (0b11001010, new byte[]{0,1,0,1,0,0,1,1}, new char[]{'0','1','0','1','0','0','1','1'}, "11001010");
            dst[203] = (0b11001011, new byte[]{1,1,0,1,0,0,1,1}, new char[]{'1','1','0','1','0','0','1','1'}, "11001011");
            dst[204] = (0b11001100, new byte[]{0,0,1,1,0,0,1,1}, new char[]{'0','0','1','1','0','0','1','1'}, "11001100");
            dst[205] = (0b11001101, new byte[]{1,0,1,1,0,0,1,1}, new char[]{'1','0','1','1','0','0','1','1'}, "11001101");
            dst[206] = (0b11001110, new byte[]{0,1,1,1,0,0,1,1}, new char[]{'0','1','1','1','0','0','1','1'}, "11001110");
            dst[207] = (0b11001111, new byte[]{1,1,1,1,0,0,1,1}, new char[]{'1','1','1','1','0','0','1','1'}, "11001111");
            dst[208] = (0b11010000, new byte[]{0,0,0,0,1,0,1,1}, new char[]{'0','0','0','0','1','0','1','1'}, "11010000");
            dst[209] = (0b11010001, new byte[]{1,0,0,0,1,0,1,1}, new char[]{'1','0','0','0','1','0','1','1'}, "11010001");
            dst[210] = (0b11010010, new byte[]{0,1,0,0,1,0,1,1}, new char[]{'0','1','0','0','1','0','1','1'}, "11010010");
            dst[211] = (0b11010011, new byte[]{1,1,0,0,1,0,1,1}, new char[]{'1','1','0','0','1','0','1','1'}, "11010011");
            dst[212] = (0b11010100, new byte[]{0,0,1,0,1,0,1,1}, new char[]{'0','0','1','0','1','0','1','1'}, "11010100");
            dst[213] = (0b11010101, new byte[]{1,0,1,0,1,0,1,1}, new char[]{'1','0','1','0','1','0','1','1'}, "11010101");
            dst[214] = (0b11010110, new byte[]{0,1,1,0,1,0,1,1}, new char[]{'0','1','1','0','1','0','1','1'}, "11010110");
            dst[215] = (0b11010111, new byte[]{1,1,1,0,1,0,1,1}, new char[]{'1','1','1','0','1','0','1','1'}, "11010111");
            dst[216] = (0b11011000, new byte[]{0,0,0,1,1,0,1,1}, new char[]{'0','0','0','1','1','0','1','1'}, "11011000");
            dst[217] = (0b11011001, new byte[]{1,0,0,1,1,0,1,1}, new char[]{'1','0','0','1','1','0','1','1'}, "11011001");
            dst[218] = (0b11011010, new byte[]{0,1,0,1,1,0,1,1}, new char[]{'0','1','0','1','1','0','1','1'}, "11011010");
            dst[219] = (0b11011011, new byte[]{1,1,0,1,1,0,1,1}, new char[]{'1','1','0','1','1','0','1','1'}, "11011011");
            dst[220] = (0b11011100, new byte[]{0,0,1,1,1,0,1,1}, new char[]{'0','0','1','1','1','0','1','1'}, "11011100");
            dst[221] = (0b11011101, new byte[]{1,0,1,1,1,0,1,1}, new char[]{'1','0','1','1','1','0','1','1'}, "11011101");
            dst[222] = (0b11011110, new byte[]{0,1,1,1,1,0,1,1}, new char[]{'0','1','1','1','1','0','1','1'}, "11011110");
            dst[223] = (0b11011111, new byte[]{1,1,1,1,1,0,1,1}, new char[]{'1','1','1','1','1','0','1','1'}, "11011111");
            dst[224] = (0b11100000, new byte[]{0,0,0,0,0,1,1,1}, new char[]{'0','0','0','0','0','1','1','1'}, "11100000");
            dst[225] = (0b11100001, new byte[]{1,0,0,0,0,1,1,1}, new char[]{'1','0','0','0','0','1','1','1'}, "11100001");
            dst[226] = (0b11100010, new byte[]{0,1,0,0,0,1,1,1}, new char[]{'0','1','0','0','0','1','1','1'}, "11100010");
            dst[227] = (0b11100011, new byte[]{1,1,0,0,0,1,1,1}, new char[]{'1','1','0','0','0','1','1','1'}, "11100011");
            dst[228] = (0b11100100, new byte[]{0,0,1,0,0,1,1,1}, new char[]{'0','0','1','0','0','1','1','1'}, "11100100");
            dst[229] = (0b11100101, new byte[]{1,0,1,0,0,1,1,1}, new char[]{'1','0','1','0','0','1','1','1'}, "11100101");
            dst[230] = (0b11100110, new byte[]{0,1,1,0,0,1,1,1}, new char[]{'0','1','1','0','0','1','1','1'}, "11100110");
            dst[231] = (0b11100111, new byte[]{1,1,1,0,0,1,1,1}, new char[]{'1','1','1','0','0','1','1','1'}, "11100111");
            dst[232] = (0b11101000, new byte[]{0,0,0,1,0,1,1,1}, new char[]{'0','0','0','1','0','1','1','1'}, "11101000");
            dst[233] = (0b11101001, new byte[]{1,0,0,1,0,1,1,1}, new char[]{'1','0','0','1','0','1','1','1'}, "11101001");
            dst[234] = (0b11101010, new byte[]{0,1,0,1,0,1,1,1}, new char[]{'0','1','0','1','0','1','1','1'}, "11101010");
            dst[235] = (0b11101011, new byte[]{1,1,0,1,0,1,1,1}, new char[]{'1','1','0','1','0','1','1','1'}, "11101011");
            dst[236] = (0b11101100, new byte[]{0,0,1,1,0,1,1,1}, new char[]{'0','0','1','1','0','1','1','1'}, "11101100");
            dst[237] = (0b11101101, new byte[]{1,0,1,1,0,1,1,1}, new char[]{'1','0','1','1','0','1','1','1'}, "11101101");
            dst[238] = (0b11101110, new byte[]{0,1,1,1,0,1,1,1}, new char[]{'0','1','1','1','0','1','1','1'}, "11101110");
            dst[239] = (0b11101111, new byte[]{1,1,1,1,0,1,1,1}, new char[]{'1','1','1','1','0','1','1','1'}, "11101111");
            dst[240] = (0b11110000, new byte[]{0,0,0,0,1,1,1,1}, new char[]{'0','0','0','0','1','1','1','1'}, "11110000");
            dst[241] = (0b11110001, new byte[]{1,0,0,0,1,1,1,1}, new char[]{'1','0','0','0','1','1','1','1'}, "11110001");
            dst[242] = (0b11110010, new byte[]{0,1,0,0,1,1,1,1}, new char[]{'0','1','0','0','1','1','1','1'}, "11110010");
            dst[243] = (0b11110011, new byte[]{1,1,0,0,1,1,1,1}, new char[]{'1','1','0','0','1','1','1','1'}, "11110011");
            dst[244] = (0b11110100, new byte[]{0,0,1,0,1,1,1,1}, new char[]{'0','0','1','0','1','1','1','1'}, "11110100");
            dst[245] = (0b11110101, new byte[]{1,0,1,0,1,1,1,1}, new char[]{'1','0','1','0','1','1','1','1'}, "11110101");
            dst[246] = (0b11110110, new byte[]{0,1,1,0,1,1,1,1}, new char[]{'0','1','1','0','1','1','1','1'}, "11110110");
            dst[247] = (0b11110111, new byte[]{1,1,1,0,1,1,1,1}, new char[]{'1','1','1','0','1','1','1','1'}, "11110111");
            dst[248] = (0b11111000, new byte[]{0,0,0,1,1,1,1,1}, new char[]{'0','0','0','1','1','1','1','1'}, "11111000");
            dst[249] = (0b11111001, new byte[]{1,0,0,1,1,1,1,1}, new char[]{'1','0','0','1','1','1','1','1'}, "11111001");
            dst[250] = (0b11111010, new byte[]{0,1,0,1,1,1,1,1}, new char[]{'0','1','0','1','1','1','1','1'}, "11111010");
            dst[251] = (0b11111011, new byte[]{1,1,0,1,1,1,1,1}, new char[]{'1','1','0','1','1','1','1','1'}, "11111011");
            dst[252] = (0b11111100, new byte[]{0,0,1,1,1,1,1,1}, new char[]{'0','0','1','1','1','1','1','1'}, "11111100");
            dst[253] = (0b11111101, new byte[]{1,0,1,1,1,1,1,1}, new char[]{'1','0','1','1','1','1','1','1'}, "11111101");
            dst[254] = (0b11111110, new byte[]{0,1,1,1,1,1,1,1}, new char[]{'0','1','1','1','1','1','1','1'}, "11111110");
            dst[255] = (0b11111111, new byte[]{1,1,1,1,1,1,1,1}, new char[]{'1','1','1','1','1','1','1','1'}, "11111111");
            return dst;
        }


        static (sbyte index, sbyte[] bitseq, char[] bitchars, string text)[] DefineI8Index()
        {
            var dst = new (sbyte index, sbyte[] bitseq, char[] bitchars, string text)[256];
            dst[0] =   (-0b0000000, new sbyte[]{0,0,0,0,0,0,0,1}, new char[]{'0','0','0','0','0','0','0','1'}, "10000000");
            dst[1] =   (-0b0000001, new sbyte[]{1,0,0,0,0,0,0,1}, new char[]{'1','0','0','0','0','0','0','1'}, "10000001");
            dst[2] =   (-0b0000010, new sbyte[]{0,1,0,0,0,0,0,1}, new char[]{'0','1','0','0','0','0','0','1'}, "10000010");
            dst[3] =   (-0b0000011, new sbyte[]{1,1,0,0,0,0,0,1}, new char[]{'1','1','0','0','0','0','0','1'}, "10000011");
            dst[4] =   (-0b0000100, new sbyte[]{0,0,1,0,0,0,0,1}, new char[]{'0','0','1','0','0','0','0','1'}, "10000100");
            dst[5] =   (-0b0000101, new sbyte[]{1,0,1,0,0,0,0,1}, new char[]{'1','0','1','0','0','0','0','1'}, "10000101");
            dst[6] =   (-0b0000110, new sbyte[]{0,1,1,0,0,0,0,1}, new char[]{'0','1','1','0','0','0','0','1'}, "10000110");
            dst[7] =   (-0b0000111, new sbyte[]{1,1,1,0,0,0,0,1}, new char[]{'1','1','1','0','0','0','0','1'}, "10000111");
            dst[8] =   (-0b0001000, new sbyte[]{0,0,0,1,0,0,0,1}, new char[]{'0','0','0','1','0','0','0','1'}, "10001000");
            dst[9] =   (-0b0001001, new sbyte[]{1,0,0,1,0,0,0,1}, new char[]{'1','0','0','1','0','0','0','1'}, "10001001");
            dst[10] =  (-0b0001010, new sbyte[]{0,1,0,1,0,0,0,1}, new char[]{'0','1','0','1','0','0','0','1'}, "10001010");
            dst[11] =  (-0b0001011, new sbyte[]{1,1,0,1,0,0,0,1}, new char[]{'1','1','0','1','0','0','0','1'}, "10001011");
            dst[12] =  (-0b0001100, new sbyte[]{0,0,1,1,0,0,0,1}, new char[]{'0','0','1','1','0','0','0','1'}, "10001100");
            dst[13] =  (-0b0001101, new sbyte[]{1,0,1,1,0,0,0,1}, new char[]{'1','0','1','1','0','0','0','1'}, "10001101");
            dst[14] =  (-0b0001110, new sbyte[]{0,1,1,1,0,0,0,1}, new char[]{'0','1','1','1','0','0','0','1'}, "10001110");
            dst[15] =  (-0b0001111, new sbyte[]{1,1,1,1,0,0,0,1}, new char[]{'1','1','1','1','0','0','0','1'}, "10001111");
            dst[16] =  (-0b0010000, new sbyte[]{0,0,0,0,1,0,0,1}, new char[]{'0','0','0','0','1','0','0','1'}, "10010000");
            dst[17] =  (-0b0010001, new sbyte[]{1,0,0,0,1,0,0,1}, new char[]{'1','0','0','0','1','0','0','1'}, "10010001");
            dst[18] =  (-0b0010010, new sbyte[]{0,1,0,0,1,0,0,1}, new char[]{'0','1','0','0','1','0','0','1'}, "10010010");
            dst[19] =  (-0b0010011, new sbyte[]{1,1,0,0,1,0,0,1}, new char[]{'1','1','0','0','1','0','0','1'}, "10010011");
            dst[20] =  (-0b0010100, new sbyte[]{0,0,1,0,1,0,0,1}, new char[]{'0','0','1','0','1','0','0','1'}, "10010100");
            dst[21] =  (-0b0010101, new sbyte[]{1,0,1,0,1,0,0,1}, new char[]{'1','0','1','0','1','0','0','1'}, "10010101");
            dst[22] =  (-0b0010110, new sbyte[]{0,1,1,0,1,0,0,1}, new char[]{'0','1','1','0','1','0','0','1'}, "10010110");
            dst[23] =  (-0b0010111, new sbyte[]{1,1,1,0,1,0,0,1}, new char[]{'1','1','1','0','1','0','0','1'}, "10010111");
            dst[24] =  (-0b0011000, new sbyte[]{0,0,0,1,1,0,0,1}, new char[]{'0','0','0','1','1','0','0','1'}, "10011000");
            dst[25] =  (-0b0011001, new sbyte[]{1,0,0,1,1,0,0,1}, new char[]{'1','0','0','1','1','0','0','1'}, "10011001");
            dst[26] =  (-0b0011010, new sbyte[]{0,1,0,1,1,0,0,1}, new char[]{'0','1','0','1','1','0','0','1'}, "10011010");
            dst[27] =  (-0b0011011, new sbyte[]{1,1,0,1,1,0,0,1}, new char[]{'1','1','0','1','1','0','0','1'}, "10011011");
            dst[28] =  (-0b0011100, new sbyte[]{0,0,1,1,1,0,0,1}, new char[]{'0','0','1','1','1','0','0','1'}, "10011100");
            dst[29] =  (-0b0011101, new sbyte[]{1,0,1,1,1,0,0,1}, new char[]{'1','0','1','1','1','0','0','1'}, "10011101");
            dst[30] =  (-0b0011110, new sbyte[]{0,1,1,1,1,0,0,1}, new char[]{'0','1','1','1','1','0','0','1'}, "10011110");
            dst[31] =  (-0b0011111, new sbyte[]{1,1,1,1,1,0,0,1}, new char[]{'1','1','1','1','1','0','0','1'}, "10011111");
            dst[32] =  (-0b0100000, new sbyte[]{0,0,0,0,0,1,0,1}, new char[]{'0','0','0','0','0','1','0','1'}, "10100000");
            dst[33] =  (-0b0100001, new sbyte[]{1,0,0,0,0,1,0,1}, new char[]{'1','0','0','0','0','1','0','1'}, "10100001");
            dst[34] =  (-0b0100010, new sbyte[]{0,1,0,0,0,1,0,1}, new char[]{'0','1','0','0','0','1','0','1'}, "10100010");
            dst[35] =  (-0b0100011, new sbyte[]{1,1,0,0,0,1,0,1}, new char[]{'1','1','0','0','0','1','0','1'}, "10100011");
            dst[36] =  (-0b0100100, new sbyte[]{0,0,1,0,0,1,0,1}, new char[]{'0','0','1','0','0','1','0','1'}, "10100100");
            dst[37] =  (-0b0100101, new sbyte[]{1,0,1,0,0,1,0,1}, new char[]{'1','0','1','0','0','1','0','1'}, "10100101");
            dst[38] =  (-0b0100110, new sbyte[]{0,1,1,0,0,1,0,1}, new char[]{'0','1','1','0','0','1','0','1'}, "10100110");
            dst[39] =  (-0b0100111, new sbyte[]{1,1,1,0,0,1,0,1}, new char[]{'1','1','1','0','0','1','0','1'}, "10100111");
            dst[40] =  (-0b0101000, new sbyte[]{0,0,0,1,0,1,0,1}, new char[]{'0','0','0','1','0','1','0','1'}, "10101000");
            dst[41] =  (-0b0101001, new sbyte[]{1,0,0,1,0,1,0,1}, new char[]{'1','0','0','1','0','1','0','1'}, "10101001");
            dst[42] =  (-0b0101010, new sbyte[]{0,1,0,1,0,1,0,1}, new char[]{'0','1','0','1','0','1','0','1'}, "10101010");
            dst[43] =  (-0b0101011, new sbyte[]{1,1,0,1,0,1,0,1}, new char[]{'1','1','0','1','0','1','0','1'}, "10101011");
            dst[44] =  (-0b0101100, new sbyte[]{0,0,1,1,0,1,0,1}, new char[]{'0','0','1','1','0','1','0','1'}, "10101100");
            dst[45] =  (-0b0101101, new sbyte[]{1,0,1,1,0,1,0,1}, new char[]{'1','0','1','1','0','1','0','1'}, "10101101");
            dst[46] =  (-0b0101110, new sbyte[]{0,1,1,1,0,1,0,1}, new char[]{'0','1','1','1','0','1','0','1'}, "10101110");
            dst[47] =  (-0b0101111, new sbyte[]{1,1,1,1,0,1,0,1}, new char[]{'1','1','1','1','0','1','0','1'}, "10101111");
            dst[48] =  (-0b0110000, new sbyte[]{0,0,0,0,1,1,0,1}, new char[]{'0','0','0','0','1','1','0','1'}, "10110000");
            dst[49] =  (-0b0110001, new sbyte[]{1,0,0,0,1,1,0,1}, new char[]{'1','0','0','0','1','1','0','1'}, "10110001");
            dst[50] =  (-0b0110010, new sbyte[]{0,1,0,0,1,1,0,1}, new char[]{'0','1','0','0','1','1','0','1'}, "10110010");
            dst[51] =  (-0b0110011, new sbyte[]{1,1,0,0,1,1,0,1}, new char[]{'1','1','0','0','1','1','0','1'}, "10110011");
            dst[52] =  (-0b0110100, new sbyte[]{0,0,1,0,1,1,0,1}, new char[]{'0','0','1','0','1','1','0','1'}, "10110100");
            dst[53] =  (-0b0110101, new sbyte[]{1,0,1,0,1,1,0,1}, new char[]{'1','0','1','0','1','1','0','1'}, "10110101");
            dst[54] =  (-0b0110110, new sbyte[]{0,1,1,0,1,1,0,1}, new char[]{'0','1','1','0','1','1','0','1'}, "10110110");
            dst[55] =  (-0b0110111, new sbyte[]{1,1,1,0,1,1,0,1}, new char[]{'1','1','1','0','1','1','0','1'}, "10110111");
            dst[56] =  (-0b0111000, new sbyte[]{0,0,0,1,1,1,0,1}, new char[]{'0','0','0','1','1','1','0','1'}, "10111000");
            dst[57] =  (-0b0111001, new sbyte[]{1,0,0,1,1,1,0,1}, new char[]{'1','0','0','1','1','1','0','1'}, "10111001");
            dst[58] =  (-0b0111010, new sbyte[]{0,1,0,1,1,1,0,1}, new char[]{'0','1','0','1','1','1','0','1'}, "10111010");
            dst[59] =  (-0b0111011, new sbyte[]{1,1,0,1,1,1,0,1}, new char[]{'1','1','0','1','1','1','0','1'}, "10111011");
            dst[60] =  (-0b0111100, new sbyte[]{0,0,1,1,1,1,0,1}, new char[]{'0','0','1','1','1','1','0','1'}, "10111100");
            dst[61] =  (-0b0111101, new sbyte[]{1,0,1,1,1,1,0,1}, new char[]{'1','0','1','1','1','1','0','1'}, "10111101");
            dst[62] =  (-0b0111110, new sbyte[]{0,1,1,1,1,1,0,1}, new char[]{'0','1','1','1','1','1','0','1'}, "10111110");
            dst[63] =  (-0b0111111, new sbyte[]{1,1,1,1,1,1,0,1}, new char[]{'1','1','1','1','1','1','0','1'}, "10111111");
            dst[64] =  (-0b1000000, new sbyte[]{0,0,0,0,0,0,1,1}, new char[]{'0','0','0','0','0','0','1','1'}, "11000000");
            dst[65] =  (-0b1000001, new sbyte[]{1,0,0,0,0,0,1,1}, new char[]{'1','0','0','0','0','0','1','1'}, "11000001");
            dst[66] =  (-0b1000010, new sbyte[]{0,1,0,0,0,0,1,1}, new char[]{'0','1','0','0','0','0','1','1'}, "11000010");
            dst[67] =  (-0b1000011, new sbyte[]{1,1,0,0,0,0,1,1}, new char[]{'1','1','0','0','0','0','1','1'}, "11000011");
            dst[68] =  (-0b1000100, new sbyte[]{0,0,1,0,0,0,1,1}, new char[]{'0','0','1','0','0','0','1','1'}, "11000100");
            dst[69] =  (-0b1000101, new sbyte[]{1,0,1,0,0,0,1,1}, new char[]{'1','0','1','0','0','0','1','1'}, "11000101");
            dst[70] =  (-0b1000110, new sbyte[]{0,1,1,0,0,0,1,1}, new char[]{'0','1','1','0','0','0','1','1'}, "11000110");
            dst[71] =  (-0b1000111, new sbyte[]{1,1,1,0,0,0,1,1}, new char[]{'1','1','1','0','0','0','1','1'}, "11000111");
            dst[72] =  (-0b1001000, new sbyte[]{0,0,0,1,0,0,1,1}, new char[]{'0','0','0','1','0','0','1','1'}, "11001000");
            dst[73] =  (-0b1001001, new sbyte[]{1,0,0,1,0,0,1,1}, new char[]{'1','0','0','1','0','0','1','1'}, "11001001");
            dst[74] =  (-0b1001010, new sbyte[]{0,1,0,1,0,0,1,1}, new char[]{'0','1','0','1','0','0','1','1'}, "11001010");
            dst[75] =  (-0b1001011, new sbyte[]{1,1,0,1,0,0,1,1}, new char[]{'1','1','0','1','0','0','1','1'}, "11001011");
            dst[76] =  (-0b1001100, new sbyte[]{0,0,1,1,0,0,1,1}, new char[]{'0','0','1','1','0','0','1','1'}, "11001100");
            dst[77] =  (-0b1001101, new sbyte[]{1,0,1,1,0,0,1,1}, new char[]{'1','0','1','1','0','0','1','1'}, "11001101");
            dst[78] =  (-0b1001110, new sbyte[]{0,1,1,1,0,0,1,1}, new char[]{'0','1','1','1','0','0','1','1'}, "11001110");
            dst[79] =  (-0b1001111, new sbyte[]{1,1,1,1,0,0,1,1}, new char[]{'1','1','1','1','0','0','1','1'}, "11001111");
            dst[80] =  (-0b1010000, new sbyte[]{0,0,0,0,1,0,1,1}, new char[]{'0','0','0','0','1','0','1','1'}, "11010000");
            dst[81] =  (-0b1010001, new sbyte[]{1,0,0,0,1,0,1,1}, new char[]{'1','0','0','0','1','0','1','1'}, "11010001");
            dst[82] =  (-0b1010010, new sbyte[]{0,1,0,0,1,0,1,1}, new char[]{'0','1','0','0','1','0','1','1'}, "11010010");
            dst[83] =  (-0b1010011, new sbyte[]{1,1,0,0,1,0,1,1}, new char[]{'1','1','0','0','1','0','1','1'}, "11010011");
            dst[84] =  (-0b1010100, new sbyte[]{0,0,1,0,1,0,1,1}, new char[]{'0','0','1','0','1','0','1','1'}, "11010100");
            dst[85] =  (-0b1010101, new sbyte[]{1,0,1,0,1,0,1,1}, new char[]{'1','0','1','0','1','0','1','1'}, "11010101");
            dst[86] =  (-0b1010110, new sbyte[]{0,1,1,0,1,0,1,1}, new char[]{'0','1','1','0','1','0','1','1'}, "11010110");
            dst[87] =  (-0b1010111, new sbyte[]{1,1,1,0,1,0,1,1}, new char[]{'1','1','1','0','1','0','1','1'}, "11010111");
            dst[88] =  (-0b1011000, new sbyte[]{0,0,0,1,1,0,1,1}, new char[]{'0','0','0','1','1','0','1','1'}, "11011000");
            dst[89] =  (-0b1011001, new sbyte[]{1,0,0,1,1,0,1,1}, new char[]{'1','0','0','1','1','0','1','1'}, "11011001");
            dst[90] =  (-0b1011010, new sbyte[]{0,1,0,1,1,0,1,1}, new char[]{'0','1','0','1','1','0','1','1'}, "11011010");
            dst[91] =  (-0b1011011, new sbyte[]{1,1,0,1,1,0,1,1}, new char[]{'1','1','0','1','1','0','1','1'}, "11011011");
            dst[92] =  (-0b1011100, new sbyte[]{0,0,1,1,1,0,1,1}, new char[]{'0','0','1','1','1','0','1','1'}, "11011100");
            dst[93] =  (-0b1011101, new sbyte[]{1,0,1,1,1,0,1,1}, new char[]{'1','0','1','1','1','0','1','1'}, "11011101");
            dst[94] =  (-0b1011110, new sbyte[]{0,1,1,1,1,0,1,1}, new char[]{'0','1','1','1','1','0','1','1'}, "11011110");
            dst[95] =  (-0b1011111, new sbyte[]{1,1,1,1,1,0,1,1}, new char[]{'1','1','1','1','1','0','1','1'}, "11011111");
            dst[96] =  (-0b1100000, new sbyte[]{0,0,0,0,0,1,1,1}, new char[]{'0','0','0','0','0','1','1','1'}, "11100000");
            dst[97] =  (-0b1100001, new sbyte[]{1,0,0,0,0,1,1,1}, new char[]{'1','0','0','0','0','1','1','1'}, "11100001");
            dst[98] =  (-0b1100010, new sbyte[]{0,1,0,0,0,1,1,1}, new char[]{'0','1','0','0','0','1','1','1'}, "11100010");
            dst[99] =  (-0b1100011, new sbyte[]{1,1,0,0,0,1,1,1}, new char[]{'1','1','0','0','0','1','1','1'}, "11100011");
            dst[100] = (-0b1100100, new sbyte[]{0,0,1,0,0,1,1,1}, new char[]{'0','0','1','0','0','1','1','1'}, "11100100");
            dst[101] = (-0b1100101, new sbyte[]{1,0,1,0,0,1,1,1}, new char[]{'1','0','1','0','0','1','1','1'}, "11100101");
            dst[102] = (-0b1100110, new sbyte[]{0,1,1,0,0,1,1,1}, new char[]{'0','1','1','0','0','1','1','1'}, "11100110");
            dst[103] = (-0b1100111, new sbyte[]{1,1,1,0,0,1,1,1}, new char[]{'1','1','1','0','0','1','1','1'}, "11100111");
            dst[104] = (-0b1101000, new sbyte[]{0,0,0,1,0,1,1,1}, new char[]{'0','0','0','1','0','1','1','1'}, "11101000");
            dst[105] = (-0b1101001, new sbyte[]{1,0,0,1,0,1,1,1}, new char[]{'1','0','0','1','0','1','1','1'}, "11101001");
            dst[106] = (-0b1101010, new sbyte[]{0,1,0,1,0,1,1,1}, new char[]{'0','1','0','1','0','1','1','1'}, "11101010");
            dst[107] = (-0b1101011, new sbyte[]{1,1,0,1,0,1,1,1}, new char[]{'1','1','0','1','0','1','1','1'}, "11101011");
            dst[108] = (-0b1101100, new sbyte[]{0,0,1,1,0,1,1,1}, new char[]{'0','0','1','1','0','1','1','1'}, "11101100");
            dst[109] = (-0b1101101, new sbyte[]{1,0,1,1,0,1,1,1}, new char[]{'1','0','1','1','0','1','1','1'}, "11101101");
            dst[110] = (-0b1101110, new sbyte[]{0,1,1,1,0,1,1,1}, new char[]{'0','1','1','1','0','1','1','1'}, "11101110");
            dst[111] = (-0b1101111, new sbyte[]{1,1,1,1,0,1,1,1}, new char[]{'1','1','1','1','0','1','1','1'}, "11101111");
            dst[112] = (-0b1110000, new sbyte[]{0,0,0,0,1,1,1,1}, new char[]{'0','0','0','0','1','1','1','1'}, "11110000");
            dst[113] = (-0b1110001, new sbyte[]{1,0,0,0,1,1,1,1}, new char[]{'1','0','0','0','1','1','1','1'}, "11110001");
            dst[114] = (-0b1110010, new sbyte[]{0,1,0,0,1,1,1,1}, new char[]{'0','1','0','0','1','1','1','1'}, "11110010");
            dst[115] = (-0b1110011, new sbyte[]{1,1,0,0,1,1,1,1}, new char[]{'1','1','0','0','1','1','1','1'}, "11110011");
            dst[116] = (-0b1110100, new sbyte[]{0,0,1,0,1,1,1,1}, new char[]{'0','0','1','0','1','1','1','1'}, "11110100");
            dst[117] = (-0b1110101, new sbyte[]{1,0,1,0,1,1,1,1}, new char[]{'1','0','1','0','1','1','1','1'}, "11110101");
            dst[118] = (-0b1110110, new sbyte[]{0,1,1,0,1,1,1,1}, new char[]{'0','1','1','0','1','1','1','1'}, "11110110");
            dst[119] = (-0b1110111, new sbyte[]{1,1,1,0,1,1,1,1}, new char[]{'1','1','1','0','1','1','1','1'}, "11110111");
            dst[120] = (-0b1111000, new sbyte[]{0,0,0,1,1,1,1,1}, new char[]{'0','0','0','1','1','1','1','1'}, "11111000");
            dst[121] = (-0b1111001, new sbyte[]{1,0,0,1,1,1,1,1}, new char[]{'1','0','0','1','1','1','1','1'}, "11111001");
            dst[122] = (-0b1111010, new sbyte[]{0,1,0,1,1,1,1,1}, new char[]{'0','1','0','1','1','1','1','1'}, "11111010");
            dst[123] = (-0b1111011, new sbyte[]{1,1,0,1,1,1,1,1}, new char[]{'1','1','0','1','1','1','1','1'}, "11111011");
            dst[124] = (-0b1111100, new sbyte[]{0,0,1,1,1,1,1,1}, new char[]{'0','0','1','1','1','1','1','1'}, "11111100");
            dst[125] = (-0b1111101, new sbyte[]{1,0,1,1,1,1,1,1}, new char[]{'1','0','1','1','1','1','1','1'}, "11111101");
            dst[126] = (-0b1111110, new sbyte[]{0,1,1,1,1,1,1,1}, new char[]{'0','1','1','1','1','1','1','1'}, "11111110");
            dst[127] = (-0b1111111, new sbyte[]{1,1,1,1,1,1,1,1}, new char[]{'1','1','1','1','1','1','1','1'}, "11111111");
            dst[128] = (0b00000000, new sbyte[]{0,0,0,0,0,0,0,0}, new char[]{'0','0','0','0','0','0','0','0'}, "00000000");
            dst[129] = (0b00000001, new sbyte[]{1,0,0,0,0,0,0,0}, new char[]{'1','0','0','0','0','0','0','0'}, "00000001");
            dst[130] = (0b00000010, new sbyte[]{0,1,0,0,0,0,0,0}, new char[]{'0','1','0','0','0','0','0','0'}, "00000010");
            dst[131] = (0b00000011, new sbyte[]{1,1,0,0,0,0,0,0}, new char[]{'1','1','0','0','0','0','0','0'}, "00000011");
            dst[132] = (0b00000100, new sbyte[]{0,0,1,0,0,0,0,0}, new char[]{'0','0','1','0','0','0','0','0'}, "00000100");
            dst[133] = (0b00000101, new sbyte[]{1,0,1,0,0,0,0,0}, new char[]{'1','0','1','0','0','0','0','0'}, "00000101");
            dst[134] = (0b00000110, new sbyte[]{0,1,1,0,0,0,0,0}, new char[]{'0','1','1','0','0','0','0','0'}, "00000110");
            dst[135] = (0b00000111, new sbyte[]{1,1,1,0,0,0,0,0}, new char[]{'1','1','1','0','0','0','0','0'}, "00000111");
            dst[136] = (0b00001000, new sbyte[]{0,0,0,1,0,0,0,0}, new char[]{'0','0','0','1','0','0','0','0'}, "00001000");
            dst[137] = (0b00001001, new sbyte[]{1,0,0,1,0,0,0,0}, new char[]{'1','0','0','1','0','0','0','0'}, "00001001");
            dst[138] = (0b00001010, new sbyte[]{0,1,0,1,0,0,0,0}, new char[]{'0','1','0','1','0','0','0','0'}, "00001010");
            dst[139] = (0b00001011, new sbyte[]{1,1,0,1,0,0,0,0}, new char[]{'1','1','0','1','0','0','0','0'}, "00001011");
            dst[140] = (0b00001100, new sbyte[]{0,0,1,1,0,0,0,0}, new char[]{'0','0','1','1','0','0','0','0'}, "00001100");
            dst[141] = (0b00001101, new sbyte[]{1,0,1,1,0,0,0,0}, new char[]{'1','0','1','1','0','0','0','0'}, "00001101");
            dst[142] = (0b00001110, new sbyte[]{0,1,1,1,0,0,0,0}, new char[]{'0','1','1','1','0','0','0','0'}, "00001110");
            dst[143] = (0b00001111, new sbyte[]{1,1,1,1,0,0,0,0}, new char[]{'1','1','1','1','0','0','0','0'}, "00001111");
            dst[144] = (0b00010000, new sbyte[]{0,0,0,0,1,0,0,0}, new char[]{'0','0','0','0','1','0','0','0'}, "00010000");
            dst[145] = (0b00010001, new sbyte[]{1,0,0,0,1,0,0,0}, new char[]{'1','0','0','0','1','0','0','0'}, "00010001");
            dst[146] = (0b00010010, new sbyte[]{0,1,0,0,1,0,0,0}, new char[]{'0','1','0','0','1','0','0','0'}, "00010010");
            dst[147] = (0b00010011, new sbyte[]{1,1,0,0,1,0,0,0}, new char[]{'1','1','0','0','1','0','0','0'}, "00010011");
            dst[148] = (0b00010100, new sbyte[]{0,0,1,0,1,0,0,0}, new char[]{'0','0','1','0','1','0','0','0'}, "00010100");
            dst[149] = (0b00010101, new sbyte[]{1,0,1,0,1,0,0,0}, new char[]{'1','0','1','0','1','0','0','0'}, "00010101");
            dst[150] = (0b00010110, new sbyte[]{0,1,1,0,1,0,0,0}, new char[]{'0','1','1','0','1','0','0','0'}, "00010110");
            dst[151] = (0b00010111, new sbyte[]{1,1,1,0,1,0,0,0}, new char[]{'1','1','1','0','1','0','0','0'}, "00010111");
            dst[152] = (0b00011000, new sbyte[]{0,0,0,1,1,0,0,0}, new char[]{'0','0','0','1','1','0','0','0'}, "00011000");
            dst[153] = (0b00011001, new sbyte[]{1,0,0,1,1,0,0,0}, new char[]{'1','0','0','1','1','0','0','0'}, "00011001");
            dst[154] = (0b00011010, new sbyte[]{0,1,0,1,1,0,0,0}, new char[]{'0','1','0','1','1','0','0','0'}, "00011010");
            dst[155] = (0b00011011, new sbyte[]{1,1,0,1,1,0,0,0}, new char[]{'1','1','0','1','1','0','0','0'}, "00011011");
            dst[156] = (0b00011100, new sbyte[]{0,0,1,1,1,0,0,0}, new char[]{'0','0','1','1','1','0','0','0'}, "00011100");
            dst[157] = (0b00011101, new sbyte[]{1,0,1,1,1,0,0,0}, new char[]{'1','0','1','1','1','0','0','0'}, "00011101");
            dst[158] = (0b00011110, new sbyte[]{0,1,1,1,1,0,0,0}, new char[]{'0','1','1','1','1','0','0','0'}, "00011110");
            dst[159] = (0b00011111, new sbyte[]{1,1,1,1,1,0,0,0}, new char[]{'1','1','1','1','1','0','0','0'}, "00011111");
            dst[160] = (0b00100000, new sbyte[]{0,0,0,0,0,1,0,0}, new char[]{'0','0','0','0','0','1','0','0'}, "00100000");
            dst[161] = (0b00100001, new sbyte[]{1,0,0,0,0,1,0,0}, new char[]{'1','0','0','0','0','1','0','0'}, "00100001");
            dst[162] = (0b00100010, new sbyte[]{0,1,0,0,0,1,0,0}, new char[]{'0','1','0','0','0','1','0','0'}, "00100010");
            dst[163] = (0b00100011, new sbyte[]{1,1,0,0,0,1,0,0}, new char[]{'1','1','0','0','0','1','0','0'}, "00100011");
            dst[164] = (0b00100100, new sbyte[]{0,0,1,0,0,1,0,0}, new char[]{'0','0','1','0','0','1','0','0'}, "00100100");
            dst[165] = (0b00100101, new sbyte[]{1,0,1,0,0,1,0,0}, new char[]{'1','0','1','0','0','1','0','0'}, "00100101");
            dst[166] = (0b00100110, new sbyte[]{0,1,1,0,0,1,0,0}, new char[]{'0','1','1','0','0','1','0','0'}, "00100110");
            dst[167] = (0b00100111, new sbyte[]{1,1,1,0,0,1,0,0}, new char[]{'1','1','1','0','0','1','0','0'}, "00100111");
            dst[168] = (0b00101000, new sbyte[]{0,0,0,1,0,1,0,0}, new char[]{'0','0','0','1','0','1','0','0'}, "00101000");
            dst[169] = (0b00101001, new sbyte[]{1,0,0,1,0,1,0,0}, new char[]{'1','0','0','1','0','1','0','0'}, "00101001");
            dst[170] = (0b00101010, new sbyte[]{0,1,0,1,0,1,0,0}, new char[]{'0','1','0','1','0','1','0','0'}, "00101010");
            dst[171] = (0b00101011, new sbyte[]{1,1,0,1,0,1,0,0}, new char[]{'1','1','0','1','0','1','0','0'}, "00101011");
            dst[172] = (0b00101100, new sbyte[]{0,0,1,1,0,1,0,0}, new char[]{'0','0','1','1','0','1','0','0'}, "00101100");
            dst[173] = (0b00101101, new sbyte[]{1,0,1,1,0,1,0,0}, new char[]{'1','0','1','1','0','1','0','0'}, "00101101");
            dst[174] = (0b00101110, new sbyte[]{0,1,1,1,0,1,0,0}, new char[]{'0','1','1','1','0','1','0','0'}, "00101110");
            dst[175] = (0b00101111, new sbyte[]{1,1,1,1,0,1,0,0}, new char[]{'1','1','1','1','0','1','0','0'}, "00101111");
            dst[176] = (0b00110000, new sbyte[]{0,0,0,0,1,1,0,0}, new char[]{'0','0','0','0','1','1','0','0'}, "00110000");
            dst[177] = (0b00110001, new sbyte[]{1,0,0,0,1,1,0,0}, new char[]{'1','0','0','0','1','1','0','0'}, "00110001");
            dst[178] = (0b00110010, new sbyte[]{0,1,0,0,1,1,0,0}, new char[]{'0','1','0','0','1','1','0','0'}, "00110010");
            dst[179] = (0b00110011, new sbyte[]{1,1,0,0,1,1,0,0}, new char[]{'1','1','0','0','1','1','0','0'}, "00110011");
            dst[180] = (0b00110100, new sbyte[]{0,0,1,0,1,1,0,0}, new char[]{'0','0','1','0','1','1','0','0'}, "00110100");
            dst[181] = (0b00110101, new sbyte[]{1,0,1,0,1,1,0,0}, new char[]{'1','0','1','0','1','1','0','0'}, "00110101");
            dst[182] = (0b00110110, new sbyte[]{0,1,1,0,1,1,0,0}, new char[]{'0','1','1','0','1','1','0','0'}, "00110110");
            dst[183] = (0b00110111, new sbyte[]{1,1,1,0,1,1,0,0}, new char[]{'1','1','1','0','1','1','0','0'}, "00110111");
            dst[184] = (0b00111000, new sbyte[]{0,0,0,1,1,1,0,0}, new char[]{'0','0','0','1','1','1','0','0'}, "00111000");
            dst[185] = (0b00111001, new sbyte[]{1,0,0,1,1,1,0,0}, new char[]{'1','0','0','1','1','1','0','0'}, "00111001");
            dst[186] = (0b00111010, new sbyte[]{0,1,0,1,1,1,0,0}, new char[]{'0','1','0','1','1','1','0','0'}, "00111010");
            dst[187] = (0b00111011, new sbyte[]{1,1,0,1,1,1,0,0}, new char[]{'1','1','0','1','1','1','0','0'}, "00111011");
            dst[188] = (0b00111100, new sbyte[]{0,0,1,1,1,1,0,0}, new char[]{'0','0','1','1','1','1','0','0'}, "00111100");
            dst[189] = (0b00111101, new sbyte[]{1,0,1,1,1,1,0,0}, new char[]{'1','0','1','1','1','1','0','0'}, "00111101");
            dst[190] = (0b00111110, new sbyte[]{0,1,1,1,1,1,0,0}, new char[]{'0','1','1','1','1','1','0','0'}, "00111110");
            dst[191] = (0b00111111, new sbyte[]{1,1,1,1,1,1,0,0}, new char[]{'1','1','1','1','1','1','0','0'}, "00111111");
            dst[192] = (0b01000000, new sbyte[]{0,0,0,0,0,0,1,0}, new char[]{'0','0','0','0','0','0','1','0'}, "01000000");
            dst[193] = (0b01000001, new sbyte[]{1,0,0,0,0,0,1,0}, new char[]{'1','0','0','0','0','0','1','0'}, "01000001");
            dst[194] = (0b01000010, new sbyte[]{0,1,0,0,0,0,1,0}, new char[]{'0','1','0','0','0','0','1','0'}, "01000010");
            dst[195] = (0b01000011, new sbyte[]{1,1,0,0,0,0,1,0}, new char[]{'1','1','0','0','0','0','1','0'}, "01000011");
            dst[196] = (0b01000100, new sbyte[]{0,0,1,0,0,0,1,0}, new char[]{'0','0','1','0','0','0','1','0'}, "01000100");
            dst[197] = (0b01000101, new sbyte[]{1,0,1,0,0,0,1,0}, new char[]{'1','0','1','0','0','0','1','0'}, "01000101");
            dst[198] = (0b01000110, new sbyte[]{0,1,1,0,0,0,1,0}, new char[]{'0','1','1','0','0','0','1','0'}, "01000110");
            dst[199] = (0b01000111, new sbyte[]{1,1,1,0,0,0,1,0}, new char[]{'1','1','1','0','0','0','1','0'}, "01000111");
            dst[200] = (0b01001000, new sbyte[]{0,0,0,1,0,0,1,0}, new char[]{'0','0','0','1','0','0','1','0'}, "01001000");
            dst[201] = (0b01001001, new sbyte[]{1,0,0,1,0,0,1,0}, new char[]{'1','0','0','1','0','0','1','0'}, "01001001");
            dst[202] = (0b01001010, new sbyte[]{0,1,0,1,0,0,1,0}, new char[]{'0','1','0','1','0','0','1','0'}, "01001010");
            dst[203] = (0b01001011, new sbyte[]{1,1,0,1,0,0,1,0}, new char[]{'1','1','0','1','0','0','1','0'}, "01001011");
            dst[204] = (0b01001100, new sbyte[]{0,0,1,1,0,0,1,0}, new char[]{'0','0','1','1','0','0','1','0'}, "01001100");
            dst[205] = (0b01001101, new sbyte[]{1,0,1,1,0,0,1,0}, new char[]{'1','0','1','1','0','0','1','0'}, "01001101");
            dst[206] = (0b01001110, new sbyte[]{0,1,1,1,0,0,1,0}, new char[]{'0','1','1','1','0','0','1','0'}, "01001110");
            dst[207] = (0b01001111, new sbyte[]{1,1,1,1,0,0,1,0}, new char[]{'1','1','1','1','0','0','1','0'}, "01001111");
            dst[208] = (0b01010000, new sbyte[]{0,0,0,0,1,0,1,0}, new char[]{'0','0','0','0','1','0','1','0'}, "01010000");
            dst[209] = (0b01010001, new sbyte[]{1,0,0,0,1,0,1,0}, new char[]{'1','0','0','0','1','0','1','0'}, "01010001");
            dst[210] = (0b01010010, new sbyte[]{0,1,0,0,1,0,1,0}, new char[]{'0','1','0','0','1','0','1','0'}, "01010010");
            dst[211] = (0b01010011, new sbyte[]{1,1,0,0,1,0,1,0}, new char[]{'1','1','0','0','1','0','1','0'}, "01010011");
            dst[212] = (0b01010100, new sbyte[]{0,0,1,0,1,0,1,0}, new char[]{'0','0','1','0','1','0','1','0'}, "01010100");
            dst[213] = (0b01010101, new sbyte[]{1,0,1,0,1,0,1,0}, new char[]{'1','0','1','0','1','0','1','0'}, "01010101");
            dst[214] = (0b01010110, new sbyte[]{0,1,1,0,1,0,1,0}, new char[]{'0','1','1','0','1','0','1','0'}, "01010110");
            dst[215] = (0b01010111, new sbyte[]{1,1,1,0,1,0,1,0}, new char[]{'1','1','1','0','1','0','1','0'}, "01010111");
            dst[216] = (0b01011000, new sbyte[]{0,0,0,1,1,0,1,0}, new char[]{'0','0','0','1','1','0','1','0'}, "01011000");
            dst[217] = (0b01011001, new sbyte[]{1,0,0,1,1,0,1,0}, new char[]{'1','0','0','1','1','0','1','0'}, "01011001");
            dst[218] = (0b01011010, new sbyte[]{0,1,0,1,1,0,1,0}, new char[]{'0','1','0','1','1','0','1','0'}, "01011010");
            dst[219] = (0b01011011, new sbyte[]{1,1,0,1,1,0,1,0}, new char[]{'1','1','0','1','1','0','1','0'}, "01011011");
            dst[220] = (0b01011100, new sbyte[]{0,0,1,1,1,0,1,0}, new char[]{'0','0','1','1','1','0','1','0'}, "01011100");
            dst[221] = (0b01011101, new sbyte[]{1,0,1,1,1,0,1,0}, new char[]{'1','0','1','1','1','0','1','0'}, "01011101");
            dst[222] = (0b01011110, new sbyte[]{0,1,1,1,1,0,1,0}, new char[]{'0','1','1','1','1','0','1','0'}, "01011110");
            dst[223] = (0b01011111, new sbyte[]{1,1,1,1,1,0,1,0}, new char[]{'1','1','1','1','1','0','1','0'}, "01011111");
            dst[224] = (0b01100000, new sbyte[]{0,0,0,0,0,1,1,0}, new char[]{'0','0','0','0','0','1','1','0'}, "01100000");
            dst[225] = (0b01100001, new sbyte[]{1,0,0,0,0,1,1,0}, new char[]{'1','0','0','0','0','1','1','0'}, "01100001");
            dst[226] = (0b01100010, new sbyte[]{0,1,0,0,0,1,1,0}, new char[]{'0','1','0','0','0','1','1','0'}, "01100010");
            dst[227] = (0b01100011, new sbyte[]{1,1,0,0,0,1,1,0}, new char[]{'1','1','0','0','0','1','1','0'}, "01100011");
            dst[228] = (0b01100100, new sbyte[]{0,0,1,0,0,1,1,0}, new char[]{'0','0','1','0','0','1','1','0'}, "01100100");
            dst[229] = (0b01100101, new sbyte[]{1,0,1,0,0,1,1,0}, new char[]{'1','0','1','0','0','1','1','0'}, "01100101");
            dst[230] = (0b01100110, new sbyte[]{0,1,1,0,0,1,1,0}, new char[]{'0','1','1','0','0','1','1','0'}, "01100110");
            dst[231] = (0b01100111, new sbyte[]{1,1,1,0,0,1,1,0}, new char[]{'1','1','1','0','0','1','1','0'}, "01100111");
            dst[232] = (0b01101000, new sbyte[]{0,0,0,1,0,1,1,0}, new char[]{'0','0','0','1','0','1','1','0'}, "01101000");
            dst[233] = (0b01101001, new sbyte[]{1,0,0,1,0,1,1,0}, new char[]{'1','0','0','1','0','1','1','0'}, "01101001");
            dst[234] = (0b01101010, new sbyte[]{0,1,0,1,0,1,1,0}, new char[]{'0','1','0','1','0','1','1','0'}, "01101010");
            dst[235] = (0b01101011, new sbyte[]{1,1,0,1,0,1,1,0}, new char[]{'1','1','0','1','0','1','1','0'}, "01101011");
            dst[236] = (0b01101100, new sbyte[]{0,0,1,1,0,1,1,0}, new char[]{'0','0','1','1','0','1','1','0'}, "01101100");
            dst[237] = (0b01101101, new sbyte[]{1,0,1,1,0,1,1,0}, new char[]{'1','0','1','1','0','1','1','0'}, "01101101");
            dst[238] = (0b01101110, new sbyte[]{0,1,1,1,0,1,1,0}, new char[]{'0','1','1','1','0','1','1','0'}, "01101110");
            dst[239] = (0b01101111, new sbyte[]{1,1,1,1,0,1,1,0}, new char[]{'1','1','1','1','0','1','1','0'}, "01101111");
            dst[240] = (0b01110000, new sbyte[]{0,0,0,0,1,1,1,0}, new char[]{'0','0','0','0','1','1','1','0'}, "01110000");
            dst[241] = (0b01110001, new sbyte[]{1,0,0,0,1,1,1,0}, new char[]{'1','0','0','0','1','1','1','0'}, "01110001");
            dst[242] = (0b01110010, new sbyte[]{0,1,0,0,1,1,1,0}, new char[]{'0','1','0','0','1','1','1','0'}, "01110010");
            dst[243] = (0b01110011, new sbyte[]{1,1,0,0,1,1,1,0}, new char[]{'1','1','0','0','1','1','1','0'}, "01110011");
            dst[244] = (0b01110100, new sbyte[]{0,0,1,0,1,1,1,0}, new char[]{'0','0','1','0','1','1','1','0'}, "01110100");
            dst[245] = (0b01110101, new sbyte[]{1,0,1,0,1,1,1,0}, new char[]{'1','0','1','0','1','1','1','0'}, "01110101");
            dst[246] = (0b01110110, new sbyte[]{0,1,1,0,1,1,1,0}, new char[]{'0','1','1','0','1','1','1','0'}, "01110110");
            dst[247] = (0b01110111, new sbyte[]{1,1,1,0,1,1,1,0}, new char[]{'1','1','1','0','1','1','1','0'}, "01110111");
            dst[248] = (0b01111000, new sbyte[]{0,0,0,1,1,1,1,0}, new char[]{'0','0','0','1','1','1','1','0'}, "01111000");
            dst[249] = (0b01111001, new sbyte[]{1,0,0,1,1,1,1,0}, new char[]{'1','0','0','1','1','1','1','0'}, "01111001");
            dst[250] = (0b01111010, new sbyte[]{0,1,0,1,1,1,1,0}, new char[]{'0','1','0','1','1','1','1','0'}, "01111010");
            dst[251] = (0b01111011, new sbyte[]{1,1,0,1,1,1,1,0}, new char[]{'1','1','0','1','1','1','1','0'}, "01111011");
            dst[252] = (0b01111100, new sbyte[]{0,0,1,1,1,1,1,0}, new char[]{'0','0','1','1','1','1','1','0'}, "01111100");
            dst[253] = (0b01111101, new sbyte[]{1,0,1,1,1,1,1,0}, new char[]{'1','0','1','1','1','1','1','0'}, "01111101");
            dst[254] = (0b01111110, new sbyte[]{0,1,1,1,1,1,1,0}, new char[]{'0','1','1','1','1','1','1','0'}, "01111110");
            dst[255] = (0b01111111, new sbyte[]{1,1,1,1,1,1,1,0}, new char[]{'1','1','1','1','1','1','1','0'}, "01111111");
            return dst;
        }
    }

}