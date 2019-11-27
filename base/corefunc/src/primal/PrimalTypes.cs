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
        static ReadOnlySpan<Type> Types =>
            new Type[]{
                typeof(byte), typeof(ushort), typeof(uint), typeof(ulong),
                typeof(sbyte), typeof(short), typeof(int), typeof(long),
                typeof(float),typeof(double)
                };

        /// <summary>
        /// Specifies the set of all primal numeric types
        /// </summary>
        public static readonly HashSet<Type> All = 
            new HashSet<Type>(Types.ToArray());

        [MethodImpl(Inline)]
        public static bool IsPrimalNumeric(this Type src)
            => All.Contains(src) || All.Contains(src.GetUnderlyingType());
    }
}