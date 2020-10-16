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

    public interface ICmdOptionData<H> : ICmdOption
        where H : struct,  ICmdOptionData<H>
    {

    }

    public interface ICmdOptionData<H,T> : ICmdOption<T>
        where H : struct,  ICmdOptionData<H,T>
    {

    }

    public interface ICmdOptionData<H,K,T> : ICmdOptionData<H,T>
        where H : struct,  ICmdOptionData<H,K,T>
    {

    }
}