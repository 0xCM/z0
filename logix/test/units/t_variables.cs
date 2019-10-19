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
            ScalarOpApi.BinaryKinds.Iterate(check_binop_vars);
        }

        public void check_compositions()
        {
            var ops = ScalarOpApi.BinaryKinds;
            var pairs = from op1 in ops
                        from op2 in ops
                        select (op1, op2);            
            pairs.Iterate(o => check_4x2(o.op1,o.op2));
                     
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

        IReadOnlyList<T> solve<T>(VariedExpr<N1,T> expr, Literal<T> match, Interval<T> domain)
            where T : unmanaged
        {
            var min = domain.Left;
            var max = domain.Right;
            var current = min;
            var solutions = new List<T>();
            while(gmath.lteq(current,max))
            {
                expr.Var0(current);
                var result = LogicEngine.eval(expr.BaseExpr);
                if(gmath.eq(result.Value, match.Value))
                    solutions.Add(result);

                if(gmath.lt(current, max))
                    gmath.inc(ref current);
                else
                    break;

            }
            return solutions;

        }

        IReadOnlyList<T> solve<T>(VariedExpr<N2,T> expr, Literal<T> match, Interval<T> domain)
            where T : unmanaged
        {
            var min = domain.Left;
            var max = domain.Right;
            var v0 = min;
            var v1 = min;
            var solutions = new List<T>();
            while(gmath.lteq(v0,max))
            {
                expr.Var0(v0);

                while(gmath.lteq(v1,max))
                {
                    expr.Var1(v1);
                    var result = LogicEngine.eval(expr.BaseExpr);
                    if(gmath.eq(result.Value, match.Value))
                        solutions.Add(result);

                    if(gmath.lt(v1, max))
                        gmath.inc(ref v1);
                    else
                        break;
                }

                if(gmath.lt(v0, max))
                    gmath.inc(ref v0);
                else
                    break;

            }
            return solutions;

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
            Notify(msg);
                        

            var expr = binary(k1, binary(k0, v0,v1), binary(k0, v2,v3));            
            var op0 = ScalarOpApi.lookup<T>(k0);
            var op1 = ScalarOpApi.lookup<T>(k1);

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

            var op = ScalarOpApi.lookup<T>(kind);
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