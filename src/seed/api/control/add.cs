// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {            

        /// <summary>
        /// Adds an offset to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The source-relative offset amount</param>
        /// <typeparam name="T">The reference type</typeparam>
        /// <remarks>
        /// u8:  movsxd rax,edx -> add rax,rcx
        /// u16: movsxd rax,edx -> lea rax,[rcx+rax*2]
        /// u32: movsxd rax,edx -> lea rax,[rcx+rax*4]
        /// u64: movsxd rax,edx -> lea rax,[rcx+rax*8]
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T add<T>(ref T src, int offset)
            where T : unmanaged
                => ref Imagine.add(src, offset);
    }
}