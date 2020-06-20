//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Konst;
 
    partial class SymbolicData
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ulong location<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => (ulong)pointer(src);

        [MethodImpl(Inline), Op]
        public static unsafe ulong location(string src)
        {
            fixed(char* pHead = src)            
            {
                return (ulong)pHead;
            }
        }

        [MethodImpl(Inline), Op]
        public static void locations(ReadOnlySpan<string> src, Span<ulong> dst)
        {
            ref readonly var r0 = ref head(src);
            for(var i=0; i<src.Length; i++)
                seek(dst,i) = location(skip(r0,i));
        }


        [MethodImpl(Inline)]
        public unsafe static T* pointer<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            ref readonly var rHead = ref head(src);
            return (T*)Unsafe.AsPointer(ref edit(rHead));
        }

        [MethodImpl(Inline)]
        unsafe static T* pointer<T>(in T src)
            where T : unmanaged
                => (T*)Unsafe.AsPointer(ref edit(src));

        [MethodImpl(Inline)]
        public unsafe static ulong location<T>(in T src)
            where T : unmanaged
                => (ulong)pointer(src);

    }
}