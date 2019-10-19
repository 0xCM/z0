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
    using static BitLogicSpec;
    using static LogicEngine;

    public class t_bit_logic : UnitTest<t_bit_logic>
    {

        public void t_and_expr()
        {
            var v1 = variable(1);
            var v2 = variable(2);
            var expr = and(v1,v2);

            foreach(var seq in bitcombo(n2)) 
            {
                var s1 = seq[0];
                var s2 = seq[1];
                v1.Set(s1);
                v2.Set(s2);
                var actual = eval(expr);
                var expect = s1 & s2;
                Claim.eq(expect,actual);
            }
            
        }

        public void t_nand_expr()
        {
            var v1 = variable(1);
            var v2 = variable(2);
            var expr = nand(v1,v2);

            foreach(var seq in bitcombo(n2)) 
            {
                var s1 = seq[0];
                var s2 = seq[1];
                v1.Set(s1);
                v2.Set(s2);
                var actual = eval(expr);
                var expect = !(s1 & s2);
                Claim.eq(expect,actual);
            }
            
        }

        public void t_or_expr()
        {
            var v1 = variable(1);
            var v2 = variable(2);
            var expr = or(v1,v2);
            
            foreach(var seq in bitcombo(n2)) 
            {
                var s1 = seq[0];
                var s2 = seq[1];
                v1.Set(s1);
                v2.Set(s2);
                var actual = eval(expr);
                var expect = s1 | s2;
                Claim.eq(expect,actual);
            }
        }

        public void t_nor_expr()
        {
            var v1 = variable(1);
            var v2 = variable(2);
            var expr = nor(v1,v2);
            
            foreach(var seq in bitcombo(n2)) 
            {
                var s1 = seq[0];
                var s2 = seq[1];
                v1.Set(s1);
                v2.Set(s2);
                var actual = eval(expr);
                var expect = !(s1 | s2);
                Claim.eq(expect,actual);
            }
        }

        public void t_xor_expr()
        {
            var v1 = variable(1);
            var v2 = variable(2);
            var expr = xor(v1,v2);
            
            foreach(var seq in bitcombo(n2)) 
            {
                var s1 = seq[0];
                var s2 = seq[1];
                v1.Set(s1);
                v2.Set(s2);
                var actual = eval(expr);
                var expect = s1 ^ s2;
                Claim.eq(expect,actual);
            }
        }

        public void t_xnor_expr()
        {
            var v1 = variable(1);
            var v2 = variable(2);
            var expr = xnor(v1,v2);

            foreach(var seq in bitcombo(n2))
            {
                var s1 = seq[0];
                var s2 = seq[1];
                v1.Set(s1);
                v2.Set(s2);

                bit expect = s1 == s2;
                var actual = eval(expr);
                Claim.eq(expect,actual);
                Claim.eq(!(s1 ^ s2), actual);
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

        public void t_bitcombo_check()
        {
            Claim.eq(Pow2.T01, bitcombo(n1).Distinct().Count());
            Claim.eq(Pow2.T02, bitcombo(n2).Distinct().Count());
            Claim.eq(Pow2.T03, bitcombo(n3).Distinct().Count());
            Claim.eq(Pow2.T04, bitcombo(n4).Distinct().Count());
            Claim.eq(Pow2.T05, bitcombo(n5).Distinct().Count());
            Claim.eq(Pow2.T06, bitcombo(n6).Distinct().Count());
            Claim.eq(Pow2.T07, bitcombo(n7).Distinct().Count());
            Claim.eq(Pow2.T08, bitcombo(n8).Distinct().Count());
        }

        public void t_bitseq_check()
        {
            for(var sample=0; sample<SampleSize; sample++)          
            {
                var bs = Random.BitString(2,7);
                var x = BitLiteralSeq.FromBitString(bs);
                var y = BitVector8.FromBitString(bs);
                for(var i=0; i<bs.Length; i++)
                {
                    Claim.eq(bs[i],x[i]);
                    Claim.eq(bs[i],y[i]);
                }
            }
        }
    }
}