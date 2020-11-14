//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IScriptSpec
    {

    }

    [Free]
    public interface IScriptSpec<T> : IScriptSpec
        where T : struct, IScriptSpec<T>
    {

    }
}