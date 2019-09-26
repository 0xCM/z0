//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gfp
    {

      [MethodImpl(Inline)]
       public static T xor<T>(T lhs, T rhs)
            where T :unmanaged
        {
            if(typematch<T,float>())
                return generic<T>(BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(float32(lhs)) ^ BitConverter.SingleToInt32Bits(float32(rhs))));
            else if(typematch<T,float>())
                return generic<T>(BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(float64(lhs)) ^  BitConverter.DoubleToInt64Bits(float64(rhs))));
            else
                throw unsupported<T>();
        }

       [MethodImpl(Inline)]
       public static ref T xor<T>(ref T lhs, T rhs)
            where T :unmanaged
        {
            if(typematch<T,float>())
                BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(float32(lhs)) ^ BitConverter.SingleToInt32Bits(float32(rhs)));
            else if(typematch<T,float>())
                BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(float64(lhs)) ^ BitConverter.DoubleToInt64Bits(float64(rhs)));
            else
                throw unsupported<T>();
            return ref lhs;
        }
 

    }

}