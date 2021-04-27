//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    [Record(CliTableKind.ImportScope), StructLayout(LayoutKind.Sequential)]
    public struct ImportScopeRow
    {
        public RowKey Parent;

        public BlobIndex Imports;
    }
}