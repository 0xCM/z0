//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRef
    {
        dynamic Target();

        T Target<T>()
            => (T)Target();
    }

    [Free]
    public interface IRef<T> : IRef
    {
        new T Target();

        dynamic IRef.Target()
            => Target();
    }
}