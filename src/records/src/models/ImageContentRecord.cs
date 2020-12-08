//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Table(TableId)]
    public struct ImageContentRecord : IRecord<ImageContentRecord>
    {
        public const string TableId = "image.content";

        public const byte RowDataSize = 32;

        public ImageToken Source;

        public BinaryCode Data;
    }
}