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
        public static Vector128<T> vselect<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
                => vor(vand(x, y), vand(vnot(x), z));

        [MethodImpl(Inline)]
        public static Vector256<T> vselect<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => vor(vand(x, y), vand(vnot(x), z));

    }

}
