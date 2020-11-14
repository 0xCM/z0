//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolScript : ITextual
    {
        ToolId ToolId {get;}
    }

    [Free]
    public interface IToolScript<T> : IToolScript
        where T : struct, IToolScript
    {

    }

    [Free]
    public interface IToolScript<H,T> : IToolScript<T>, IContented<T>
        where H : struct, IToolScript<H,T>
        where T : struct, IToolScript
    {

    }
}