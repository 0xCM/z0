//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;
    

    using Z0.Image;

    using static Konst;
    using static z;
    using static MdR;

    using K = Z0.Image.HandleKind;
    
        // public readonly struct EventDefinition
        // {
        //     public readonly int RowId;

        //     public readonly EventDefinitionHandle Token;

        //     public readonly StringHandle Name;

        //     public readonly EventAttributes Attributes;

        //     public readonly System.Reflection.Metadata.EntityHandle Type;

        //     public readonly CustomAttributeHandleCollection CustomAttributes;        
        // }

    partial struct MdR
    {                
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
        
        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct StringHandle
        {
            public HandleKind Kind => K.String;
        }                 
    }
}