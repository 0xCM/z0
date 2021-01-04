// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Z0.Schemas.Ecma
{
    //
    // Summary:
    //     Specifies the security actions that can be performed using declarative security.
    public enum DeclarativeSecurityAction : short
    {
        //
        // Summary:
        //     No declarative security action.
        None = 0,
        //
        // Summary:
        //     Check that all callers in the call chain have been granted the specified permission.
        Demand = 2,
        //
        // Summary:
        //     The calling code can access the resource identified by the current permission
        //     object, even if callers higher in the stack have not been granted permission
        //     to access the resource.
        Assert = 3,
        //
        // Summary:
        //     Without further checks refuse Demand for the specified permission.
        Deny = 4,
        //
        // Summary:
        //     Without further checks, refuse the demand for all permissions other than those
        //     specified.
        PermitOnly = 5,
        //
        // Summary:
        //     Check that the immediate caller has been granted the specified permission.
        LinkDemand = 6,
        //
        // Summary:
        //     The derived class inheriting the class or overriding a method is required to
        //     have the specified permission.
        InheritanceDemand = 7,
        //
        // Summary:
        //     Request the minimum permissions required for code to run. This action can only
        //     be used within the scope of the assembly.
        RequestMinimum = 8,
        //
        // Summary:
        //     Request additional permissions that are optional (not required to run). This
        //     request implicitly refuses all other permissions not specifically requested.
        //     This action can only be used within the scope of the assembly.
        RequestOptional = 9,
        //
        // Summary:
        //     Request that permissions that might be misused not be granted to the calling
        //     code. This action can only be used within the scope of the assembly.
        RequestRefuse = 10
    }
}