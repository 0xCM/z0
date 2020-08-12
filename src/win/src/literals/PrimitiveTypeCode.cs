//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    
    /// <summary>
    /// Represents a primitive type found in metadata signatures.
    /// </summary>
    public enum PrimitiveTypeCode : byte
    {
        Boolean = SignatureTypeCode.Boolean,

        Byte = SignatureTypeCode.Byte,

        SByte = SignatureTypeCode.SByte,

        Char = SignatureTypeCode.Char,

        Int16 = SignatureTypeCode.Int16,

        UInt16 = SignatureTypeCode.UInt16,

        Int32 = SignatureTypeCode.Int32,

        UInt32 = SignatureTypeCode.UInt32,

        Int64 = SignatureTypeCode.Int64,

        UInt64 = SignatureTypeCode.UInt64,

        Single = SignatureTypeCode.Single,

        Double = SignatureTypeCode.Double,

        IntPtr = SignatureTypeCode.IntPtr,

        UIntPtr = SignatureTypeCode.UIntPtr,
    
        Object = SignatureTypeCode.Object,
    
        String = SignatureTypeCode.String,
    
        TypedReference = SignatureTypeCode.TypedReference,
    
        Void = SignatureTypeCode.Void,
    }
}