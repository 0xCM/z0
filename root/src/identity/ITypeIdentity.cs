//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ITypeIdentity : IIdentity
    {

    }
    
    public interface ITypeIdentity<T> : ITypeIdentity, IIdentity<T>
        where T : ITypeIdentity<T>, new()    
    {

    }
}