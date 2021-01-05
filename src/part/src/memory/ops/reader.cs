//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static MemoryReader<T> reader<T>(T* pSrc, int length)
            where T : unmanaged
                => new MemoryReader<T>(pSrc, length);

        [MethodImpl(Inline), Op]
        public unsafe static MemoryReader reader(byte* pSrc, int length)
            => new MemoryReader(pSrc, length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static MemoryReader<T> reader<T>(MemoryRange src)
            where T : unmanaged
                => reader(src.BaseAddress.Pointer<T>(), (int)src.Length);
    }
}