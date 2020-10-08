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
    public interface IName<S> : IName, IContented<S>, IIdentified<S>
    {
        string IIdentified.Identifier
            => string.Format("{0}", Content);

        S IIdentified<S>.Id
            => Content;
    }

    [Free]
    public interface INameHost<H,S> : IName<S>
        where H : struct, INameHost<H,S>
    {

    }
}