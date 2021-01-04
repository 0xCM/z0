//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct ImplMapRow
    {
        public RowKey Key;

        public PInvokeAttributes MappingFlags;

        public int MemberForwarded;

        public FK<name> ImportName;

        public int ImportScope;
    }
}