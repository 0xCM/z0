//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static unsafe T* refptr<T>(ref T src)
            where T : unmanaged
                => memory.refptr(ref src);

        [MethodImpl(Inline)]
        public static unsafe T* refptr<T>(ref T src, int offset)
            where T : unmanaged
                => memory.refptr(ref src, offset);

        [MethodImpl(Inline)]
        public static unsafe P* refptr<T,P>(ref T r)
            where T : unmanaged
            where P : unmanaged
                => memory.refptr<T,P>(ref r);
    }
}