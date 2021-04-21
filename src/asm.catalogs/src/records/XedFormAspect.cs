//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct AsmCatalogRecords
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct XedFormAspect : IRecord<XedFormAspect>
        {
            public const string TableId = "xed.aspects";

            public uint Index;

            public string Value;

            public Hash32 Hash;
        }
    }
}