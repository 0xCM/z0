//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static memory;

    partial struct ClrEnums
    {
        /// <summary>
        /// Queries the source assemblies for enum types
        /// </summary>
        /// <param name="src">The assemblies to query</param>
        [Op]
        public static Index<KeyedValues<ClrAssemblyName,Type>> types(params Assembly[] src)
        {
            var x = from part in src
                    let enums = part.Enums()
                    orderby part.FullName
                    select Lookups.keyed(Clr.name(part), enums);
            return x;
        }
    }
}