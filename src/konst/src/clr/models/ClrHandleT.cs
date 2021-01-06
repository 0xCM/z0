//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = ClrHandles;

    public readonly struct ClrHandle<T>
        where T : struct
    {
        public ClrArtifactKind Kind {get;}

        public ClrToken Token {get;}

        public T Handle {get;}

        [MethodImpl(Inline)]
        public ClrHandle(ClrArtifactKind kind, ClrToken token, T handle)
        {
            Kind = kind;
            Token = token;
            Handle = handle;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrHandle(ClrHandle<T> src)
            => api.untype(src);
    }
}