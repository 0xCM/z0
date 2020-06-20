//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        /// <summary>
        /// Returns the type of the type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Type type<T>()
            => typeof(T);    
    }
}