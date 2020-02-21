//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IApiHostIdentity : IIdentity
    {

    }
    
    public interface IApiHostIdentity<T> : IApiHostIdentity, IIdentity<T>
        where T : struct, IApiHostIdentity<T>    
    {

    }
}