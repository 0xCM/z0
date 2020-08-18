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

    partial struct ComponentModels
    {
        public readonly struct ClrAssembly
        {
            public Assembly Definition {get;}

            public ArtifactIdentity Id
            {
                [MethodImpl(Inline)]
                get => new ArtifactIdentity(Definition);
            }

            [MethodImpl(Inline)]
            public ClrAssembly(Assembly src)
                => Definition = src;

            [MethodImpl(Inline)]
            public static implicit operator Assembly(ClrAssembly src)
                => src.Definition;
        }
    }
}