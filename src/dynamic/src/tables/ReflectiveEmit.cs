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

    [ApiHost]
    public readonly partial struct ReflectiveEmit
    {
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

        [MethodImpl(Inline), Op]
        public static FieldBuilder field(TypeBuilder tb, Name name, string type, Address16? offset = null)
        {
            var fb = tb.DefineField(name, Type.GetType(type), FieldAttributes.Public);
            if(offset != null)
                fb.SetOffset(offset.Value);
            return fb;
        }

        [MethodImpl(Inline), Op]
        public static string fullName(string @namespace, string name)
            => text.format(RenderPatterns.SlotDot2, @namespace, name);
    }
}