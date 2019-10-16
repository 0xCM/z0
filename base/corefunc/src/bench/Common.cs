//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using static zfunc;
    

    public static partial class PrimalBench
    {
        public static OpTime bench_uint8(UInt8 s1, UInt8 s2, long reps, SystemCounter counter = default)
        {
           var state = s1 | s2;
            counter.Start();
            for(var i=0; i< reps; i++)
            {
                state &= s1;
                state |= s2;
                state ^= s1;
                state = ~s2;
                state = ~(state & s1);
                state = ~(state | s2);
                state = ~(s1 ^ s2);
            }
            counter.Stop();
            
            return ("uint8", reps, counter);            

        }

        public static OpTime bench_byte(byte s1, byte s2, long reps, SystemCounter counter = default)
        {
            var state = (byte)(s1 | s2);
            counter.Start();
            for(var i=0; i< reps; i++)
            {
                state &= s1;
                state |= s2;
                state ^= s1;
                state = (byte) ~s2;
                state = (byte) ~(state & s1);
                state = (byte) ~(state | s2);
                state = (byte) ~(s1 ^ s2);
            }
            counter.Stop();
            return ("System.Byte", reps, counter);
        
        }


        public static OpTime bench_bool(bool s1, bool s2, long reps, SystemCounter counter = default)
        {
            var state = s1 | s2;
            counter.Start();
            for(var i=0; i< reps; i++)
            {
                state &= s1;
                state |= s2;
                state ^= s1;
                state = !s2;
                state = !(state & s1);
                state = !(state | s2);
                state = !(s1 ^ s2);
            }
            counter.Stop();
            return ("System.Bool", reps, counter);
        
        }

        public static OpTime bench_bit(bit s1, bit s2, long reps, SystemCounter counter = default)
        {
            var state = s1 | s2;
            counter.Start();
            for(var i=0; i< reps; i++)
            {
                state &= s1;
                state |= s2;
                state ^= s1;
                state = !s2;
                state = !(state & s1);
                state = !(state | s2);
                state = !(s1 ^ s2);
            }
            counter.Stop();
            return ("z0.bit", reps, counter);
        
        }

    }

}