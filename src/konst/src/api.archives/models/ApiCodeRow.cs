//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCodeRow
    {
        public MemoryAddress Base;

        public string Uri;

        public BinaryCode Encoded;
    }

    public struct ApiCodeRow<K,T>
        where T : struct
    {


    }
}