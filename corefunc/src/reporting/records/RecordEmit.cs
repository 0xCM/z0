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

    using static zfunc;

    public static class RecordEmit
    {
        public static RecordFieldSpec SpecifyField(string FieldName, int Position, ByteSize Offset, string FieldType)
            => RecordFieldSpec.Define(FieldName, Position, Offset, FieldType);

        public static RecordSpec SpecifyRecord(string Namespace, string TypeName, params RecordFieldSpec[] Fields)
            => RecordSpec.Define(Namespace, TypeName, Fields);

        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        public static Type CreateType(RecordSpec spec)        
            => DefineModule().DefineRecord(spec);

        /// <summary>
        /// Manufactures the types that reifies supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        public static Type[] CreateTypes(params RecordSpec[] specs)
        {
            var dst = new Type[specs.Length];
            var mb = DefineModule();
            for(var i=0; i< specs.Length; i++)
                dst[i] = mb.DefineRecord(specs[i]);
            return dst;
        }

        public static IEnumerable<Type> CreateTypes(this IEnumerable<RecordSpec> specs)
            => CreateTypes(specs.ToArray());

        static FieldBuilder DefineField(this TypeBuilder tb, RecordFieldSpec spec)
        {            
            
            var fb = tb.DefineField(spec.FieldName,Type.GetType(spec.FieldType), FieldAttributes.Public);
            fb.SetOffset(spec.Offset);            
            return fb;
        }

        static Type DefineRecord(this ModuleBuilder mb, RecordSpec spec)
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
