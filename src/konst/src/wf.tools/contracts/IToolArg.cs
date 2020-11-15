//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IToolArg<V>
    {
        ToolOption Option {get;}

        V Value {get;}
    }

    public interface IToolArg : IToolArg<string>
    {

    }

    [Free]
    public interface IToolArg<K,V> : IToolArg<V>
        where K : unmanaged
    {
        new ToolOption<K> Option {get;}

        ToolOption IToolArg<V>.Option
            => Option;
    }
}