//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    public sealed class t_classify : t_identity<t_classify>
    {
        static string FormatList(IEnumerable<NumericKind> src, char? sep = null)
            => src.Select(k => k.ToString()).Join(sep ?? Chars.Comma);

        static string FormatList(IEnumerable<Type> src, char? sep = null)
            => src.Select(k => k.DisplayName()).Join(sep ?? Chars.Comma);

        public void classify_numeric()
        {
            var fkExpect = root.hashset(NumericKind.F32, NumericKind.F64);
            var fkActual = NumericKind.Floats.DistinctKinds();
            Claim.seteq(fkExpect,fkActual);

            var ftExpect = root.hashset(typeof(float), typeof(double));
            var ftActual = NumericKind.Floats.DistinctTypes();
            Claim.seteq(ftExpect,ftActual);

            var ukExpect = root.hashset(NumericKind.U8, NumericKind.U16, NumericKind.U32, NumericKind.U64);
            var ukActual = NumericKind.UnsignedInts.DistinctKinds();
            Claim.seteq(ukExpect,ukActual);

            var utExpect = root.hashset(typeof(byte), typeof(ushort), typeof(uint), typeof(ulong));
            var utActual = NumericKind.UnsignedInts.DistinctTypes();
            Claim.seteq(utExpect,utActual);

            var skExpect = root.hashset(NumericKind.I8, NumericKind.I16, NumericKind.I32, NumericKind.I64);
            var skActual = NumericKind.SignedInts.DistinctKinds();
            Claim.seteq(skExpect,skActual);

            var stExpect = root.hashset(typeof(sbyte), typeof(short), typeof(int), typeof(long));
            var stActual = NumericKind.SignedInts.DistinctTypes();
            Claim.seteq(stExpect,stActual);
        }

        public void classify_numeric_width()
        {
            Claim.eq(TypeWidth.W8, NumericKind.U8.TypeWidth());
            Claim.eq(TypeWidth.W8, NumericKind.I8.TypeWidth());
            Claim.eq(TypeWidth.W16, NumericKind.U16.TypeWidth());
            Claim.eq(TypeWidth.W16, NumericKind.I16.TypeWidth());
            Claim.eq(TypeWidth.W32, NumericKind.U32.TypeWidth());
            Claim.eq(TypeWidth.W32, NumericKind.I32.TypeWidth());
            Claim.eq(TypeWidth.W32, NumericKind.F32.TypeWidth());
            Claim.eq(TypeWidth.W64, NumericKind.I64.TypeWidth());
            Claim.eq(TypeWidth.W64, NumericKind.U64.TypeWidth());
            Claim.eq(TypeWidth.W64, NumericKind.F64.TypeWidth());
        }

        public void check_numeric_identity()
        {
            Claim.eq(ScalarKind.U8, NumericKind.U8.ApiKind());
            Claim.eq(ScalarKind.I8, NumericKind.I8.ApiKind());
            Claim.eq(ScalarKind.U16, NumericKind.U16.ApiKind());
            Claim.eq(ScalarKind.I16, NumericKind.I16.ApiKind());
            Claim.eq(ScalarKind.U32, NumericKind.U32.ApiKind());
            Claim.eq(ScalarKind.I32, NumericKind.I32.ApiKind());
            Claim.eq(ScalarKind.U64, NumericKind.U64.ApiKind());
            Claim.eq(ScalarKind.I64, NumericKind.I64.ApiKind());
            Claim.eq(ScalarKind.F32, NumericKind.F32.ApiKind());
            Claim.eq(ScalarKind.F64, NumericKind.F64.ApiKind());
        }

        public void classify_block_segment_16()
        {
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock16<byte>)), NumericKind.U8);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock16<sbyte>)), NumericKind.I8);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock16<ushort>)), NumericKind.U16);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock16<short>)), NumericKind.I16);
        }

        public void classify_block_segment_64()
        {
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<byte>)), NumericKind.U8);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<sbyte>)), NumericKind.I8);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<ushort>)), NumericKind.U16);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<short>)), NumericKind.I16);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<uint>)), NumericKind.U32);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<int>)), NumericKind.I32);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<ulong>)), NumericKind.U64);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<long>)), NumericKind.I64);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<float>)), NumericKind.F32);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock64<double>)), NumericKind.F64);
        }

        public void classify_block_segment_128()
        {
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<byte>)), NumericKind.U8);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<sbyte>)), NumericKind.I8);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<ushort>)), NumericKind.U16);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<short>)), NumericKind.I16);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<uint>)), NumericKind.U32);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<int>)), NumericKind.I32);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<ulong>)), NumericKind.U64);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<long>)), NumericKind.I64);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<float>)), NumericKind.F32);
            Claim.eq(SegmentedKinds.segment(typeof(SpanBlock128<double>)), NumericKind.F64);
        }

        public void classify_block_width()
        {
            Claim.eq(TypeWidth.W16, SegmentedKinds.width(typeof(SpanBlock16<byte>)));
            Claim.eq(TypeWidth.W32, SegmentedKinds.width(typeof(SpanBlock32<byte>)));
            Claim.eq(TypeWidth.W64, SegmentedKinds.width(typeof(SpanBlock64<byte>)));
            Claim.eq(TypeWidth.W128, SegmentedKinds.width(typeof(SpanBlock128<byte>)));
            Claim.eq(TypeWidth.W256, SegmentedKinds.width(typeof(SpanBlock256<byte>)));
            Claim.eq(TypeWidth.W512, SegmentedKinds.width(typeof(SpanBlock512<byte>)));

            Claim.eq(TypeWidth.W16, SegmentedKinds.width(typeof(SpanBlock16<>)));
            Claim.eq(TypeWidth.W32, SegmentedKinds.width(typeof(SpanBlock32<>)));
            Claim.eq(TypeWidth.W64, SegmentedKinds.width(typeof(SpanBlock64<>)));
            Claim.eq(TypeWidth.W128, SegmentedKinds.width(typeof(SpanBlock128<>)));
            Claim.eq(TypeWidth.W256, SegmentedKinds.width(typeof(SpanBlock256<>)));
            Claim.eq(TypeWidth.W512, SegmentedKinds.width(typeof(SpanBlock512<>)));
        }

        static bool blocked(Type t)
            => t.IsSegmented();

        public void test_generic_blocks()
        {
            Claim.Require(blocked(typeof(SpanBlock16<>)));
            Claim.Require(blocked(typeof(SpanBlock32<>)));
            Claim.Require(blocked(typeof(SpanBlock64<>)));
            Claim.Require(blocked(typeof(SpanBlock128<>)));
            Claim.Require(blocked(typeof(SpanBlock256<>)));
            Claim.Require(blocked(typeof(SpanBlock512<>)));
        }

        public void test_block_16()
        {
            Claim.Require(blocked(typeof(SpanBlock16<byte>)));
            Claim.Require(blocked(typeof(SpanBlock16<sbyte>)));
            Claim.Require(blocked(typeof(SpanBlock16<ushort>)));
            Claim.Require(blocked(typeof(SpanBlock16<short>)));
        }

        public void test_block_32()
        {
            Claim.Require(blocked(typeof(SpanBlock32<byte>)));
            Claim.Require(blocked(typeof(SpanBlock32<sbyte>)));
            Claim.Require(blocked(typeof(SpanBlock32<ushort>)));
            Claim.Require(blocked(typeof(SpanBlock32<short>)));
            Claim.Require(blocked(typeof(SpanBlock32<int>)));
            Claim.Require(blocked(typeof(SpanBlock32<uint>)));
            Claim.Require(blocked(typeof(SpanBlock32<float>)));
        }

        public void test_block_64()
        {
            Claim.Require(blocked(typeof(SpanBlock64<byte>)));
            Claim.Require(blocked(typeof(SpanBlock64<sbyte>)));
            Claim.Require(blocked(typeof(SpanBlock64<ushort>)));
            Claim.Require(blocked(typeof(SpanBlock64<short>)));
            Claim.Require(blocked(typeof(SpanBlock64<int>)));
            Claim.Require(blocked(typeof(SpanBlock64<uint>)));
            Claim.Require(blocked(typeof(SpanBlock64<long>)));
            Claim.Require(blocked(typeof(SpanBlock64<ulong>)));
            Claim.Require(blocked(typeof(SpanBlock64<float>)));
            Claim.Require(blocked(typeof(SpanBlock64<double>)));
        }

        public void test_block_128()
        {
            Claim.Require(blocked(typeof(SpanBlock128<byte>)));
            Claim.Require(blocked(typeof(SpanBlock128<sbyte>)));
            Claim.Require(blocked(typeof(SpanBlock128<ushort>)));
            Claim.Require(blocked(typeof(SpanBlock128<short>)));
            Claim.Require(blocked(typeof(SpanBlock128<int>)));
            Claim.Require(blocked(typeof(SpanBlock128<uint>)));
            Claim.Require(blocked(typeof(SpanBlock128<long>)));
            Claim.Require(blocked(typeof(SpanBlock128<ulong>)));
            Claim.Require(blocked(typeof(SpanBlock128<float>)));
            Claim.Require(blocked(typeof(SpanBlock128<double>)));
        }

        public void classify_block_16()
        {
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock16<byte>)), SegKind.Seg16x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock16<sbyte>)), SegKind.Seg16x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock16<ushort>)), SegKind.Seg16x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock16<short>)), SegKind.Seg16x16i);
        }

        void classify_block_32()
        {
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<byte>)), SegKind.Seg32x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<sbyte>)), SegKind.Seg32x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<ushort>)), SegKind.Seg32x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<short>)), SegKind.Seg32x16i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<uint>)), SegKind.Seg32x32u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<int>)), SegKind.Seg32x32i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<float>)), SegKind.Seg32x32f);
        }

        void classify_block_64()
        {
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<byte>)), SegKind.Seg64x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<sbyte>)), SegKind.Seg64x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<ushort>)), SegKind.Seg64x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<short>)), SegKind.Seg64x16i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<uint>)), SegKind.Seg64x32u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<int>)), SegKind.Seg64x32i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<ulong>)), SegKind.Seg64x64u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<long>)), SegKind.Seg64x64i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<float>)), SegKind.Seg64x32f);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<double>)), SegKind.Seg64x64f);
        }

        void classify_block_128()
        {
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<byte>)), SegKind.Seg128x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<sbyte>)), SegKind.Seg128x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<ushort>)), SegKind.Seg128x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<short>)), SegKind.Seg128x16i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<uint>)), SegKind.Seg128x32u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<int>)), SegKind.Seg128x32i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<ulong>)), SegKind.Seg128x64u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<long>)), SegKind.Seg128x64i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<float>)), SegKind.Seg128x32f);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<double>)), SegKind.Seg128x64f);

        }

        void classify_block_256()
        {
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<byte>)), SegKind.Seg256x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<sbyte>)), SegKind.Seg256x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<ushort>)), SegKind.Seg256x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<short>)), SegKind.Seg256x16i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<uint>)), SegKind.Seg256x32u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<int>)), SegKind.Seg256x32i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<ulong>)), SegKind.Seg256x64u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<long>)), SegKind.Seg256x64i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<float>)), SegKind.Seg256x32f);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<double>)), SegKind.Seg256x64f);
        }

        public void classify_vector()
        {
            Claim.eq(VK.kind(typeof(Vector128<byte>)), VectorKind.v128x8u);
            Claim.eq(VK.kind(typeof(Vector128<sbyte>)), VectorKind.v128x8i);
            Claim.eq(VK.kind(typeof(Vector128<ushort>)), VectorKind.v128x16u);
            Claim.eq(VK.kind(typeof(Vector128<short>)), VectorKind.v128x16i);
            Claim.eq(VK.kind(typeof(Vector128<uint>)), VectorKind.v128x32u);
            Claim.eq(VK.kind(typeof(Vector128<int>)), VectorKind.v128x32i);
            Claim.eq(VK.kind(typeof(Vector128<ulong>)), VectorKind.v128x64u);
            Claim.eq(VK.kind(typeof(Vector128<long>)), VectorKind.v128x64i);
            Claim.eq(VK.kind(typeof(Vector128<float>)), VectorKind.v128x32f);
            Claim.eq(VK.kind(typeof(Vector128<double>)), VectorKind.v128x64f);

            Claim.eq(VK.kind(typeof(Vector256<byte>)), VectorKind.v256x8u);
            Claim.eq(VK.kind(typeof(Vector256<sbyte>)), VectorKind.v256x8i);
            Claim.eq(VK.kind(typeof(Vector256<ushort>)), VectorKind.v256x16u);
            Claim.eq(VK.kind(typeof(Vector256<short>)), VectorKind.v256x16i);
            Claim.eq(VK.kind(typeof(Vector256<uint>)), VectorKind.v256x32u);
            Claim.eq(VK.kind(typeof(Vector256<int>)), VectorKind.v256x32i);
            Claim.eq(VK.kind(typeof(Vector256<ulong>)), VectorKind.v256x64u);
            Claim.eq(VK.kind(typeof(Vector256<long>)), VectorKind.v256x64i);
            Claim.eq(VK.kind(typeof(Vector256<float>)), VectorKind.v256x32f);
            Claim.eq(VK.kind(typeof(Vector256<double>)), VectorKind.v256x64f);
        }

        public void classify_vector_type()
        {
            Claim.eq(VK.kind(typeof(Vector128<sbyte>)), VectorKind.v128x8i);
            Claim.eq(VK.kind(typeof(Vector128<byte>)), VectorKind.v128x8u);

            Claim.eq(VK.kind(typeof(Vector128<short>)), VectorKind.v128x16i);
            Claim.eq(VK.kind(typeof(Vector128<ushort>)), VectorKind.v128x16u);

            Claim.eq(VK.kind(typeof(Vector128<int>)), VectorKind.v128x32i);
            Claim.eq(VK.kind(typeof(Vector128<uint>)), VectorKind.v128x32u);
            Claim.eq(VK.kind(typeof(Vector128<float>)), VectorKind.v128x32f);

            Claim.eq(VK.kind(typeof(Vector128<ulong>)), VectorKind.v128x64u);
            Claim.eq(VK.kind(typeof(Vector128<long>)), VectorKind.v128x64i);
            Claim.eq(VK.kind(typeof(Vector128<double>)), VectorKind.v128x64f);

            Claim.eq(VK.kind(typeof(Vector256<sbyte>)), VectorKind.v256x8i);
            Claim.eq(VK.kind(typeof(Vector256<byte>)), VectorKind.v256x8u);

            Claim.eq(VK.kind(typeof(Vector256<short>)), VectorKind.v256x16i);
            Claim.eq(VK.kind(typeof(Vector256<ushort>)), VectorKind.v256x16u);

            Claim.eq(VK.kind(typeof(Vector256<int>)), VectorKind.v256x32i);
            Claim.eq(VK.kind(typeof(Vector256<uint>)), VectorKind.v256x32u);
            Claim.eq(VK.kind(typeof(Vector256<float>)), VectorKind.v256x32f);

            Claim.eq(VK.kind(typeof(Vector256<ulong>)), VectorKind.v256x64u);
            Claim.eq(VK.kind(typeof(Vector256<long>)), VectorKind.v256x64i);
            Claim.eq(VK.kind(typeof(Vector256<double>)), VectorKind.v256x64f);
        }
    }
}