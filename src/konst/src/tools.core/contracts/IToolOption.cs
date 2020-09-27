//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IToolOption<F>
        where F : unmanaged
    {
        F Flag {get;}

        string Value {get;}
    }

    public interface IToolOption<F,K> : IToolOption<F>
        where F : unmanaged, Enum
        where K : unmanaged, Enum
    {
        new K Value {get;}

        string IToolOption<F>.Value
            => Value.ToString();
    }
}