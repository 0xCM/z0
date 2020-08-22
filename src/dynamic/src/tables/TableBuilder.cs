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

    using static TableSpecLiterals;
    using static ReflectiveEmit;
    using static Konst;
    using static z;

    [ApiDataType]
    public ref struct TableBuilder
    {
        readonly Span<FieldSpec> Fields;

        ushort Index;

        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        [Op]
        public static Type type(Name assname, TableSpec spec)
            => build(module(assname), spec);

        /// <summary>
        /// Manufactures the types that reifies supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        [Op]
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

        static Type build(ModuleBuilder mb, TableSpec spec)
        {
            var tb = valueType(mb, spec.TableName, ExplicitAnsi);
            var fields = spec.Fields;
            foreach(var f in fields)
                field(tb, f.FieldName, f.TypeName, f.Offset);
            var type = tb.CreateType();
            return type;
        }
        [MethodImpl(Inline)]
        public TableBuilder(uint capacity)
        {
            Index = 0;
            Fields = span<FieldSpec>(capacity);
        }

        [MethodImpl(Inline)]
        public TableBuilder WithField(PropertyInfo src)
        {
            var field = new FieldSpec(src.Name, src.PropertyType.AssemblyQualifiedName, Index);
            seek(Fields, Index++) = field;
            return this;
        }

        [MethodImpl(Inline)]
        public TableBuilder WithField(string name, Type type)
        {
            var field = new FieldSpec(name, type.AssemblyQualifiedName, Index);
            seek(Fields, Index++) = field;
            return this;
        }

        [MethodImpl(Inline)]
        public TableBuilder WithField(FieldInfo src)
        {
            var field = new FieldSpec(src.Name, src.FieldType.AssemblyQualifiedName, Index);
            seek(Fields, Index++) = field;
            return this;
        }

        [MethodImpl(Inline)]
        public TableBuilder WithFields(params PropertyInfo[] src)
        {
            foreach(var item in src)
                WithField(item);

            return this;
        }

        [MethodImpl(Inline)]
        public TableBuilder WithFields(params FieldInfo[] src)
        {
            foreach(var item in src)
                WithField(item);
            return this;
        }

        [MethodImpl(Inline)]
        public TableSpec Complete(string name)
        {
            var cells = Fields.Slice(0,(int)Index).ToArray();
            Fields.Clear();
            return new TableSpec(name, cells);
        }
    }
}