//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRefSource
    {
        ref readonly T Next<T>()
            where T : struct;
    }

    [Free]
    public interface IRefSource<T> : ISource<T>
        where T : struct
    {
        new ref readonly T Next();

        T ISource<T>.Next()
            => Next();
    }
}