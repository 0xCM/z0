//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct ClrQuery
    {
        /// <summary>
        /// Selects all instance/static and public/non-public properties declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static Index<PropertyInfo> properties(Type src)
            => src.GetProperties(BF);
    }
}