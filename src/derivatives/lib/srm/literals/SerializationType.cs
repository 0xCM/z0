//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{

    public enum SerializationType : byte
    {
        CustomAttributeStart = 0x01,

        SecurityAttribute20Start = 0x2E,

        Undefined = 0x00,

        Boolean = ElementType.Boolean,

        Char = ElementType.Char,

        Int8 = ElementType.Int8,

        UInt8 = ElementType.UInt8,

        Int16 = ElementType.Int16,

        UInt16 = ElementType.UInt16,

        Int32 = ElementType.Int32,

        UInt32 = ElementType.UInt32,

        Int64 = ElementType.Int64,

        UInt64 = ElementType.UInt64,

        Single = ElementType.Single,

        Double = ElementType.Double,

        String = ElementType.String,

        SZArray = ElementType.SzArray,

        Type = 0x50,

        TaggedObject = 0x51,

        Field = 0x53,

        Property = 0x54,

        Enum = 0x55,
    }
}