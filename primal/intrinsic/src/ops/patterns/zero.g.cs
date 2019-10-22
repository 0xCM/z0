//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vector128<T> vzero<T>(N128 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vector256<T> vzero<T>(N256 n)
            where T : unmanaged
                => default;




    }

}