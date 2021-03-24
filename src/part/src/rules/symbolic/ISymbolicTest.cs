//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISymbolicTest<S>
        where S : unmanaged
    {
        bit Check(S s);
    }

    public interface ISymbolicTest<H,S> : ISymbolicTest<S>, IKeyed<string>
        where H : struct, ISymbolicTest<H,S>
        where S : unmanaged
    {
        string IKeyed<string>.Key
            => typeof(H).AssemblyQualifiedName;
    }
}