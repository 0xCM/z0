//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;

    public readonly partial struct Types
    {
        const LayoutKind Layout = LayoutKind.Sequential;

        const NumericKind Closure = NumericKind.UnsignedInts;
    }
}