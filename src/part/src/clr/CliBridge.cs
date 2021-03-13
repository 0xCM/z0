//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    using static Root;
    using static memory;
    using static root;

    [ApiHost]
    public readonly struct CliBridge
    {
        [MethodImpl(Inline), Op]
        public static string @string(Module module, ClrToken token)
            => module.ResolveString((int)token);

        /// <summary>
        /// Determines the <see cref='CliSig'/> for a specified <see cref='MethodInfo'/>
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline), Op]
        public static CliSig sig(MethodInfo src)
        {
            sig(src, out var dst);
            return dst;
        }

        public static bool sig(MethodInfo src, out CliSig dst)
        {
            try
            {
                dst = src.Module.ResolveSignature(src.MetadataToken);
                return true;
            }
            catch
            {
                dst = CliSig.Empty;
                return false;
            }
        }

        /// <summary>
        /// Determines the <see cref='CliSig'/> for a specified <see cref='Type'/>
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static bool sig(Type src, out CliSig dst)
        {
            var module = src.Module;
            try
            {
                dst = new CliSig(module.ResolveSignature(src.MetadataToken));
                return true;
            }
            catch(Exception)
            {
                dst = CliSig.Empty;
                return false;
            }
        }


        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeMethodHandle> method(Module src, ClrToken token)
            => new ClrHandle<RuntimeMethodHandle>(ClrArtifactKind.Method, token, src.ModuleHandle.GetRuntimeMethodHandleFromMetadataToken((int)token));

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeFieldHandle> field(Module src, ClrToken token)
            => new ClrHandle<RuntimeFieldHandle>(ClrArtifactKind.Field, token, src.ModuleHandle.GetRuntimeFieldHandleFromMetadataToken((int)token));

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeTypeHandle> type(Module src, ClrToken token)
            => new ClrHandle<RuntimeTypeHandle>(ClrArtifactKind.Type, token, src.ModuleHandle.GetRuntimeTypeHandleFromMetadataToken((int)token));

        public static Index<CliSig> sigs(MethodInfo[] src)
        {
            var count = root.count(src);
            if(count==0)
                return default;

            var dst = sys.alloc<CliSig>(count);
            sigs(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void sigs(MethodInfo[] src, Span<CliSig> dst)
        {
            var k = min(count(src), count(dst));
            if(k != 0)
            {
                ref readonly var input = ref first(src);
                ref var output = ref first(dst);
                for(var i=0; i<k; i++)
                    seek(output,i) = sig(skip(input,i));
            }
        }

        /// <summary>
        /// Returns a <see cref='SegRef'/> to the cli metadata segment of the source
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static unsafe SegRef<byte> metaref(Assembly src)
        {
            if(src.TryGetRawMetadata(out var ptr, out var len))
                return memory.segref(ptr, len);
            else
                return SegRef<byte>.Empty;
        }

        /// <summary>
        /// Returns a reference to the cli metadata for an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static unsafe ref SegRef<byte> metaref(Assembly src, out SegRef<byte> dst)
        {
            src.TryGetRawMetadata(out var ptr, out var len);
            dst = memory.segref(ptr, len);
            return ref dst;
        }

        /// <summary>
        /// Returns a reference to the cli metadata for an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static unsafe ref ReadOnlySpan<byte> metaspan(Assembly src, out ReadOnlySpan<byte> dst)
        {
            src.TryGetRawMetadata(out var ptr, out var size);
            dst = memory.cover(ptr, size);
            return ref dst;
        }

        /// <summary>
        /// Returns a reference to the cli metadata for an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static unsafe ReadOnlySpan<byte> metaspan(Assembly src)
        {
            src.TryGetRawMetadata(out var ptr, out var size);
            return memory.cover(ptr, size);
        }

        [Op]
        public static Type type(Index<Type> src, ClrToken id)
        {
            for(var i=0; i<src.Length; i++)
            {
                var candidate = src[i];
                if(candidate.MetadataToken == id)
                    return candidate;
            }
            return EmptyVessels.EmptyStruct;
        }

    }
}