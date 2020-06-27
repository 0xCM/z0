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
    public readonly struct Addresses : IApiHost<Addresses>
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ReadOnlySpan<T> read<T>(MemoryAddress location, int count)
            where T : unmanaged
        {
            var pFirst = location.Pointer<T>();
            ref var first = ref Unsafe.AsRef<T>(pFirst);
            return MemoryMarshal.CreateReadOnlySpan<T>(ref first, count);      
        }        

        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress locate<T>(in T src)
            => pvoid(src);

        [MethodImpl(Inline), Op]
        public static MemoryAddress address(ulong src)
            => new MemoryAddress(src);

        [MethodImpl(Inline), Op]
        public static MemoryAddress address(IntPtr src)
            => new MemoryAddress((ulong)src.ToInt64());

        [MethodImpl(Inline), Op]
        public static Address8 address8(byte src)
            => new Address8(src);

        [MethodImpl(Inline), Op]
        public static Address16 address16(ushort src)
            => new Address16(src);

        [MethodImpl(Inline), Op]
        public static Address32 address32(uint src)
            => new Address32(src);

        [MethodImpl(Inline), Op]
        public static Address64 address64(ulong src)
            => new Address64(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ref T toRef<T>(MemoryAddress src)
            => ref src.Ref<T>();
         
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> edit<T>(MemoryAddress src, int length)
            => MemoryMarshal.CreateSpan(ref src.Ref<T>(), length);

        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> edit(MemoryAddress src, int length)
            => MemoryMarshal.CreateSpan(ref src.Ref<byte>(), length);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> cover(MemoryAddress src, int length)
            => MemoryMarshal.CreateReadOnlySpan(ref src.Ref<byte>(), length);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ReadOnlySpan<T> cover<T>(MemoryAddress src, int length)
            => MemoryMarshal.CreateReadOnlySpan(ref src.Ref<T>(), length);

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

        [MethodImpl(Inline), Op]
        public unsafe static MemoryAddress address(void* p)
            => address((ulong)p);
    }
}