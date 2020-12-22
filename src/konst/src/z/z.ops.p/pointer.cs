// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static unsafe void* pointer(IntPtr src)
            => memory.pointer(src);

        [MethodImpl(Inline)]
        public static unsafe T* pointer<T>(ref T src)
            where T : unmanaged
                => memory.pointer(ref src);
    }
}