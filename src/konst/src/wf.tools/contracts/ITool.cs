//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITool
    {
        ToolId Id {get;}
    }

    [Free]
    public interface ITool<T> : ITool
        where T : struct, ITool<T>
    {

    }
}