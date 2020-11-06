//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using Z0.Asm;

    using static Konst;
    using static Typed;

    public readonly struct TestDynamicVectors
    {
        readonly IAsmContext Context;

        readonly BufferToken Buffer;

        readonly Type Host;

        public TestDynamicVectors(IAsmContext context, Type host, BufferToken buffer)
        {
            Context = context;
            Buffer = buffer;
            Host = host;
        }

        IDynexus Dynamic
            => Dynops.Dynexus;

        uint PointCount<T>()
            => (uint)Root.size<T>()/Buffer.BufferSize;

        IPolyrand Random
            => Context.Random;

        public TestCaseRecord Match<T>(BinaryOp<Vector128<T>> f, ApiCodeBlock bits)
            where T : unmanaged
        {
            var g = Dynamic.EmitFixedBinary(Buffer, w128, bits);
            return Match<T>(f, g, bits.OpUri.OpId);
        }

        public TestCaseRecord Match<T>(BinaryOp<Vector256<T>> f, ApiCodeBlock bits)
            where T : unmanaged
        {
            var g = Dynamic.EmitFixedBinary(Buffer, w256, bits);
            return Match<T>(f, g, bits.OpUri.OpId);
        }

        public TestCaseRecord Match<T>(BinaryOp<Vector128<T>> f, BinaryOp128 g, OpIdentity id)
            where T : unmanaged
        {
            var w = w128;
            var t = default(T);
            var success = Bit32.On;
            var clock = Time.counter(true);
            var count = PointCount<T>();

            for(var i=0; i<count; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                success &= gvec.vtestc(gvec.veq(f(x,y), g.Apply(x,y)));
            }

            return TestCaseRecord.Define(TestCaseIdentity.name<T>(Host,id), success, clock);
        }

        public TestCaseRecord Match<T>(BinaryOp<Vector256<T>> f, BinaryOp256 g, OpIdentity id)
            where T : unmanaged
        {
            var w = w256;
            var t = default(T);
            var success = Bit32.On;
            var clock = Time.counter(true);
            var count = PointCount<T>();

            for(var i=0; i<count; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                success &= gvec.vtestc(gvec.veq(f(x,y), g.Apply(x,y)));
            }

            return TestCaseRecord.Define(TestCaseIdentity.name<T>(Host,id), success, clock);
        }
    }
}