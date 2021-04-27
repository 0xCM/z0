//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ModuleRow : IRecord<ModuleRow>
    {
        public ushort Generation;

        public StringIndex Name;

        public GuidIndex ModuleVersionId;

        public GuidIndex EncId;

        public GuidIndex EncBaseId;
    }
}