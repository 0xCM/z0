// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Z0.Schemas.Ecma
{
    using System;

    [Flags]
    public enum MethodAttributes : ushort
    {
        //
        // Summary:
        //     Indicates that the member cannot be referenced.
        PrivateScope = 0x0,
        //
        // Summary:
        //     Indicates that the method will reuse an existing slot in the vtable. This is
        //     the default behavior.
        ReuseSlot = 0x0,
        //
        // Summary:
        //     Indicates that the method is accessible only to the current class.
        Private = 0x1,
        //
        // Summary:
        //     Indicates that the method is accessible to members of this type and its derived
        //     types that are in this assembly only.
        FamANDAssem = 0x2,
        //
        // Summary:
        //     Indicates that the method is accessible to any class of this assembly.
        Assembly = 0x3,
        //
        // Summary:
        //     Indicates that the method is accessible only to members of this class and its
        //     derived classes.
        Family = 0x4,
        //
        // Summary:
        //     Indicates that the method is accessible to derived classes anywhere, as well
        //     as to any class in the assembly.
        FamORAssem = 0x5,
        //
        // Summary:
        //     Indicates that the method is accessible to any object for which this object is
        //     in scope.
        Public = 0x6,
        //
        // Summary:
        //     Retrieves accessibility information.
        MemberAccessMask = 0x7,
        //
        // Summary:
        //     Indicates that the managed method is exported by thunk to unmanaged code.
        UnmanagedExport = 0x8,
        //
        // Summary:
        //     Indicates that the method is defined on the type; otherwise, it is defined per
        //     instance.
        Static = 0x10,
        //
        // Summary:
        //     Indicates that the method cannot be overridden.
        Final = 0x20,
        //
        // Summary:
        //     Indicates that the method is virtual.
        Virtual = 0x40,
        //
        // Summary:
        //     Indicates that the method hides by name and signature; otherwise, by name only.
        HideBySig = 0x80,
        //
        // Summary:
        //     Indicates that the method always gets a new slot in the vtable.
        NewSlot = 0x100,
        //
        // Summary:
        //     Retrieves vtable attributes.
        VtableLayoutMask = 0x100,
        //
        // Summary:
        //     Indicates that the method can only be overridden when it is also accessible.
        CheckAccessOnOverride = 0x200,
        //
        // Summary:
        //     Indicates that the class does not provide an implementation of this method.
        Abstract = 0x400,
        //
        // Summary:
        //     Indicates that the method is special. The name describes how this method is special.
        SpecialName = 0x800,
        //
        // Summary:
        //     Indicates that the common language runtime checks the name encoding.
        RTSpecialName = 0x1000,
        //
        // Summary:
        //     Indicates that the method implementation is forwarded through PInvoke (Platform
        //     Invocation Services).
        PinvokeImpl = 0x2000,
        //
        // Summary:
        //     Indicates that the method has security associated with it. Reserved flag for
        //     runtime use only.
        HasSecurity = 0x4000,
        //
        // Summary:
        //     Indicates that the method calls another method containing security code. Reserved
        //     flag for runtime use only.
        RequireSecObject = 0x8000,
        //
        // Summary:
        //     Indicates a reserved flag for runtime use only.
        ReservedMask = 0xD000
    }
}