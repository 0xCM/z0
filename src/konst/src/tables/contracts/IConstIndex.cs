// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
        
    [SuppressUnmanagedCodeSecurity]
    public interface IConstIndex<T> : IMeasured
    {
        ref readonly T this[int index] {get;}  

        ref readonly T Lookup(int index) 
            => ref this[index];    
    }
}