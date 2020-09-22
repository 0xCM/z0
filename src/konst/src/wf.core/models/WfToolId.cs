//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    public readonly struct WfToolId : ITextual
    {
        readonly Type Type;

        public string Name
        {
            [MethodImpl(Inline)]
            get => Type.Name;
        }

        public ApiArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => Type.MetadataToken;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfToolId(string name)
            => new WfToolId(typeof(void));

        [MethodImpl(Inline)]
        public static implicit operator WfToolId(Type src)
            => new WfToolId(src);

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(WfToolId src)
            => new WfStepId(src.Type);

        [MethodImpl(Inline)]
        public WfToolId(Type src)
            => Type = src;

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}