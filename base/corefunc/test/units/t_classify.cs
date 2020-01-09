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

    public sealed class t_classify : UnitTest<t_classify>
    {
        public void classify_primal()
        {
            var floats = PrimalKind.Floats;
            Claim.yea(floats.Is(PrimalKind.F32));
            Claim.yea(floats.Is(PrimalKind.F64));
            Claim.nea(floats.Is(PrimalKind.I32));
            Claim.nea(floats.Is(PrimalKind.U32));
            Claim.nea(floats.Is(PrimalKind.I64));
            Claim.nea(floats.Is(PrimalKind.U64));

        }
        
        public void classify_vector_generic()
        {
            Claim.eq(Classified.vectorkind<Vector128<sbyte>>(), CpuVectorKind.v16x8i);
            Claim.eq(Classified.vectorkind<Vector128<byte>>(), CpuVectorKind.v16x8u);

            Claim.eq(Classified.vectorkind<Vector128<short>>(), CpuVectorKind.v8x16i);
            Claim.eq(Classified.vectorkind<Vector128<ushort>>(), CpuVectorKind.v8x16u);

            Claim.eq(Classified.vectorkind<Vector128<int>>(), CpuVectorKind.v4x32i);
            Claim.eq(Classified.vectorkind<Vector128<uint>>(), CpuVectorKind.v4x32u);
            Claim.eq(Classified.vectorkind<Vector128<float>>(), CpuVectorKind.v4x32f);

            Claim.eq(Classified.vectorkind<Vector128<ulong>>(), CpuVectorKind.v2x64u);
            Claim.eq(Classified.vectorkind<Vector128<long>>(), CpuVectorKind.v2x64i);
            Claim.eq(Classified.vectorkind<Vector128<double>>(), CpuVectorKind.v2x64f);

            Claim.eq(Classified.vectorkind<Vector256<sbyte>>(), CpuVectorKind.v32x8i);
            Claim.eq(Classified.vectorkind<Vector256<byte>>(), CpuVectorKind.v32x8u);

            Claim.eq(Classified.vectorkind<Vector256<short>>(), CpuVectorKind.v16x16i);
            Claim.eq(Classified.vectorkind<Vector256<ushort>>(), CpuVectorKind.v16x16u);

            Claim.eq(Classified.vectorkind<Vector256<int>>(), CpuVectorKind.v8x32i);
            Claim.eq(Classified.vectorkind<Vector256<uint>>(), CpuVectorKind.v8x32u);
            Claim.eq(Classified.vectorkind<Vector256<float>>(), CpuVectorKind.v8x32f);

            Claim.eq(Classified.vectorkind<Vector256<ulong>>(), CpuVectorKind.v4x64u);
            Claim.eq(Classified.vectorkind<Vector256<long>>(), CpuVectorKind.v4x64i);
            Claim.eq(Classified.vectorkind<Vector256<double>>(), CpuVectorKind.v4x64f);

        }

        public void classify_vector_type()
        {
            Claim.eq(Classified.vectorkind(typeof(Vector128<sbyte>)), CpuVectorKind.v16x8i);       
            Claim.eq(Classified.vectorkind(typeof(Vector128<byte>)), CpuVectorKind.v16x8u);

            Claim.eq(Classified.vectorkind(typeof(Vector128<short>)), CpuVectorKind.v8x16i);
            Claim.eq(Classified.vectorkind(typeof(Vector128<ushort>)), CpuVectorKind.v8x16u);

            Claim.eq(Classified.vectorkind(typeof(Vector128<int>)), CpuVectorKind.v4x32i);
            Claim.eq(Classified.vectorkind(typeof(Vector128<uint>)), CpuVectorKind.v4x32u);
            Claim.eq(Classified.vectorkind(typeof(Vector128<float>)), CpuVectorKind.v4x32f);

            Claim.eq(Classified.vectorkind(typeof(Vector128<ulong>)), CpuVectorKind.v2x64u);
            Claim.eq(Classified.vectorkind(typeof(Vector128<long>)), CpuVectorKind.v2x64i);
            Claim.eq(Classified.vectorkind(typeof(Vector128<double>)), CpuVectorKind.v2x64f);

            Claim.eq(Classified.vectorkind(typeof(Vector256<sbyte>)), CpuVectorKind.v32x8i);
            Claim.eq(Classified.vectorkind(typeof(Vector256<byte>)), CpuVectorKind.v32x8u);

            Claim.eq(Classified.vectorkind(typeof(Vector256<short>)), CpuVectorKind.v16x16i);
            Claim.eq(Classified.vectorkind(typeof(Vector256<ushort>)), CpuVectorKind.v16x16u);

            Claim.eq(Classified.vectorkind(typeof(Vector256<int>)), CpuVectorKind.v8x32i);
            Claim.eq(Classified.vectorkind(typeof(Vector256<uint>)), CpuVectorKind.v8x32u);
            Claim.eq(Classified.vectorkind(typeof(Vector256<float>)), CpuVectorKind.v8x32f);

            Claim.eq(Classified.vectorkind(typeof(Vector256<ulong>)), CpuVectorKind.v4x64u);
            Claim.eq(Classified.vectorkind(typeof(Vector256<long>)), CpuVectorKind.v4x64i);
            Claim.eq(Classified.vectorkind(typeof(Vector256<double>)), CpuVectorKind.v4x64f);

        }


    }

}