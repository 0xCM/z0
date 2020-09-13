//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IClrIdentifier
    {
        ClrTypeCode ArtifactType {get;}

        ArtifactIdentifier ArtifactId {get;}

    }

    public interface IClrIdentifier<A> : IClrIdentifier
        where A : struct, IClrArtifact<A>
    {
    }

}