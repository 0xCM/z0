//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ClrHandles)]
    public readonly struct ClrHandles
    {
        [Op]
        public static ReadOnlySpan<ClrHandle> methods(Assembly src)
        {
            var catalog = ApiCatalogs.part(src);
            var ops = catalog.ConcreteOperations();
            var count = ops.Length;
            var buffer = alloc<ClrHandle>(count);
            methods(ops, catalog.ManifestModule, buffer);
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static void methods(in ReadOnlySpan<MethodInfo> methods, Module module, Span<ClrHandle> dst)
        {
            var count = methods.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = method(module, ClrArtifactKey.from(skip(methods,i)));
        }

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeMethodHandle> method(Module src, ClrArtifactKey key)
            => new ClrHandle<RuntimeMethodHandle>(ClrArtifactKind.Method, key, src.ModuleHandle.GetRuntimeMethodHandleFromMetadataToken((int)key));

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeTypeHandle> type(Module src, ClrArtifactKey key)
            => new ClrHandle<RuntimeTypeHandle>(ClrArtifactKind.Method, key, src.ModuleHandle.GetRuntimeTypeHandleFromMetadataToken((int)key));

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeFieldHandle> field(Module src, ClrArtifactKey key)
            => new ClrHandle<RuntimeFieldHandle>(ClrArtifactKind.Method, key, src.ModuleHandle.GetRuntimeFieldHandleFromMetadataToken((int)key));

        [MethodImpl(Inline), Op]
        public static ClrHandle untype(in ClrHandle<RuntimeMethodHandle> src)
            => new ClrHandle(src.Kind, src.Key, src.Handle.GetFunctionPointer());

        [MethodImpl(Inline), Op]
        public static ClrHandle untype(in ClrHandle<RuntimeFieldHandle> src)
            => new ClrHandle(src.Kind, src.Key, src.Handle.Value);

        [MethodImpl(Inline), Op]
        public static ClrHandle untype(in ClrHandle<RuntimeTypeHandle> src)
            => new ClrHandle(src.Kind, src.Key, src.Handle.Value);

        [MethodImpl(Inline)]
        public static ClrHandle untype<T>(in ClrHandle<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(RuntimeMethodHandle))
                return untype(@as<ClrHandle<T>,ClrHandle<RuntimeMethodHandle>>(src));
            else if(typeof(T) == typeof(RuntimeFieldHandle))
                return untype(@as<ClrHandle<T>,ClrHandle<RuntimeFieldHandle>>(src));
            else if(typeof(T) == typeof(RuntimeTypeHandle))
                return untype(@as<ClrHandle<T>,ClrHandle<RuntimeTypeHandle>>(src));
            else
                throw no<T>();
        }
    }
}