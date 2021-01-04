// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0.Schemas.Ecma
{
    using System;

    [Flags]
    public enum MethodSemanticsAttributes : ushort
    {
        //
        // Summary:
        //     Used to modify the value of the property.
        //     CLS-compliant setters are named with the set_ prefix.
        Setter = 0x1,
        //
        // Summary:
        //     Reads the value of the property.
        //     CLS-compliant getters are named with get_ prefix.
        Getter = 0x2,
        //
        // Summary:
        //     Other method for a property (not a getter or setter) or an event (not an adder,
        //     remover, or raiser).
        Other = 0x4,
        //
        // Summary:
        //     Used to add a handler for an event. Corresponds to the AddOn flag in the Ecma
        //     335 CLI specification.
        //     CLS-compliant adders are named the with add_ prefix.
        Adder = 0x8,
        //
        // Summary:
        //     Used to remove a handler for an event. Corresponds to the RemoveOn flag in the
        //     Ecma 335 CLI specification.
        //     CLS-compliant removers are named with the remove_ prefix.
        Remover = 0x10,
        //
        // Summary:
        //     Used to indicate that an event has occurred. Corresponds to the Fire flag in
        //     the Ecma 335 CLI specification.
        //     CLS-compliant raisers are named with the raise_ prefix.
        Raiser = 0x20

    }
}