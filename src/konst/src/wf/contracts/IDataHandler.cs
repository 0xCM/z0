//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataHandler
    {

    }

    [Free]
    public interface IDataHandler<T> : IDataHandler
    {
        void Handle(T data);
    }

    [Free]
    public interface IDataHandler<C,T> : IDataHandler
    {
        void Handle(C context, T data);
    }
}