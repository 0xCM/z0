//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct CliOffset : IRecord<CliOffset>
    {
        public const string TableId = "cli.offsets";

        public string Name;

        public ulong Value;

        [MethodImpl(Inline)]
        public CliOffset(string name, ulong address)
        {
            Name = name;
            Value  = address;
        }
    }
}