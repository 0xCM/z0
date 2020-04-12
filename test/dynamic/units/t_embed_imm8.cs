//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public class t_embed_imm8 : UnitTest<t_embed_imm8>
    {    
        protected override bool TraceDetailEnabled
            => false;

        VMethodSearch Search
            => VMethods.Search;

        public void unary_shift_v128_embed_imm8()
            => iter(VImmTestCases.V128UnaryShifts, m =>  check_unary_shift(m, w128));

        public void unary_shift_v256_embed_imm8()
            => iter(VImmTestCases.V256UnaryShifts, m => check_unary_shift(m, w256));

        byte[] Immediates => new byte[]{1,2,3,4};

        BoxedNumber one(Type t) => BoxedNumber.Define(1).Convert(t);

        void check_unary_shift(MethodInfo src, W128 w)
        {
            Claim.require(src.IsVectorized(w));
            Claim.require(src.AcceptsVector(0,w));
            Claim.require(src.AcceptsImmediate(1));
            Claim.eq(ImmFunctionClass.UnaryImm8, src.ImmFunctionClass());

            var tVector = src.ParameterType(0);
            check_cell_type(tVector, w);
            check_imm_embedding(src,w,tVector);
        }

        void check_imm_embedding(MethodInfo src, W128 w, Type tVector)
        {            
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();
            var vbroadcast = Search.vbroadcast(tCell,w);
            var vones = vbroadcast.Invoke(null, new object[]{w,one(tCell).Boxed});            

            foreach(var imm in Immediates)
            {
                var method = Dynop.EmbedV128UnaryOpImm(src,imm);
                var vOutput = method.Invoke(vones);
            }
        }

        void check_unary_shift(MethodInfo src, W256 w)
        {
            Claim.require(src.IsVectorized(w));
            Claim.require(src.AcceptsVector(0,w));
            Claim.require(src.AcceptsImmediate(1));
            Claim.eq(ImmFunctionClass.UnaryImm8, src.ImmFunctionClass());

            var tVector = src.ParameterType(0);
            check_cell_type(tVector, w);
            check_imm_embedding(src,w,tVector);
        }

        void check_imm_embedding(MethodInfo src, W256 w, Type tVector)
        {
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();
            var vbroadcast = Search.vbroadcast(tCell,w);
            var vones = vbroadcast.Invoke(null, new object[]{w,one(tCell).Boxed});            

            foreach(var imm in Immediates)
            {
                var method = Dynop.EmbedV256UnaryOpImm(src,imm);
                var vOutput = method.Invoke(vones);
                trace(vOutput.ToString());
            }            
        }

        void check_cell_type(Type tVector, W128 w)
        {
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();

            if(TraceDetailEnabled)
            {
                Notify($"tVector := {tVector.DisplayName()}");
                Notify($"kVector := {kVector}");
                Notify($"tCell := {tCell.Name}");
            }
            
            Claim.require(tCell.IsSome());

            if(tVector == typeof(Vector128<sbyte>))
            {
                Claim.require(tCell == typeof(sbyte));
                Claim.eq(VectorKind.v128x8i, kVector);
            }
            else if(tVector == typeof(Vector128<byte>))
            {
                Claim.require(tCell == typeof(byte));
                Claim.eq(VectorKind.v128x8u, kVector);
            }
            else if(tVector == typeof(Vector128<short>))
            {
                Claim.require(tCell == typeof(short));
                Claim.eq(VectorKind.v128x16i, kVector);
            }
            else if(tVector == typeof(Vector128<ushort>))
            {
                Claim.require(tCell == typeof(ushort));
                Claim.eq(VectorKind.v128x16u, kVector);
            }
            else if(tVector == typeof(Vector128<int>))
            {
                Claim.require(tCell == typeof(int));
                Claim.eq(VectorKind.v128x32i, kVector);
            }
            else if(tVector == typeof(Vector128<uint>))
            {
                Claim.require(tCell == typeof(uint));
                Claim.eq(VectorKind.v128x32u, kVector);
            }
            else if(tVector == typeof(Vector128<long>))
            {
                Claim.require(tCell == typeof(long));
                Claim.eq(VectorKind.v128x64i, kVector);
            }
            else if(tVector == typeof(Vector128<ulong>))
            {
                Claim.require(tCell == typeof(ulong));
                Claim.eq(VectorKind.v128x64u, kVector);
            }
            else
                Claim.fail();
        }

        void check_cell_type(Type tVector, W256 w)
        {
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();

            if(TraceDetailEnabled)
            {
                Notify($"tVector := {tVector.DisplayName()}");
                Notify($"kVector := {kVector}");
                Notify($"tCell := {tCell.Name}");
            }
            
            Claim.require(tCell.IsSome());

            if(tVector == typeof(Vector256<sbyte>))
            {
                Claim.require(tCell == typeof(sbyte));
                Claim.eq(VectorKind.v256x8i, kVector);
            }
            else if(tVector == typeof(Vector256<byte>))
            {
                Claim.require(tCell == typeof(byte));
                Claim.eq(VectorKind.v256x8u, kVector);
            }
            else if(tVector == typeof(Vector256<short>))
            {
                Claim.require(tCell == typeof(short));
                Claim.eq(VectorKind.v256x16i, kVector);
            }
            else if(tVector == typeof(Vector256<ushort>))
            {
                Claim.require(tCell == typeof(ushort));
                Claim.eq(VectorKind.v256x16u, kVector);
            }
            else if(tVector == typeof(Vector256<int>))
            {
                Claim.require(tCell == typeof(int));
                Claim.eq(VectorKind.v256x32i, kVector);
            }
            else if(tVector == typeof(Vector256<uint>))
            {
                Claim.require(tCell == typeof(uint));
                Claim.eq(VectorKind.v256x32u, kVector);
            }
            else if(tVector == typeof(Vector256<long>))
            {
                Claim.require(tCell == typeof(long));
                Claim.eq(VectorKind.v256x64i, kVector);
            }
            else if(tVector == typeof(Vector256<ulong>))
            {
                Claim.require(tCell == typeof(ulong));
                Claim.eq(VectorKind.v256x64u, kVector);
            }
            else
                Claim.fail();
        }
    }
}