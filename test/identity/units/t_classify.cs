//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
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
            Claim.Eq(TypeWidth.W8, NumericKind.U8.TypeWidth());
            Claim.Eq(TypeWidth.W8, NumericKind.I8.TypeWidth());
            Claim.Eq(TypeWidth.W16, NumericKind.U16.TypeWidth());
            Claim.Eq(TypeWidth.W16, NumericKind.I16.TypeWidth());
            Claim.Eq(TypeWidth.W32, NumericKind.U32.TypeWidth());
            Claim.Eq(TypeWidth.W32, NumericKind.I32.TypeWidth());
            Claim.Eq(TypeWidth.W32, NumericKind.F32.TypeWidth());
            Claim.Eq(TypeWidth.W64, NumericKind.I64.TypeWidth());
            Claim.Eq(TypeWidth.W64, NumericKind.U64.TypeWidth());
            Claim.Eq(TypeWidth.W64, NumericKind.F64.TypeWidth());
        }

        public void check_numeric_identity()
        {
            Claim.Eq(NumericApiKeyKind.U8, NumericKind.U8.NumericId());
            Claim.Eq(NumericApiKeyKind.I8, NumericKind.I8.NumericId());
            Claim.Eq(NumericApiKeyKind.U16, NumericKind.U16.NumericId());
            Claim.Eq(NumericApiKeyKind.I16, NumericKind.I16.NumericId());
            Claim.Eq(NumericApiKeyKind.U32, NumericKind.U32.NumericId());
            Claim.Eq(NumericApiKeyKind.I32, NumericKind.I32.NumericId());
            Claim.Eq(NumericApiKeyKind.U64, NumericKind.U64.NumericId());
            Claim.Eq(NumericApiKeyKind.I64, NumericKind.I64.NumericId());
            Claim.Eq(NumericApiKeyKind.F32, NumericKind.F32.NumericId());
            Claim.Eq(NumericApiKeyKind.F64, NumericKind.F64.NumericId());
        }

        public void classify_block_segment_16()
        {
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock16<byte>)), NumericKind.U8);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock16<sbyte>)), NumericKind.I8);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock16<ushort>)), NumericKind.U16);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock16<short>)), NumericKind.I16);
        }

        public void classify_block_segment_64()
        {
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<byte>)), NumericKind.U8);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<sbyte>)), NumericKind.I8);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<ushort>)), NumericKind.U16);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<short>)), NumericKind.I16);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<uint>)), NumericKind.U32);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<int>)), NumericKind.I32);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<ulong>)), NumericKind.U64);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<long>)), NumericKind.I64);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<float>)), NumericKind.F32);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock64<double>)), NumericKind.F64);
        }

        public void classify_block_segment_128()
        {
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<byte>)), NumericKind.U8);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<sbyte>)), NumericKind.I8);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<ushort>)), NumericKind.U16);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<short>)), NumericKind.I16);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<uint>)), NumericKind.U32);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<int>)), NumericKind.I32);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<ulong>)), NumericKind.U64);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<long>)), NumericKind.I64);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<float>)), NumericKind.F32);
            Claim.Eq(BlockedKinds.segment(typeof(SpanBlock128<double>)), NumericKind.F64);
        }

        public void classify_block_width()
        {
            Claim.Eq(TypeWidth.W16, BlockedKinds.width(typeof(SpanBlock16<byte>)));
            Claim.Eq(TypeWidth.W32, BlockedKinds.width(typeof(SpanBlock32<byte>)));
            Claim.Eq(TypeWidth.W64, BlockedKinds.width(typeof(SpanBlock64<byte>)));
            Claim.Eq(TypeWidth.W128, BlockedKinds.width(typeof(SpanBlock128<byte>)));
            Claim.Eq(TypeWidth.W256, BlockedKinds.width(typeof(SpanBlock256<byte>)));
            Claim.Eq(TypeWidth.W512, BlockedKinds.width(typeof(SpanBlock512<byte>)));

            Claim.Eq(TypeWidth.W16, BlockedKinds.width(typeof(SpanBlock16<>)));
            Claim.Eq(TypeWidth.W32, BlockedKinds.width(typeof(SpanBlock32<>)));
            Claim.Eq(TypeWidth.W64, BlockedKinds.width(typeof(SpanBlock64<>)));
            Claim.Eq(TypeWidth.W128, BlockedKinds.width(typeof(SpanBlock128<>)));
            Claim.Eq(TypeWidth.W256, BlockedKinds.width(typeof(SpanBlock256<>)));
            Claim.Eq(TypeWidth.W512, BlockedKinds.width(typeof(SpanBlock512<>)));
        }

        static bool blocked(Type t)
            => t.IsBlocked();

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
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock16<byte>)), BlockedKind.b16x8u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock16<sbyte>)), BlockedKind.b16x8i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock16<ushort>)), BlockedKind.b16x16u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock16<short>)), BlockedKind.b16x16i);
        }

        void classify_block_32()
        {
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock32<byte>)), BlockedKind.b32x8u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock32<sbyte>)), BlockedKind.b32x8i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock32<ushort>)), BlockedKind.b32x16u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock32<short>)), BlockedKind.b32x16i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock32<uint>)), BlockedKind.b32x32u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock32<int>)), BlockedKind.b32x32i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock32<float>)), BlockedKind.b32x32f);
        }

        void classify_block_64()
        {
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<byte>)), BlockedKind.b64x8u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<sbyte>)), BlockedKind.b64x8i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<ushort>)), BlockedKind.b64x16u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<short>)), BlockedKind.b64x16i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<uint>)), BlockedKind.b64x32u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<int>)), BlockedKind.b64x32i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<ulong>)), BlockedKind.b64x64u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<long>)), BlockedKind.b64x64i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<float>)), BlockedKind.b64x32f);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock64<double>)), BlockedKind.b64x64f);
        }

        void classify_block_128()
        {
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<byte>)), BlockedKind.b128x8u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<sbyte>)), BlockedKind.b128x8i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<ushort>)), BlockedKind.b128x16u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<short>)), BlockedKind.b128x16i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<uint>)), BlockedKind.b128x32u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<int>)), BlockedKind.b128x32i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<ulong>)), BlockedKind.b128x64u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<long>)), BlockedKind.b128x64i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<float>)), BlockedKind.b128x32f);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock128<double>)), BlockedKind.b128x64f);

        }

        void classify_block_256()
        {
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<byte>)), BlockedKind.b256x8u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<sbyte>)), BlockedKind.b256x8i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<ushort>)), BlockedKind.b256x16u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<short>)), BlockedKind.b256x16i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<uint>)), BlockedKind.b256x32u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<int>)), BlockedKind.b256x32i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<ulong>)), BlockedKind.b256x64u);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<long>)), BlockedKind.b256x64i);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<float>)), BlockedKind.b256x32f);
            Claim.Eq(BlockedKinds.kind(typeof(SpanBlock256<double>)), BlockedKind.b256x64f);
        }

        public void classify_vector()
        {
            Claim.Eq(VectorType.kind(typeof(Vector128<byte>)), VectorKind.v128x8u);
            Claim.Eq(VectorType.kind(typeof(Vector128<sbyte>)), VectorKind.v128x8i);
            Claim.Eq(VectorType.kind(typeof(Vector128<ushort>)), VectorKind.v128x16u);
            Claim.Eq(VectorType.kind(typeof(Vector128<short>)), VectorKind.v128x16i);
            Claim.Eq(VectorType.kind(typeof(Vector128<uint>)), VectorKind.v128x32u);
            Claim.Eq(VectorType.kind(typeof(Vector128<int>)), VectorKind.v128x32i);
            Claim.Eq(VectorType.kind(typeof(Vector128<ulong>)), VectorKind.v128x64u);
            Claim.Eq(VectorType.kind(typeof(Vector128<long>)), VectorKind.v128x64i);
            Claim.Eq(VectorType.kind(typeof(Vector128<float>)), VectorKind.v128x32f);
            Claim.Eq(VectorType.kind(typeof(Vector128<double>)), VectorKind.v128x64f);

            Claim.Eq(VectorType.kind(typeof(Vector256<byte>)), VectorKind.v256x8u);
            Claim.Eq(VectorType.kind(typeof(Vector256<sbyte>)), VectorKind.v256x8i);
            Claim.Eq(VectorType.kind(typeof(Vector256<ushort>)), VectorKind.v256x16u);
            Claim.Eq(VectorType.kind(typeof(Vector256<short>)), VectorKind.v256x16i);
            Claim.Eq(VectorType.kind(typeof(Vector256<uint>)), VectorKind.v256x32u);
            Claim.Eq(VectorType.kind(typeof(Vector256<int>)), VectorKind.v256x32i);
            Claim.Eq(VectorType.kind(typeof(Vector256<ulong>)), VectorKind.v256x64u);
            Claim.Eq(VectorType.kind(typeof(Vector256<long>)), VectorKind.v256x64i);
            Claim.Eq(VectorType.kind(typeof(Vector256<float>)), VectorKind.v256x32f);
            Claim.Eq(VectorType.kind(typeof(Vector256<double>)), VectorKind.v256x64f);
        }

        public void classify_vector_type()
        {
            Claim.Eq(VectorType.kind(typeof(Vector128<sbyte>)), VectorKind.v128x8i);
            Claim.Eq(VectorType.kind(typeof(Vector128<byte>)), VectorKind.v128x8u);

            Claim.Eq(VectorType.kind(typeof(Vector128<short>)), VectorKind.v128x16i);
            Claim.Eq(VectorType.kind(typeof(Vector128<ushort>)), VectorKind.v128x16u);

            Claim.Eq(VectorType.kind(typeof(Vector128<int>)), VectorKind.v128x32i);
            Claim.Eq(VectorType.kind(typeof(Vector128<uint>)), VectorKind.v128x32u);
            Claim.Eq(VectorType.kind(typeof(Vector128<float>)), VectorKind.v128x32f);

            Claim.Eq(VectorType.kind(typeof(Vector128<ulong>)), VectorKind.v128x64u);
            Claim.Eq(VectorType.kind(typeof(Vector128<long>)), VectorKind.v128x64i);
            Claim.Eq(VectorType.kind(typeof(Vector128<double>)), VectorKind.v128x64f);

            Claim.Eq(VectorType.kind(typeof(Vector256<sbyte>)), VectorKind.v256x8i);
            Claim.Eq(VectorType.kind(typeof(Vector256<byte>)), VectorKind.v256x8u);

            Claim.Eq(VectorType.kind(typeof(Vector256<short>)), VectorKind.v256x16i);
            Claim.Eq(VectorType.kind(typeof(Vector256<ushort>)), VectorKind.v256x16u);

            Claim.Eq(VectorType.kind(typeof(Vector256<int>)), VectorKind.v256x32i);
            Claim.Eq(VectorType.kind(typeof(Vector256<uint>)), VectorKind.v256x32u);
            Claim.Eq(VectorType.kind(typeof(Vector256<float>)), VectorKind.v256x32f);

            Claim.Eq(VectorType.kind(typeof(Vector256<ulong>)), VectorKind.v256x64u);
            Claim.Eq(VectorType.kind(typeof(Vector256<long>)), VectorKind.v256x64i);
            Claim.Eq(VectorType.kind(typeof(Vector256<double>)), VectorKind.v256x64f);
        }
    }
}