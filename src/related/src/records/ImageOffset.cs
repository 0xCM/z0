//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct ImageOffset : IRecord<ImageOffset>
        {
            public const string TableId = "image.offsets";

            public string Name;

            public ulong Value;
        }
    }
}