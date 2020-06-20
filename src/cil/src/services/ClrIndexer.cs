//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using Z0.CilSpecs;

    using static Konst;
    using static Root;

    using DnLib = dnlib.DotNet.Emit;
    using Dn = dnlib.DotNet;

    class ClrIndexer : IClrIndexer
    {                            
        public static readonly IClrIndexer Empty = default(EmptyClrIndex);

        public static ClrIndexer Create(Assembly assembly)
            => Create(assembly.Modules.ToArray());

        static ClrIndexer Create(params Module[] modules)
            => new ClrIndexer(modules);

        ConcurrentDictionary<int, Type> TypeIndex 
            = new ConcurrentDictionary<int, Type>();

        ConcurrentDictionary<int, MethodInfo> MethodIndex 
            = new ConcurrentDictionary<int, MethodInfo>();

        ConcurrentDictionary<int, Dn.ModuleDefMD> ModuleDefIndex 
            = new ConcurrentDictionary<int, Dn.ModuleDefMD>();
        
        ConcurrentDictionary<int, Dn.TypeDef> TypeDefIndex 
            = new ConcurrentDictionary<int, Dn.TypeDef>();
        
        ConcurrentDictionary<int, Dn.MethodDef> MethodDefIndex 
            = new ConcurrentDictionary<int, Dn.MethodDef>();

        ClrIndexer(params Module[] modules)
        {
            iter(modules, IndexModuleDef);
            iter(modules, IndexClrModule);
        }

        public Option<CilFunction> FindCil(int id)
            => IsEmpty ? default : 
                from def in MethodDefIndex.TryFind(id)
                from f in GetCilFunction(def)
                select f;

        public Option<Type> FindType(int id)
            => TypeIndex.TryFind(id);

        public Option<MethodInfo> FindMethod(int id)
            => MethodIndex.TryFind(id);

        public bool IsEmpty
            => ModuleDefIndex.Count == 0;
            
        void IndexClrMethod(MethodInfo m)
        {
            require(MethodIndex.TryAdd(m.MetadataToken, m));
        }
        
        void IndexClrType(Type t)
        {
            require(TypeIndex.TryAdd(t.MetadataToken, t));            
            iter(t.DeclaredMethods(),IndexClrMethod);
        }

        void IndexClrModule(Module mod)
        {            
            iter(mod.GetTypes(), IndexClrType);
        }

        Option<CilFunction> GetCilFunction(Dn.MethodDef md)
        {
            if(!md.HasBody || !md.Body.HasInstructions)
                return default;
            
            var mcil = CilFunction.Create((int)md.MDToken.Raw, 
                md.FullName, 
                ToSpec(md.ImplAttributes), 
                md.Body.Instructions.Map(ToSpec));
            md.FreeMethodBody();
            return mcil;
        }

        void IndexMethodDef(Dn.MethodDef md)
        {            
            require(MethodDefIndex.TryAdd((int)md.MDToken.Raw, md));
        }

        void IndexTypeDef(Dn.TypeDef t)
        {
            require(TypeDefIndex.TryAdd((int)t.MDToken.Raw, t));
            iter(t.Methods,IndexMethodDef);
        }

        Dn.ModuleDefMD AddModuleDef(Dn.ModuleDefMD mod)
        {
            require(ModuleDefIndex.TryAdd((int)mod.MDToken.Raw, mod));
            return mod;
        }

        void IndexModuleDef(Module mod)
        {            
            var md = AddModuleDef(Dn.ModuleDefMD.Load(mod));
            iter(md.GetTypes(), IndexTypeDef);                        
        }        

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        public static CilSpecs.MethodImplAttributes ToSpec(Dn.MethodImplAttributes src)
            => (CilSpecs.MethodImplAttributes)src;

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        public static Instruction ToSpec(DnLib.Instruction src)
            => new Instruction{
                OpCode = ToSpec(src.OpCode),
                Operand = src.Operand,
                Offset = src.Offset,
                Formatted = src.ToString()
            };

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        static OpCode ToSpec(DnLib.OpCode src)
            => new OpCode(
                name: src.Name, 
                code: (Code)src.Code, 
                operandType: (OperandType)src.OperandType, 
                flowControl: (FlowControl)src.FlowControl, 
                opCodeType:  (OpCodeType)src.OpCodeType, 
                push: (StackBehaviour)src.StackBehaviourPush, 
                pop: (StackBehaviour)src.StackBehaviourPop
                );        
    }
}