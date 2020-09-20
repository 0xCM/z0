//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfToolId<T> : ITextual
    {
        static Type Type = typeof(T);

        public string Name
        {
            [MethodImpl(Inline)]
            get => Type.Name;
        }

        public ArtifactIdentifier Id
        {
            [MethodImpl(Inline)]
            get => Type.MetadataToken;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfToolId(WfToolId<T> src)
            => new WfToolId(WfToolId<T>.Type);

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}