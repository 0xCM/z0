//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public enum GridDim32 : uint
    {
        Dim1x32 = 1 << 16 | 32,

        Dim32x1 = 32 << 16 | 1,

        Dim2x16 = 2 << 16 | 16,

        Dim16x2 = 16 << 16 | 2,

        Dim4x8 = 4 << 16 | 8,

        Dim8x4 = 8 << 16 | 4,

    }

    public enum GridDim64 : uint
    {
        Dim1x64 = 1 << 16 | 64,

        Dim64x1 = 64 << 16 | 1,

        Dim2x32 = 2 << 16 | 32,

        Dim32x2 = 32 << 16 | 2,

        Dim4x16 = 4 << 16 | 16,

        Dim16x4 = 16 << 16 | 4,

        Dim8x8 = 8 << 16 | 8,
    }
 
    public enum GridDim128 : uint
    {
        Dim1x128 = 1 << 16 | 128,

        Dim128x1 = 128 << 16 | 1,

        Dim2x64 =  2 << 16 | 64,

        Dim64x2 = 64 << 16 | 2,

        Dim4x32 =  4 << 16 | 32,

        Dim32x4 = 32 << 16 | 4,

        Dim8x16 =  8 << 16 | 16,

        Dim16x8 = 16 << 16 | 8,
    }

    public enum GridDim256 : uint
    {
        Dim1x256 = 1 << 16 | 256,

        Dim256x1 = 256 << 16 | 1,

        Dim2x128 = 2 << 16 | 128,

        Dim128x2 = 128 << 16 | 2,

        Dim4x64 = 4 << 16 | 64,

        Dim64x4 = 64 << 16 | 4,

        Dim8x32 = 8 << 16 | 32,

        Dim32x8 = 32 << 16 | 8,

        Dim16x16 = 16 << 16 | 16,
 
    }

    public enum GridDim : uint
    {
        Dim1x32 = GridDim32.Dim1x32,

        Dim32x1 = GridDim32.Dim32x1,

        Dim2x16 = GridDim32.Dim2x16,

        Dim16x2 = GridDim32.Dim16x2,

        Dim4x8 = GridDim32.Dim4x8,

        Dim8x4 = GridDim32.Dim8x4,

        Dim1x64 = GridDim64.Dim1x64,

        Dim64x1 = GridDim64.Dim64x1,

        Dim2x32 = GridDim64.Dim2x32,

        Dim32x2 = GridDim64.Dim32x2,

        Dim4x16 = GridDim64.Dim4x16,

        Dim16x4 = GridDim64.Dim16x4,

        Dim8x8 = GridDim64.Dim8x8,

        Dim1x128 = GridDim128.Dim1x128,

        Dim128x1 = GridDim128.Dim128x1,

        Dim2x64 =  GridDim128.Dim2x64,

        Dim64x2 = GridDim128.Dim64x2,

        Dim4x32 =  GridDim128.Dim4x32,

        Dim32x4 = GridDim128.Dim32x4,

        Dim8x16 =  GridDim128.Dim8x16,

        Dim16x8 = GridDim128.Dim16x8,

        Dim1x256 = GridDim256.Dim1x256,

        Dim256x1 = GridDim256.Dim256x1,

        Dim2x128 = GridDim256.Dim2x128,

        Dim128x2 = GridDim256.Dim128x2,

        Dim4x64 = GridDim256.Dim4x64,

        Dim64x4 = GridDim256.Dim64x4,

        Dim8x32 = GridDim256.Dim8x32,

        Dim32x8 = GridDim256.Dim32x8,

        Dim16x16 = GridDim256.Dim16x16,

    }

}