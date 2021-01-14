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
    using static memory;

    partial struct Clr
    {


        /// <summary>
        /// Queries the source assemblies for enum types
        /// </summary>
        /// <param name="src">The assemblies to query</param>
        [Op]
        public static Index<KeyedValues<ClrAssemblyName,Type>> enums(Assembly[] src)
        {
            var x = from part in src
                    let enums = part.Enums()
                    orderby part.FullName
                    select Lookups.keyed(Clr.adapt(part).Name, enums);
            return x;
        }

        [MethodImpl(Inline), Op]
        public readonly void enums(ReadOnlySpan<Type> src, Span<ClrEnum> dst)
        {
            var count = src.Length;
            for(uint i=0, j=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(src,i);
                if(candidate.IsEnum)
                    seek(dst, j++) = candidate;
            }
        }
    }
}