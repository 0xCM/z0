//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using K = Z0.Image.MetadataHandleKind;

    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public readonly struct EventDefinitionHandle
    {
        public MetadataHandleKind Kind => K.EventDefinition;
    }
}