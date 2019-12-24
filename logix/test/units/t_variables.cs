//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
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
        public void check_compositions()
        {
            var ops = ScalarOpApi.BinaryBitwiseKinds.ToArray();
            var pairs = from op1 in ops
                        from op2 in ops
                        select (op1, op2);            
            pairs.Iterate(o => check_4x2(o.op1,o.op2));
                     
        }

        public void check_binop_vars()
        {
            ScalarOpApi.BinaryBitwiseKinds.ToArray().Iterate(check_binop_vars);
        }

        public void check_solution()
        {
            var x = variable<uint>(0);
            var y = literal(27u);
            var expr1 = varied(n1, and(x,y),x);
            var expr2 = y;
            var result = solve(expr1, expr2,(1,0xFF));
            Trace($"Expression is satisfied by {result.Count} values");
            Claim.nea(result.IsEmpty());
                                                
        }


        public void minimize()
        {
            var v1 = variable<uint>(0);
            var v2 = variable<uint>(1);
            var expr1 = varied(n2, or(v2, xor(v1,and(v1,nand(v2, not(v1))))),v1,v2);
            var expr2 = literal(32u);
            var result = solve(expr1, expr2, (1,0xFF));
            Trace($"Expression is satisfied by {result.Count} values");

        }


        IReadOnlyList<T> solve<T>(VariedExpr<N1,T> expr, LiteralExpr<T> match, Interval<T> domain)
            where T : unmanaged
        {
            var sln = new List<T>();
            var level0 = domain.Increments();
            for(var i=0; i<level0.Length; i++)
            {
                expr.Var0(level0[i]);
                var result = LogicEngine.eval(expr.BaseExpr);
                if(gmath.eq(result.Value, match.Value))
                    sln.Add(result);
            }
            return sln;
        }

        IReadOnlyList<T> solve<T>(VariedExpr<N2,T> expr, LiteralExpr<T> match, Interval<T> domain)
            where T : unmanaged
        {

            var sln = new List<T>();
            var level0 = domain.Increments();
            var level1 = domain.Increments();
            for(var i=0; i<level0.Length; i++)
            {
                expr.Var0(level0[i]);
                for(var j=0; j<level1.Length; j++)
                {
                    expr.Var1(level1[j]);

                    var result = LogicEngine.eval(expr.BaseExpr);
                    if(gmath.eq(result.Value, match.Value))
                        sln.Add(result);
                }
            }
            return sln;

        }


        void check_4x2(BinaryBitwiseOpKind k0, BinaryBitwiseOpKind k1)
        {
            check_4x2<byte>(k0,k1);
            check_4x2<ushort>(k0,k1);
            check_4x2<uint>(k0,k1);
            check_4x2<ulong>(k0,k1);
        }

        void check_4x2<T>(BinaryBitwiseOpKind k0, BinaryBitwiseOpKind k1)
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
            var msg = appMsg($"{method}");
            Notify(msg);
                        

            var expr = binary(k1, binary(k0, v0,v1), binary(k0, v2,v3));            
            var op0 = ScalarOpApi.lookup<T>(k0);
            var op1 = ScalarOpApi.lookup<T>(k1);

            for(var i=0; i< SampleCount; i++)
            {
                var a = Random.SetNext(v0);
                var b = Random.SetNext(v1);
                var c = Random.SetNext(v2);
                var d = Random.SetNext(v3);

                var expect = op1(op0(a,b), op0(c,d));
                var actual = LogicEngine.eval(expr).Value;
                Claim.eq(expect,actual);            
            }
        }

        void check_binop_vars(BinaryBitwiseOpKind kind)
        {
            check_binop_vars<byte>(kind);
            check_binop_vars<ushort>(kind);
            check_binop_vars<uint>(kind);
            check_binop_vars<ulong>(kind);
        }

        void check_binop_vars<T>(BinaryBitwiseOpKind kind)
            where T : unmanaged
        {
            var v0 = variable<T>(0);
            var v1 = variable<T>(1);

            var op = ScalarOpApi.lookup<T>(kind);
            var expr = binary(kind,v0,v1);
            for(var i=0; i< SampleCount; i++)
            {
                var a = Random.SetNext(v0);
                var b = Random.SetNext(v1);
                var expect = op(a, b);   
                var actual = LogicEngine.eval(expr).Value;
                Claim.eq(expect,actual);          
            }

        }



    }

 
}