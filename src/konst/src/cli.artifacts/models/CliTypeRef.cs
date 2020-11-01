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

    /// <summary>
    /// Defines a reference to a type
    /// </summary>
    public readonly struct CliTypeRef<T>
    {
        public ClrArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => typeof(T).MetadataToken;
        }
    }
}