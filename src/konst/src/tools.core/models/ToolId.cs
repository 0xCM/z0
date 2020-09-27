//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolId : ITextual
    {
        readonly Type Type;

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
        public static implicit operator ToolId(string name)
            => new ToolId(typeof(void));

        [MethodImpl(Inline)]
        public static implicit operator ToolId(Type src)
            => new ToolId(src);

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(ToolId src)
            => new WfStepId(src.Type);

        [MethodImpl(Inline)]
        public ToolId(Type src)
            => Type = src;

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}