//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct MethodDebugInformationRow
    {
        public RowKey Key;

        public int Document;

        public FK<bytes> SequencePoints;
    }
}