//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IClrArtifactRef : ITextual
    {
        ClrArtifactKind Kind {get;}

        ApiArtifactKey Id {get;}

        ClrName Name {get;}

        string ITextual.Format()
            => text.format(RenderPatterns.PSx3, Kind, Id, Name);
    }

    public interface IClrArtifactRef<A> : IClrArtifactRef
        where A : struct, IClrArtifact<A>
    {
    }

}