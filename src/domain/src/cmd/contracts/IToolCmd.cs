//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IToolCmd : ICmdSpec
    {
        ToolId ToolId {get;}
    }

    [Free]
    public interface IToolCmd<T> : IToolCmd, ICmdSpec<T>
        where T : struct, IToolCmd<T>
    {
        ToolId IToolCmd.ToolId
            => ToolCmd.toolid<T>();

        CmdId ICmdSpec.CmdId
            => ToolCmd.cmdid<T>();
    }

    [Free]
    public interface IToolCmd<K,C> : IToolCmd<C>, ICmdSpec<K,C>
        where C : struct, IToolCmd<K,C>
        where K : unmanaged
    {

    }
}