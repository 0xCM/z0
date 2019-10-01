//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;    

    public delegate Vec256<T> Perm64x4<T>(Vec256<T> src)
        where T : unmanaged;

    partial class inxvoc
    {
        [MethodImpl(Inline)]
        public static Vec256<ulong> perm4x64(Vec256<ulong> src, uint x0, uint x1, uint x2, uint x3)            
        {
            var spec = (Perm4)(x0 | x1 | x2 | x3);
            return perm4x64(src, spec);
        }
        
        public static Vec256<ulong> perm4x64(Vec256<ulong> src, Perm4 spec)            
        {
            switch(spec)
            {
                case Perm4.ABCD:
                    return dinx.perm4x64_ABCD(src);
                case Perm4.ACBD:
                    return dinx.perm4x64_ACBD(src);
                case Perm4.ACDB:
                    return dinx.perm4x64_ACDB(src);
                case Perm4.ADBC:
                    return dinx.perm4x64_ADBC(src);
                case Perm4.ADCB:
                    return dinx.perm4x64_ADCB(src);
                case Perm4.BACD:
                    return dinx.perm4x64_BACD(src);
                case Perm4.BADC:
                    return dinx.perm4x64_BADC(src);
                case Perm4.BCAD:
                    return dinx.perm4x64_BCAD(src);
                case Perm4.BDCA:
                    return dinx.perm4x64_BDCA(src);
                case Perm4.BDAC:
                    return dinx.perm4x64_BDAC(src);
                default:
                    return default;
            }
        }

    }

}