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



    public static class vxops
    {

        public static Vector128<uint> and_class(Vector128<uint> x, Vector128<uint> y)
            =>  VXTypes.CAnd128<uint>.Op.Invoke(x,y);

        public static uint and_class_scalar(uint x, uint y)
            =>  VXTypes.CAnd128<uint>.Op.InvokeScalar(x,y);

        public static uint and_class_scalar(VXTypes.CAnd128<uint> f, uint x, uint y)
            =>  f.InvokeScalar(x,y);

        public static Vector128<uint> and_struct(Vector128<uint> x, Vector128<uint> y)
            =>  VXTypes.And128<uint>.Op.Invoke(x,y);

        public static uint and_struct_scalar(uint x, uint y)
            =>  VXTypes.And128<uint>.Op.InvokeScalar(x,y);

        public static void loop_1(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            Loop.run(GZ.negate(z32), src, dst);
        }


        public static void loop_2(ArrayExchange<uint> src, ArrayExchange<uint> dst)
        {
            Loop.run(GZ.negate(z32), src, dst);   
        }

        public static void pipeline_1(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var f = GZ.negate<uint>();
            var g = GZ.not<uint>();
            var count = dst.Length;
            for(var i=0; i< count; i++)
                seek(dst,i) = Pipes.pipe(skip(src,i),f,g);
        }


        public static void pipeline_2(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var g = GZ.negate(z32);
            var f = GZ.and(z32);
            var count = dst.Length;
            for(var i=0; i< count; i++)
                seek(dst,i) = Pipes.compose(skip(src,i),f,g);
        }

        public static uint and_negate(uint x)
            => math.and(x,math.negate(x));

        public static uint and_negate_ops(uint x)
        {
            var g = GZ.negate(x);
            var f = GZ.and(x);
            return Pipes.compose(x,f,g);
        }
        public static uint vxor_128x32u(Vector128<uint> x, Vector128<uint> y)
        {
            var ops = VX.vxor(n128,z32);
            var z = ops.Invoke(x,y);
            var a = ops.InvokeScalar(x.FirstCell(),y.LastCell());
            return a;
        }

        public static Vector256<uint> op_shift_specific(Vector256<uint> src)
            => apply(VX.vsll<uint>(n256),src,3);
        
        public static Vector256<uint> op_shift(Vector256<uint> src, byte amount)
            => apply(VX.vsll<uint>(n256),src,amount);
        
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