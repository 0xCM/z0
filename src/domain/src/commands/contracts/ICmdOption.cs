//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface ICmdOption : ITextual
    {
        asci32 Name {get;}

        string Value {get;}

        string ITextual.Format()
            => Render.setting(Name,Value);
    }

    public interface ICmdOption<T> : ICmdOption
    {
        new T Value {get;}

        string ICmdOption.Value => Value.ToString();
    }

    public interface ICmdOption<K,T> : ICmdOption<T>
        where K : unmanaged, Enum
    {
        K Kind {get;}

        asci32 ICmdOption.Name
            => Kind.ToString().ToLower();
    }
}