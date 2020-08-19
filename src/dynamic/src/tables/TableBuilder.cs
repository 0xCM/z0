//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Emit;

    using static z;
    using static Konst;
    using static TableBuilderLiterals;
    using static ReflectiveEmit;
    using RE = ReflectiveEmit;

    [ApiHost]
    public readonly struct TableBuilder
    {
        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        [Op]
        public static Type create(string assname, TableSpec spec)
            => build(module(assname), spec);

        /// <summary>
        /// Manufactures the types that reifies supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        [Op]
        public static Type[] create(string assname, params TableSpec[] specs)
        {
            var count = specs.Length;
            var buffer = alloc<Type>(count);
            var dst = span(buffer);
            var src = @readonly(specs);
            var mb = module(assname);

            for(var i=0u; i<count; i++)
                seek(dst,i) = build(mb, skip(src,i));
            return buffer;
        }

        public static Type build(ModuleBuilder mb, TableSpec spec)
        {
            var fullName = RE.fullName(spec.Namespace, spec.TypeName);
            var tb = RE.valueType(mb, fullName, TableAttributes);
            foreach(var field in spec.Fields)
                RE.field(tb, field.Name, field.FieldTypeName, field.Offset);
            var type = tb.CreateType();
            return type;
        }
    }
}