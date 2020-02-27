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

    using dnlib.DotNet;

    using Z0;

    using static zfunc;

    class ClrMetadataIndex : IClrIndex
    {                            
        public static readonly IClrIndex Empty = default(EmptyClrIndex);

        public static ClrMetadataIndex Create(Assembly assembly)
            => Create(assembly.Modules.ToArray());

        static ClrMetadataIndex Create(params Module[] modules)
            => new ClrMetadataIndex(modules);

        ConcurrentDictionary<int, Type> TypeIndex 
            = new ConcurrentDictionary<int, Type>();

        ConcurrentDictionary<int, MethodInfo> MethodIndex 
            = new ConcurrentDictionary<int, MethodInfo>();

        ConcurrentDictionary<int, ModuleDefMD> ModuleDefIndex 
            = new ConcurrentDictionary<int, ModuleDefMD>();
        
        ConcurrentDictionary<int, TypeDef> TypeDefIndex 
            = new ConcurrentDictionary<int, TypeDef>();
        
        ConcurrentDictionary<int, MethodDef> MethodDefIndex 
            = new ConcurrentDictionary<int, MethodDef>();

        ClrMetadataIndex(params Module[] modules)
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

        Option<CilFunction> GetCilFunction(MethodDef md)
        {
            if(!md.HasBody || !md.Body.HasInstructions)
                return default;
            
            var mcil = CilFunction.Create((int)md.MDToken.Raw, md.FullName, md.ImplAttributes.ToSpec(), md.Body.Instructions.Map(i => i.ToSpec()));
            md.FreeMethodBody();
            return mcil;
        }

        void IndexMethodDef(MethodDef md)
        {            
            require(MethodDefIndex.TryAdd((int)md.MDToken.Raw, md));
        }

        void IndexTypeDef(TypeDef t)
        {
            require(TypeDefIndex.TryAdd((int)t.MDToken.Raw, t));
            iter(t.Methods,IndexMethodDef);
        }

        ModuleDefMD AddModuleDef(ModuleDefMD mod)
        {
            require(ModuleDefIndex.TryAdd((int)mod.MDToken.Raw, mod));
            return mod;
        }

        void IndexModuleDef(Module mod)
        {            
            var md = AddModuleDef(ModuleDefMD.Load(mod));
            iter(md.GetTypes(), IndexTypeDef);                        
        }        
    }
}