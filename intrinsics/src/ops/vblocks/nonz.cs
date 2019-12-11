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
    using static ginx;
    
    partial class vblock
    {     
        [MethodImpl(Inline)]
        public static bit vnonz<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vnonz(vA);
        }

        [MethodImpl(Inline)]
        public static bit vnonz<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vnonz(vA);
        }

        [MethodImpl(Inline)]
        public static bit nonz<T>(N128 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vnonz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit nonz<T>(N256 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vnonz(n, in skip(in a, offset));
            return result;
        }
    }
}