//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static As;    
    using static Core;

    partial class BitPack
    {
        /// <summary>
        /// Packs bitsize[T] values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="offset">The source offset</param>
        /// <param name="t">A target type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T pack8<S,T>(ReadOnlySpan<S> src, int offset, T t = default)
            where S : unmanaged
            where T : unmanaged
                => pack8_u(src,offset,t);

        /// <summary>
        /// Packs bitsize[T] values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="offset">The source offset</param>
        /// <param name="t">A target type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T pack8<S,T>(Span<S> src, int offset, T t = default)
            where S : unmanaged
            where T : unmanaged
                => pack8_u(src.ReadOnly(),offset,t);

        [MethodImpl(Inline)]
        static T pack8_u<S,T>(ReadOnlySpan<S> src, int offset, T t = default)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(pack8x8(src,offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(pack16x8(src,offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(pack32x8(src,offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(pack64x8(src,offset));
            else
                return pack8_i(src,offset,t);
        }

        [MethodImpl(Inline)]
        static T pack8_i<S,T>(ReadOnlySpan<S> src, int offset, T t = default)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(pack8x8(src,offset));
            else if(typeof(T) == typeof(short))
                return convert<T>(pack16x8(src,offset));
            else if(typeof(T) == typeof(int))
                return convert<T>(pack32x8(src,offset));
            else if(typeof(T) == typeof(long))
                return convert<T>(pack64x8(src,offset));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        static byte pack8x8<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
                => pack8(uint64(skip(src,offset)));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        static ushort pack16x8<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
                => maskpack16(skip(src,offset));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        static uint pack32x8<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
                => maskpack32(skip(src,offset));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        static ulong pack64x8<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
                => maskpack64(skip(src,offset));
    }
}