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

    partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public static ModuleView vManifest(Assembly src)
            => view(src.ManifestModule);
    }
}