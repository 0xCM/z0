//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public interface ITypeIdentity : IIdentity
    {

    }
    
    public interface ITypeIdentity<T> : ITypeIdentity, IIdentity<T>
        where T : struct, ITypeIdentity<T>    
    {

    }
}