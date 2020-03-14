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
            => iter(VImmTestCases.V128UnaryShifts, v128imm_unary_shift_check);

        public void v256imm_unary_shift()
            => iter(VImmTestCases.V256UnaryShifts, v256imm_unary_shift_check);

        byte[] Immediates => new byte[]{1,2,3,4};

        BoxedNumber one(Type t) => BoxedNumber.Define(1).Convert(t);

        void v128imm_unary_shift_check(MethodInfo src)
        {
            var w = n128;
            Claim.yea(src.IsVectorized(w));
            Claim.yea(src.AcceptsVector(0,w));
            Claim.yea(src.AcceptsImmediate(1));            

            var tVector = src.ParameterType(0);
            check_cell_type(tVector, w);

            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();
            var vbroadcast = Search.vbroadcast(tCell,w);
            var vones = vbroadcast.Invoke(null, new object[]{w,one(tCell).Boxed});            

            foreach(var imm in Immediates)
            {
                var method = src.V128EmbedUnaryImm(imm);
                var vOutput = method.Invoke(vones);
            }
        }

        void v256imm_unary_shift_check(MethodInfo src)
        {
            var w = n256;
            Claim.yea(src.IsVectorized(w));
            Claim.yea(src.AcceptsVector(0,w));
            Claim.yea(src.AcceptsImmediate(1));

            var tVector = src.ParameterType(0);
            check_cell_type(tVector, w);

            var kVector = VectorType.kind(tVector);
            var tCell = kVector.CellType();
            var vbroadcast = Search.vbroadcast(tCell,w);
            var vones = vbroadcast.Invoke(null, new object[]{w,one(tCell).Boxed});            

            foreach(var imm in Immediates)
            {
                var method = src.V256EmbedUnaryImm(imm);
                var vOutput = method.Invoke(vones);
                Trace(vOutput.ToString());
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
                Claim.yea(tCell == typeof(sbyte));
            else if(tVector == typeof(Vector128<byte>))
                Claim.yea(tCell == typeof(byte));
            else if(tVector == typeof(Vector128<short>))
                Claim.yea(tCell == typeof(short));
            else if(tVector == typeof(Vector128<ushort>))
                Claim.yea(tCell == typeof(ushort));
            else if(tVector == typeof(Vector128<int>))
                Claim.yea(tCell == typeof(int));
            else if(tVector == typeof(Vector128<uint>))
                Claim.yea(tCell == typeof(uint));
            else if(tVector == typeof(Vector128<long>))
                Claim.yea(tCell == typeof(long));
            else if(tVector == typeof(Vector128<ulong>))
                Claim.yea(tCell == typeof(ulong));
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
                Claim.yea(tCell == typeof(sbyte));
            else if(tVector == typeof(Vector256<byte>))
                Claim.yea(tCell == typeof(byte));
            else if(tVector == typeof(Vector256<short>))
                Claim.yea(tCell == typeof(short));
            else if(tVector == typeof(Vector256<ushort>))
                Claim.yea(tCell == typeof(ushort));
            else if(tVector == typeof(Vector256<int>))
                Claim.yea(tCell == typeof(int));
            else if(tVector == typeof(Vector256<uint>))
                Claim.yea(tCell == typeof(uint));
            else if(tVector == typeof(Vector256<long>))
                Claim.yea(tCell == typeof(long));
            else if(tVector == typeof(Vector256<ulong>))
                Claim.yea(tCell == typeof(ulong));
            else
                Claim.fail();
        }

    }
}
