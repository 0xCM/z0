//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using Xed;

    partial struct XedContext
    {
        [MethodImpl(Inline), Op]
        public string Name(xed_category_enum_t id)
            => name(id);

        [MethodImpl(Inline), Op]
        public string Name(xed_extension_enum_t id)
            => name(id);

        [MethodImpl(Inline), Op]
        public string Name(xed_flag_enum_t id)
            => name(id);

        [MethodImpl(Inline), Op]
        public string Name(xed_iclass_enum_t id)
            => name(id);

        [MethodImpl(Inline)]
        readonly string name<E>(E id)
            where E : unmanaged, Enum
        {
            if(typeof(E) == typeof(xed_category_enum_t))
                return Data.CategoryNames[z.uint8(id)];
            if(typeof(E) == typeof(xed_extension_enum_t))
                return Data.ExtensionNames[z.uint8(id)];
            if(typeof(E) == typeof(xed_flag_enum_t))
                return Data.FlagNames[z.uint8(id)];
            if(typeof(E) == typeof(xed_iclass_enum_t))
                return Data.ClassNames[z.uint16(id)];
            else
                throw no<E>();
        }        
        
        [MethodImpl(Inline)]
        readonly ReadOnlySpan<char> chars<E>(E id)
            where E : unmanaged, Enum
                => name(id);
    }
}