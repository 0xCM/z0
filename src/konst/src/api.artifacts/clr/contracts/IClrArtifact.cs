//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IClrArtifact<A> : ITextual
        where A : struct, IClrArtifact<A>
    {
        ClrArtifactKind Kind {get;}

        ApiArtifactKey Id {get;}

        string Name {get;}

        ClrArtifactRef Ref
            => new ClrArtifactRef(Id, Kind ,Name);
        string ITextual.Format()
            => (Ref as IClrArtifactRef).Format();
    }
}