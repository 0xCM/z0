//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct CliRecords
    {
        public enum StringHeapKind : byte
        {
            None = 0,

            Default = 0x78,

            String1 = 0x79,

            String2 = 0x7a,

            String3 = 0x7b,

            Namespace = 0x7c,
        }
    }
}