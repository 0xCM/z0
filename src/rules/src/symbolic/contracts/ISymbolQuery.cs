//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISymbolQuery<S>
        where S : unmanaged
    {
        bit Test(S s);
    }

    public interface ISymbolQuery<H,S> : ISymbolQuery<S>, IKeyed<string>
        where H : struct, ISymbolQuery<H,S>
        where S : unmanaged
    {
        string IKeyed<string>.Key
            => typeof(H).AssemblyQualifiedName;
    }
}