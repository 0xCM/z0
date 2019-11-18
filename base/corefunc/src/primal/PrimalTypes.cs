//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public static class PrimalTypes
    {
        /// <summary>
        /// Specifies the set of unsigned primal integer types
        /// </summary>
        public static readonly Type[] UnsignedInt = 
            array(typeof(byte),  typeof(ushort), typeof(uint), typeof(ulong));

        /// <summary>
        /// Specifies the set of signed primal integer types
        /// </summary>
        public static readonly Type[] SignedInt = 
            array(typeof(sbyte), typeof(short), typeof(int),  typeof(long));

        /// <summary>
        /// Specifies the set of primal floating-point types
        /// </summary>
        public static readonly Type[] Floating = 
            array(typeof(float),typeof(double));

        /// <summary>
        /// Specifies the set of all primal numeric types
        /// </summary>
        public static readonly HashSet<Type> All = 
            new HashSet<Type>(concat(UnsignedInt, SignedInt, Floating));

        [MethodImpl(Inline)]
        public static bool IsPrimalNumeric(this Type src)
            => All.Contains(src) || All.Contains(src.GetUnderlyingType());
    }
}