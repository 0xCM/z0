//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct FieldDefInfo : IRecord<FieldDefInfo>
    {
        public const string TableId = "image.fields";

        public string Component;

        public CliToken Token;

        public string Name;

        public uint Offset;

        public CliSig CliSig;

        public FieldAttributes Attributes;
    }
}