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
    
    using static zfunc;

    using static LogicExpr;
    using static BitExpr;
    using static LogicExprSpec;
    using static BitExprSpec;


    public class t_identity : UnitTest<t_logic>
    {

        /// <summary>
        /// Verifies the identity ~(x & y) = ~ x | ~ y
        /// </summary>
        public void check_identity_A()
        {
            Claim.yea(same(IdentityA_Lhs, IdentityA_Rhs));            
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
            Claim.yea(same(IdentityB_Lhs, IdentityB_Rhs));
        }

        static VariedExpr IdentityA_Lhs
        {
            get
            {
                var v1 = bitvar(1);
                var v2 = bitvar(2);
                var expr = not(and(v1,v2));
                return varied(expr, v1,v2);
            }
        }

        static VariedExpr IdentityA_Rhs
        {
            get
            {
                var v1 = bitvar(1);
                var v2 = bitvar(2);
                var expr = or(not(v1), not(v2));
                return varied(expr, v1,v2);
            }
        }

        static VariedExpr IdentityB_Lhs
        {
            get
            {
                var v1 = bitvar(1);
                var v2 = bitvar(2);
                return varied(not(xor(v1,v2)), v1,v2);
            }
        }

        static VariedExpr IdentityB_Rhs
        {
            get
            {
                var v1 = bitvar(1);
                var v2 = bitvar(2);
                return varied(xor(not(v1), v2), v1,v2);
            }
        }

        public void check_equality(ILogicVarExpr v1, ILogicVarExpr v2, ILogicExpr expr1, ILogicExpr expr2)
        {
            foreach(var seq in bitcombo(n2))
            {
                var a = seq[0];
                var b = seq[1];
                v1.Set(literal(a));   
                v2.Set(literal(b));
                var x = eval(expr1);
                var y = eval(expr2);
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
            var v1 = bitvar<T>(1);
            var v2 = bitvar<T>(2);
            var expr1 = not(and(v1,v2));
            var expr2 = or(not(v1), not(v2));
            check_equality(v1,v2,expr1,expr2);
        }

        void check_identity_A_128<T>()            
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec128<T>.Zero);
            var v2 = bitvar(2, Vec128<T>.Zero);
            var expr1 = not(and(v1,v2));
            var expr2 = or(not(v1), not(v2));
            check_equality(v1,v2,expr1,expr2);
        }

        void check_identity_A_256<T>()            
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec256<T>.Zero);
            var v2 = bitvar(2, Vec256<T>.Zero);
            var expr1 = not(and(v1,v2));
            var expr2 = or(not(v1), not(v2));
            check_equality(v1,v2,expr1,expr2);

        }

        void check_identity_B<T>()            
            where T : unmanaged
        {
            var v1 = bitvar<T>(1);
            var v2 = bitvar<T>(2);
            var expr1 = not(xor(v1,v2));
            var expr2 = xor(not(v1), v2);
            check_equality(v1,v2,expr1,expr2);
        }

        void check_identity_B_128<T>()            
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec128<T>.Zero);
            var v2 = bitvar(2, Vec128<T>.Zero);
            var expr1 = not(xor(v1,v2));
            var expr2 = xor(not(v1), v2);
            check_equality(v1,v2,expr1,expr2);
        }

        void check_identity_B_256<T>()            
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec256<T>.Zero);
            var v2 = bitvar(2, Vec256<T>.Zero);
            var expr1 = not(xor(v1,v2));
            var expr2 = xor(not(v1), v2);
            check_equality(v1,v2,expr1,expr2);

        }

        void check_equality<T>(IBitVarExpr<T> v1, IBitVarExpr<T> v2, IBitExpr<T> expr1, IBitExpr<T> expr2)
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

        void check_equality<T>(IBitVarExpr<Vec128<T>> v1, IBitVarExpr<Vec128<T>> v2, IBitExpr<Vec128<T>> expr1, IBitExpr<Vec128<T>> expr2)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec128<T>();
                var b = Random.CpuVec128<T>();
                v1.Set(literal(a));
                v2.Set(literal(b));
                var x = eval(expr1);
                var y = eval(expr2);
                Claim.eq(x.Value,y.Value);
            }

        }

        void check_equality<T>(IBitVarExpr<Vec256<T>> v1, IBitVarExpr<Vec256<T>> v2, IBitExpr<Vec256<T>> expr1, IBitExpr<Vec256<T>> expr2)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec256<T>();
                var b = Random.CpuVec256<T>();
                v1.Set(literal(a));
                v2.Set(literal(b));
                var x = eval(expr1);
                var y = eval(expr2);
                Claim.eq(x.Value,y.Value);
            }
        }
    }
}