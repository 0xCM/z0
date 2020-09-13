//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Artifacts
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<TypeArtifact> types(Assembly src)
            => @recover<Type,TypeArtifact>(@readonly(src.Types()));
    }
}