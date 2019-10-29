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
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static ScalarOpApi;
    using static LogicOpApi;

    /// <summary>
    /// Verifies the bit-level equivalence of the canonical binary logical operators
    /// </summary>
    public class t_bitwise_logic : UnitTest<t_bitwise_logic>
    {

        public void and_check()
        {
            and_check<byte>();
            and_check<ushort>();
            and_check<uint>();
            and_check<ulong>();
        }
        
        
        void and_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)   
            {   
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                var result1 = ScalarOpApi.eval(BinaryBitwiseOpKind.And,a,b);    
                var result2 = and_cw(BitVector.generic(a),BitVector.generic(b)).Data;
                Claim.eq(result1, result2);
            }
        }

        static BitVector<T> and_cw<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.And, x[i], y[i]);
            return z;
        }

        

    }

}