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
    public interface IToolCmd<C> : IToolCmd, ICmdSpec<C>
        where C : struct, IToolCmd<C>
    {
        ToolId ICmdSpec.ToolId
            => Tooling.toolid<C>();
    }

    [Free]
    public interface IToolCmd<C,T> : IToolCmd<C>, ICmdSpec<C>
        where C : struct, IToolCmd<C>
        where T : struct, ITool<T>
    {
        ToolId ICmdSpec.ToolId
            => default(T).Id;
    }
}