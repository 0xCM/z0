//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolId<T> : ITextual
    {
        static Type Type = typeof(T);

        public string Name
        {
            [MethodImpl(Inline)]
            get => Type.Name;
        }

        public ClrArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => Type.MetadataToken;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolId(ToolId<T> src)
            => new ToolId(ToolId<T>.Type);

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}