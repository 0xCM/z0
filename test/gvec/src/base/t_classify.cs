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

    using static Konst;
    using static z;

    public sealed class t_classify : t_identity<t_classify>
    {
        static string FormatList(IEnumerable<NumericKind> src, char? sep = null)
            => src.Select(k => k.ToString()).Concat(sep ?? Chars.Comma);

        static string FormatList(IEnumerable<Type> src, char? sep = null)
            => src.Select(k => k.DisplayName()).Concat(sep ?? Chars.Comma);

        public void classify_numeric()
        {
            var fkExpect = hashset(NumericKind.F32, NumericKind.F64);
            var fkActual = NumericKind.Floats.DistinctKinds();
            Claim.seteq(fkExpect,fkActual);

            var ftExpect = hashset(typeof(float), typeof(double));
            var ftActual = NumericKind.Floats.DistinctTypes();
            Claim.seteq(ftExpect,ftActual);

            var ukExpect = hashset(NumericKind.U8, NumericKind.U16, NumericKind.U32, NumericKind.U64);
            var ukActual = NumericKind.UnsignedInts.DistinctKinds();
            Claim.seteq(ukExpect,ukActual);

            var utExpect = hashset(typeof(byte), typeof(ushort), typeof(uint), typeof(ulong));
            var utActual = NumericKind.UnsignedInts.DistinctTypes();
            Claim.seteq(utExpect,utActual);

            var skExpect = hashset(NumericKind.I8, NumericKind.I16, NumericKind.I32, NumericKind.I64);
            var skActual = NumericKind.SignedInts.DistinctKinds();
            Claim.seteq(skExpect,skActual);

            var stExpect = hashset(typeof(sbyte), typeof(short), typeof(int), typeof(long));
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
            Claim.eq(NumericApiKind.U8, NumericKind.U8.ApiKind());
            Claim.eq(NumericApiKind.I8, NumericKind.I8.ApiKind());
            Claim.eq(NumericApiKind.U16, NumericKind.U16.ApiKind());
            Claim.eq(NumericApiKind.I16, NumericKind.I16.ApiKind());
            Claim.eq(NumericApiKind.U32, NumericKind.U32.ApiKind());
            Claim.eq(NumericApiKind.I32, NumericKind.I32.ApiKind());
            Claim.eq(NumericApiKind.U64, NumericKind.U64.ApiKind());
            Claim.eq(NumericApiKind.I64, NumericKind.I64.ApiKind());
            Claim.eq(NumericApiKind.F32, NumericKind.F32.ApiKind());
            Claim.eq(NumericApiKind.F64, NumericKind.F64.ApiKind());
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
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock16<byte>)), SegKind.b16x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock16<sbyte>)), SegKind.b16x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock16<ushort>)), SegKind.b16x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock16<short>)), SegKind.b16x16i);
        }

        void classify_block_32()
        {
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<byte>)), SegKind.b32x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<sbyte>)), SegKind.b32x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<ushort>)), SegKind.b32x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<short>)), SegKind.b32x16i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<uint>)), SegKind.b32x32u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<int>)), SegKind.b32x32i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock32<float>)), SegKind.b32x32f);
        }

        void classify_block_64()
        {
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<byte>)), SegKind.b64x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<sbyte>)), SegKind.b64x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<ushort>)), SegKind.b64x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<short>)), SegKind.b64x16i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<uint>)), SegKind.b64x32u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<int>)), SegKind.b64x32i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<ulong>)), SegKind.b64x64u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<long>)), SegKind.b64x64i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<float>)), SegKind.b64x32f);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock64<double>)), SegKind.b64x64f);
        }

        void classify_block_128()
        {
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<byte>)), SegKind.b128x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<sbyte>)), SegKind.b128x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<ushort>)), SegKind.b128x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<short>)), SegKind.b128x16i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<uint>)), SegKind.b128x32u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<int>)), SegKind.b128x32i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<ulong>)), SegKind.b128x64u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<long>)), SegKind.b128x64i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<float>)), SegKind.b128x32f);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock128<double>)), SegKind.b128x64f);

        }

        void classify_block_256()
        {
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<byte>)), SegKind.b256x8u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<sbyte>)), SegKind.b256x8i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<ushort>)), SegKind.b256x16u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<short>)), SegKind.b256x16i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<uint>)), SegKind.b256x32u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<int>)), SegKind.b256x32i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<ulong>)), SegKind.b256x64u);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<long>)), SegKind.b256x64i);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<float>)), SegKind.b256x32f);
            Claim.eq(SegmentedKinds.kind(typeof(SpanBlock256<double>)), SegKind.b256x64f);
        }

        public void classify_vector()
        {
            Claim.eq(VKinds.kind(typeof(Vector128<byte>)), VectorKind.v128x8u);
            Claim.eq(VKinds.kind(typeof(Vector128<sbyte>)), VectorKind.v128x8i);
            Claim.eq(VKinds.kind(typeof(Vector128<ushort>)), VectorKind.v128x16u);
            Claim.eq(VKinds.kind(typeof(Vector128<short>)), VectorKind.v128x16i);
            Claim.eq(VKinds.kind(typeof(Vector128<uint>)), VectorKind.v128x32u);
            Claim.eq(VKinds.kind(typeof(Vector128<int>)), VectorKind.v128x32i);
            Claim.eq(VKinds.kind(typeof(Vector128<ulong>)), VectorKind.v128x64u);
            Claim.eq(VKinds.kind(typeof(Vector128<long>)), VectorKind.v128x64i);
            Claim.eq(VKinds.kind(typeof(Vector128<float>)), VectorKind.v128x32f);
            Claim.eq(VKinds.kind(typeof(Vector128<double>)), VectorKind.v128x64f);

            Claim.eq(VKinds.kind(typeof(Vector256<byte>)), VectorKind.v256x8u);
            Claim.eq(VKinds.kind(typeof(Vector256<sbyte>)), VectorKind.v256x8i);
            Claim.eq(VKinds.kind(typeof(Vector256<ushort>)), VectorKind.v256x16u);
            Claim.eq(VKinds.kind(typeof(Vector256<short>)), VectorKind.v256x16i);
            Claim.eq(VKinds.kind(typeof(Vector256<uint>)), VectorKind.v256x32u);
            Claim.eq(VKinds.kind(typeof(Vector256<int>)), VectorKind.v256x32i);
            Claim.eq(VKinds.kind(typeof(Vector256<ulong>)), VectorKind.v256x64u);
            Claim.eq(VKinds.kind(typeof(Vector256<long>)), VectorKind.v256x64i);
            Claim.eq(VKinds.kind(typeof(Vector256<float>)), VectorKind.v256x32f);
            Claim.eq(VKinds.kind(typeof(Vector256<double>)), VectorKind.v256x64f);
        }

        public void classify_vector_type()
        {
            Claim.eq(VKinds.kind(typeof(Vector128<sbyte>)), VectorKind.v128x8i);
            Claim.eq(VKinds.kind(typeof(Vector128<byte>)), VectorKind.v128x8u);

            Claim.eq(VKinds.kind(typeof(Vector128<short>)), VectorKind.v128x16i);
            Claim.eq(VKinds.kind(typeof(Vector128<ushort>)), VectorKind.v128x16u);

            Claim.eq(VKinds.kind(typeof(Vector128<int>)), VectorKind.v128x32i);
            Claim.eq(VKinds.kind(typeof(Vector128<uint>)), VectorKind.v128x32u);
            Claim.eq(VKinds.kind(typeof(Vector128<float>)), VectorKind.v128x32f);

            Claim.eq(VKinds.kind(typeof(Vector128<ulong>)), VectorKind.v128x64u);
            Claim.eq(VKinds.kind(typeof(Vector128<long>)), VectorKind.v128x64i);
            Claim.eq(VKinds.kind(typeof(Vector128<double>)), VectorKind.v128x64f);

            Claim.eq(VKinds.kind(typeof(Vector256<sbyte>)), VectorKind.v256x8i);
            Claim.eq(VKinds.kind(typeof(Vector256<byte>)), VectorKind.v256x8u);

            Claim.eq(VKinds.kind(typeof(Vector256<short>)), VectorKind.v256x16i);
            Claim.eq(VKinds.kind(typeof(Vector256<ushort>)), VectorKind.v256x16u);

            Claim.eq(VKinds.kind(typeof(Vector256<int>)), VectorKind.v256x32i);
            Claim.eq(VKinds.kind(typeof(Vector256<uint>)), VectorKind.v256x32u);
            Claim.eq(VKinds.kind(typeof(Vector256<float>)), VectorKind.v256x32f);

            Claim.eq(VKinds.kind(typeof(Vector256<ulong>)), VectorKind.v256x64u);
            Claim.eq(VKinds.kind(typeof(Vector256<long>)), VectorKind.v256x64i);
            Claim.eq(VKinds.kind(typeof(Vector256<double>)), VectorKind.v256x64f);
        }
    }
}