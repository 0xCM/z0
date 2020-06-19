//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial class Memories
    {
        /// <summary>
        /// Gets type typecode of a parametrically-identified type
        /// </summary>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static TypeCode typecode<T>()
            => Type.GetTypeCode(typeof(T));
    }
}