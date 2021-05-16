//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct CliRows
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldPtrRow : ICliRecord<FieldPtrRow>
        {
        }
    }
}