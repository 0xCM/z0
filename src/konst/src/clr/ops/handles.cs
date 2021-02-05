//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeMethodHandle> hmethod(Module src, ClrToken token)
            => new ClrHandle<RuntimeMethodHandle>(ClrArtifactKind.Method, token, src.ModuleHandle.GetRuntimeMethodHandleFromMetadataToken((int)token));

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeFieldHandle> hfield(Module src, ClrToken token)
            => new ClrHandle<RuntimeFieldHandle>(ClrArtifactKind.Field, token, src.ModuleHandle.GetRuntimeFieldHandleFromMetadataToken((int)token));

        [MethodImpl(Inline), Op]
        public static ClrHandle<RuntimeTypeHandle> htype(Module src, ClrToken token)
            => new ClrHandle<RuntimeTypeHandle>(ClrArtifactKind.Type, token, src.ModuleHandle.GetRuntimeTypeHandleFromMetadataToken((int)token));
    }
}