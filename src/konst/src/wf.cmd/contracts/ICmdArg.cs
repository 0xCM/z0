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
        string Key {get;}

        object Value {get;}

        string ITextual.Format()
            => Render.setting(Key,Value);
    }

    [Free]
    public interface ICmdArg<T> : ICmdArg
    {
        new T Value {get;}

        object ICmdArg.Value
            => Value;
    }

    [Free]
    public interface ICmdArg<K,T> : ICmdArg<T>
    {
        new K Key {get;}
        string ICmdArg.Key
            => Key.ToString();
    }
}