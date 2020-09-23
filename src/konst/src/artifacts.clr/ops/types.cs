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
        public static ClrArtifactSet<TypeView> sTypes(Assembly src)
            => @recover<Type,TypeView>(@readonly(src.Types()));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<TypeView> vTypes(Assembly src)
            => View(src.Types(),type);
    }
}