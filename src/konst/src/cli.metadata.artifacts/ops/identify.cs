//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Buffers;
    using System.Reflection;

    using static Konst;
    using static z;
    using static ReflectionFlags;

    partial struct ClrArtifacts
    {
        // [MethodImpl(Inline), Op]
        // public static ArtifactIdentity<ClrArtifactKind,ClrArtifactKey> identify(FieldInfo src)
        //     => (ClrArtifactKind.Field, src.MetadataToken);
    }
}