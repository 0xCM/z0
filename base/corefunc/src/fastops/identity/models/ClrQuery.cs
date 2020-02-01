//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    
    using static zfunc;

    public readonly struct ClrQuery
    {
        public readonly string Name;
    }

    public readonly struct ClrTypeQuery<T>
    {
        public readonly string Name;
    }

    public readonly struct ClrTypeQuery<N,T>
        where N : unmanaged, ITypeNat
    {
        public readonly string Name;
    }

    public readonly struct ClrMethodQuery<T>
    {
        public readonly string MethodName;
    }

    public readonly struct ClrMethodQuery<N,T>
        where N : unmanaged, ITypeNat
    {
        public readonly string MethodName;
    }

}