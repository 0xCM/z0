//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial class SpanExtend
    {
        /// <summary>
        /// Reads a partial value if there aren't a sufficient number of bytes to comprise a target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target type</typeparam>
        public static T TakeScalar<T>(this Span<byte> src)
            where T : unmanaged
        {
            if(src.Length == 0)
                return default;

            var tsize = Unsafe.SizeOf<T>();
            var srclen = src.Length;
            if(srclen >= tsize)
                return MemoryMarshal.Read<T>(src);
            else
            {
                var remaining = tsize - src.Length;
                Span<T> dst = stackalloc T[1];
                src.CopyTo(dst.AsBytes());            
                return dst[0];
            }
        }

        /// <summary>
        /// Copies at most n bytes from the source span to the target span where n is the length of the target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<byte> TakeBytes(this ReadOnlySpan<byte> src, Span<byte> dst)
        {
            if(src.Length > dst.Length)
                src.Slice(0,dst.Length).CopyTo(dst);
            else
                src.CopyTo(dst);
            return dst;
        }

        /// <summary>
        /// If the source is nonempty, converts the leading element to an 8-bit unsigned integer;
        /// otherwise, returns 0
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
            => src.Length > 0 ? src.AsBytes()[0] : (byte)0;

        /// <summary>
        /// If the source is nonempty, converts the leading element to an 8-bit unsigned integer;
        /// otherwise, returns 0
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt8();

        /// <summary>
        /// Converts the leading elements of a primal source span to a 16-bit unsigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[2];       
            return BitConverter.ToUInt16(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 16-bit unsigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt16();

        /// <summary>
        /// Converts the leading elements of a primal source span to a 32-bit signed integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static int TakeInt32<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[4];       
            return BitConverter.ToInt32(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 32-bit usigned integer, 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[4];       
            return BitConverter.ToUInt32(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 24-bit usigned integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static uint TakeUInt24<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[4];  
            var bytes = src.AsBytes();
            var len = Math.Min(bytes.Length, 3);
            bytes.Slice(len).CopyTo(dst);
            return MemoryMarshal.GetReference(dst.AsUInt32());
        }
        
        /// <summary>
        /// Converts the leading elements of a primal source span to a 24-bit usigned integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static uint TakeUInt24<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt24();

        /// <summary>
        /// Converts the leading elements of a primal source span to a 32-bit usigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt32();

        /// <summary>
        /// Converts the leading elements of a primal source span to a 64-bit signed integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static long TakeInt64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[8];       
            return BitConverter.ToInt64(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 64-bit unsigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[8];       
            return BitConverter.ToUInt64(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 64-bit unsigned integer, 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt64();         
    }
}