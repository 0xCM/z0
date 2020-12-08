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
    using static Cil;

    [ApiHost(ApiNames.CilTables, true)]
    public readonly struct CilTables
    {
        const TypeAttributes Default = BeforeFieldInit | Public | Sealed | AnsiClass;

        public const TypeAttributes ExplicitAnsi
            = Default | ExplicitLayout;

        public const TypeAttributes SequentialAnsi
            = Default | SequentialLayout;

        [Op]
        public static string format(in RecordSpec src)
        {
            var dst = text.build();
            dst.AppendLine(src.TableName.ShortName);
            for(var i=0; i<src.Fields.Length; i++)
                dst.AppendLine(src.Fields[i].ToString());
            return dst.ToString();
        }

        [Op]
        public static string format(in FieldSpec src)
            => string.Format(RP.PSx4, src.FieldName, src.Position, src.Offset, src.TypeName);

        [MethodImpl(Inline), Op]
        public static RecordSpec table(TypeName type, params FieldSpec[] Fields)
            => new RecordSpec(type, Fields);

        [MethodImpl(Inline), Op]
        public static FieldSpec field(MemberName name, TypeName type, ushort position, ushort offset = default)
            => new FieldSpec(name, type, position, offset);

        [Op]
        public static TypeBuilder type(ModuleBuilder mb, TypeName fullName, TypeAttributes attributes, Type parent)
            => mb.DefineType(fullName, attributes, parent);

        [Op]
        public static TypeBuilder valueType(ModuleBuilder mb, TypeName fullName, TypeAttributes attributes)
            => mb.DefineType(fullName, attributes, typeof(ValueType));

        [Op]
        public static FieldBuilder field(TypeBuilder tb, MemberName name, string type, Address16? offset = null)
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

        [Op]
        public static RecordSpec clone(Type src)
        {
            var name = TypeName.from(src);
            var declared = src.DeclaredInstanceFields();
            var count = declared.Length;
            var buffer = alloc<FieldSpec>(count);
            var fields = @readonly(declared);
            var fieldOffsets = span(ClrQuery.offsets(src, declared));

            var dst = span(buffer);
            for(ushort i=0; i<count; i++)
            {
                ref readonly var f = ref skip(fields, i);
                var offset = skip(fieldOffsets,i);
                seek(dst,i) = field(f, name, i, skip(fieldOffsets,i));
            }

            return new RecordSpec(name, buffer);
        }

        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        [MethodImpl(NotInline),Op]
        public static Type type(Name assname, RecordSpec spec)
            => build(module(assname), spec);

        /// <summary>
        /// Manufactures the types that reifies supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        [MethodImpl(NotInline), Op]
        public static Type[] types(Name assname, params RecordSpec[] specs)
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
        static Type build(ModuleBuilder mb, RecordSpec spec)
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