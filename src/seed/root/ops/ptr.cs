// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline)]
        public static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => Pointed.ptr(ref src);

        [MethodImpl(Inline)]
        public static unsafe T* constptr<T>(in T src)
            where T : unmanaged
                => As.point(src);
    }
}