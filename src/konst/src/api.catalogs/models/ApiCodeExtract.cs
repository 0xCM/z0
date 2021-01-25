//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [Record(TableId)]
    public struct ApiCodeExtract : IRecord<ApiCodeExtract>
    {
        public const string TableId = "extract";

        public MemoryAddress Base;

        public string Uri;

        public BinaryCode Encoded;
    }
}