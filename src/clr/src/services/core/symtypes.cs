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
    using static core;

    partial struct Clr
    {
        public static SymTypes symtypes(Assembly[] src)
        {
            var types = src.Enums().Tagged<SymSourceAttribute>().ToReadOnlySpan();
            var count = types.Length;
            var buffer = alloc<SymType>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                var attrib = type.Tag<SymSourceAttribute>().Require();
                var alias = type.Tag<AliasAttribute>();
                if(alias.Exists && alias.Value.AliasList.Length!=0)
                    seek(dst,i) = new SymType(type, attrib.GroupName, alias.Value.AliasList);
                else
                    seek(dst,i) = new SymType(type, attrib.GroupName);
            }
            return new SymTypes(buffer);
        }
    }
}