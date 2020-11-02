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

    using static Konst;
    using static z;

    using Dn = dnlib.DotNet;
    using api = CilApi;

    class CilIndex : ICilIndex
    {
        public static CilIndex create(Assembly assembly)
            => create(assembly.Modules.ToArray());

        public static CilIndex create(params Module[] modules)
            => new CilIndex(modules);

        ConcurrentDictionary<int,Type> TypeIndex
            = new ConcurrentDictionary<int,Type>();

        ConcurrentDictionary<int, MethodInfo> MethodIndex
            = new ConcurrentDictionary<int, MethodInfo>();

        ConcurrentDictionary<int, Dn.ModuleDefMD> ModuleDefIndex
            = new ConcurrentDictionary<int, Dn.ModuleDefMD>();

        ConcurrentDictionary<int, Dn.TypeDef> TypeDefIndex
            = new ConcurrentDictionary<int, Dn.TypeDef>();

        ConcurrentDictionary<int, Dn.MethodDef> MethodDefIndex
            = new ConcurrentDictionary<int, Dn.MethodDef>();

        internal CilIndex(params Module[] modules)
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

        void IndexClrMethod(MethodInfo src)
        {
            insist(MethodIndex.TryAdd(src.MetadataToken, src), $"Attempt to include {src} in the index failed");
        }

        void IndexClrType(Type src)
        {
            insist(TypeIndex.TryAdd(src.MetadataToken, src), $"Attempt to include {src} in the index failed");
            iter(src.DeclaredMethods(), IndexClrMethod);
        }

        void IndexClrModule(Module mod)
        {
            iter(mod.GetTypes(), IndexClrType);
        }

        Option<CilFunction> GetCilFunction(Dn.MethodDef md)
        {
            if(!md.HasBody || !md.Body.HasInstructions)
                return default;

            var f = new CilFunction((int)md.MDToken.Raw, md.FullName, ToSpec(md.ImplAttributes), md.Body.Instructions.Map(api.describe));
            md.FreeMethodBody();
            return f;
        }

        void IndexMethodDef(Dn.MethodDef src)
        {
            insist(MethodDefIndex.TryAdd((int)src.MDToken.Raw, src), $"Attempt to include {src} in the index failed");
        }

        void IndexTypeDef(Dn.TypeDef src)
        {
            insist(TypeDefIndex.TryAdd((int)src.MDToken.Raw, src), $"Attempt to include {src} in the index failed");
            iter(src.Methods,IndexMethodDef);
        }

        Dn.ModuleDefMD AddModuleDef(Dn.ModuleDefMD src)
        {
            insist(ModuleDefIndex.TryAdd((int)src.MDToken.Raw, src), $"Attempt to include {src} in the index failed");
            return src;
        }

        void IndexModuleDef(Module mod)
        {
            var md = AddModuleDef(Dn.ModuleDefMD.Load(mod));
            iter(md.GetTypes(), IndexTypeDef);
        }

        [MethodImpl(Inline)]
        public static MethodImplAttributes ToSpec(Dn.MethodImplAttributes src)
            => (MethodImplAttributes)src;
    }
}