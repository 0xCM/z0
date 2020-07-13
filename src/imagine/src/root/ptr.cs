// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline)]
        public static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => (T*)AsPointer(ref src); 

        public static unsafe T* refptr<T>(ref T src)
            where T : unmanaged
                => (T*)AsPointer(ref src); 

        [MethodImpl(Inline)]
        public static unsafe T* constptr<T>(in T src)
            where T : unmanaged
                => refptr(ref edit(src));
    }
}