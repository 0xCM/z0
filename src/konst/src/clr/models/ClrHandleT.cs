//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = ClrHandles;

    public readonly struct ClrHandle<T>
        where T : struct
    {
        public ClrArtifactKind Kind {get;}

        public CliArtifactKey Key {get;}

        public T Handle {get;}

        [MethodImpl(Inline)]
        public ClrHandle(ClrArtifactKind kind, CliArtifactKey key, T handle)
        {
            Kind = kind;
            Key = key;
            Handle = handle;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrHandle(ClrHandle<T> src)
            => api.untype(src);
    }
}