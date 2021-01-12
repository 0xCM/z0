namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    using static Part;

    partial struct Clr
    {
        /// <summary>
        /// Returns a <see cref='SegRef'/> to the cli metadata segment of the source
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static unsafe SegRef<byte> metadata(Assembly src)
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
        public static unsafe ref SegRef<byte> metadata(Assembly src, out SegRef<byte> dst)
        {
            src.TryGetRawMetadata(out var ptr, out var len);
            dst = memory.segref(ptr, len);
            return ref dst;
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
            dst.DefiningAssembly = src.Module.Assembly;
            dst.DefiningModule = src.Module.Name;
            dst.DeclaringType = siginfo(src.DeclaringType);
            dst.ReturnType = siginfo(src.ReturnType);
            dst.ValueParams = src.GetParameters().Select(p => new ClrParamInfo(siginfo(p), p.RefKind(), p.Name, (ushort)p.Position));
            dst.TypeParams = src.TypeParameters();
            return dst;
        }
    }
}