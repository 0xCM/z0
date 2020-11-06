//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IJsonProvider
    {
        JsonText ToJson(object src);
    }

    [Free]
    public interface IJsonProvider<T> : IJsonProvider
    {
        JsonText ToJson(in T src);

        JsonText IJsonProvider.ToJson(object src)
            => ToJson((T)src);
    }

    [Free]
    public interface IJsonProvider<H,T> : IJsonProvider<T>
        where H : struct, IJsonProvider<H,T>
    {

    }
}