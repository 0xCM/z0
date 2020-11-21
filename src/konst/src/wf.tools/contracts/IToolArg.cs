//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IToolArg<V>
    {
        ushort Position {get;}

        CmdArgProtocol Protocol {get;}

        CmdOption Option {get;}

        V Value {get;}
    }

    public interface IToolArg : IToolArg<string>
    {

    }

    [Free]
    public interface IToolArg<K,V> : IToolArg<V>
        where K : unmanaged
    {
        new CmdOption<K> Option {get;}

        CmdOption IToolArg<V>.Option
            => Option;
    }
}