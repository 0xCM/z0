//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using Xed;

    partial struct XedContext
    {
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
    }
}