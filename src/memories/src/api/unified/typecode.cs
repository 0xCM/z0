//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    
    partial class Memories
    {
        /// <summary>
        /// Gets type typecode of a parametrically-identified type
        /// </summary>
        [MethodImpl(Inline)]
        public static TypeCode typecode<T>()
            => Type.GetTypeCode(typeof(T));
    }
}