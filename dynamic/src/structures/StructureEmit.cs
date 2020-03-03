//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Threading;
    using System.Reflection.Emit;
    using System.Linq;

    public static class StructureEmit
    {
        public static StructuredField SpecifyField(string FieldName, int Position, ByteSize Offset, string FieldType)
            => StructuredField.Define(FieldName, Position, Offset, FieldType);

        public static StructureSpec SpecifyRecord(string Namespace, string TypeName, params StructuredField[] Fields)
            => StructureSpec.Define(Namespace, TypeName, Fields);

        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        public static Type CreateType(StructureSpec spec)        
            => DefineModule().DefineRecord(spec);

        /// <summary>
        /// Manufactures the types that reifies supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        public static Type[] CreateTypes(params StructureSpec[] specs)
        {
            var dst = new Type[specs.Length];
            var mb = DefineModule();
            for(var i=0; i< specs.Length; i++)
                dst[i] = mb.DefineRecord(specs[i]);
            return dst;
        }

        public static IEnumerable<Type> CreateTypes(this IEnumerable<StructureSpec> specs)
            => CreateTypes(specs.ToArray());

        static FieldBuilder DefineField(this TypeBuilder tb, StructuredField spec)
        {            
            
            var fb = tb.DefineField(spec.FieldName,Type.GetType(spec.FieldType), FieldAttributes.Public);
            fb.SetOffset(spec.Offset);            
            return fb;
        }

        static Type DefineRecord(this ModuleBuilder mb, StructureSpec spec)
        {
            const TypeAttributes attribs 
                = TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.ExplicitLayout |
                  TypeAttributes.Serializable | TypeAttributes.AnsiClass;
            
            var fullName = string.IsNullOrWhiteSpace(spec.Namespace) ? spec.Namespace : $"{spec.Namespace}.{spec.TypeName}";
            TypeBuilder tb = mb.DefineType(fullName, attribs, typeof(ValueType));
            foreach(var field in spec.Fields)
                tb.DefineField(field);
            var type = tb.CreateType();
            return type;            
        }

        static ModuleBuilder DefineModule()        
        {
            var ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(Guid.NewGuid().ToString()), AssemblyBuilderAccess.Run);
            return ab.DefineDynamicModule("Primary");
        }
    }
}
