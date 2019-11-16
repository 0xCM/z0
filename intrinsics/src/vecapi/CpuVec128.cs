//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static As;

    public static class CpuVec128
    {
        [MethodImpl(Inline)]
        public static T item<T>(Vector128<T> x, int index)
            where T : unmanaged
                => x.GetElement(index);

        [MethodImpl(Inline)]
        public static Vector128<T> item<T>(Vector128<T> x, int index, T value)
            where T : unmanaged
                => x.WithElement(index,value);

    }
}