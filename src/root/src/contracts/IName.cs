//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IName : IText
    {
        string ITextual.Format()
            => Text;
    }

    [Free]
    public interface IName<S> : IName, IContented<S>, ITypedIdentity<S>
    {
        S ITypedIdentity<S>.Id
            => Content;
    }
}