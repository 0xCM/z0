//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IClrArtifact : ITextual
    {
        ClrArtifactKind Kind {get;}

        CliKey Key {get;}

        string Name {get;}

        CliArtifactRef Ref
            => new CliArtifactRef(Key, Kind ,Name);
        string ITextual.Format()
            => Name;
    }

    [Free]
    public interface IClrArtifact<A> : IClrArtifact
        where A : struct, IClrArtifact<A>
    {

    }
}