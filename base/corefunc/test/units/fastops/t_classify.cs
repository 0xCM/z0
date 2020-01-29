//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    public sealed class t_classify : t_fastop<t_classify>
    {
        public void adjudicate_primal()
        {
            var floats = NumericKind.Floats;
            Claim.yea(floats.Is(NumericKind.F32));
            Claim.yea(floats.Is(NumericKind.F64));
            Claim.nea(floats.Is(NumericKind.I32));
            Claim.nea(floats.Is(NumericKind.U32));
            Claim.nea(floats.Is(NumericKind.I64));
            Claim.nea(floats.Is(NumericKind.U64));

        }
        
        public void classify_primal_width()
        {
            Claim.eq(8, NumericKind.U8.Width());
            Claim.eq(8, NumericKind.I8.Width());
            Claim.eq(16, NumericKind.U16.Width());
            Claim.eq(16, NumericKind.I16.Width());
            Claim.eq(32, NumericKind.U32.Width());
            Claim.eq(32, NumericKind.I32.Width());
            Claim.eq(32, NumericKind.F32.Width());
            Claim.eq(64, NumericKind.I64.Width());
            Claim.eq(64, NumericKind.U64.Width());
            Claim.eq(64, NumericKind.F64.Width());
        }

        public void adjudicate_block()
        {
            Claim.yea(BlockedType.test(typeof(Block16<byte>)));
            Claim.yea(BlockedType.test(typeof(Block32<byte>)));
            Claim.yea(BlockedType.test(typeof(Block64<byte>)));
            Claim.yea(BlockedType.test(typeof(Block128<byte>)));
            Claim.yea(BlockedType.test(typeof(Block256<byte>)));
            Claim.yea(BlockedType.test(typeof(Block512<byte>)));

            Claim.yea(BlockedType.test(typeof(Block16<>)));
            Claim.yea(BlockedType.test(typeof(Block32<>)));
            Claim.yea(BlockedType.test(typeof(Block64<>)));
            Claim.yea(BlockedType.test(typeof(Block128<>)));
            Claim.yea(BlockedType.test(typeof(Block256<>)));
            Claim.yea(BlockedType.test(typeof(Block512<>)));
        }

        public void classify_block_segment_16()
        {
            Claim.eq(BlockedType.segment(typeof(Block16<byte>)), NumericKind.U8);
            Claim.eq(BlockedType.segment(typeof(Block16<sbyte>)), NumericKind.I8);
            Claim.eq(BlockedType.segment(typeof(Block16<ushort>)), NumericKind.U16);
            Claim.eq(BlockedType.segment(typeof(Block16<short>)), NumericKind.I16);
        }

        public void classify_block_segment_64()
        {
            Claim.eq(BlockedType.segment(typeof(Block64<byte>)), NumericKind.U8);
            Claim.eq(BlockedType.segment(typeof(Block64<sbyte>)), NumericKind.I8);
            Claim.eq(BlockedType.segment(typeof(Block64<ushort>)), NumericKind.U16);
            Claim.eq(BlockedType.segment(typeof(Block64<short>)), NumericKind.I16);
            Claim.eq(BlockedType.segment(typeof(Block64<uint>)), NumericKind.U32);
            Claim.eq(BlockedType.segment(typeof(Block64<int>)), NumericKind.I32);
            Claim.eq(BlockedType.segment(typeof(Block64<ulong>)), NumericKind.U64);
            Claim.eq(BlockedType.segment(typeof(Block64<long>)), NumericKind.I64);
            Claim.eq(BlockedType.segment(typeof(Block64<float>)), NumericKind.F32);
            Claim.eq(BlockedType.segment(typeof(Block64<double>)), NumericKind.F64);
        }

        public void classify_block_segment_128()
        {
            Claim.eq(BlockedType.segment(typeof(Block128<byte>)), NumericKind.U8);
            Claim.eq(BlockedType.segment(typeof(Block128<sbyte>)), NumericKind.I8);
            Claim.eq(BlockedType.segment(typeof(Block128<ushort>)), NumericKind.U16);
            Claim.eq(BlockedType.segment(typeof(Block128<short>)), NumericKind.I16);
            Claim.eq(BlockedType.segment(typeof(Block128<uint>)), NumericKind.U32);
            Claim.eq(BlockedType.segment(typeof(Block128<int>)), NumericKind.I32);
            Claim.eq(BlockedType.segment(typeof(Block128<ulong>)), NumericKind.U64);
            Claim.eq(BlockedType.segment(typeof(Block128<long>)), NumericKind.I64);
            Claim.eq(BlockedType.segment(typeof(Block128<float>)), NumericKind.F32);
            Claim.eq(BlockedType.segment(typeof(Block128<double>)), NumericKind.F64);
        }

        public void classify_block_width()
        {
            Claim.eq(BlockWidth.W16, BlockedType.width(typeof(Block16<byte>)));
            Claim.eq(BlockWidth.W32, BlockedType.width(typeof(Block32<byte>)));
            Claim.eq(BlockWidth.W64, BlockedType.width(typeof(Block64<byte>)));
            Claim.eq(BlockWidth.W128, BlockedType.width(typeof(Block128<byte>)));
            Claim.eq(BlockWidth.W256, BlockedType.width(typeof(Block256<byte>)));
            Claim.eq(BlockWidth.W512, BlockedType.width(typeof(Block512<byte>)));

            Claim.eq(BlockWidth.W16, BlockedType.width(typeof(Block16<>)));
            Claim.eq(BlockWidth.W32, BlockedType.width(typeof(Block32<>)));
            Claim.eq(BlockWidth.W64, BlockedType.width(typeof(Block64<>)));
            Claim.eq(BlockWidth.W128, BlockedType.width(typeof(Block128<>)));
            Claim.eq(BlockWidth.W256, BlockedType.width(typeof(Block256<>)));
            Claim.eq(BlockWidth.W512, BlockedType.width(typeof(Block512<>)));
        }

        public void test_block_16()
        {
            Claim.yea(BlockedType.test(typeof(Block16<byte>)));
            Claim.yea(BlockedType.test(typeof(Block16<sbyte>)));
            Claim.yea(BlockedType.test(typeof(Block16<ushort>)));
            Claim.yea(BlockedType.test(typeof(Block16<short>)));
        }

        public void test_block_32()
        {
            Claim.yea(BlockedType.test(typeof(Block32<byte>)));
            Claim.yea(BlockedType.test(typeof(Block32<sbyte>)));
            Claim.yea(BlockedType.test(typeof(Block32<ushort>)));
            Claim.yea(BlockedType.test(typeof(Block32<short>)));
            Claim.yea(BlockedType.test(typeof(Block32<int>)));
            Claim.yea(BlockedType.test(typeof(Block32<uint>)));
            Claim.yea(BlockedType.test(typeof(Block32<float>)));
        }

        public void test_block_64()
        {
            Claim.yea(BlockedType.test(typeof(Block64<byte>)));
            Claim.yea(BlockedType.test(typeof(Block64<sbyte>)));
            Claim.yea(BlockedType.test(typeof(Block64<ushort>)));
            Claim.yea(BlockedType.test(typeof(Block64<short>)));
            Claim.yea(BlockedType.test(typeof(Block64<int>)));
            Claim.yea(BlockedType.test(typeof(Block64<uint>)));
            Claim.yea(BlockedType.test(typeof(Block64<long>)));
            Claim.yea(BlockedType.test(typeof(Block64<ulong>)));
            Claim.yea(BlockedType.test(typeof(Block64<float>)));
            Claim.yea(BlockedType.test(typeof(Block64<double>)));
        }

        public void check_primal_identity()
        {
            Claim.eq(PrimalId.U8, NumericKind.U8.GetPrimalId());
            Claim.eq(PrimalId.I8, NumericKind.I8.GetPrimalId());
            Claim.eq(PrimalId.U16, NumericKind.U16.GetPrimalId());
            Claim.eq(PrimalId.I16, NumericKind.I16.GetPrimalId());

        }
        public void classify_block_16()
        {
            Claim.eq(BlockedType.kind(typeof(Block16<byte>)), BlockKind.Block16x8u);
            Claim.eq(BlockedType.kind(typeof(Block16<sbyte>)), BlockKind.Block16x8i);
            Claim.eq(BlockedType.kind(typeof(Block16<ushort>)), BlockKind.Block16x16u);
            Claim.eq(BlockedType.kind(typeof(Block16<short>)), BlockKind.Block16x16i);
        }

        void classify_block_32()
        {
            Claim.eq(BlockedType.kind(typeof(Block32<byte>)), BlockKind.Block32x8u);
            Claim.eq(BlockedType.kind(typeof(Block32<sbyte>)), BlockKind.Block32x8i);
            Claim.eq(BlockedType.kind(typeof(Block32<ushort>)), BlockKind.Block32x16u);
            Claim.eq(BlockedType.kind(typeof(Block32<short>)), BlockKind.Block32x16i);
            Claim.eq(BlockedType.kind(typeof(Block32<uint>)), BlockKind.Block32x32u);
            Claim.eq(BlockedType.kind(typeof(Block32<int>)), BlockKind.Block32x32i);
            Claim.eq(BlockedType.kind(typeof(Block32<float>)), BlockKind.Block32x32f);
        }

        void classify_block_64()
        {
            Claim.eq(BlockedType.kind(typeof(Block64<byte>)), BlockKind.Block64x8u);
            Claim.eq(BlockedType.kind(typeof(Block64<sbyte>)), BlockKind.Block64x8i);
            Claim.eq(BlockedType.kind(typeof(Block64<ushort>)), BlockKind.Block64x16u);
            Claim.eq(BlockedType.kind(typeof(Block64<short>)), BlockKind.Block64x16i);
            Claim.eq(BlockedType.kind(typeof(Block64<uint>)), BlockKind.Block64x32u);
            Claim.eq(BlockedType.kind(typeof(Block64<int>)), BlockKind.Block64x32i);
            Claim.eq(BlockedType.kind(typeof(Block64<ulong>)), BlockKind.Block64x64u);
            Claim.eq(BlockedType.kind(typeof(Block64<long>)), BlockKind.Block64x64i);
            Claim.eq(BlockedType.kind(typeof(Block64<float>)), BlockKind.Block64x32f);
            Claim.eq(BlockedType.kind(typeof(Block64<double>)), BlockKind.Block64x64f);
        }

        void classify_block_128()
        {
            Claim.eq(BlockedType.kind(typeof(Block128<byte>)), BlockKind.Block128x8u);
            Claim.eq(BlockedType.kind(typeof(Block128<sbyte>)), BlockKind.Block128x8i);
            Claim.eq(BlockedType.kind(typeof(Block128<ushort>)), BlockKind.Block128x16u);
            Claim.eq(BlockedType.kind(typeof(Block128<short>)), BlockKind.Block128x16i);
            Claim.eq(BlockedType.kind(typeof(Block128<uint>)), BlockKind.Block128x32u);
            Claim.eq(BlockedType.kind(typeof(Block128<int>)), BlockKind.Block128x32i);
            Claim.eq(BlockedType.kind(typeof(Block128<ulong>)), BlockKind.Block128x64u);
            Claim.eq(BlockedType.kind(typeof(Block128<long>)), BlockKind.Block128x64i);
            Claim.eq(BlockedType.kind(typeof(Block128<float>)), BlockKind.Block128x32f);
            Claim.eq(BlockedType.kind(typeof(Block128<double>)), BlockKind.Block128x64f);

        }

        void classify_block_256()
        {
            Claim.eq(BlockedType.kind(typeof(Block256<byte>)), BlockKind.Block256x8u);
            Claim.eq(BlockedType.kind(typeof(Block256<sbyte>)), BlockKind.Block256x8i);
            Claim.eq(BlockedType.kind(typeof(Block256<ushort>)), BlockKind.Block256x16u);
            Claim.eq(BlockedType.kind(typeof(Block256<short>)), BlockKind.Block256x16i);
            Claim.eq(BlockedType.kind(typeof(Block256<uint>)), BlockKind.Block256x32u);
            Claim.eq(BlockedType.kind(typeof(Block256<int>)), BlockKind.Block256x32i);
            Claim.eq(BlockedType.kind(typeof(Block256<ulong>)), BlockKind.Block256x64u);
            Claim.eq(BlockedType.kind(typeof(Block256<long>)), BlockKind.Block256x64i);
            Claim.eq(BlockedType.kind(typeof(Block256<float>)), BlockKind.Block256x32f);
            Claim.eq(BlockedType.kind(typeof(Block256<double>)), BlockKind.Block256x64f);
        }

        public void classify_vector()
        {
            Claim.eq(VectorType.kind(typeof(Vector128<byte>)), VectorKind.Vector128x8u);
            Claim.eq(VectorType.kind(typeof(Vector128<sbyte>)), VectorKind.Vector128x8i);
            Claim.eq(VectorType.kind(typeof(Vector128<ushort>)), VectorKind.Vector128x16u);
            Claim.eq(VectorType.kind(typeof(Vector128<short>)), VectorKind.Vector128x16i);
            Claim.eq(VectorType.kind(typeof(Vector128<uint>)), VectorKind.Vector128x32u);
            Claim.eq(VectorType.kind(typeof(Vector128<int>)), VectorKind.Vector128x32i);
            Claim.eq(VectorType.kind(typeof(Vector128<ulong>)), VectorKind.Vector128x64u);
            Claim.eq(VectorType.kind(typeof(Vector128<long>)), VectorKind.Vector128x64i);
            Claim.eq(VectorType.kind(typeof(Vector128<float>)), VectorKind.Vector128x32f);
            Claim.eq(VectorType.kind(typeof(Vector128<double>)), VectorKind.Vector128x64f);

            Claim.eq(VectorType.kind(typeof(Vector256<byte>)), VectorKind.Vector256x8u);
            Claim.eq(VectorType.kind(typeof(Vector256<sbyte>)), VectorKind.Vector256x8i);
            Claim.eq(VectorType.kind(typeof(Vector256<ushort>)), VectorKind.Vector256x16u);
            Claim.eq(VectorType.kind(typeof(Vector256<short>)), VectorKind.Vector256x16i);
            Claim.eq(VectorType.kind(typeof(Vector256<uint>)), VectorKind.Vector256x32u);
            Claim.eq(VectorType.kind(typeof(Vector256<int>)), VectorKind.Vector256x32i);
            Claim.eq(VectorType.kind(typeof(Vector256<ulong>)), VectorKind.Vector256x64u);
            Claim.eq(VectorType.kind(typeof(Vector256<long>)), VectorKind.Vector256x64i);
            Claim.eq(VectorType.kind(typeof(Vector256<float>)), VectorKind.Vector256x32f);
            Claim.eq(VectorType.kind(typeof(Vector256<double>)), VectorKind.Vector256x64f);
        }

        public void classify_vector_type()
        {
            Claim.eq(VectorType.kind(typeof(Vector128<sbyte>)), VectorKind.Vector128x8i);       
            Claim.eq(VectorType.kind(typeof(Vector128<byte>)), VectorKind.Vector128x8u);

            Claim.eq(VectorType.kind(typeof(Vector128<short>)), VectorKind.Vector128x16i);
            Claim.eq(VectorType.kind(typeof(Vector128<ushort>)), VectorKind.Vector128x16u);

            Claim.eq(VectorType.kind(typeof(Vector128<int>)), VectorKind.Vector128x32i);
            Claim.eq(VectorType.kind(typeof(Vector128<uint>)), VectorKind.Vector128x32u);
            Claim.eq(VectorType.kind(typeof(Vector128<float>)), VectorKind.Vector128x32f);

            Claim.eq(VectorType.kind(typeof(Vector128<ulong>)), VectorKind.Vector128x64u);
            Claim.eq(VectorType.kind(typeof(Vector128<long>)), VectorKind.Vector128x64i);
            Claim.eq(VectorType.kind(typeof(Vector128<double>)), VectorKind.Vector128x64f);

            Claim.eq(VectorType.kind(typeof(Vector256<sbyte>)), VectorKind.Vector256x8i);
            Claim.eq(VectorType.kind(typeof(Vector256<byte>)), VectorKind.Vector256x8u);

            Claim.eq(VectorType.kind(typeof(Vector256<short>)), VectorKind.Vector256x16i);
            Claim.eq(VectorType.kind(typeof(Vector256<ushort>)), VectorKind.Vector256x16u);

            Claim.eq(VectorType.kind(typeof(Vector256<int>)), VectorKind.Vector256x32i);
            Claim.eq(VectorType.kind(typeof(Vector256<uint>)), VectorKind.Vector256x32u);
            Claim.eq(VectorType.kind(typeof(Vector256<float>)), VectorKind.Vector256x32f);

            Claim.eq(VectorType.kind(typeof(Vector256<ulong>)), VectorKind.Vector256x64u);
            Claim.eq(VectorType.kind(typeof(Vector256<long>)), VectorKind.Vector256x64i);
            Claim.eq(VectorType.kind(typeof(Vector256<double>)), VectorKind.Vector256x64f);

        }


    }

}