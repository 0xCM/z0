//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    using static Relations;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct ExportedTypeRow  : IRecord<ExportedTypeRow>
    {
        public RowKey Key;

        public uint Flags;

        public Token TypeDefId;

        public FK<StringIndex> TypeName;

        public FK<StringIndex> TypeNamespace;

        public int Implementation;
    }
}