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
        public static Pair<Vector128<T>> vsplit<T>(Vector256<T> src)
            where T : unmanaged
                => (vlo(src), vhi(src));

        [MethodImpl(Inline)]
        public static Pair<Vector256<T>> vsplit<T>(Vector512<T> src)
            where T : unmanaged
                => (vlo(src), vhi(src));

        [MethodImpl(Inline)]
        public static Pair<Vector512<T>> vsplit<T>(Vector1024<T> src)
            where T : unmanaged
                => (vlo(src), vhi(src));

    }

}