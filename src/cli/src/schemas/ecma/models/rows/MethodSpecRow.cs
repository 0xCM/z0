//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct MethodSpecRow : IRecord<MethodSpecRow>
    {
        public RowKey Key;

        public token Method;

        public FK<bytes> Instantiation;
    }
}