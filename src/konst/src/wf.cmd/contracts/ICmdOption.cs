//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdOption : ITextual
    {
        string Name {get;}

        string Value {get;}

        string ITextual.Format()
            => Render.setting(Name,Value);
    }

    [Free]
    public interface ICmdOption<T> : ICmdOption
    {
        new T Value {get;}

        string ICmdOption.Value
            => Value.ToString();
    }

    [Free]
    public interface ICmdOption<K,T> : ICmdOption<T>
    {
        K Kind {get;}

        string ICmdOption.Name
            => Kind.ToString();
    }
}