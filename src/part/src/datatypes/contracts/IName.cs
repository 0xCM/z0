//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IName : ITextual, IIdentified
    {
        string ITextual.Format()
            => Identifier;
    }

    [Free]
    public interface IName<S> : IName, IContented<S>, ITypedIdentity<S>
    {
        string IIdentified.Identifier
            => string.Format("{0}", Content);

        S ITypedIdentity<S>.Id
            => Content;
    }
}