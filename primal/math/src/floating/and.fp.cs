//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class fmath
    {

        [MethodImpl(Inline)]
        public static float and(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(
                    BitConverter.SingleToInt32Bits(lhs) &  
                    BitConverter.SingleToInt32Bits(rhs)
                    );

        [MethodImpl(Inline)]
        public static double and(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(
                BitConverter.DoubleToInt64Bits(lhs) &  
                BitConverter.DoubleToInt64Bits(rhs)
                );


    }

}