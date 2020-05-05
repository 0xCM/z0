//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IDynamicNumeric : IService
    {
        UnaryOp<T> EmitUnaryOp<T>(IBufferToken dst, UriHex src)
            where T : unmanaged;

        BinaryOp<T> EmitBinaryOp<T>(IBufferToken dst, UriHex src)
            where T : unmanaged;            

        TernaryOp<T> EmitTernaryOp<T>(IBufferToken dst, UriHex src)
            where T : unmanaged;            
    }
}