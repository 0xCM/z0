//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Memories;

    public class t_half_adder : UnitTest<t_half_adder>
    {
        void test1()
        {
            var circuit = Circuits.half<byte>();
            BitVector8 a = 0b11010110;
            BitVector8 b = 0b10101001;
            (BitVector8 s, BitVector8 c) = circuit.Invoke(a, b);
        }
    }
}