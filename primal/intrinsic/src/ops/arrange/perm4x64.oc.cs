//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;    

    public delegate Vec256<T> Perm64x4<T>(Vec256<T> src)
        where T : unmanaged;

    partial class inxvoc
    {

        public static Vec256<ulong> perm4x64_ABCD(Vec256<ulong> src)            
            => dinx.perm4x64(src,Perm4.ABCD);

        public static Vec256<ulong> perm4x64_DCBA(Vec256<ulong> src)            
            => dinx.perm4x64(src,Perm4.DCBA);

    }

}