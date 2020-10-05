//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCodeBlockInfo
    {
        public const string FormatPattern = "{0,-12} | {1,-32} | {2,-16} | {3,-10} | {4}";

        public ApiPartKind Part;

        public Name Host;

        public MemoryAddress Base;

        public ByteSize Size;

        public ApiUri<string> Uri;
    }
}