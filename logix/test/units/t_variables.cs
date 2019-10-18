//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using static zfunc;
    using static TypedLogicSpec;

    public class t_variables : UnitTest<t_variables>
    {
        public void check_binop_vars()
        {
            ScalarOps.BinaryKinds.Iterate(check_binop_vars);
        }

        public void check_compositions()
        {
            var ops = ScalarOps.BinaryKinds;
            var pairs = from op1 in ops
                        from op2 in ops
                        select (op1, op2);            
            pairs.Iterate(o => check_4x2(o.op1,o.op2));
                     
        }

        void check_4x2(BinaryLogicOpKind k0, BinaryLogicOpKind k1)
        {
            check_4x2<byte>(k0,k1);
            check_4x2<ushort>(k0,k1);
            check_4x2<uint>(k0,k1);
            check_4x2<ulong>(k0,k1);
        }

        void check_4x2<T>(BinaryLogicOpKind k0, BinaryLogicOpKind k1)
            where T : unmanaged
        {
            var v0 = variable<T>(0);
            var v1 = variable<T>(1);
            var v2 = variable<T>(2);
            var v3 = variable<T>(3);

            var op0_name = k0.Format();
            var op1_name = k1.Format();
            var v0_name = v0.Format(false);
            var v1_name = v1.Format(false);
            var v2_name = v2.Format(false);
            var v3_name = v3.Format(false);
            var method = MethodInfo.GetCurrentMethod().SpecializeName<T>();
            var exprfmt = $"{op1_name}({op0_name}({v0_name},{v1_name}), {op0_name}({v2_name},{v3_name}";
            var msg = appMsg($"{method} := {exprfmt}))");
            Enqueue(msg);
            

            var expr = binary(k1, binary(k0, v0,v1), binary(k0, v2,v3));            
            var op0 = ScalarOps.lookup<T>(k0);
            var op1 = ScalarOps.lookup<T>(k1);

            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Set(v0);
                var b = Random.Set(v1);
                var c = Random.Set(v2);
                var d = Random.Set(v3);

                var expect = op1(op0(a,b), op0(c,d));
                var actual = LogicEngine.eval(expr).Value;
                Claim.eq(expect,actual);            
            }
        }

        void check_binop_vars(BinaryLogicOpKind kind)
        {
            check_binop_vars<byte>(kind);
            check_binop_vars<ushort>(kind);
            check_binop_vars<uint>(kind);
            check_binop_vars<ulong>(kind);
        }

        void check_binop_vars<T>(BinaryLogicOpKind kind)
            where T : unmanaged
        {
            var v0 = variable<T>(0);
            var v1 = variable<T>(1);

            var op = ScalarOps.lookup<T>(kind);
            var expr = binary(kind,v0,v1);
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Set(v0);
                var b = Random.Set(v1);
                var expect = op(a, b);   
                var actual = LogicEngine.eval(expr).Value;
                Claim.eq(expect,actual);          
            }

        }
    }

 
}