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
    
    public class CilMetadataIndex
    {                            
        public static CilMetadataIndex Create(params Assembly[] assemblies)
        {
            var modules = from a in assemblies
                          from m in a.Modules
                          select m;
            return Create(modules.ToArray());
        }
        
        public static CilMetadataIndex Create(params Module[] modules)
            => new CilMetadataIndex(modules);

        ConcurrentDictionary<int, ModuleDefMD> ModuleIndex 
            = new ConcurrentDictionary<int, ModuleDefMD>();
        ConcurrentDictionary<int, TypeDef> TypeIndex 
            = new ConcurrentDictionary<int, TypeDef>();
        ConcurrentDictionary<int, MethodDef> MethodIndex 
            = new ConcurrentDictionary<int, MethodDef>();
        ConcurrentDictionary<int, CilFuncSpec> CilIndex 
            = new ConcurrentDictionary<int, CilFuncSpec>();

        CilMetadataIndex(params Module[] modules)
        {
            iter(modules, IndexModule);
        }

        Option<CilFuncSpec> FindCil(int methodId)
            => CilIndex.TryFind(methodId);

        public Option<CilFuncSpec> FindCil(MethodInfo mi)
            => from m in FindCil(mi.MetadataToken)
                let result = m.WithSig(mi.Signature())
                select result;

        [MethodImpl(Inline)]
        Option<TypeDef> FindType(int typeId)
        {
            if(TypeIndex.TryGetValue(typeId, out TypeDef td))
                return td;
            else
                return none<TypeDef>();
        }

        [MethodImpl(Inline)]
        public Option<TypeDef> FindType(Type t)
            => FindType(t.MetadataToken);

        [MethodImpl(Inline)]
        public Option<MethodDef> FindMethod(int methodId)
        {
            var m = default(MethodInfo);
            if(MethodIndex.TryGetValue(methodId, out MethodDef md))
                return md;
            else
                return none<MethodDef>();
        }

        public IEnumerable<ModuleDef> Modules
            => ModuleIndex.Values;

        public IEnumerable<TypeDef> Types
            => TypeIndex.Values;

        public IEnumerable<CilFuncSpec> CilBodies
            => CilIndex.Values;

        public IEnumerable<MethodDef> Methods
            => MethodIndex.Values;

        [MethodImpl(Inline)]
        public Option<MethodDef> FindMethod(MethodInfo mi)
            => FindMethod(mi.MetadataToken);

        TypeDef ResolveType(ModuleDefMD mod, string fullName)
        {
            var def =  new TypeRefUser(mod, fullName).Resolve();
            if(def == null)
                throw new Exception($"Coud not resolve type {fullName}");
            return def;
        }

        ModuleDefMD GetModDef(Module src)
        {
            var metadata = ModuleIndex.GetOrAdd(src.MetadataToken,
                 _ => ModuleDefMD.Load(src));
            return metadata;
        }

        TypeDef GetTypeDef(Type src)
        {
            var declMod = GetModDef(src.Module);
            var typeDef = TypeIndex.GetOrAdd(src.MetadataToken, 
                _ => ResolveType(declMod, src.FullName));
            return typeDef;
        }

        CilFuncSpec ExtractCil(MethodDef md)
        {
            var mid = (int)md.MDToken.Raw;
            var instructions = md.Body.Instructions.ToReadOnlyList();
            var mcil = new CilFuncSpec(mid, md.FullName, md.ImplAttributes, instructions);
            return mcil;
        }
        
        void IndexCil(MethodDef md)
        {
            var mid = (int)md.MDToken.Raw;
            var mcil = ExtractCil(md);
            require(CilIndex.TryAdd(mid, mcil));
            md.FreeMethodBody();
        }

        void IndexMethod(MethodDef md)
        {            
            var mid = (int)md.MDToken.Raw;
            require(MethodIndex.TryAdd(mid, md));
            if(md.HasBody && md.Body.HasInstructions)
                IndexCil(md);
        }
        
        void IndexType(TypeDef t)
        {
            require(TypeIndex.TryAdd((int)t.MDToken.Raw, t));
            foreach(var md in t.Methods)
                IndexMethod(md);
        }
        
        void IndexModule(Module mod)
        {
            var modDef = GetModDef(mod);
            foreach(var t in modDef.GetTypes())
                IndexType(t);
        }        
    }
}