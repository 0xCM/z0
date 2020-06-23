//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static As;    
    
    partial class Vectors
    {

        [MethodImpl(Inline)]
        public static void vstore<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => VStore.vsave(src, ref dst);

        [MethodImpl(Inline)]
        public static void vstore<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => VStore.vsave(src, ref dst);
    }
}