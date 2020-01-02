//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static TypedLogicSpec;
    using static LogicEngine;

    using CS = TypedComparisonSpec;

    public abstract class TypedLogixTest<X> : LogixTest<X>
        where X : TypedLogixTest<X>
    {
        /// <summary>
        /// Creates a typed variable named 'a'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_a<V>()
            where V : unmanaged
                => variable<V>(AsciLower.a);

        /// <summary>
        /// Creates a typed variable named 'b'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_b<V>()
            where V : unmanaged
                => variable<V>(AsciLower.b);

        /// <summary>
        /// Creates a typed variable named 'c'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_c<V>()
            where V : unmanaged
                => variable<V>(AsciLower.c);

        /// <summary>
        /// Creates a typed variable named 'x'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_x<V>()
            where V : unmanaged
                => variable<V>(AsciLower.a);

        /// <summary>
        /// Creates a typed variable named 'y'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_y<V>()
            where V : unmanaged
                => variable<V>(AsciLower.b);

        /// <summary>
        /// Creates a typed variable named 'z'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_z<V>()
            where V : unmanaged
                => variable<V>(AsciLower.c);

      protected void check_op<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);   
                T actual = LogicEngine.eval(expr);
                T expect = ScalarOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

        protected void check_op_128<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            byte offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector<T>(n128);
                v1.Set(a);   
                Vector128<T> actual = LogicEngine.eval(expr);
                Vector128<T> expect = CpuOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

        protected void check_op_256<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector256<T>));
            byte offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector<T>(n256);
                v1.Set(a);   
                Vector256<T> actual = LogicEngine.eval(expr);
                Vector256<T> expect = CpuOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

         protected void scalar_lt_expr_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = CS.lt(va,vb);
            for(var i=0; i<RepCount; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var result = eval(x).Value;
                var expect = ScalarOpApi.eval(ComparisonKind.Lt,a,b);                
                Claim.eq(expect,result);            
            }
        }

        protected void scalar_lteq_expr_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = CS.lteq(va,vb);
            for(var i=0; i<RepCount; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var result = eval(x).Value;
                var expect = ScalarOpApi.eval(ComparisonKind.LtEq,a,b);                
                Claim.eq(expect,result);
            }
        }

        protected void scalar_gt_expr_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = CS.gt(va,vb);
            for(var i=0; i<RepCount; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var expect = ScalarOpApi.eval(ComparisonKind.Gt,a,b);   
                var actual = eval(x).Value;
                if(gmath.neq(actual,expect))             
                    Trace($"{a} > {b}?");
                Claim.eq(expect,actual);            
            }

        }

        protected void scalar_gteq_expr_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = CS.gteq(va,vb);
            for(var i=0; i<RepCount; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var expect = ScalarOpApi.eval(ComparisonKind.GtEq,a,b);
                var actual = eval(x).Value;
                Claim.eq(expect,actual);
            }
        } 
    }
}