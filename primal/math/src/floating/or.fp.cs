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
    using System.Diagnostics;
    
    using static zfunc;    
    using static As;

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float or(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(lhs.ToBits() | rhs.ToBits());

        [MethodImpl(Inline)]
        public static double or(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(lhs.ToBits() | rhs.ToBits());         


        [MethodImpl(Inline)]
        public static ref float or(ref float lhs, float rhs)
        {
            lhs = BitConverter.Int32BitsToSingle(lhs.ToBits() | rhs.ToBits());
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double or(ref double lhs, double rhs)
        {
            BitConverter.Int64BitsToDouble(lhs.ToBits() | rhs.ToBits());         
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float or(in float lhs, in float rhs, ref float dst)
        {
            dst = BitConverter.Int32BitsToSingle(lhs.ToBits() | rhs.ToBits());
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double or(in double lhs, in double rhs, ref double dst)
        {
            dst = BitConverter.Int64BitsToDouble(lhs.ToBits() | rhs.ToBits());
            return ref dst;
        }

    }

}
