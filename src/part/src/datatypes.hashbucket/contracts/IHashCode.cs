//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IHashCode
    {
        ReadOnlySpan<byte> Data {get;}
    }

    [Free]
    public interface IHashCode<T> : IHashCode
        where T : unmanaged
     {
         T Value {get;}

        ReadOnlySpan<byte> IHashCode.Data
            => memory.bytes(Value);
         BitSize Width
            => memory.bitsize<T>();
     }

    [Free]
    public interface IHashCode<T,U> : IHashCode<T>
        where T : unmanaged
        where U : unmanaged
    {
        U Primitive {get;}
    }
}