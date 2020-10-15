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

    using static System.Reflection.TypeAttributes;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.CilTables, true)]
    public readonly struct CilTables
    {

        const TypeAttributes Default = BeforeFieldInit | Public | Sealed | AnsiClass;

        public const TypeAttributes ExplicitAnsi
            = Default | ExplicitLayout;

        public const TypeAttributes SequentialAnsi
            = Default | SequentialLayout;

        [Op]
        public static TypeBuilder type(ModuleBuilder mb, ClrTypeName fullName, TypeAttributes attributes, Type parent)
            => mb.DefineType(fullName, attributes, parent);

        [Op]
        public static TypeBuilder valueType(ModuleBuilder mb, ClrTypeName fullName, TypeAttributes attributes)
            => mb.DefineType(fullName, attributes, typeof(ValueType));

        [Op]
        public static FieldBuilder field(TypeBuilder tb, Name name, string type, Address16? offset = null)
        {
            var fb = tb.DefineField(name, Type.GetType(type), FieldAttributes.Public);
            if(offset != null)
                fb.SetOffset(offset.Value);
            return fb;
        }

        [MethodImpl(Inline), Op]
        public static ModuleBuilder module(Name name)
        {
            var ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(name), AssemblyBuilderAccess.Run);
            return ab.DefineDynamicModule("Primary");
        }

        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        [MethodImpl(NotInline),Op]
        public static Type type(Name assname, CilTableSpec spec)
            => build(module(assname), spec);

        /// <summary>
        /// Manufactures the types that reifies supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        [MethodImpl(NotInline), Op]
        public static Type[] types(Name assname, params CilTableSpec[] specs)
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

        [Op]
        static Type build(ModuleBuilder mb, CilTableSpec spec)
        {
            var tb = valueType(mb, spec.TableName, ExplicitAnsi);
            var fields = spec.Fields;
            foreach(var f in fields)
                field(tb, f.FieldName, f.TypeName, f.Offset);
            var type = tb.CreateType();
            return type;
        }
    }
}