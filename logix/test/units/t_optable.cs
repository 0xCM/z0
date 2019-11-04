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
            var v1 = variable(1);
            var v2 = variable(2);
            var expr = or(and(v1,v2), xor(v1,v2));
            // and(v1,v2) -> x1 | push
            // xor(v1,v2) -> x2 | push
            // or(x1,x2) -> x3 | pop, pop

        }

        public void bitstack_example()
        {
            var stack = BitStack.Init(0b101011);
            Claim.yea(stack.Pop());
            Claim.yea(stack.Pop());
            Claim.nea(stack.Pop());
            Claim.yea(stack.Pop());
            Claim.nea(stack.Pop());
            Claim.yea(stack.Pop());            
            stack.Push(on);
            Claim.yea(stack.Pop());
        }


        public void bitstack_check()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var bits = Random.BitString(Random.Next<int>(2,50));
                var stack = BitStack.Init();
                for(var j = 0; j < bits.Length; j++)   
                    stack.Push(bits[j]);
                
                var rbits = bits.Reverse();
                for(var j=0; j< bits.Length; j++)
                {
                    var actual = stack.Pop();
                    var expect = rbits[j];
                    Claim.eq(actual,expect);
                }
            }
        }

        public void ringbuffer_check()
        {
            var buffer = RingBuffer.alloc<uint>(Pow2.T08);
            var count = Random.Next<int>(20,Pow2.T07);
            var points = Random.Span<uint>(count);

            for(var i=0; i<points.Length; i++)
                buffer.Push(points[i]);

            for(var i=0; i<points.Length; i++)
                Claim.eq(points[i], buffer.Pop());
        }

        public void stacked_example()
        {
            var stack = Stacked.alloc<uint>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var x1 = stack.Pop();
            var x2 = stack.Pop();
            var x3 = stack.Pop();
            Claim.eq(x1,3);
            Claim.eq(x2,2);
            Claim.eq(x3,1);
            

        }

    }
}