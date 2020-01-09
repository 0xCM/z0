//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class CpuVectorKinds
    {

        public readonly struct V16x8u { public const CpuVectorKind Kind = CpuVectorKind.v16x8u;}
        
        public readonly struct V16x8i { public const CpuVectorKind Kind = CpuVectorKind.v16x8i;}
        
        public readonly struct V8x16u { public const CpuVectorKind Kind = CpuVectorKind.v8x16u;}

        public readonly struct V8x16i { public const CpuVectorKind Kind = CpuVectorKind.v8x16i;}

        public readonly struct V4x32u { public const CpuVectorKind Kind = CpuVectorKind.v4x32u;}

        public readonly struct V4x32i { public const CpuVectorKind Kind = CpuVectorKind.v4x32i;}

        public readonly struct V2x64u { public const CpuVectorKind Kind = CpuVectorKind.v2x64u;}

        public readonly struct V2x64i { public const CpuVectorKind Kind = CpuVectorKind.v2x64i;}

        public readonly struct V4x32f { public const CpuVectorKind Kind = CpuVectorKind.v4x32f;}

        public readonly struct V2x64f { public const CpuVectorKind Kind = CpuVectorKind.v2x64f;}

        public readonly struct V32x8u { public const CpuVectorKind Kind = CpuVectorKind.v32x8u;}
        
        public readonly struct V32x8i { public const CpuVectorKind Kind = CpuVectorKind.v32x8i;}
        
        public readonly struct V16x16u { public const CpuVectorKind Kind = CpuVectorKind.v16x16u;}

        public readonly struct V16x16i { public const CpuVectorKind Kind = CpuVectorKind.v16x16i;}

        public readonly struct V8x32u { public const CpuVectorKind Kind = CpuVectorKind.v8x32u;}

        public readonly struct V8x32i { public const CpuVectorKind Kind = CpuVectorKind.v8x32i;}

        public readonly struct V4x64u { public const CpuVectorKind Kind = CpuVectorKind.v4x64u;}

        public readonly struct V4x64i { public const CpuVectorKind Kind = CpuVectorKind.v4x64i;}

        public readonly struct V8x32f { public const CpuVectorKind Kind = CpuVectorKind.v8x32f;}

        public readonly struct V4x64f { public const CpuVectorKind Kind = CpuVectorKind.v4x64f;}

    }
}
