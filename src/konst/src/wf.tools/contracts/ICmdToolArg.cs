//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdToolArg<V>
    {
        ushort Position {get;}

        CmdOptionSpec Option {get;}

        V Value {get;}
    }

    [Free]
    public interface ICmdToolArg : ICmdToolArg<string>
    {

    }

    [Free]
    public interface ICmdToolArg<K,V> : ICmdToolArg<V>
        where K : unmanaged
    {
        new CmdOptionSpec<K> Option {get;}

        CmdOptionSpec ICmdToolArg<V>.Option
            => Option;
    }
}