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
    
    using static zfunc;

    using static BitExprEval;
    using static LogicEngine;
    using static BitLogicSpec;
    using static TypedLogicSpec;


    public class t_identity : UnitTest<t_identity>
    {

        /// <summary>
        /// Verifies the identity ~(x & y) = ~ x | ~ y
        /// </summary>
        public void check_identity_A()
        {
            Claim.yea(equal(IdentityA_Lhs, IdentityA_Rhs));            
        }

        public void check_identity_A_32u()
            => check_identity_A<uint>();

        public void check_identity_A_128x32u()
            => check_identity_A_128<uint>();

        public void check_identity_A_256x32u()
            => check_identity_A_256<uint>();

        /// <summary>
        /// Verifies the identity ~(x ^ y) = ~x ^ y
        /// </summary>
        public void check_identity_B()
        {
            Claim.yea(equal(IdentityB_Lhs, IdentityB_Rhs));
        }

        static VariedLogicExpr IdentityA_Lhs
        {
            get
            {
                var v1 = variable(1);
                var v2 = variable(2);
                var expr = not(and(v1,v2));
                return varied(expr, v1,v2);
            }
        }

        static VariedLogicExpr IdentityA_Rhs
        {
            get
            {
                var v1 = variable(1);
                var v2 = variable(2);
                var expr = or(not(v1), not(v2));
                return varied(expr, v1,v2);
            }
        }

        static VariedLogicExpr IdentityB_Lhs
        {
            get
            {
                var v1 = variable(1);
                var v2 = variable(2);
                return varied(not(xor(v1,v2)), v1,v2);
            }
        }

        static VariedLogicExpr IdentityB_Rhs
        {
            get
            {
                var v1 = variable(1);
                var v2 = variable(2);
                return varied(xor(not(v1), v2), v1,v2);
            }
        }

        public void check_equality(IVariable v1, IVariable v2, ILogicExpr expr1, ILogicExpr expr2)
        {
            foreach(var seq in bitcombo(n2))
            {
                var a = seq[0];
                var b = seq[1];
                v1.Set(literal(a));   
                v2.Set(literal(b));
                var x = LogicEngine.eval(expr1);
                var y = LogicEngine.eval(expr2);
                Claim.eq(x,y);

            }
        }

        public void check_identity_B_32u()
            => check_identity_B<uint>();

        public void check_identity_B_128x32u()
            => check_identity_B_128<uint>();

        public void check_identity_B_256x32u()
            => check_identity_B_256<uint>();

        void check_identity_A<T>()            
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var v2 = variable<T>(2);
            var expr1 = not(and(v1,v2));
            var expr2 = or(not(v1), not(v2));
            check_equality(v1,v2,expr1,expr2);
        }

        void check_identity_A_128<T>()            
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            var v2 = variable(2, default(Vector128<T>));
            var expr1 = not(and(v1,v2));
            var expr2 = or(not(v1), not(v2));
            check_equality(v1,v2,expr1,expr2);
        }

        void check_identity_A_256<T>()            
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector256<T>));
            var v2 = variable(2, default(Vector256<T>));
            var expr1 = not(and(v1,v2));
            var expr2 = or(not(v1), not(v2));
            check_equality(v1,v2,expr1,expr2);

        }

        void check_identity_B<T>()            
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var v2 = variable<T>(2);
            var expr1 = not(xor(v1,v2));
            var expr2 = xor(not(v1), v2);
            check_equality(v1,v2,expr1,expr2);
        }

        void check_identity_B_128<T>()            
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            var v2 = variable(2, default(Vector128<T>));
            var expr1 = not(xor(v1,v2));
            var expr2 = xor(not(v1), v2);
            check_equality(v1,v2,expr1,expr2);
        }

        void check_identity_B_256<T>()            
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector256<T>));
            var v2 = variable(2, default(Vector256<T>));
            var expr1 = not(xor(v1,v2));
            var expr2 = xor(not(v1), v2);
            check_equality(v1,v2,expr1,expr2);

        }

        void check_equality<T>(IVariable<T> v1, IVariable<T> v2, IExpr<T> expr1, IExpr<T> expr2)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                v1.Set(literal(a));
                v2.Set(literal(b));
                var x = eval(expr1);
                var y = eval(expr2);
                Claim.eq(x.Value,y.Value);
            }

        }

        void check_equality<T>(IVariable<Vector128<T>> v1, IVariable<Vector128<T>> v2, IExpr<Vector128<T>> expr1, IExpr<Vector128<T>> expr2)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector128<T>();
                var b = Random.CpuVector128<T>();
                v1.Set(literal(a));
                v2.Set(literal(b));
                var x = eval(expr1);
                var y = eval(expr2);
                Claim.eq(x.Value,y.Value);
            }

        }

        void check_equality<T>(IVariable<Vector256<T>> v1, IVariable<Vector256<T>> v2, IExpr<Vector256<T>> expr1, IExpr<Vector256<T>> expr2)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector256<T>();
                var b = Random.CpuVector256<T>();
                v1.Set(literal(a));
                v2.Set(literal(b));
                var x = eval(expr1);
                var y = eval(expr2);
                Claim.eq(x.Value,y.Value);
            }
        }
    }
}