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
        public static ModuleBuilder module(string name)
        {
            var ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(name), AssemblyBuilderAccess.Run);
            return ab.DefineDynamicModule("Primary");
        }

        [MethodImpl(Inline), Op]
        public static TypeBuilder type(ModuleBuilder mb, string fullName, TypeAttributes attributes, Type parent)
            => mb.DefineType(fullName, attributes, parent);

        [MethodImpl(Inline), Op]
        public static TypeBuilder valueType(ModuleBuilder mb, string fullName, TypeAttributes attributes)
            => mb.DefineType(fullName, attributes, typeof(ValueType));

        [MethodImpl(Inline), Op]
        public static FieldBuilder field(TypeBuilder tb, string name, string type, Address16 offset)
        {
            var fb = tb.DefineField(name, Type.GetType(type), FieldAttributes.Public);
            fb.SetOffset(offset);
            return fb;
        }

        [MethodImpl(Inline), Op]
        public static string fullName(string @namespace, string name)
            => text.format(RenderPatterns.SlotDot2, @namespace, name);
    }
}