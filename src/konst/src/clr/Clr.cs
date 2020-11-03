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

    public readonly struct Clr
    {
        [MethodImpl(Inline), Op]
        public static CliSig sig(MethodInfo src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));

        [MethodImpl(Inline), Op]
        public static CliSig sig(Type src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));

        [MethodImpl(Inline), Op]
        public static CliSig sig(FieldInfo src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));
    }
}