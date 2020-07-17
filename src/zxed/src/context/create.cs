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
    using System.Reflection;

    using Xed;

    partial struct XedContext
    {        
        readonly XedContextData Data;

        [MethodImpl(Inline), Op]
        public static XedContext create()
        {            
            var index = types();            
            index.Search(t => t.Name == nameof(XedContextData), out var ctx);            
            var fields = Reflex.fields(ctx);
            
            index.Search(x => x.Name == nameof(xed_category_enum_t), out var e0);
            var n0 = names(e0);
            
            index.Search(x => x.Name == nameof(xed_extension_enum_t), out var e1);
            var n1 = names(e1);

            index.Search(x => x.Name == nameof(xed_flag_enum_t), out var e2);            
            var n2 = names(e2);
            
            index.Search(x => x.Name == nameof(xed_iclass_enum_t), out var e3);            
            var n3 = names(e3);

            var data = new XedContextData(ctx, index, fields, n0, n0, n2, n3);
            return new XedContext(data);            
        }

        [MethodImpl(Inline), Op]
        public static Z0.EnumNames names(Type src)                   
            => new Z0.EnumNames(src, System.Enum.GetNames(src));        

        [MethodImpl(Inline), Op]
        public static KeyedValues<ArtifactIdentity,Type> types()
            => types(Assembly.GetExecutingAssembly());

        [MethodImpl(Inline), Op]
        public static KeyedValues<ArtifactIdentity,Type> types(Assembly a)
            => Reflex.TypeIndex(a);

        [MethodImpl(Inline)]
        XedContext(in XedContextData data)
            : this()
        {
            Data = data;
        }
    }
}