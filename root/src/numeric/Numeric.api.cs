//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    [ApiHost("numeric.api")]
    public static partial class Numeric
    {
        /// <summary>
        /// Creates a parametric numeric comparer
        /// </summary>
        /// <typeparam name="T">The numeric type to compare</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static NumericComparer<T> comparer<T>()
            where T : unmanaged
                => NumericComparer.create<T>();


        [MethodImpl(Inline), Op]
        public static FixedWidth width(Type t)
        {
            var k = t.NumericKind();
            if(k.IsSome())
                return (FixedWidth)(ushort)k;
            else
                return FixedWidth.None;            
        }

        /// <summary>
        /// Converts a fixed width kind to an integer corresponding to the with represented by the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static int @int(FixedWidth src)
            => (int)src;
    }
}