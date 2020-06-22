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
        /// Presents a reference as an address
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public unsafe static MemoryAddress address<T>(in T src)
            where T : unmanaged
                => (ulong)Pointed.constptr(src);
    }
}