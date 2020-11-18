//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Reflection.Metadata;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Cli
    {
        [MethodImpl(Inline)]
        public static CliDependency<S,T> dependency<S,T>(S src, T dst)
            where S : struct
            where T : struct
                => new CliDependency<S,T>(src,dst);

        /// <summary>
        /// Returns a reference to the cli metadata for an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref SegRef metadata(Assembly src, out SegRef dst)
        {
            src.TryGetRawMetadata(out var ptr, out var len);
            dst = new SegRef(ptr,len);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static CliSig sig(MethodInfo src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));

        [Op]
        public static CliSig sig(Type src)
        {
            var module = src.Module;
            try
            {
                return new CliSig(module.ResolveSignature(src.MetadataToken));
            }
            catch(Exception)
            {
                throw new AppException(AppMsg.error($"Signature resolution failure: The signature of the type {src.AssemblyQualifiedName} was not found in the module {src.Module}"));
            }
        }

        [MethodImpl(Inline), Op]
        public static CliSig sig(FieldInfo src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));
    }
}