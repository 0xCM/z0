//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static z;
    using static Konst;

    public interface IApiTypeSig : IApiSig
    {

    }


    public interface IApiTypeSig<T> : IApiTypeSig
    {

    }

}