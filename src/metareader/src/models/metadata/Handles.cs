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

    using Z0.Image;

    using static Konst;
    using static z;

    using K = Z0.Image.HandleKind;
    
    partial struct MdR
    {                
        public interface IMetadataHandle
        {

            HandleKind Kind {get;}
        }    

        public interface IMetadataHandle<T> : IMetadataHandle
        {

        }    

        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct MetadataHandle<T>
        {

        }
        
        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct MetadataHandle
        {
            
        }

        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct MethodDefinitionHandle
        {
            public HandleKind Kind => K.MethodDefinition;
        }
        
        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct EventDefinitionHandle
        {
            public HandleKind Kind => K.EventDefinition;
        }

        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct LocalVariableHandle
        {
            public HandleKind Kind => K.LocalVariable;
        }        

        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct StringHandle
        {
            public HandleKind Kind => K.String;
        }                 
    }
}