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

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct ClrSigs
    {
        [MethodImpl(Inline), Op]
        public static byte[] data(Module src, ClrArtifactKey key)
            => src.ResolveSignature((int)key);

        [MethodImpl(Inline), Op]
        public static ClrSig resolve(MethodInfo src)
            =>  new ClrSig(ClrArtifactKind.Method, data(src.Module, src.MetadataToken));

        [MethodImpl(Inline), Op]
        public static ClrSig resolve(Type src)
            => new ClrSig(ClrArtifactKind.Type, data(src.Module, src.MetadataToken));

        [MethodImpl(Inline), Op]
        public static ClrSig resolve(FieldInfo src)
            => new ClrSig(ClrArtifactKind.Field, data(src.Module, src.MetadataToken));
    }
}