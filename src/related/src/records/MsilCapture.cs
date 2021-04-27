//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct MsilCapture : IRecord<MsilCapture>
        {
            public const string TableId = "cil.data";

            public const byte FieldCount = 4;

            public CliToken Token;

            public MemoryAddress BaseAddress;

            public OpUri Uri;

            public BinaryCode Encoded;
        }
    }
}