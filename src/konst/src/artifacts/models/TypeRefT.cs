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

    partial struct ArtifactModel
    {
        /// <summary>
        /// Defines a reference to a type
        /// </summary>
        public readonly struct TypeRef<T>
        {
            public ArtifactIdentifier Id
            {
                [MethodImpl(Inline)]
                get => typeof(T).MetadataToken;
            }
        }
    }
}