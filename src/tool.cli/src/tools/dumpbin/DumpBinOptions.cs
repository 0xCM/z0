//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct DumpBinOptions
    {
        public enum Bytes : byte
        {
            BYTES = 0,

            NOBYTES = 1
        }

        public enum ErrorReport : byte
        {
            NONE = 0,

            PROMPT = 1,

            QUEUE = 2,

            SEND = 3
        }

        public enum SegSize : byte
        {
            NONE = 0,

            D1 = 1,

            D2 = 2,

            D4 = 4,

            D8 = 8
        }

        public struct VaRange
        {
            public ulong vaMin;

            public ulong? vaMax;
        }
    }
}