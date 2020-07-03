//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static As;

    [ApiHost]
    public readonly struct Addressable : IApiHost<Addressable>
    {        
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static Span<T> read<T>(in Ref src)
            => src.As<T>();

        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address<T>(in T src)
            => new MemoryAddress(pvoid(src));

        /// <summary>
        /// Defines an address predicated on the leading source cell
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => gptr(first(src));                

        [MethodImpl(Inline), Op]
        public static MemoryAddress address(ulong src)
            => new MemoryAddress(src);

        [MethodImpl(Inline), Op]
        public static Address8 address(W8 w, byte src)
            => new Address8(src);

        [MethodImpl(Inline), Op]
        public static Address16 address(W16 w, ushort src)
            => new Address16(src);

        [MethodImpl(Inline), Op]
        public static Address32 address(W32 w, uint src)
            => new Address32(src);

        [MethodImpl(Inline), Op]
        public static Address64 address(W64 w, ulong src)
            => new Address64(src);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, byte offset)
            => new MemoryOffset(@base, offset, NumericWidth.W8);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, ushort offset)
            => new MemoryOffset(@base, offset, NumericWidth.W16);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, uint offset)
            => new MemoryOffset(@base, offset, NumericWidth.W32);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, ulong offset)
            => new MemoryOffset(@base, offset, NumericWidth.W64);

        [MethodImpl(Inline), Op]
        public static MemoryOffsets offsets(params MemoryOffset[] src)
            => new MemoryOffsets(src);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, MemoryAddress src)
        {
            var delta = src - @base;

            if(delta <= byte.MaxValue)
                return offset(@base, (byte)delta);
            else if(delta <= ushort.MaxValue)
                return offset(@base, (ushort)delta);
            else if(delta <= uint.MaxValue)
                return offset(@base, (uint)delta);
            else
                return offset(@base, (ulong)delta);
        }

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static ReadOnlySpan<T> view<T>(MemoryAddress src, int count)
            where T : unmanaged
                => As.cover<T>(src.Ref<T>(), (uint)count);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> view(MemoryAddress src, ByteSize size)
            => As.cover<byte>(src.Ref<byte>(), size);

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static unsafe Span<T> edit<T>(MemoryAddress src, uint count)
            => As.cover(src.Ref<T>(), count);

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static unsafe Span<byte> edit(MemoryAddress src, ByteSize size)
            => As.cover(src.Ref<byte>(), size);
         
        [MethodImpl(Inline), Op]
        public unsafe static MemoryAddress address(void* p)
            => address((ulong)p);
    }
}