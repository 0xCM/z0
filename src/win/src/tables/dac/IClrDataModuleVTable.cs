//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;
    
    [Table, StructLayout(LayoutKind.Sequential)]
    public struct IClrDataModuleVTable
    {
        public IntPtr StartEnumAssemblies;

        public IntPtr EnumAssembly;

        public IntPtr EndEnumAssemblies;

        public IntPtr StartEnumTypeDefinitions;

        public IntPtr EnumTypeDefinition;

        public IntPtr EndEnumTypeDefinitions;

        public IntPtr StartEnumTypeInstances;

        public IntPtr EnumTypeInstance;

        public IntPtr EndEnumTypeInstances;

        public IntPtr StartEnumTypeDefinitionsByName;

        public IntPtr EnumTypeDefinitionByName;

        public IntPtr EndEnumTypeDefinitionsByName;

        public IntPtr StartEnumTypeInstancesByName;

        public IntPtr EnumTypeInstanceByName;

        public IntPtr EndEnumTypeInstancesByName;

        public IntPtr GetTypeDefinitionByToken;

        public IntPtr StartEnumMethodDefinitionsByName;

        public IntPtr EnumMethodDefinitionByName;

        public IntPtr EndEnumMethodDefinitionsByName;

        public IntPtr StartEnumMethodInstancesByName;

        public IntPtr EnumMethodInstanceByName;

        public IntPtr EndEnumMethodInstancesByName;

        public IntPtr GetMethodDefinitionByToken;

        public IntPtr StartEnumDataByName;

        public IntPtr EnumDataByName;

        public IntPtr EndEnumDataByName;

        public IntPtr GetName;

        public IntPtr GetFileName;

        public IntPtr GetFlags;

        public IntPtr IsSameObject;

        public IntPtr StartEnumExtents;

        public IntPtr EnumExtent;

        public IntPtr EndEnumExtents;

        public IntPtr Request;

        public IntPtr StartEnumAppDomains;

        public IntPtr EnumAppDomain;

        public IntPtr EndEnumAppDomains;

        public IntPtr GetVersionId;
    }    
}