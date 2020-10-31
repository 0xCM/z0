//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an clr artifact reference
    /// </summary>
    [Free]
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
        StringRef Name {get;}

        string ITextual.Format()
            => text.format(RP.PSx3, Kind, Key, Name);
    }

    public interface IClrArtifact : ITextual
    {
        ClrArtifactKind Kind {get;}

        ClrArtifactKey Key {get;}

        string Name {get;}

        ClrArtifactRef Ref
            => new ClrArtifactRef(Key, Kind ,Name);
        string ITextual.Format()
            => Name;
    }

    public interface IClrArtifact<A> : IClrArtifact
        where A : struct, IClrArtifact<A>
    {

    }
}