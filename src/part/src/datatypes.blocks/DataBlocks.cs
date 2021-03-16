//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct DataBlocks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static DataBlockSpec specify(uint index, uint lo, uint hi)
            => new DataBlockSpec(index, (ulong)lo | (ulong)hi << 32);

        [Op]
        public static Index<DataBlockSpec> alloc(uint count)
            => memory.alloc<DataBlockSpec>(count);

        [Op]
        public static DataBlockSeqSpec specify(N8 n)
        {
            var buffer = memory.alloc<DataBlockSpec>(n);
            ref var dst = ref first(buffer);
            var i = 0u;
            seek(dst, i++) = specify(i, 1, 0); // 1:[0 | 1]
            seek(dst, i++) = specify(i, 1, 1); // 2:[1 | 1]
            seek(dst, i++) = specify(i, 2, 1); // 3:[1 | 2]
            seek(dst, i++) = specify(i, 2, 2); // 4:[2 | 2]
            seek(dst, i++) = specify(i, 3, 2); // 5:[2 | 3]
            seek(dst, i++) = specify(i, 3, 3); // 5:[3 | 3]
            seek(dst, i++) = specify(i, 4, 2); // 6:[2 | 4]
            seek(dst, i++) = specify(i, 4, 3); // 7:[3 | 4]
            seek(dst, i++) = specify(i, 4, 4); // 8:[4 | 4]
            return new DataBlockSeqSpec(buffer);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block04<T> load<T>(ReadOnlySpan<T> src, ref Block04<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block04<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Block03<T> load<T>(ReadOnlySpan<T> src, ref Block03<T> dst)
            where T : unmanaged
        {
            dst = first(recover<T,Block03<T>>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block03<T> store<T>(in Block03<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block03<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block04<T> store<T>(in Block04<T> src, Span<T> dst)
            where T : unmanaged
        {
            first(recover<T,Block04<T>>(dst)) = src;
            return ref src;
        }


        public struct Block01<T>
            where T : unmanaged
        {
            T Data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block02<T>
            where T : unmanaged
        {
            Block01<T> Block0;

            Block01<T> Block1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block03<T>
            where T : unmanaged
        {
            Block01<T> Block0;

            Block02<T> Block1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block04<T>
            where T : unmanaged
        {
            Block02<T> Cell0;

            Block02<T> Cell1;
        }
    }
}