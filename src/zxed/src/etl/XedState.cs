//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;


    using static Konst;

    [ApiHost]
    public readonly struct XedState
    {
        public readonly EnumLiteralNames[] EnumNames;

        public readonly Indexed<FieldInfo> DataFields;

        public readonly Type ContextType;

        public readonly ClrTypes TypeIndex;

        [MethodImpl(Inline), Op]
        public XedState(Type t, ClrTypes index, Indexed<FieldInfo> fields, params EnumLiteralNames[] names)
        {
            ContextType = t;
            TypeIndex = index;
            EnumNames = names;
            DataFields = fields;
        }

        public ref readonly EnumLiteralNames CategoryNames
        {
            [MethodImpl(Inline), Op]
            get => ref EnumNames[0];
        }

        public ref readonly EnumLiteralNames ExtensionNames
        {
            [MethodImpl(Inline), Op]
            get => ref EnumNames[1];
        }

        public ref readonly EnumLiteralNames FlagNames
        {
            [MethodImpl(Inline), Op]
            get => ref EnumNames[2];
        }

        public ref readonly EnumLiteralNames ClassNames
        {
            [MethodImpl(Inline), Op]
            get => ref EnumNames[3];
        }

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
                return CategoryNames[z.uint8(id)];
            if(typeof(E) == typeof(xed_extension_enum_t))
                return ExtensionNames[z.uint8(id)];
            if(typeof(E) == typeof(xed_flag_enum_t))
                return FlagNames[z.uint8(id)];
            if(typeof(E) == typeof(xed_iclass_enum_t))
                return ClassNames[z.uint16(id)];
            else
                throw no<E>();
        }

        [MethodImpl(Inline)]
        readonly ReadOnlySpan<char> chars<E>(E id)
            where E : unmanaged, Enum
                => name(id);
    }
}