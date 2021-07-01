//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct XedFormAspect : IRecord<XedFormAspect>
    {
        public const string TableId = "xed.aspects";

        public uint Index;

        public string Value;

        public Hash32 Hash;
    }
}