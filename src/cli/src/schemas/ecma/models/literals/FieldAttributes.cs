namespace Z0.Schemas.Ecma
{
    public enum FieldAttributes : ushort
    {
        //
        // Summary:
        //     Specifies that the field cannot be referenced.
        PrivateScope = 0x0,
        //
        // Summary:
        //     Specifies that the field is accessible only by the parent type.
        Private = 0x1,
        //
        // Summary:
        //     Specifies that the field is accessible only by subtypes in this assembly.
        FamANDAssem = 0x2,
        //
        // Summary:
        //     Specifies that the field is accessible throughout the assembly.
        Assembly = 0x3,
        //
        // Summary:
        //     Specifies that the field is accessible only by type and subtypes.
        Family = 0x4,
        //
        // Summary:
        //     Specifies that the field is accessible by subtypes anywhere, as well as throughout
        //     this assembly.
        FamORAssem = 0x5,
        //
        // Summary:
        //     Specifies that the field is accessible by any member for whom this scope is visible.
        Public = 0x6,
        //
        // Summary:
        //     Specifies the access level of a given field.
        FieldAccessMask = 0x7,
        //
        // Summary:
        //     Specifies that the field represents the defined type, or else it is per-instance.
        Static = 0x10,
        //
        // Summary:
        //     Specifies that the field is initialized only, and can be set only in the body
        //     of a constructor.
        InitOnly = 0x20,
        //
        // Summary:
        //     Specifies that the field's value is a compile-time (static or early bound) constant.
        //     Any attempt to set it throws a System.FieldAccessException.
        Literal = 0x40,
        //
        // Summary:
        //     Specifies that the field does not have to be serialized when the type is remoted.
        NotSerialized = 0x80,
        //
        // Summary:
        //     Specifies that the field has a relative virtual address (RVA). The RVA is the
        //     location of the method body in the current image, as an address relative to the
        //     start of the image file in which it is located.
        HasFieldRVA = 0x100,
        //
        // Summary:
        //     Specifies a special method, with the name describing how the method is special.
        SpecialName = 0x200,
        //
        // Summary:
        //     Specifies that the common language runtime (metadata internal APIs) should check
        //     the name encoding.
        RTSpecialName = 0x400,
        //
        // Summary:
        //     Specifies that the field has marshaling information.
        HasFieldMarshal = 0x1000,
        //
        // Summary:
        //     Reserved for future use.
        PinvokeImpl = 0x2000,
        //
        // Summary:
        //     Specifies that the field has a default value.
        HasDefault = 0x8000,
        //
        // Summary:
        //     Reserved.
        ReservedMask = 0x9500
    }
}