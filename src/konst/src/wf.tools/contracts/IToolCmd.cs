//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolCmd : ICmdSpec
    {

    }

    [Free]
    public interface IToolCmd<T> : IToolCmd, ICmdSpec<T>
        where T : struct, IToolCmd<T>
    {
        ToolId ICmdSpec.ToolId
            => Tooling.toolid<T>();
    }
}