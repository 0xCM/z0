//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolArg<V>
    {
        ushort Position {get;}

        CmdOptionSpec Option {get;}

        V Value {get;}
    }

    [Free]
    public interface IToolArg : IToolArg<string>
    {

    }

    [Free]
    public interface IToolArg<K,V> : IToolArg<V>
        where K : unmanaged
    {
        new CmdOptionSpec<K> Option {get;}

        CmdOptionSpec IToolArg<V>.Option
            => Option;
    }
}