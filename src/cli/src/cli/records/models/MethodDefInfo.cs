//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct MethodDefInfo : IRecord<MethodDefInfo>
    {
        public const string TableId = "image.methods";

        public string Component;

        public CliToken Token;

        public string Name;

        public Address32 Rva;

        public CliSig CliSig;

        public MethodImplAttributes ImplAttributes;

        public MethodAttributes Attributes;
    }
}