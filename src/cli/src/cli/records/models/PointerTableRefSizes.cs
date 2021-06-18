//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct PointerTableRefSizes
    {
        public const string TableId = "clisize.pointer-ref";

        public uint FieldRefSize;

        public uint MethodRefSize;

        public uint ParamRefSize;

        public uint EventRefSize;

        public uint PropertyRefSize;
    }
}