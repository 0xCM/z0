//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public delegate F FixedUnaryOp<F>(F a)
        where F : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate F FixedBinaryOp<F>(F a, F b)
        where F : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate F FixedTernaryOp<F>(F a, F b, F c)
        where F : IFixed;
    
    [SuppressUnmanagedCodeSecurity]
    public delegate bit FixedUnaryPred<F>(F a)
        where F : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit FixedBinaryPred<F>(F a, F b)
        where F : IFixed;        

    [SuppressUnmanagedCodeSecurity]
    public delegate bit FixedTernaryPred<F>(F a, F b, F c)
        where F : IFixed;        
}