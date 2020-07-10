//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using static Part;
    using static OpacityKind;
    
    partial struct sys
    {
        /// <summary>
        /// Tests whether the source string is empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Options), Opaque(EmptyStringTest)]
        public static bool empty(string src)
            => string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Returns an empty array
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Opaque(GetEmptyArray), Closures(AllNumeric)]
        public static T[] empty<T>()
            => Array.Empty<T>();
    }
}