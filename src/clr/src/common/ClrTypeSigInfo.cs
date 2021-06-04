//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// A succinct type signature
    /// </summary>
    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct ClrTypeSigInfo : IRecord<ClrTypeSigInfo>
    {
        public const string TableId = "clr.typesigs";

        public string DisplayName;

        public string Modifier;

        public bool IsOpenGeneric;

        public bool IsClosedGeneric;

        public bool IsByRef;

        public bool IsIn;

        public bool IsOut;

        public bool IsPointer;

        public bool IsArray;

        public string Format()
            => $"{Modifier}{DisplayName}";

        public override string ToString()
            => Format();
    }
}