//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ArtifactModels
    {
        /// <summary>
        /// Defines a reference to a type
        /// </summary>
        public readonly struct TypeRef<T>
        {
            public ClrArtifactKey Id
            {
                [MethodImpl(Inline)]
                get => typeof(T).MetadataToken;
            }
        }
    }
}