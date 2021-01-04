//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct MethodImplRow
    {
        public RowKey Key;

        public token Class;

        public token MethodBody;

        public token MethodDecl;
    }
}