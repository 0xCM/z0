//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;

    public class t_vimm_imbedding : UnitTest<t_vimm_imbedding>
    {    
        protected override bool TraceDetailEnabled
            => false;

        VMethodSearch Search
            => VMethods.Search;

        public void v128imm_unary_shift()
            => iter(VImmTestCases.V128UnaryShifts, m =>  check_unary_shift(m,n128));

        public void v256imm_unary_shift()
            => iter(VImmTestCases.V256UnaryShifts, m => check_unary_shift(m, n256));

        byte[] Immediates => new byte[]{1,2,3,4};

        BoxedNumber one(Type t) => BoxedNumber.Define(1).Convert(t);


        void check_unary_shift(MethodInfo src, N128 w)
        {
            Claim.yea(src.IsVectorized(w));
            Claim.yea(src.AcceptsVector(0,w));
            Claim.yea(src.AcceptsImmediate(1));
            Claim.eq(ImmClass.UnaryImm8, src.ImmClass());

            var tVector = src.ParameterType(0);
            check_cell_type(tVector, w);
            check_imm_embedding(src,w,tVector);
        }

        void check_imm_embedding(MethodInfo src, N128 w, Type tVector)
        {            
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();
            var vbroadcast = Search.vbroadcast(tCell,w);
            var vones = vbroadcast.Invoke(null, new object[]{w,one(tCell).Boxed});            

            foreach(var imm in Immediates)
            {
                var method = Dynop.EmbedVUnaryOpImm(src,imm);//src.V128EmbedUnaryImm(imm);
                var vOutput = method.Invoke(vones);
            }
        }

        void check_unary_shift(MethodInfo src, N256 w)
        {
            Claim.yea(src.IsVectorized(w));
            Claim.yea(src.AcceptsVector(0,w));
            Claim.yea(src.AcceptsImmediate(1));
            Claim.eq(ImmClass.UnaryImm8, src.ImmClass());

            var tVector = src.ParameterType(0);
            check_cell_type(tVector, w);
            check_imm_embedding(src,w,tVector);
        }

        void check_imm_embedding(MethodInfo src, N256 w, Type tVector)
        {
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();
            var vbroadcast = Search.vbroadcast(tCell,w);
            var vones = vbroadcast.Invoke(null, new object[]{w,one(tCell).Boxed});            

            foreach(var imm in Immediates)
            {
                var method = Dynop.EmbedVUnaryOpImm(src,imm);
                var vOutput = method.Invoke(vones);
                trace(vOutput.ToString());
            }            
        }

        void check_cell_type(Type tVector, N128 w)
        {
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();

            if(TraceDetailEnabled)
            {
                Notify($"tVector := {tVector.DisplayName()}");
                Notify($"kVector := {kVector}");
                Notify($"tCell := {tCell.Name}");
            }
            
            Claim.yea(tCell.IsSome());

            if(tVector == typeof(Vector128<sbyte>))
            {
                Claim.yea(tCell == typeof(sbyte));
                Claim.eq(VectorKind.v128x8i, kVector);
            }
            else if(tVector == typeof(Vector128<byte>))
            {
                Claim.yea(tCell == typeof(byte));
                Claim.eq(VectorKind.v128x8u, kVector);
            }
            else if(tVector == typeof(Vector128<short>))
            {
                Claim.yea(tCell == typeof(short));
                Claim.eq(VectorKind.v128x16i, kVector);
            }
            else if(tVector == typeof(Vector128<ushort>))
            {
                Claim.yea(tCell == typeof(ushort));
                Claim.eq(VectorKind.v128x16u, kVector);
            }
            else if(tVector == typeof(Vector128<int>))
            {
                Claim.yea(tCell == typeof(int));
                Claim.eq(VectorKind.v128x32i, kVector);
            }
            else if(tVector == typeof(Vector128<uint>))
            {
                Claim.yea(tCell == typeof(uint));
                Claim.eq(VectorKind.v128x32u, kVector);
            }
            else if(tVector == typeof(Vector128<long>))
            {
                Claim.yea(tCell == typeof(long));
                Claim.eq(VectorKind.v128x64i, kVector);
            }
            else if(tVector == typeof(Vector128<ulong>))
            {
                Claim.yea(tCell == typeof(ulong));
                Claim.eq(VectorKind.v128x64u, kVector);
            }
            else
                Claim.fail();
        }

        void check_cell_type(Type tVector, N256 w)
        {
            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();

            if(TraceDetailEnabled)
            {
                Notify($"tVector := {tVector.DisplayName()}");
                Notify($"kVector := {kVector}");
                Notify($"tCell := {tCell.Name}");
            }
            
            Claim.yea(tCell.IsSome());

            if(tVector == typeof(Vector256<sbyte>))
            {
                Claim.yea(tCell == typeof(sbyte));
                Claim.eq(VectorKind.v256x8i, kVector);
            }
            else if(tVector == typeof(Vector256<byte>))
            {
                Claim.yea(tCell == typeof(byte));
                Claim.eq(VectorKind.v256x8u, kVector);
            }
            else if(tVector == typeof(Vector256<short>))
            {
                Claim.yea(tCell == typeof(short));
                Claim.eq(VectorKind.v256x16i, kVector);
            }
            else if(tVector == typeof(Vector256<ushort>))
            {
                Claim.yea(tCell == typeof(ushort));
                Claim.eq(VectorKind.v256x16u, kVector);
            }
            else if(tVector == typeof(Vector256<int>))
            {
                Claim.yea(tCell == typeof(int));
                Claim.eq(VectorKind.v256x32i, kVector);
            }
            else if(tVector == typeof(Vector256<uint>))
            {
                Claim.yea(tCell == typeof(uint));
                Claim.eq(VectorKind.v256x32u, kVector);
            }
            else if(tVector == typeof(Vector256<long>))
            {
                Claim.yea(tCell == typeof(long));
                Claim.eq(VectorKind.v256x64i, kVector);
            }
            else if(tVector == typeof(Vector256<ulong>))
            {
                Claim.yea(tCell == typeof(ulong));
                Claim.eq(VectorKind.v256x64u, kVector);
            }
            else
                Claim.fail();
        }
    }
}