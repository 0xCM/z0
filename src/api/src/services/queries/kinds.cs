//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static core;

    partial class ApiQuery
    {
        [Op]
        public static Index<IApiClass> kinds()
        {
            var types = @readonly(typeof(ApiClasses).GetNestedTypes().NonGeneric().Realize<IApiClass>());
            var count = types.Length;
            var classes = alloc<IApiClass>(count);
            ref var dst = ref first(classes);
            for(var i=0; i<count; i++)
                seek(dst,i) = (IApiClass)Activator.CreateInstance(skip(types,i));
            return classes;
        }

        [Op]
        public static Index<SymLiteral> ClassLiterals()
            => Symbols.literals(Parts.Root.Assembly.Enums().Tagged<ApiClassAttribute>());

        public static Index<ApiClassifier> Classifiers()
            => ClassLiterals().GroupBy(x => x.Type).Select(x => new ApiClassifier(x.Key, x.ToArray())).Array();
    }
}