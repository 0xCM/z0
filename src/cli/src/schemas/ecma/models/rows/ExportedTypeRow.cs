//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct ExportedTypeRow  : IRecord<ExportedTypeRow>
    {
        public RowKey Key;

        public uint Flags;

        public Token TypeDefId;

        public FK<name> TypeName;

        public FK<name> TypeNamespace;

        public int Implementation;
    }
}