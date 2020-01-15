//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    using static AndSkeleton;


    public static class vxops
    {
        public static bit check_and_1(Vector128<uint> x, Vector128<uint> y)
        {
            var svc = GX.bitlogic<uint>();
            var v1 = VX.vbitlogic<uint>(n128).and(x,y);
            var a0 = svc.and(vcell(x,0), vcell(y,0));
            var a1 = svc.and(vcell(x,1), vcell(y,1));
            var a2 = svc.and(vcell(x,2), vcell(y,2));
            var a3 = svc.and(vcell(x,3), vcell(y,3));
            var v2 = CpuVector.vparts(n128,a0,a1,a2,a3);
            return ginx.vsame(v1,v2);
        }

        public static Vector128<uint> and_class(Vector128<uint> x, Vector128<uint> y)
            =>  CAnd128<uint>.Op.Invoke(x,y);

        public static uint and_class_scalar(uint x, uint y)
            =>  CAnd128<uint>.Op.InvokeScalar(x,y);

        public static uint and_class_scalar(CAnd128<uint> f, uint x, uint y)
            =>  f.InvokeScalar(x,y);

        public static Vector128<uint> and_struct(Vector128<uint> x, Vector128<uint> y)
            =>  VXTypes.And128<uint>.Op.Invoke(x,y);

        public static uint and_struct_scalar(uint x, uint y)
            =>  VXTypes.And128<uint>.Op.InvokeScalar(x,y);

        public static void loop_1(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            Loop.run(GX.negate(z32), src, dst);
        }


        public static void loop_2(ArrayExchange<uint> src, ArrayExchange<uint> dst)
        {
            Loop.run(GX.negate(z32), src, dst);   
        }

        public static void pipeline_1(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var f = GX.negate<uint>();
            var g = GX.not<uint>();
            var count = dst.Length;
            for(var i=0; i< count; i++)
                seek(dst,i) = Pipes.pipe(skip(src,i),f,g);
        }


        public static void pipeline_2(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var g = GX.negate(z32);
            var f = GX.and(z32);
            var count = dst.Length;
            for(var i=0; i< count; i++)
                seek(dst,i) = Pipes.compose(skip(src,i),f,g);
        }

        public static uint and_negate(uint x)
            => math.and(x,math.negate(x));

        public static uint and_negate_ops(uint x)
        {
            var g = GX.negate(x);
            var f = GX.and(x);
            return Pipes.compose(x,f,g);
        }
        
        public static uint vxor_128x32u_1(Vector128<uint> x, Vector128<uint> y)
        {
            var ops = VX.vxor(n128,z32);
            var z = ops.Invoke(x,y);
            var a = ops.InvokeScalar(x.FirstCell(),y.LastCell());
            return a;
        }

        
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