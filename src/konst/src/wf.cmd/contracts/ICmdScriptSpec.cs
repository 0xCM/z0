//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdScriptSpec
    {

    }

    [Free]
    public interface ICmdScriptSpec<T> : ICmdScriptSpec
        where T : struct, ICmdScriptSpec<T>
    {

    }
}