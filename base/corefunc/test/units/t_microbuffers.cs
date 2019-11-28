//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;
    using static zfunc;

    public sealed class t_microbuffers : UnitTest<t_microbuffers>
    {
        public void stacked_basecase()
        {
            var stack = MicroBuffers.stack<uint>(3);
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

        public void bitstack_basecase()
        {
            var stack = MicroBuffers.bitstack(0b101011);
            Claim.yea(stack.Pop());
            Claim.yea(stack.Pop());
            Claim.nea(stack.Pop());
            Claim.yea(stack.Pop());
            Claim.nea(stack.Pop());
            Claim.yea(stack.Pop());            
            stack.Push(on);
            Claim.yea(stack.Pop());
        }

        public void bitstack()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var bits = Random.BitString(Random.Next<int>(2,50));
                var stack = MicroBuffers.bitstack();
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

        public void ringbuffer_32()
        {
            var buffer = MicroBuffers.ring<uint>(Pow2.T08);
            var count = Random.Next<int>(20,Pow2.T07);
            var points = Random.Span<uint>(count);

            for(var i=0; i<points.Length; i++)
                buffer.Push(points[i]);

            for(var i=0; i<points.Length; i++)
                Claim.eq(points[i], buffer.Pop());
        }

        public void partring_basecase()
        {
            var capacity = Pow2.T10;
            var partwidth = 4;
            var buffer = MicroBuffers.parts<byte,ulong>(capacity);  
            buffer.Next = 0xFul;
            buffer.Next = 0xFFul;
            buffer.Next = 0xFFFul;
            buffer.Next = 0xFFFFul;

            Claim.eq(buffer.Data.AsUInt64()[0],0xF);
            Claim.eq(buffer.Data.AsUInt64()[1],0xFF);
            Claim.eq(buffer.Data.AsUInt64()[2],0xFFF);
            Claim.eq(buffer.Data.AsUInt64()[3],0xFFFF);
            
        }
    }
}