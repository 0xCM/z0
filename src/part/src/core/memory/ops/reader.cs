//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline), Op]
        public unsafe static MemoryReader reader(byte* pSrc, ByteSize size)
            => new MemoryReader(pSrc, size);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static MemoryReader<T> reader<T>(T* pSrc, int count)
            where T : unmanaged
                => new MemoryReader<T>(pSrc, count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static MemoryReader<T> reader<T>(MemoryRange src)
            where T : unmanaged
                => reader(src.Min.Pointer<T>(), src.Size);
    }
}