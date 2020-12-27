//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    [ApiHost(ApiNames.ClrHandles, true)]
    public readonly struct ClrHandles
    {
        [Op]
        public static void project(ReadOnlySpan<ClrHandle> src, Span<ClrHandleRecord> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(src,i);
                ref var record = ref seek(dst,i);
                record.Address = handle.Pointer.Address;
                record.Key = handle.Key;
                record.Kind = handle.Kind;
            }
        }

        public static ReadOnlySpan<byte> HandleRenderWidths
            => new byte[3]{16, 16, 16};

        [Op]
        public static uint project(ReadOnlySpan<ClrHandleRecord> src,  StreamWriter dst)
        {
            var count = src.Length;
            var counter = 0u;
            var formatter = TableFormatter.row<ClrHandleRecord>(HandleRenderWidths);
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(src,i);
                var row = formatter.FormatRow(record);
                dst.WriteLine(row);
                counter++;
            }
            return counter;
        }


        [Op]
        public static ReadOnlySpan<ClrHandle<RuntimeTypeHandle>> types(Assembly src)
        {
            var metadata = src.Types();
            var count = metadata.Length;
            var buffer = alloc<ClrHandle<RuntimeTypeHandle>>(count);
            types(metadata, src.ManifestModule, buffer);
            return buffer;
        }

        [Op]
        public static ReadOnlySpan<ClrHandle<RuntimeFieldHandle>> fields(Assembly src)
        {
            var metadata = src.Fields();
            var count = metadata.Length;
            var buffer = alloc<ClrHandle<RuntimeFieldHandle>>(count);
            fields(metadata, src.ManifestModule, buffer);
            return buffer;
        }

        [Op]
        public static ReadOnlySpan<ClrHandle<RuntimeMethodHandle>> methods(Assembly src)
        {
            var catalog = ApiCatalogs.part(src);
            var metadata = catalog.ConcreteOperations();
            var count = metadata.Length;
            var buffer = alloc<ClrHandle<RuntimeMethodHandle>>(count);
            methods(metadata, catalog.ManifestModule, buffer);
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static void fields(in ReadOnlySpan<FieldInfo> src, Module module, Span<ClrHandle<RuntimeFieldHandle>> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = field(module, ClrToken.from(skip(src,i)));
        }


        [MethodImpl(Inline), Op]
        public static void types(in ReadOnlySpan<Type> src, Module module, Span<ClrHandle<RuntimeTypeHandle>> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = type(module, ClrToken.from(skip(src,i)));
        }

        [MethodImpl(Inline), Op]
        public static void methods(in ReadOnlySpan<MethodInfo> src, Module module, Span<ClrHandle<RuntimeMethodHandle>> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = method(module, ClrToken.from(skip(src,i)));
        }

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeMethodHandle> method(Module src, ClrToken key)
            => new ClrHandle<RuntimeMethodHandle>(ClrArtifactKind.Method, key, src.ModuleHandle.GetRuntimeMethodHandleFromMetadataToken((int)key));

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeTypeHandle> type(Module src, ClrToken key)
            => new ClrHandle<RuntimeTypeHandle>(ClrArtifactKind.Type, key, src.ModuleHandle.GetRuntimeTypeHandleFromMetadataToken((int)key));

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeFieldHandle> field(Module src, ClrToken key)
            => new ClrHandle<RuntimeFieldHandle>(ClrArtifactKind.Field, key, src.ModuleHandle.GetRuntimeFieldHandleFromMetadataToken((int)key));

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