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

    using static zfunc;
    
    public class ClrMetadataIndex
    {                            
        public static ClrMetadataIndex Create(params Assembly[] assemblies)
        {
            var modules = from a in assemblies
                          from m in a.Modules
                          select m;
            return Create(modules.ToArray());
        }
        
        public static ClrMetadataIndex Create(params Module[] modules)
            => new ClrMetadataIndex(modules);

        ConcurrentDictionary<int, ModuleDefMD> ModuleIndex 
            = new ConcurrentDictionary<int, ModuleDefMD>();
        ConcurrentDictionary<int, TypeDef> TypeIndex 
            = new ConcurrentDictionary<int, TypeDef>();
        ConcurrentDictionary<int, MethodDef> MethodIndex 
            = new ConcurrentDictionary<int, MethodDef>();

        ClrMetadataIndex(params Module[] modules)
        {
            iter(modules, IndexModule);
        }

        public Option<CilFunction> FindCilFunction(MethodInfo mi)
            => from m in FindMethod(mi)
                from f in GetCilFunction(m)
                select f.WithSig(mi.Signature());

        Option<TypeDef> FindType(int typeId)
        {
            if(TypeIndex.TryGetValue(typeId, out TypeDef td))
                return td;
            else
                return default;
        }

        public Option<TypeDef> FindType(Type t)
            => FindType(t.MetadataToken);

        public Option<MethodDef> FindMethod(int methodId)
        {
            var m = default(MethodInfo);
            if(MethodIndex.TryGetValue(methodId, out MethodDef md))
                return md;
            else
                return none<MethodDef>();
        }

        public Option<MethodDef> FindMethod(MethodInfo mi)
            => FindMethod(mi.MetadataToken);

        ModuleDefMD GetModDef(Module src)
        {
            var metadata = ModuleIndex.GetOrAdd(src.MetadataToken,
                 _ => ModuleDefMD.Load(src));
            return metadata;
        }
                        
        Option<CilFunction> GetCilFunction(MethodDef md)
        {
            if(md.HasBody && md.Body.HasInstructions)
            {
                var mid = (int)md.MDToken.Raw;
                var mcil = new CilFunction(mid, md.FullName, md.ImplAttributes, md.Body.Instructions.ToArray());
                md.FreeMethodBody();
                return mcil;
            }
            return default;

        }
        void IndexMethod(MethodDef md)
        {            
            var mid = (int)md.MDToken.Raw;
            require(MethodIndex.TryAdd(mid, md));
        }
        
        void IndexType(TypeDef t)
        {
            require(TypeIndex.TryAdd((int)t.MDToken.Raw, t));
            foreach(var md in t.Methods)
                IndexMethod(md);
        }
        
        void IndexModule(Module mod)
        {            
            var md = GetModDef(mod);
            foreach(var t in md.GetTypes())
                IndexType(t);
        }        
    }
}