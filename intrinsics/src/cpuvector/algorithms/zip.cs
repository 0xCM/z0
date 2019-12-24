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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    using static ginx;
    using static As;

    partial class CpuVector
    {
        [MethodImpl(Inline)]
        public static ref readonly Block128<T> zip<F,T>(in Block128<T> lhs, in Block128<T> rhs, in Block128<T> dst, F f)
            where T : unmanaged
            where F : IVBinOp128<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block)).StoreTo(dst, block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> zip<F,T>(in Block256<T> lhs, in Block256<T> rhs, in Block256<T> dst, F f)
            where T : unmanaged
            where F : IVBinOp256<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block)).StoreTo(dst, block);            
            return ref dst;
        }

    }

}