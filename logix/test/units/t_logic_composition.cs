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
    
    using static zfunc;
    using static BitLogicSpec;
    using static LogicEngine;

    public class t_logic_composition : UnitTest<t_logic_composition>
    {
        public void t_seqential_op_check()
        {
            var a = variable(0);
            var b = variable(1);

            var expr1 = and(a, b);
            var expr2 = or(a, b);
            var expr3 = xor(expr1, expr2);
            var expr4 = nand(expr2, expr3);
            var expr5 = nor(expr3, expr4);
            var expr6 = xnor(expr4, expr5);
            foreach(var seq in bitcombo(n2))
            {
                var s0 = seq[0];
                var s1 = seq[1];

                var e1 = BitOps.and(s0,s1);
                var e2 = BitOps.or(s0,s1);
                var e3 = BitOps.xor(e1,e2);
                var e4 = BitOps.nand(e2,e3);
                var e5 = BitOps.nor(e3,e4);
                var e6 = BitOps.xnor(e4,e5);
                var expect = e6;

                a.Set(s0);
                b.Set(s1);
                var actual = eval(expr6);
                Claim.eq(expect,actual);        
            }
            
        }
        
        public void t_sop_expr()
        {
            var v1 = variable(1);
            var v2 = variable(2);
            var v3 = variable(3);
            var expr = or(and(v1,v2), and(v2,v3));

            foreach(var seq in bitcombo(n4))
            {
                var s1 = seq[0];
                var s2 = seq[1];
                var s3 = seq[2];
                v1.Set(s1);
                v2.Set(s2);
                v3.Set(s3);

                var actual = eval(expr);
                var expect = (s1 & s2) | (s2 & s3);
                Claim.eq(expect,actual);
            }
        }

        
        public void t_andnot_expr()
        {
            var v1 = variable(1);
            var v2 = variable(2);
            var expr = and(v1,not(v2));
            foreach(var seq in bitcombo(n2))
            {
                var s1 = seq[0];
                var s2 = seq[1];
                v1.Set(s1);
                v2.Set(s2);
                var actual = eval(expr);
                var expect = s1 & ~s2;
                Claim.eq(expect,actual);

            }
        }
    }

}