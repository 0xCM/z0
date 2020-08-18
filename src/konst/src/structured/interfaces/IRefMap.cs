//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IRefMap<S,T>
    {
        void Map(in S src, ref T dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IRefMap<H,S,T> : IRefMap<S,T>
        where H : struct, IRefMap<H,S,T>
    {

    }
}