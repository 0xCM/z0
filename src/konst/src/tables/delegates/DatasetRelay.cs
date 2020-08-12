//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate void DatasetRelay<S,R>(in R src, IDatasetFormatter<S> dst)
        where S : unmanaged, Enum
        where R : struct;
}