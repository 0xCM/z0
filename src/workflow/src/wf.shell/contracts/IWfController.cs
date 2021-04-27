//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfController
    {
        Assembly Component {get;}
    }

    [Free]
    public interface IWfController<P> : IWfController
        where P : IPart<P>, new()
    {

    }
}