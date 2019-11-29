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

    public static partial class CpuVecX
    {
        [MethodImpl(Inline)]
        public static Span<T> Store<T>(this Vector128<T> src, Span<T> dst)
            where T : unmanaged            
                => vstore(src,dst);

        [MethodImpl(Inline)]
        public static Span<T> Store<T>(this Vector256<T> src, Span<T> dst)
            where T : unmanaged            
                => vstore(src,dst);
    }
}