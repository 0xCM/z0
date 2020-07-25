//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Runtime.InteropServices;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct MdR
    {        
        public readonly struct EventDefinition
        {
            public readonly int RowId;

            public readonly EventDefinitionHandle Token;

            public readonly StringHandle Name;

            public readonly EventAttributes Attributes;

            public readonly EntityHandle Type;

            public readonly CustomAttributeHandleCollection CustomAttributes;        
        }

        [MethodImpl(Inline), Op]
        public static EventDefinitionHandle @event(uint id)
        {
            var dst = default(EventDefinitionHandle);
            z.seek<EventDefinitionHandle,uint>(dst,0) = id;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexCodeLo> digits(EventDefinitionHandle src)
        {
            return Structures.digits(src, LowerCase);
        }
        
        [MethodImpl(Inline), Op]
        public static string format(EventDefinitionHandle src)
            => Structures.format(src);
    }
}
