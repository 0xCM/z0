//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;
    
    using Z0.Image;

    using K = Z0.Image.HandleKind;

    [Table, StructLayout(LayoutKind.Sequential, Size = 4)]
    public readonly struct MethodDefinitionHandle
    {
        public HandleKind Kind => K.MethodDefinition;
    }    
}