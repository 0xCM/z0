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
    using static Memories;

    public sealed class t_classify : t_identity<t_classify>
    {        
        static string FormatList(IEnumerable<NumericKind> src, char? sep = null)
            => src.Select(k => k.ToString()).Concat(sep ?? Chars.Comma);

        static string FormatList(IEnumerable<Type> src, char? sep = null)
            => src.Select(k => k.DisplayName()).Concat(sep ?? Chars.Comma);

        public void classify_numeric()
        {

            var fkExpect = set(NumericKind.F32, NumericKind.F64);
            var fkActual = NumericKind.Floats.DistinctKinds();
            Claim.seteq(fkExpect,fkActual);

            var ftExpect = set(typeof(float), typeof(double));
            var ftActual = NumericKind.Floats.DistinctTypes();
            Claim.seteq(ftExpect,ftActual);


            var ukExpect = set(NumericKind.U8, NumericKind.U16, NumericKind.U32, NumericKind.U64);
            var ukActual = NumericKind.UnsignedInts.DistinctKinds();
            Claim.seteq(ukExpect,ukActual);

            var utExpect = set(typeof(byte), typeof(ushort), typeof(uint), typeof(ulong));
            var utActual = NumericKind.UnsignedInts.DistinctTypes();
            Claim.seteq(utExpect,utActual);

            var skExpect = set(NumericKind.I8, NumericKind.I16, NumericKind.I32, NumericKind.I64);
            var skActual = NumericKind.SignedInts.DistinctKinds();
            Claim.seteq(skExpect,skActual);

            var stExpect = set(typeof(sbyte), typeof(short), typeof(int), typeof(long));
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
            Claim.Eq(NumericTypeId.U8, NumericKind.U8.NumericId());
            Claim.Eq(NumericTypeId.I8, NumericKind.I8.NumericId());
            Claim.Eq(NumericTypeId.U16, NumericKind.U16.NumericId());
            Claim.Eq(NumericTypeId.I16, NumericKind.I16.NumericId());
            Claim.Eq(NumericTypeId.U32, NumericKind.U32.NumericId());
            Claim.Eq(NumericTypeId.I32, NumericKind.I32.NumericId());
            Claim.Eq(NumericTypeId.U64, NumericKind.U64.NumericId());
            Claim.Eq(NumericTypeId.I64, NumericKind.I64.NumericId());
            Claim.Eq(NumericTypeId.F32, NumericKind.F32.NumericId());
            Claim.Eq(NumericTypeId.F64, NumericKind.F64.NumericId());
        }

        public void classify_block_segment_16()
        {
            Claim.Eq(BlockedKinds.segment(typeof(Block16<byte>)), NumericKind.U8);
            Claim.Eq(BlockedKinds.segment(typeof(Block16<sbyte>)), NumericKind.I8);
            Claim.Eq(BlockedKinds.segment(typeof(Block16<ushort>)), NumericKind.U16);
            Claim.Eq(BlockedKinds.segment(typeof(Block16<short>)), NumericKind.I16);
        }

        public void classify_block_segment_64()
        {
            Claim.Eq(BlockedKinds.segment(typeof(Block64<byte>)), NumericKind.U8);
            Claim.Eq(BlockedKinds.segment(typeof(Block64<sbyte>)), NumericKind.I8);
            Claim.Eq(BlockedKinds.segment(typeof(Block64<ushort>)), NumericKind.U16);
            Claim.Eq(BlockedKinds.segment(typeof(Block64<short>)), NumericKind.I16);
            Claim.Eq(BlockedKinds.segment(typeof(Block64<uint>)), NumericKind.U32);
            Claim.Eq(BlockedKinds.segment(typeof(Block64<int>)), NumericKind.I32);
            Claim.Eq(BlockedKinds.segment(typeof(Block64<ulong>)), NumericKind.U64);
            Claim.Eq(BlockedKinds.segment(typeof(Block64<long>)), NumericKind.I64);
            Claim.Eq(BlockedKinds.segment(typeof(Block64<float>)), NumericKind.F32);
            Claim.Eq(BlockedKinds.segment(typeof(Block64<double>)), NumericKind.F64);
        }

        public void classify_block_segment_128()
        {
            Claim.Eq(BlockedKinds.segment(typeof(Block128<byte>)), NumericKind.U8);
            Claim.Eq(BlockedKinds.segment(typeof(Block128<sbyte>)), NumericKind.I8);
            Claim.Eq(BlockedKinds.segment(typeof(Block128<ushort>)), NumericKind.U16);
            Claim.Eq(BlockedKinds.segment(typeof(Block128<short>)), NumericKind.I16);
            Claim.Eq(BlockedKinds.segment(typeof(Block128<uint>)), NumericKind.U32);
            Claim.Eq(BlockedKinds.segment(typeof(Block128<int>)), NumericKind.I32);
            Claim.Eq(BlockedKinds.segment(typeof(Block128<ulong>)), NumericKind.U64);
            Claim.Eq(BlockedKinds.segment(typeof(Block128<long>)), NumericKind.I64);
            Claim.Eq(BlockedKinds.segment(typeof(Block128<float>)), NumericKind.F32);
            Claim.Eq(BlockedKinds.segment(typeof(Block128<double>)), NumericKind.F64);
        }

        public void classify_block_width()
        {
            Claim.Eq(TypeWidth.W16, BlockedKinds.width(typeof(Block16<byte>)));
            Claim.Eq(TypeWidth.W32, BlockedKinds.width(typeof(Block32<byte>)));
            Claim.Eq(TypeWidth.W64, BlockedKinds.width(typeof(Block64<byte>)));
            Claim.Eq(TypeWidth.W128, BlockedKinds.width(typeof(Block128<byte>)));
            Claim.Eq(TypeWidth.W256, BlockedKinds.width(typeof(Block256<byte>)));
            Claim.Eq(TypeWidth.W512, BlockedKinds.width(typeof(Block512<byte>)));

            Claim.Eq(TypeWidth.W16, BlockedKinds.width(typeof(Block16<>)));
            Claim.Eq(TypeWidth.W32, BlockedKinds.width(typeof(Block32<>)));
            Claim.Eq(TypeWidth.W64, BlockedKinds.width(typeof(Block64<>)));
            Claim.Eq(TypeWidth.W128, BlockedKinds.width(typeof(Block128<>)));
            Claim.Eq(TypeWidth.W256, BlockedKinds.width(typeof(Block256<>)));
            Claim.Eq(TypeWidth.W512, BlockedKinds.width(typeof(Block512<>)));
        }

        static bool blocked(Type t)
            => t.IsBlocked();

        public void test_generic_blocks()
        {
            Claim.Require(blocked(typeof(Block16<>)));
            Claim.Require(blocked(typeof(Block32<>)));
            Claim.Require(blocked(typeof(Block64<>)));
            Claim.Require(blocked(typeof(Block128<>)));
            Claim.Require(blocked(typeof(Block256<>)));
            Claim.Require(blocked(typeof(Block512<>)));
        }

        public void test_block_16()
        {
            Claim.Require(blocked(typeof(Block16<byte>)));
            Claim.Require(blocked(typeof(Block16<sbyte>)));
            Claim.Require(blocked(typeof(Block16<ushort>)));
            Claim.Require(blocked(typeof(Block16<short>)));
        }

        public void test_block_32()
        {
            Claim.Require(blocked(typeof(Block32<byte>)));
            Claim.Require(blocked(typeof(Block32<sbyte>)));
            Claim.Require(blocked(typeof(Block32<ushort>)));
            Claim.Require(blocked(typeof(Block32<short>)));
            Claim.Require(blocked(typeof(Block32<int>)));
            Claim.Require(blocked(typeof(Block32<uint>)));
            Claim.Require(blocked(typeof(Block32<float>)));
        }

        public void test_block_64()
        {
            Claim.Require(blocked(typeof(Block64<byte>)));
            Claim.Require(blocked(typeof(Block64<sbyte>)));
            Claim.Require(blocked(typeof(Block64<ushort>)));
            Claim.Require(blocked(typeof(Block64<short>)));
            Claim.Require(blocked(typeof(Block64<int>)));
            Claim.Require(blocked(typeof(Block64<uint>)));
            Claim.Require(blocked(typeof(Block64<long>)));
            Claim.Require(blocked(typeof(Block64<ulong>)));
            Claim.Require(blocked(typeof(Block64<float>)));
            Claim.Require(blocked(typeof(Block64<double>)));
        }

        public void test_block_128()
        {
            Claim.Require(blocked(typeof(Block128<byte>)));
            Claim.Require(blocked(typeof(Block128<sbyte>)));
            Claim.Require(blocked(typeof(Block128<ushort>)));
            Claim.Require(blocked(typeof(Block128<short>)));
            Claim.Require(blocked(typeof(Block128<int>)));
            Claim.Require(blocked(typeof(Block128<uint>)));
            Claim.Require(blocked(typeof(Block128<long>)));
            Claim.Require(blocked(typeof(Block128<ulong>)));
            Claim.Require(blocked(typeof(Block128<float>)));
            Claim.Require(blocked(typeof(Block128<double>)));
        }

        public void classify_block_16()
        {
            Claim.Eq(BlockedKinds.kind(typeof(Block16<byte>)), BlockedKind.b16x8u);
            Claim.Eq(BlockedKinds.kind(typeof(Block16<sbyte>)), BlockedKind.b16x8i);
            Claim.Eq(BlockedKinds.kind(typeof(Block16<ushort>)), BlockedKind.b16x16u);
            Claim.Eq(BlockedKinds.kind(typeof(Block16<short>)), BlockedKind.b16x16i);
        }

        void classify_block_32()
        {
            Claim.Eq(BlockedKinds.kind(typeof(Block32<byte>)), BlockedKind.b32x8u);
            Claim.Eq(BlockedKinds.kind(typeof(Block32<sbyte>)), BlockedKind.b32x8i);
            Claim.Eq(BlockedKinds.kind(typeof(Block32<ushort>)), BlockedKind.b32x16u);
            Claim.Eq(BlockedKinds.kind(typeof(Block32<short>)), BlockedKind.b32x16i);
            Claim.Eq(BlockedKinds.kind(typeof(Block32<uint>)), BlockedKind.b32x32u);
            Claim.Eq(BlockedKinds.kind(typeof(Block32<int>)), BlockedKind.b32x32i);
            Claim.Eq(BlockedKinds.kind(typeof(Block32<float>)), BlockedKind.b32x32f);
        }

        void classify_block_64()
        {
            Claim.Eq(BlockedKinds.kind(typeof(Block64<byte>)), BlockedKind.b64x8u);
            Claim.Eq(BlockedKinds.kind(typeof(Block64<sbyte>)), BlockedKind.b64x8i);
            Claim.Eq(BlockedKinds.kind(typeof(Block64<ushort>)), BlockedKind.b64x16u);
            Claim.Eq(BlockedKinds.kind(typeof(Block64<short>)), BlockedKind.b64x16i);
            Claim.Eq(BlockedKinds.kind(typeof(Block64<uint>)), BlockedKind.b64x32u);
            Claim.Eq(BlockedKinds.kind(typeof(Block64<int>)), BlockedKind.b64x32i);
            Claim.Eq(BlockedKinds.kind(typeof(Block64<ulong>)), BlockedKind.b64x64u);
            Claim.Eq(BlockedKinds.kind(typeof(Block64<long>)), BlockedKind.b64x64i);
            Claim.Eq(BlockedKinds.kind(typeof(Block64<float>)), BlockedKind.b64x32f);
            Claim.Eq(BlockedKinds.kind(typeof(Block64<double>)), BlockedKind.b64x64f);
        }

        void classify_block_128()
        {
            Claim.Eq(BlockedKinds.kind(typeof(Block128<byte>)), BlockedKind.b128x8u);
            Claim.Eq(BlockedKinds.kind(typeof(Block128<sbyte>)), BlockedKind.b128x8i);
            Claim.Eq(BlockedKinds.kind(typeof(Block128<ushort>)), BlockedKind.b128x16u);
            Claim.Eq(BlockedKinds.kind(typeof(Block128<short>)), BlockedKind.b128x16i);
            Claim.Eq(BlockedKinds.kind(typeof(Block128<uint>)), BlockedKind.b128x32u);
            Claim.Eq(BlockedKinds.kind(typeof(Block128<int>)), BlockedKind.b128x32i);
            Claim.Eq(BlockedKinds.kind(typeof(Block128<ulong>)), BlockedKind.b128x64u);
            Claim.Eq(BlockedKinds.kind(typeof(Block128<long>)), BlockedKind.b128x64i);
            Claim.Eq(BlockedKinds.kind(typeof(Block128<float>)), BlockedKind.b128x32f);
            Claim.Eq(BlockedKinds.kind(typeof(Block128<double>)), BlockedKind.b128x64f);

        }

        void classify_block_256()
        {
            Claim.Eq(BlockedKinds.kind(typeof(Block256<byte>)), BlockedKind.b256x8u);
            Claim.Eq(BlockedKinds.kind(typeof(Block256<sbyte>)), BlockedKind.b256x8i);
            Claim.Eq(BlockedKinds.kind(typeof(Block256<ushort>)), BlockedKind.b256x16u);
            Claim.Eq(BlockedKinds.kind(typeof(Block256<short>)), BlockedKind.b256x16i);
            Claim.Eq(BlockedKinds.kind(typeof(Block256<uint>)), BlockedKind.b256x32u);
            Claim.Eq(BlockedKinds.kind(typeof(Block256<int>)), BlockedKind.b256x32i);
            Claim.Eq(BlockedKinds.kind(typeof(Block256<ulong>)), BlockedKind.b256x64u);
            Claim.Eq(BlockedKinds.kind(typeof(Block256<long>)), BlockedKind.b256x64i);
            Claim.Eq(BlockedKinds.kind(typeof(Block256<float>)), BlockedKind.b256x32f);
            Claim.Eq(BlockedKinds.kind(typeof(Block256<double>)), BlockedKind.b256x64f);
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