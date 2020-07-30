//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;
    
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct IClrDataModuleVTable
    {
        public readonly IntPtr StartEnumAssemblies;

        public readonly IntPtr EnumAssembly;

        public readonly IntPtr EndEnumAssemblies;

        public readonly IntPtr StartEnumTypeDefinitions;

        public readonly IntPtr EnumTypeDefinition;

        public readonly IntPtr EndEnumTypeDefinitions;

        public readonly IntPtr StartEnumTypeInstances;

        public readonly IntPtr EnumTypeInstance;

        public readonly IntPtr EndEnumTypeInstances;

        public readonly IntPtr StartEnumTypeDefinitionsByName;

        public readonly IntPtr EnumTypeDefinitionByName;

        public readonly IntPtr EndEnumTypeDefinitionsByName;

        public readonly IntPtr StartEnumTypeInstancesByName;

        public readonly IntPtr EnumTypeInstanceByName;

        public readonly IntPtr EndEnumTypeInstancesByName;

        public readonly IntPtr GetTypeDefinitionByToken;

        public readonly IntPtr StartEnumMethodDefinitionsByName;

        public readonly IntPtr EnumMethodDefinitionByName;

        public readonly IntPtr EndEnumMethodDefinitionsByName;

        public readonly IntPtr StartEnumMethodInstancesByName;

        public readonly IntPtr EnumMethodInstanceByName;

        public readonly IntPtr EndEnumMethodInstancesByName;

        public readonly IntPtr GetMethodDefinitionByToken;

        public readonly IntPtr StartEnumDataByName;

        public readonly IntPtr EnumDataByName;

        public readonly IntPtr EndEnumDataByName;

        public readonly IntPtr GetName;

        public readonly IntPtr GetFileName;

        public readonly IntPtr GetFlags;

        public readonly IntPtr IsSameObject;

        public readonly IntPtr StartEnumExtents;

        public readonly IntPtr EnumExtent;

        public readonly IntPtr EndEnumExtents;

        public readonly IntPtr Request;

        public readonly IntPtr StartEnumAppDomains;

        public readonly IntPtr EnumAppDomain;

        public readonly IntPtr EndEnumAppDomains;

        public readonly IntPtr GetVersionId;
    }    
}