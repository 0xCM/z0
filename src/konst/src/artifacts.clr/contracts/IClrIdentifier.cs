//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes an clr artifact reference
    /// </summary>
    public interface IClrArtifactRef : ITextual
    {
        /// <summary>
        /// The artifact classifier
        /// </summary>
        ClrArtifactKind Kind {get;}

        /// <summary>
        /// The artifact key that, together with the artifact kind, forms an identity
        /// </summary>
        ClrArtifactKey Key {get;}

        /// <summary>
        /// The name of the referenced artifact
        /// </summary>
        ClrName Name {get;}

        string ITextual.Format()
            => text.format(RenderPatterns.PSx3, Kind, Key, Name);
    }

    public interface IClrArtifactRef<A> : IClrArtifactRef
        where A : struct, IClrArtifact<A>
    {
    }

}