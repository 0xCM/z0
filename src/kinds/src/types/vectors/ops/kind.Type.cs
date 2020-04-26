//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class VectorType
    {
        /// <summary>
        /// Computes the vector kind classifier determined by a system type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Classify]
        public static VectorKind kind(Type src)
        {
            var t = src.EffectiveType();
            if(t == typeof(Vector128<byte>))
                return VectorKind.v128x8u;
            else if(t == typeof(Vector128<ushort>))
                return VectorKind.v128x16u;
            else if(t == typeof(Vector128<uint>))
                return VectorKind.v128x32u;
            else if(t == typeof(Vector128<ulong>))
                return VectorKind.v128x64u;

            else if(t == typeof(Vector128<sbyte>))
                return VectorKind.v128x8i;
            else if(t == typeof(Vector128<short>))
                return VectorKind.v128x16i;
            else if(t == typeof(Vector128<int>))
                return VectorKind.v128x32i;
            else if(t == typeof(Vector128<long>))            
                return VectorKind.v128x64i;
                
            else if(t == typeof(Vector128<float>))
                return VectorKind.v128x32f;
            else if(t == typeof(Vector128<double>))
                return VectorKind.v128x64f;

            else if(t == typeof(Vector256<byte>))
                return VectorKind.v256x8u;
            else if(t == typeof(Vector256<ushort>))
                return VectorKind.v256x16u;
            else if(t == typeof(Vector256<uint>))
                return VectorKind.v256x32u;
            else if(t == typeof(Vector256<ulong>))
                return VectorKind.v256x64u;

            else if(t == typeof(Vector256<sbyte>))
                return VectorKind.v256x8i;
            else if(t == typeof(Vector256<short>))
                return VectorKind.v256x16i;
            else if(t == typeof(Vector256<int>))
                return VectorKind.v256x32i;
            else if(t == typeof(Vector256<long>))
                return VectorKind.v256x64i;

            else if(t == typeof(Vector256<float>))
                return VectorKind.v256x32f;
            else if(t == typeof(Vector256<double>))
                return VectorKind.v256x64f;

            else if(t == typeof(Vector512<byte>))
                return VectorKind.v512x8u;
            else if(t == typeof(Vector512<ushort>))
                return VectorKind.v512x16u;
            else if(t == typeof(Vector512<uint>))
                return VectorKind.v512x32u;
            else if(t == typeof(Vector512<ulong>))
                return VectorKind.v512x64u;

            else if(t == typeof(Vector512<sbyte>))
                return VectorKind.v512x8i;
            else if(t == typeof(Vector512<short>))
                return VectorKind.v512x16i;
            else if(t == typeof(Vector512<int>))
                return VectorKind.v512x32i;
            else if(t == typeof(Vector512<long>))
                return VectorKind.v512x64i;

            else if(t == typeof(Vector512<float>))
                return VectorKind.v512x32f;
            else if(t == typeof(Vector512<double>))
                return VectorKind.v512x64f;
            else    
                return VectorKind.None;
        } 
    }
}