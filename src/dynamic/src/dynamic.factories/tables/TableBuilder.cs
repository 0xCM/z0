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

    [ApiHost(ApiNames.TableBuilder, true)]
    public ref partial struct TableBuilder
    {
        [Op]
        public static string format(in TableSpec src)
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

        [Op]
        public static FieldSpec field(Name name, ClrTypeName type, ushort position, Address16 offset = default)
            => new FieldSpec(name, type, position, offset);

        [Op]
        public static TableBuilder create(ushort? capacity = null)
            => new TableBuilder(capacity ?? 20);

        [MethodImpl(Inline), Op]
        public static TableSpec build(ClrTypeName type, params FieldSpec[] Fields)
            => new TableSpec(type, Fields);

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

        [MethodImpl(Inline), Op]
        public static TypeBuilder type(ModuleBuilder mb, ClrTypeName fullName, TypeAttributes attributes, Type parent)
            => mb.DefineType(fullName, attributes, parent);

        [MethodImpl(Inline), Op]
        public static TypeBuilder valueType(ModuleBuilder mb, ClrTypeName fullName, TypeAttributes attributes)
            => mb.DefineType(fullName, attributes, typeof(ValueType));

        const TypeAttributes Default = BeforeFieldInit | Public | Sealed | AnsiClass;

        public const TypeAttributes ExplicitAnsi
            = Default | ExplicitLayout;

        public const TypeAttributes SequentialAnsi
            = Default | SequentialLayout;

        readonly Span<FieldSpec> Fields;

        ushort Index;

        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        [MethodImpl(NotInline),Op]
        public static Type type(Name assname, TableSpec spec)
            => build(module(assname), spec);

        /// <summary>
        /// Manufactures the types that reifies supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        [MethodImpl(NotInline),Op]
        public static Type[] types(Name assname, params TableSpec[] specs)
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

        [MethodImpl(NotInline),Op]
        static Type build(ModuleBuilder mb, TableSpec spec)
        {
            var tb = valueType(mb, spec.TableName, ExplicitAnsi);
            var fields = spec.Fields;
            foreach(var f in fields)
                field(tb, f.FieldName, f.TypeName, f.Offset);
            var type = tb.CreateType();
            return type;
        }

        [MethodImpl(NotInline),Op]
        public TableBuilder(uint capacity)
        {
            Index = 0;
            Fields = span<FieldSpec>(capacity);
        }

        [MethodImpl(NotInline),Op]
        public TableBuilder WithField(PropertyInfo src)
        {
            var field = new FieldSpec(src.Name, src.PropertyType, Index);
            seek(Fields, Index++) = field;
            return this;
        }

        [MethodImpl(NotInline),Op]
        public TableBuilder WithField(string name, Type type)
        {
            var field = new FieldSpec(name, type, Index);
            seek(Fields, Index++) = field;
            return this;
        }

        [MethodImpl(NotInline), Op]
        public TableBuilder WithField(FieldInfo src)
        {
            var field = new FieldSpec(src.Name, src.FieldType, Index);
            seek(Fields, Index++) = field;
            return this;
        }

        [MethodImpl(NotInline), Op]
        public TableBuilder WithFields(params PropertyInfo[] src)
        {
            foreach(var item in src)
                WithField(item);
            return this;
        }

        [MethodImpl(NotInline), Op]
        public TableBuilder WithFields(params FieldInfo[] src)
        {
            foreach(var item in src)
                WithField(item);
            return this;
        }

        [MethodImpl(NotInline), Op]
        public TableSpec Complete(ClrTypeName name)
        {
            var cells = Fields.Slice(0,(int)Index).ToArray();
            Fields.Clear();
            return new TableSpec(name, cells);
        }
    }
}