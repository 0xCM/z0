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
    public interface ICliArtifact : ITextual
    {
        /// <summary>
        /// The artifact classifier
        /// </summary>
        ClrArtifactKind Kind {get;}

        /// <summary>
        /// The artifact key that, together with the artifact kind, forms an identity
        /// </summary>
        ClrToken Key {get;}

        /// <summary>
        /// The name of the referenced artifact
        /// </summary>
        StringRef Name {get;}

        string ITextual.Format()
            => text.format(RP.PSx3, Kind, Key, Name);
    }
}