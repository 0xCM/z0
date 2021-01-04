//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ModuleRow : IRecord<ModuleRow>
    {
        public RowKey Key;

        public ushort Generation;

        public FK<name> Name;

        public FK<Guid> ModuleVersionId;

        public FK<Guid> EncId;

        public FK<Guid> EncBaseId;
    }
}