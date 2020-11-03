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
    public readonly struct CliSigs
    {
        [MethodImpl(Inline), Op]
        public static CliSig resolve(MethodInfo src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));

        [MethodImpl(Inline), Op]
        public static CliSig resolve(Type src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));

        [MethodImpl(Inline), Op]
        public static CliSig resolve(FieldInfo src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));
    }
}