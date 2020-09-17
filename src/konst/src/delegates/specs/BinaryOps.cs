//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryOp1(bit a, bit b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell8 BinaryOp8(Cell8 a, Cell8 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell32 BinaryOp32(Cell32 a, Cell32 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell16 BinaryOp16(Cell16 a, Cell16 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell64 BinaryOp64(Cell64 a, Cell64 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell128 BinaryOp128(Cell128 a, Cell128 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell256 BinaryOp256(Cell256 a, Cell256 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell512 BinaryOp512(Cell512 a, Cell512 b);
}