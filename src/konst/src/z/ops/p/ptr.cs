// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => (T*)AsPointer(ref src); 
    }
}