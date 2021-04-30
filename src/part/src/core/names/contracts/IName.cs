//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IName : IIdentified, IText
    {
        string ITextual.Format()
            => IdentityText;
    }

    [Free]
    public interface IName<S> : IName, IContented<S>, ITypedIdentity<S>
    {
        string IIdentified.IdentityText
            => string.Format("{0}", Content);

        S ITypedIdentity<S>.Id
            => Content;
    }
}