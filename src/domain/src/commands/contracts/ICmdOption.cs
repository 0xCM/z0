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
        asci32 Id {get;}

        string Value {get;}

        string ITextual.Format()
            => Render.setting(Id,Value);
    }

    public interface ICmdOption<T> : ICmdOption
    {
        new T Value {get;}

        string ICmdOption.Value
            => Value.ToString();
    }

    public interface ICmdOption<K,T> : ICmdOption<T>
        where K : unmanaged, Enum
    {
        new K Id {get;}

        asci32 ICmdOption.Id
            => Id.ToString().ToLower();
    }
}