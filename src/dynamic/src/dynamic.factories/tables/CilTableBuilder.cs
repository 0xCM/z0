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

    [ApiHost(ApiNames.CilTableBuilder, true)]
    public ref partial struct CilTableBuilder
    {
        [Op]
        public static CilTableBuilder create(ushort? capacity = null)
            => new CilTableBuilder(capacity ?? 20);

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

        readonly Span<CilFieldSpec> Fields;

        ushort Index;


        [MethodImpl(NotInline),Op]
        public CilTableBuilder(uint capacity)
        {
            Index = 0;
            Fields = span<CilFieldSpec>(capacity);
        }

        [MethodImpl(NotInline),Op]
        public CilTableBuilder WithField(PropertyInfo src)
        {
            var field = new CilFieldSpec(src.Name, src.PropertyType, Index);
            seek(Fields, Index++) = field;
            return this;
        }

        [MethodImpl(NotInline),Op]
        public CilTableBuilder WithField(string name, Type type)
        {
            var field = new CilFieldSpec(name, type, Index);
            seek(Fields, Index++) = field;
            return this;
        }

        [MethodImpl(NotInline), Op]
        public CilTableBuilder WithField(ClrField src)
        {
            var field = new CilFieldSpec(src.Name, src.FieldType, Index);
            seek(Fields, Index++) = field;
            return this;
        }

        [MethodImpl(NotInline), Op]
        public CilTableBuilder WithFields(params PropertyInfo[] src)
        {
            foreach(var item in src)
                WithField(item);
            return this;
        }

        [MethodImpl(NotInline), Op]
        public CilTableBuilder WithFields(params FieldInfo[] src)
        {
            foreach(var item in src)
                WithField(item);
            return this;
        }

        [MethodImpl(NotInline), Op]
        public CilTableSpec Complete(ClrTypeName name)
        {
            var cells = Fields.Slice(0,(int)Index).ToArray();
            Fields.Clear();
            return new CilTableSpec(name, cells);
        }
    }
}