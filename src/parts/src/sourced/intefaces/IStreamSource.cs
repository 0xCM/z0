//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IStreamSource<T> : ISource<IEnumerable<T>>
    {
     
    }
}