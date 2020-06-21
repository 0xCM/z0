//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe MemoryAddress location<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => (ulong)Imagine.pointer(src);


        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress location(string src)
        {
            fixed(char* pHead = src)            
            {
                return pHead;
            }
        }


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static MemoryAddress location<T>(in T src)
            where T : unmanaged
                => (MemoryAddress)gptr(src);
    }
}