namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    using static Part;

    partial struct ClrQuery
    {
        /// <summary>
        /// Returns a <see cref='Ref'/> to the cli metadata segment of the source
        /// </summary>
        /// <param name="src">The source assembly</param>
        public static unsafe Ref<byte> metadata(Assembly src)
        {
            if(src.TryGetRawMetadata(out var ptr, out var len))
                return MemRefs.segment(ptr,len);
            else
                return Ref<byte>.Empty;
        }

        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [Op]
        public static MethodMetadata metadata(MethodInfo src)
        {
            var dst = new MethodMetadata();
            dst.Token = src.MetadataToken;
            dst.MethodName = src.DisplayName();
            dst.DefiningAssembly = src.Module.Assembly.GetSimpleName();
            dst.DefiningModule = src.Module.Name;
            dst.DeclaringType = TypeSigInfo.from(src.DeclaringType);
            dst.ReturnType = TypeSigInfo.from(src.ReturnType);
            dst.ValueParams = src.GetParameters().Select(p => new MethodParameter(TypeSigInfo.from(p), p.RefKind(), p.Name, (ushort)p.Position));
            dst.TypeParams = src.TypeParameters();
            return dst;
        }
    }
}