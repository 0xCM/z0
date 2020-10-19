//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;
        
    [SuppressUnmanagedCodeSecurity]
    public interface IDataEntity<T> : ITextual, INullary<T>, IEquatable<T>
        where T : struct
    {
        
    }
}