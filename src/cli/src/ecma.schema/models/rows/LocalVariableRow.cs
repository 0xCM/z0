//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LocalVariableRow : IRecord<LocalVariableRow>
    {
        public RowKey Key;

        public ushort Attributes;

        public ushort Index;

        public FK<string> Name;
    }
}