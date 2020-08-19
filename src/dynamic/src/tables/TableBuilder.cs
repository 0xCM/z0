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
    using static TableSpecLiterals;
    using static ReflectiveEmit;

    [ApiHost]
    public readonly struct TableBuilder
    {
        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        [Op]
        public static Type create(Name assname, TableSpec spec)
            => build(module(assname), spec);

        /// <summary>
        /// Manufactures the types that reifies supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        [Op]
        public static Type[] create(Name assname, params TableSpec[] specs)
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

        static Type build(ModuleBuilder mb, TableSpec spec)
        {
            var tb = valueType(mb, spec.Type, ExplicitAnsi);
            foreach(var f in spec.Fields)
                field(tb, f.Name, f.Type, f.Offset);
            var type = tb.CreateType();
            return type;
        }
    }
}