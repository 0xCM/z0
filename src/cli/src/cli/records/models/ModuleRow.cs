//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.Module), StructLayout(LayoutKind.Sequential)]
        public struct ModuleRow : ICliRecord<ModuleRow>
        {
            public ushort Generation;

            public CliStringIndex Name;

            public GuidIndex ModuleVersionId;

            public GuidIndex EncId;

            public GuidIndex EncBaseId;
        }
    }
}