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
    using static z;

    [ApiHost]
    public readonly struct XedState
    {
        [MethodImpl(Inline), Op]
        public static EnumLiteralNames names(Type src)
            => new EnumLiteralNames(src, System.Enum.GetNames(src));

        public static XedContext create()
            => new XedContext(data());

        [MethodImpl(Inline), Op]
        public static ClrTypes types()
            => types(Assembly.GetExecutingAssembly());

        [MethodImpl(Inline), Op]
        public static ClrTypes types(Assembly a)
            => Reflex.index(a.GetTypes());

        public static XedState data()
        {
            var index = types();
            index.Search(t => t.Name == nameof(XedState), out var ctx);
            var fields = Reflex.fields(ctx);

            var nameBuffer = sys.alloc<EnumLiteralNames>(4);
            var _names = span(nameBuffer);

            index.Search(x => x.Name == nameof(xed_category_enum_t), out var e0);
            seek(_names,0) = names(e0);

            index.Search(x => x.Name == nameof(xed_extension_enum_t), out var e1);
            seek(_names,1) = names(e1);

            index.Search(x => x.Name == nameof(xed_flag_enum_t), out var e2);
            seek(_names,2) = names(e2);

            index.Search(x => x.Name == nameof(xed_iclass_enum_t), out var e3);
            seek(_names,3) = names(e3);
            return data(ctx, index,fields, nameBuffer);
        }

        [MethodImpl(Inline), Op]
        public static XedState data(Type t, ClrTypes index, Indexed<FieldInfo> fields, EnumLiteralNames[] names)
            => new XedState(t, index, fields, names);
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