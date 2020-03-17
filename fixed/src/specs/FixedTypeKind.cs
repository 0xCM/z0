//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static FixedWidth;
    using NC = NumericClass;

    [Flags]
    public enum FixedTypeKind : ushort
    {
        None = 0,
        
        Signed = NC.Signed,

        Float = NC.Float,

        Fixed1 = NC.W1,

        Fixed8 = NC.W8,
        
        Fixed8u = NC.Int8u,

        Fixed8i = NC.Int8i,

        Fixed16 = NC.W16,

        Fixed16u = NC.Int16u,

        Fixed16i = NC.Int16i,

        Fixed32 = NC.W32,

        Fixed32u = NC.Int32u,

        Fixed32i = NC.Int32i,

        Fixed32f = NC.Float32,

        Fixed64 = NC.W64,

        Fixed64u = NC.Int64u,
        
        Fixed64i = NC.Int64i,

        Fixed64f = NC.Float64,

        Fixed128 = W128,

        Fixed256 = W256,

        Fixed512 = W512,

        Fixed128x8u = Fixed128 | Fixed8u,

        Fixed128x8i = Fixed128 | Fixed8i,

        Fixed128x16u = Fixed128 | Fixed16u,

        Fixed128x16i = Fixed128 | Fixed16i,

        Fixed128x32u = Fixed128 | Fixed32u,

        Fixed128x32i = Fixed128 | Fixed32i,

        Fixed128x64u = Fixed128 | Fixed64u,
        
        Fixed128x64i = Fixed128 | Fixed64i,

        Fixed128x32f = Fixed128 | Fixed32f,

        Fixed128x64f = Fixed128 | Fixed64f,

        Fixed256x8u = Fixed256 | Fixed8u,

        Fixed256x8i = Fixed256 | Fixed8i,

        Fixed256x16u = Fixed256 | Fixed16u,

        Fixed256x16i = Fixed256 | Fixed16i,

        Fixed256x32u = Fixed256 | Fixed32u,

        Fixed256x32i = Fixed256 | Fixed32i,

        Fixed256x64u = Fixed256 | Fixed64u,

        Fixed256x64i = Fixed256 | Fixed64i,

        Fixed256x32f = Fixed256 | Fixed32f,

        Fixed256x64f = Fixed256 | Fixed64f,

        Fixed512x8u = Fixed512 | Fixed8u,

        Fixed512x8i = Fixed512 | Fixed8i,

        Fixed512x16u = Fixed512 | Fixed16u,

        Fixed512x16i = Fixed512 | Fixed16i,

        Fixed512x32u = Fixed512 | Fixed32u,

        Fixed512x32i = Fixed512 | Fixed32i,

        Fixed512x64u = Fixed512 | Fixed64u,

        Fixed512x64i = Fixed512 | Fixed64i,

        Fixed512x32f = Fixed512 | Fixed32f,

        Fixed512x64f = Fixed512 | Fixed64f,     

        NumericWidths = Fixed8 | Fixed16 | Fixed32 | Fixed64,
    
        UnsignedKinds = Fixed8u | Fixed16u | Fixed32u | Fixed64u,

        SignedKinds = Fixed8i | Fixed16i | Fixed32i | Fixed64i,

        FloatKinds = Fixed32f | Fixed64f,

        IntegralKinds = UnsignedKinds | SignedKinds,

        NumericKinds = IntegralKinds | FloatKinds,

        VectorWidths = Fixed128 | Fixed256 | Fixed512,

        UnsignedVector128Kinds = Fixed128x8u | Fixed128x16u | Fixed128x32u | Fixed128x64u,

        SignedVector128Kinds = Fixed128x8i | Fixed128x16i | Fixed128x32i | Fixed128x64i,

        FloatVector128Kinds = Fixed128x32f | Fixed128x64f,

        IntegralVector128Kinds = UnsignedVector128Kinds | SignedVector128Kinds,

        Vector128Kinds = IntegralVector128Kinds | FloatVector128Kinds,

        UnsignedVector256Kinds = Fixed256x8u | Fixed256x16u | Fixed256x32u | Fixed256x64u,

        FloatVector256Kinds = Fixed256x32f | Fixed256x64f,

        SignedVector256Kinds = Fixed256x8i | Fixed256x16i | Fixed256x32i | Fixed256x64i,

        IntegralVector256Kinds = UnsignedVector256Kinds | SignedVector256Kinds,

        Vector256Kinds = IntegralVector256Kinds | FloatVector256Kinds,

        UnsignedVector512Kinds = Fixed512x8u | Fixed512x16u | Fixed512x32u | Fixed512x64u,

        SignedVector512Kinds = Fixed512x8i | Fixed512x16i | Fixed512x32i | Fixed512x64i,

        FloatVector512Kinds = Fixed512x32f | Fixed512x64f,

        IntegralVector512Kinds = UnsignedVector512Kinds | SignedVector512Kinds,

        Vector512Kinds = IntegralVector512Kinds | FloatVector512Kinds,

        UnsignedVectorKinds = UnsignedVector128Kinds | UnsignedVector256Kinds | UnsignedVector512Kinds,

        SignedVectorKinds = SignedVector128Kinds | SignedVector256Kinds | SignedVector512Kinds,

        FloatVectorKinds = FloatVector128Kinds | FloatVector256Kinds,

        IntegralVectorKinds = SignedVectorKinds | UnsignedVectorKinds,

        VectorKinds = IntegralVectorKinds | FloatVectorKinds,

        LastClass = 1024
    }
}