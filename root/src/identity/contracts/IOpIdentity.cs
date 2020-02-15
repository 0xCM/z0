//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static RootShare;

    public interface IOpIdentity : IIdentity
    {

    }
    
    public interface IOpIdentity<T> : IOpIdentity, IIdentity<T>
        where T : struct, IOpIdentity<T>    
    {

    }    
}