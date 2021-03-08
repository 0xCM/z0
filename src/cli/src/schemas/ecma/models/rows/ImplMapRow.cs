//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct ImplMapRow
    {
        public RowKey Key;

        public PInvokeAttributes MappingFlags;

        public int MemberForwarded;

        public FK<StringIndex> ImportName;

        public int ImportScope;
    }
}