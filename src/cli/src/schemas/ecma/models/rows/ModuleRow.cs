//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    using static Relations;

    [StructLayout(LayoutKind.Sequential)]
    public struct ModuleRow : IRecord<ModuleRow>
    {
        public RowKey Key;

        public ushort Generation;

        public FK<StringIndex> Name;

        public FK<GuidIndex> ModuleVersionId;

        public FK<GuidIndex> EncId;

        public FK<GuidIndex> EncBaseId;
    }
}