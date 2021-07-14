//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [Free]
    public interface ICmdLineTool<T,C> : ITool<T>
        where T : ITool<T>, new()
        where C : IToolCmd
    {
        CmdLine CmdLine(in C src);
    }
}