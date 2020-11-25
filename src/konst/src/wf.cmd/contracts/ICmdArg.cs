//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdArg : ITextual
    {
        string Prefix {get;}

        string Name {get;}

        string Specifier {get;}

        string Value {get;}

        string ITextual.Format()
            => Render.setting(Name,Value);
    }

    [Free]
    public interface ICmdArg<T> : ICmdArg
    {
        new T Value {get;}

        string ICmdArg.Value
            => Value?.ToString() ?? string.Empty;
    }

    [Free]
    public interface ICmdArg<K,T> : ICmdArg<T>
        where K : unmanaged
    {
        // new K Key {get;}

        // string ICmdArg.Key
        //     => Key.ToString();
    }
}