//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum ArtifactSourceKind
    {
        None = 0,

        FileSystem,

        ProjectSystem,

        Repository,

        Package

    }

    public readonly struct ArtifactSource<T>
    {

    }
}