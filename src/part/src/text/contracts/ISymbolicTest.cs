//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISymbolicQuery<S>
        where S : unmanaged
    {
        bit Check(S s);
    }

    public interface ISymbolicQuery<H,S> : ISymbolicQuery<S>, IKeyed<string>
        where H : struct, ISymbolicQuery<H,S>
        where S : unmanaged
    {
        string IKeyed<string>.Key
            => typeof(H).AssemblyQualifiedName;
    }
}