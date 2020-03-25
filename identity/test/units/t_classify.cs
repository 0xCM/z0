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
    
    using static Root;

    public sealed class t_classify : t_identity<t_classify>
    {
        static string FormatList(IEnumerable<NumericKind> src, char? sep = null)
            => src.Select(k => k.ToString()).Concat(sep ?? text.comma());

        static string FormatList(IEnumerable<Type> src, char? sep = null)
            => src.Select(k => k.DisplayName()).Concat(sep ?? text.comma());

        public void classify_numeric()
        {

            var fkExpect = set(NumericKind.F32, NumericKind.F64);
            var fkActual = NumericKind.Floats.DistinctKinds();
            Claim.eq(fkExpect,fkActual);

            var ftExpect = set(typeof(float), typeof(double));
            var ftActual = NumericKind.Floats.DistinctTypes();
            Claim.eq(ftExpect,ftActual);


            var ukExpect = set(NumericKind.U8, NumericKind.U16, NumericKind.U32, NumericKind.U64);
            var ukActual = NumericKind.UnsignedInts.DistinctKinds();
            Claim.eq(ukExpect,ukActual);

            var utExpect = set(typeof(byte), typeof(ushort), typeof(uint), typeof(ulong));
            var utActual = NumericKind.UnsignedInts.DistinctTypes();
            Claim.eq(utExpect,utActual);

            var skExpect = set(NumericKind.I8, NumericKind.I16, NumericKind.I32, NumericKind.I64);
            var skActual = NumericKind.SignedInts.DistinctKinds();
            Claim.eq(skExpect,skActual);

            var stExpect = set(typeof(sbyte), typeof(short), typeof(int), typeof(long));
            var stActual = NumericKind.SignedInts.DistinctTypes();
            Claim.eq(stExpect,stActual);            

        }

        public void classify_numeric_width()
        {
            Claim.eq(FixedWidth.W8, NumericKind.U8.WidthKind());
            Claim.eq(FixedWidth.W8, NumericKind.I8.WidthKind());
            Claim.eq(FixedWidth.W16, NumericKind.U16.WidthKind());
            Claim.eq(FixedWidth.W16, NumericKind.I16.WidthKind());
            Claim.eq(FixedWidth.W32, NumericKind.U32.WidthKind());
            Claim.eq(FixedWidth.W32, NumericKind.I32.WidthKind());
            Claim.eq(FixedWidth.W32, NumericKind.F32.WidthKind());
            Claim.eq(FixedWidth.W64, NumericKind.I64.WidthKind());
            Claim.eq(FixedWidth.W64, NumericKind.U64.WidthKind());
            Claim.eq(FixedWidth.W64, NumericKind.F64.WidthKind());
        }

        public void check_numeric_identity()
        {
            Claim.eq(NumericTypeId.U8, NumericKind.U8.GetNumericId());
            Claim.eq(NumericTypeId.I8, NumericKind.I8.GetNumericId());
            Claim.eq(NumericTypeId.U16, NumericKind.U16.GetNumericId());
            Claim.eq(NumericTypeId.I16, NumericKind.I16.GetNumericId());
            Claim.eq(NumericTypeId.U32, NumericKind.U32.GetNumericId());
            Claim.eq(NumericTypeId.I32, NumericKind.I32.GetNumericId());
            Claim.eq(NumericTypeId.U64, NumericKind.U64.GetNumericId());
            Claim.eq(NumericTypeId.I64, NumericKind.I64.GetNumericId());
            Claim.eq(NumericTypeId.F32, NumericKind.F32.GetNumericId());
            Claim.eq(NumericTypeId.F64, NumericKind.F64.GetNumericId());
        }

        public void classify_block_segment_16()
        {
            Claim.eq(BK.segment(typeof(Block16<byte>)), NumericKind.U8);
            Claim.eq(BK.segment(typeof(Block16<sbyte>)), NumericKind.I8);
            Claim.eq(BK.segment(typeof(Block16<ushort>)), NumericKind.U16);
            Claim.eq(BK.segment(typeof(Block16<short>)), NumericKind.I16);
        }

        public void classify_block_segment_64()
        {
            Claim.eq(BK.segment(typeof(Block64<byte>)), NumericKind.U8);
            Claim.eq(BK.segment(typeof(Block64<sbyte>)), NumericKind.I8);
            Claim.eq(BK.segment(typeof(Block64<ushort>)), NumericKind.U16);
            Claim.eq(BK.segment(typeof(Block64<short>)), NumericKind.I16);
            Claim.eq(BK.segment(typeof(Block64<uint>)), NumericKind.U32);
            Claim.eq(BK.segment(typeof(Block64<int>)), NumericKind.I32);
            Claim.eq(BK.segment(typeof(Block64<ulong>)), NumericKind.U64);
            Claim.eq(BK.segment(typeof(Block64<long>)), NumericKind.I64);
            Claim.eq(BK.segment(typeof(Block64<float>)), NumericKind.F32);
            Claim.eq(BK.segment(typeof(Block64<double>)), NumericKind.F64);
        }

        public void classify_block_segment_128()
        {
            Claim.eq(BK.segment(typeof(Block128<byte>)), NumericKind.U8);
            Claim.eq(BK.segment(typeof(Block128<sbyte>)), NumericKind.I8);
            Claim.eq(BK.segment(typeof(Block128<ushort>)), NumericKind.U16);
            Claim.eq(BK.segment(typeof(Block128<short>)), NumericKind.I16);
            Claim.eq(BK.segment(typeof(Block128<uint>)), NumericKind.U32);
            Claim.eq(BK.segment(typeof(Block128<int>)), NumericKind.I32);
            Claim.eq(BK.segment(typeof(Block128<ulong>)), NumericKind.U64);
            Claim.eq(BK.segment(typeof(Block128<long>)), NumericKind.I64);
            Claim.eq(BK.segment(typeof(Block128<float>)), NumericKind.F32);
            Claim.eq(BK.segment(typeof(Block128<double>)), NumericKind.F64);
        }

        public void classify_block_width()
        {
            Claim.eq(FixedWidth.W16, BK.width(typeof(Block16<byte>)));
            Claim.eq(FixedWidth.W32, BK.width(typeof(Block32<byte>)));
            Claim.eq(FixedWidth.W64, BK.width(typeof(Block64<byte>)));
            Claim.eq(FixedWidth.W128, BK.width(typeof(Block128<byte>)));
            Claim.eq(FixedWidth.W256, BK.width(typeof(Block256<byte>)));
            Claim.eq(FixedWidth.W512, BK.width(typeof(Block512<byte>)));

            Claim.eq(FixedWidth.W16, BK.width(typeof(Block16<>)));
            Claim.eq(FixedWidth.W32, BK.width(typeof(Block32<>)));
            Claim.eq(FixedWidth.W64, BK.width(typeof(Block64<>)));
            Claim.eq(FixedWidth.W128, BK.width(typeof(Block128<>)));
            Claim.eq(FixedWidth.W256, BK.width(typeof(Block256<>)));
            Claim.eq(FixedWidth.W512, BK.width(typeof(Block512<>)));
        }

        public void test_generic_blocks()
        {
            Claim.yea(BK.test(typeof(Block16<>)));
            Claim.yea(BK.test(typeof(Block32<>)));
            Claim.yea(BK.test(typeof(Block64<>)));
            Claim.yea(BK.test(typeof(Block128<>)));
            Claim.yea(BK.test(typeof(Block256<>)));
            Claim.yea(BK.test(typeof(Block512<>)));
        }

        public void test_block_16()
        {
            Claim.yea(BK.test(typeof(Block16<byte>)));
            Claim.yea(BK.test(typeof(Block16<sbyte>)));
            Claim.yea(BK.test(typeof(Block16<ushort>)));
            Claim.yea(BK.test(typeof(Block16<short>)));
        }

        public void test_block_32()
        {
            Claim.yea(BK.test(typeof(Block32<byte>)));
            Claim.yea(BK.test(typeof(Block32<sbyte>)));
            Claim.yea(BK.test(typeof(Block32<ushort>)));
            Claim.yea(BK.test(typeof(Block32<short>)));
            Claim.yea(BK.test(typeof(Block32<int>)));
            Claim.yea(BK.test(typeof(Block32<uint>)));
            Claim.yea(BK.test(typeof(Block32<float>)));
        }

        public void test_block_64()
        {
            Claim.yea(BK.test(typeof(Block64<byte>)));
            Claim.yea(BK.test(typeof(Block64<sbyte>)));
            Claim.yea(BK.test(typeof(Block64<ushort>)));
            Claim.yea(BK.test(typeof(Block64<short>)));
            Claim.yea(BK.test(typeof(Block64<int>)));
            Claim.yea(BK.test(typeof(Block64<uint>)));
            Claim.yea(BK.test(typeof(Block64<long>)));
            Claim.yea(BK.test(typeof(Block64<ulong>)));
            Claim.yea(BK.test(typeof(Block64<float>)));
            Claim.yea(BK.test(typeof(Block64<double>)));
        }

        public void test_block_128()
        {
            Claim.yea(BK.test(typeof(Block128<byte>)));
            Claim.yea(BK.test(typeof(Block128<sbyte>)));
            Claim.yea(BK.test(typeof(Block128<ushort>)));
            Claim.yea(BK.test(typeof(Block128<short>)));
            Claim.yea(BK.test(typeof(Block128<int>)));
            Claim.yea(BK.test(typeof(Block128<uint>)));
            Claim.yea(BK.test(typeof(Block128<long>)));
            Claim.yea(BK.test(typeof(Block128<ulong>)));
            Claim.yea(BK.test(typeof(Block128<float>)));
            Claim.yea(BK.test(typeof(Block128<double>)));
        }

        public void classify_block_16()
        {
            Claim.eq(BK.kind(typeof(Block16<byte>)), BlockedKind.b16x8u);
            Claim.eq(BK.kind(typeof(Block16<sbyte>)), BlockedKind.b16x8i);
            Claim.eq(BK.kind(typeof(Block16<ushort>)), BlockedKind.b16x16u);
            Claim.eq(BK.kind(typeof(Block16<short>)), BlockedKind.b16x16i);
        }

        void classify_block_32()
        {
            Claim.eq(BK.kind(typeof(Block32<byte>)), BlockedKind.b32x8u);
            Claim.eq(BK.kind(typeof(Block32<sbyte>)), BlockedKind.b32x8i);
            Claim.eq(BK.kind(typeof(Block32<ushort>)), BlockedKind.b32x16u);
            Claim.eq(BK.kind(typeof(Block32<short>)), BlockedKind.b32x16i);
            Claim.eq(BK.kind(typeof(Block32<uint>)), BlockedKind.b32x32u);
            Claim.eq(BK.kind(typeof(Block32<int>)), BlockedKind.b32x32i);
            Claim.eq(BK.kind(typeof(Block32<float>)), BlockedKind.b32x32f);
        }

        void classify_block_64()
        {
            Claim.eq(BK.kind(typeof(Block64<byte>)), BlockedKind.b64x8u);
            Claim.eq(BK.kind(typeof(Block64<sbyte>)), BlockedKind.b64x8i);
            Claim.eq(BK.kind(typeof(Block64<ushort>)), BlockedKind.b64x16u);
            Claim.eq(BK.kind(typeof(Block64<short>)), BlockedKind.b64x16i);
            Claim.eq(BK.kind(typeof(Block64<uint>)), BlockedKind.b64x32u);
            Claim.eq(BK.kind(typeof(Block64<int>)), BlockedKind.b64x32i);
            Claim.eq(BK.kind(typeof(Block64<ulong>)), BlockedKind.b64x64u);
            Claim.eq(BK.kind(typeof(Block64<long>)), BlockedKind.b64x64i);
            Claim.eq(BK.kind(typeof(Block64<float>)), BlockedKind.b64x32f);
            Claim.eq(BK.kind(typeof(Block64<double>)), BlockedKind.b64x64f);
        }

        void classify_block_128()
        {
            Claim.eq(BK.kind(typeof(Block128<byte>)), BlockedKind.b128x8u);
            Claim.eq(BK.kind(typeof(Block128<sbyte>)), BlockedKind.b128x8i);
            Claim.eq(BK.kind(typeof(Block128<ushort>)), BlockedKind.b128x16u);
            Claim.eq(BK.kind(typeof(Block128<short>)), BlockedKind.b128x16i);
            Claim.eq(BK.kind(typeof(Block128<uint>)), BlockedKind.b128x32u);
            Claim.eq(BK.kind(typeof(Block128<int>)), BlockedKind.b128x32i);
            Claim.eq(BK.kind(typeof(Block128<ulong>)), BlockedKind.b128x64u);
            Claim.eq(BK.kind(typeof(Block128<long>)), BlockedKind.b128x64i);
            Claim.eq(BK.kind(typeof(Block128<float>)), BlockedKind.b128x32f);
            Claim.eq(BK.kind(typeof(Block128<double>)), BlockedKind.b128x64f);

        }

        void classify_block_256()
        {
            Claim.eq(BK.kind(typeof(Block256<byte>)), BlockedKind.b256x8u);
            Claim.eq(BK.kind(typeof(Block256<sbyte>)), BlockedKind.b256x8i);
            Claim.eq(BK.kind(typeof(Block256<ushort>)), BlockedKind.b256x16u);
            Claim.eq(BK.kind(typeof(Block256<short>)), BlockedKind.b256x16i);
            Claim.eq(BK.kind(typeof(Block256<uint>)), BlockedKind.b256x32u);
            Claim.eq(BK.kind(typeof(Block256<int>)), BlockedKind.b256x32i);
            Claim.eq(BK.kind(typeof(Block256<ulong>)), BlockedKind.b256x64u);
            Claim.eq(BK.kind(typeof(Block256<long>)), BlockedKind.b256x64i);
            Claim.eq(BK.kind(typeof(Block256<float>)), BlockedKind.b256x32f);
            Claim.eq(BK.kind(typeof(Block256<double>)), BlockedKind.b256x64f);
        }

        public void classify_vector()
        {
            Claim.eq(VectorType.kind(typeof(Vector128<byte>)), VectorKind.v128x8u);
            Claim.eq(VectorType.kind(typeof(Vector128<sbyte>)), VectorKind.v128x8i);
            Claim.eq(VectorType.kind(typeof(Vector128<ushort>)), VectorKind.v128x16u);
            Claim.eq(VectorType.kind(typeof(Vector128<short>)), VectorKind.v128x16i);
            Claim.eq(VectorType.kind(typeof(Vector128<uint>)), VectorKind.v128x32u);
            Claim.eq(VectorType.kind(typeof(Vector128<int>)), VectorKind.v128x32i);
            Claim.eq(VectorType.kind(typeof(Vector128<ulong>)), VectorKind.v128x64u);
            Claim.eq(VectorType.kind(typeof(Vector128<long>)), VectorKind.v128x64i);
            Claim.eq(VectorType.kind(typeof(Vector128<float>)), VectorKind.v128x32f);
            Claim.eq(VectorType.kind(typeof(Vector128<double>)), VectorKind.v128x64f);

            Claim.eq(VectorType.kind(typeof(Vector256<byte>)), VectorKind.v256x8u);
            Claim.eq(VectorType.kind(typeof(Vector256<sbyte>)), VectorKind.v256x8i);
            Claim.eq(VectorType.kind(typeof(Vector256<ushort>)), VectorKind.v256x16u);
            Claim.eq(VectorType.kind(typeof(Vector256<short>)), VectorKind.v256x16i);
            Claim.eq(VectorType.kind(typeof(Vector256<uint>)), VectorKind.v256x32u);
            Claim.eq(VectorType.kind(typeof(Vector256<int>)), VectorKind.v256x32i);
            Claim.eq(VectorType.kind(typeof(Vector256<ulong>)), VectorKind.v256x64u);
            Claim.eq(VectorType.kind(typeof(Vector256<long>)), VectorKind.v256x64i);
            Claim.eq(VectorType.kind(typeof(Vector256<float>)), VectorKind.v256x32f);
            Claim.eq(VectorType.kind(typeof(Vector256<double>)), VectorKind.v256x64f);
        }

        public void classify_vector_type()
        {
            Claim.eq(VectorType.kind(typeof(Vector128<sbyte>)), VectorKind.v128x8i);       
            Claim.eq(VectorType.kind(typeof(Vector128<byte>)), VectorKind.v128x8u);

            Claim.eq(VectorType.kind(typeof(Vector128<short>)), VectorKind.v128x16i);
            Claim.eq(VectorType.kind(typeof(Vector128<ushort>)), VectorKind.v128x16u);

            Claim.eq(VectorType.kind(typeof(Vector128<int>)), VectorKind.v128x32i);
            Claim.eq(VectorType.kind(typeof(Vector128<uint>)), VectorKind.v128x32u);
            Claim.eq(VectorType.kind(typeof(Vector128<float>)), VectorKind.v128x32f);

            Claim.eq(VectorType.kind(typeof(Vector128<ulong>)), VectorKind.v128x64u);
            Claim.eq(VectorType.kind(typeof(Vector128<long>)), VectorKind.v128x64i);
            Claim.eq(VectorType.kind(typeof(Vector128<double>)), VectorKind.v128x64f);

            Claim.eq(VectorType.kind(typeof(Vector256<sbyte>)), VectorKind.v256x8i);
            Claim.eq(VectorType.kind(typeof(Vector256<byte>)), VectorKind.v256x8u);

            Claim.eq(VectorType.kind(typeof(Vector256<short>)), VectorKind.v256x16i);
            Claim.eq(VectorType.kind(typeof(Vector256<ushort>)), VectorKind.v256x16u);

            Claim.eq(VectorType.kind(typeof(Vector256<int>)), VectorKind.v256x32i);
            Claim.eq(VectorType.kind(typeof(Vector256<uint>)), VectorKind.v256x32u);
            Claim.eq(VectorType.kind(typeof(Vector256<float>)), VectorKind.v256x32f);

            Claim.eq(VectorType.kind(typeof(Vector256<ulong>)), VectorKind.v256x64u);
            Claim.eq(VectorType.kind(typeof(Vector256<long>)), VectorKind.v256x64i);
            Claim.eq(VectorType.kind(typeof(Vector256<double>)), VectorKind.v256x64f);

        }


    }

}