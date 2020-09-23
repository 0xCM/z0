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

    partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public static Module[] modules(Assembly src)
            => src.Modules.Array();

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ModuleView> vModules(Assembly src)
            => View(modules(src), module);
    }
}