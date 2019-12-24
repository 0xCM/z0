//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    


    public static class vops
    {

        public static void add_blocks_zip(Block128<uint> left, Block128<uint> right, Block128<uint> dst)
            => CpuVector.zip(left,right,dst, VOps.vadd(n128,z32));

        public static void add_blocksp(ConstBlock128<uint> left, ConstBlock128<uint> right, Block128<uint> dst)
            => ginx.vadd(left,right,dst);

        public static Vector256<uint> op_shift_specific(Vector256<uint> src)
            => apply(VOps.vsll<uint>(n256),src,3);
        
        public static Vector256<uint> op_shift(Vector256<uint> src, byte amount)
            => apply(VOps.vsll<uint>(n256),src,amount);
        
        [MethodImpl(Inline)]
        public static Vector256<T> apply<F,T>(F op, Vector256<T> src, byte amount)
            where F : unmanaged, IVShiftOp<Vector256<T>>
            where T : unmanaged
        {
            var x = src;
            for(var i=0; i<20; i++)
                x = ginx.vsrl(op.Invoke(x,amount), amount);            
            return x;
        }

    }

}