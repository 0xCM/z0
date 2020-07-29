//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
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
    
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public readonly struct EventDefinitionHandle
    {
        public HandleKind Kind => K.EventDefinition;
    }

    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public readonly struct MethodDefinitionHandle
    {
        public HandleKind Kind => K.MethodDefinition;
    }
    
    // [StructLayout(LayoutKind.Sequential, Size = 4)]
    // public readonly struct StringHandle
    // {
    //     public HandleKind Kind => K.String;
    // }                 
}