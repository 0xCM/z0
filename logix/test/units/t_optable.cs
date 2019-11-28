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

    public class t_optable : UnitTest<t_optable>
    {

        public void test_dot()
        {
            for(var i=0; i <= 0xF; i++)
            {
                var tvid = (BinaryLogicOpKind)i;
                var tv  = TruthTables.sig(tvid);                

                var arg0 = BitVector.from(n4,off,off,off,off);
                var x0 = tv % arg0;

                var arg1 = BitVector.from(n4,on,on,off,off);
                var x1 = tv % arg1;

                var arg2 = BitVector.from(n4,off,off,on,on);
                var x2 = tv % arg2;

                var arg3 = BitVector.from(n4,on,on,on,on);
                var x3 = tv % arg3;

                var candidate = BitVector.from(n4,x0,x1,x2,x3);
                if(candidate == tv)
                {
                    Trace($"Matched {tvid}");
                }
            }
        }


        public void test_1()
        {
            var v1 = lvar(1);
            var v2 = lvar(2);
            var expr = or(and(v1,v2), xor(v1,v2));
            // and(v1,v2) -> x1 | push
            // xor(v1,v2) -> x2 | push
            // or(x1,x2) -> x3 | pop, pop

        }

    }
}