//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;

    using static Seed;
    using static Memories;
    using static MemSizeKind;

    using SZ = MemorySize;

    enum MemSizeKind 
    {
        S0,
        S1,
        S2,
        S4,
        S6,
        S8,
        S10,
        S14,
        S16,
        S28,
        S32,
        S64,
        S94,
        S108,
        S512,
    }

	public static class MemorySizeTable
    {
        const int MemorySizeCount = IcedConstants.NumberOfMemorySizes;
        const int MemorySizeByteCount = MemorySizeCount * 3;

        public static MemorySizeInfo[] ToMemorySizes(ReadOnlySpan<byte> data)
        {
            var sizes = new ushort[] {0,1,2, 4,6,8,10,14,16,28,32,64,94,108,512};
            var infos = new MemorySizeInfo[MemorySizeCount];

            for (int i = 0, j = 0; i < infos.Length; i++, j += 3) 
            {
                var elementType = (MemorySize)data[j];
                var b = data[j + 1];
                var size = sizes[b & 0xF];
                var elementSize = sizes[b >> 4];
                infos[i] = new MemorySizeInfo(
                    (MemorySize)i, 
                    size, 
                    elementSize, 
                    elementType, 
                    data[j + 2] != 0, 
                    i >= (int)IcedConstants.FirstBroadcastMemorySize
                    );
            }
            return infos;
        }

        public static ReadOnlySpan<byte> MemorySizeData 
            => new byte[MemorySizeByteCount] 
                {
                    (byte)SZ.Unknown, (byte)((uint)S0 | ((uint)S0 << 4)), 0,
                    (byte)SZ.UInt8, (byte)((uint)S1 | ((uint)S1 << 4)), 0,
                    (byte)SZ.UInt16, (byte)((uint)S2 | ((uint)S2 << 4)), 0,
                    (byte)SZ.UInt32, (byte)((uint)S4 | ((uint)S4 << 4)), 0,
                    (byte)SZ.UInt52, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.UInt64, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.UInt128, (byte)((uint)S16 | ((uint)S16 << 4)), 0,
                    (byte)SZ.UInt256, (byte)((uint)S32 | ((uint)S32 << 4)), 0,
                    (byte)SZ.UInt512, (byte)((uint)S64 | ((uint)S64 << 4)), 0,
                    (byte)SZ.Int8, (byte)((uint)S1 | ((uint)S1 << 4)), 1,
                    (byte)SZ.Int16, (byte)((uint)S2 | ((uint)S2 << 4)), 1,
                    (byte)SZ.Int32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Int64, (byte)((uint)S8 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Int128, (byte)((uint)S16 | ((uint)S16 << 4)), 1,
                    (byte)SZ.Int256, (byte)((uint)S32 | ((uint)S32 << 4)), 1,
                    (byte)SZ.Int512, (byte)((uint)S64 | ((uint)S64 << 4)), 1,
                    (byte)SZ.SegPtr16, (byte)((uint)S4 | ((uint)S4 << 4)), 0,
                    (byte)SZ.SegPtr32, (byte)((uint)S6 | ((uint)S6 << 4)), 0,
                    (byte)SZ.SegPtr64, (byte)((uint)S10 | ((uint)S10 << 4)), 0,
                    (byte)SZ.WordOffset, (byte)((uint)S2 | ((uint)S2 << 4)), 0,
                    (byte)SZ.DwordOffset, (byte)((uint)S4 | ((uint)S4 << 4)), 0,
                    (byte)SZ.QwordOffset, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.Bound16_WordWord, (byte)((uint)S4 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Bound32_DwordDword, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.Bnd32, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.Bnd64, (byte)((uint)S16 | ((uint)S16 << 4)), 0,
                    (byte)SZ.Fword6, (byte)((uint)S6 | ((uint)S6 << 4)), 0,
                    (byte)SZ.Fword10, (byte)((uint)S10 | ((uint)S10 << 4)), 0,
                    (byte)SZ.Float16, (byte)((uint)S2 | ((uint)S2 << 4)), 1,
                    (byte)SZ.Float32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Float64, (byte)((uint)S8 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Float80, (byte)((uint)S10 | ((uint)S10 << 4)), 1,
                    (byte)SZ.Float128, (byte)((uint)S16 | ((uint)S16 << 4)), 1,
                    (byte)SZ.BFloat16, (byte)((uint)S2 | ((uint)S2 << 4)), 1,
                    (byte)SZ.FpuEnv14, (byte)((uint)S14 | ((uint)S14 << 4)), 0,
                    (byte)SZ.FpuEnv28, (byte)((uint)S28 | ((uint)S28 << 4)), 0,
                    (byte)SZ.FpuState94, (byte)((uint)S94 | ((uint)S94 << 4)), 0,
                    (byte)SZ.FpuState108, (byte)((uint)S108 | ((uint)S108 << 4)), 0,
                    (byte)SZ.Fxsave_512Byte, (byte)((uint)S512 | ((uint)S512 << 4)), 0,
                    (byte)SZ.Fxsave64_512Byte, (byte)((uint)S512 | ((uint)S512 << 4)), 0,
                    (byte)SZ.Xsave, (byte)((uint)S0 | ((uint)S0 << 4)), 0,
                    (byte)SZ.Xsave64, (byte)((uint)S0 | ((uint)S0 << 4)), 0,
                    (byte)SZ.Bcd, (byte)((uint)S10 | ((uint)S10 << 4)), 1,
                    (byte)SZ.UInt8, (byte)((uint)S2 | ((uint)S1 << 4)), 0,
                    (byte)SZ.Int8, (byte)((uint)S2 | ((uint)S1 << 4)), 1,
                    (byte)SZ.UInt8, (byte)((uint)S4 | ((uint)S1 << 4)), 0,
                    (byte)SZ.Int8, (byte)((uint)S4 | ((uint)S1 << 4)), 1,
                    (byte)SZ.UInt16, (byte)((uint)S4 | ((uint)S2 << 4)), 0,
                    (byte)SZ.Int16, (byte)((uint)S4 | ((uint)S2 << 4)), 1,
                    (byte)SZ.BFloat16, (byte)((uint)S4 | ((uint)S2 << 4)), 1,
                    (byte)SZ.UInt8, (byte)((uint)S8 | ((uint)S1 << 4)), 0,
                    (byte)SZ.Int8, (byte)((uint)S8 | ((uint)S1 << 4)), 1,
                    (byte)SZ.UInt16, (byte)((uint)S8 | ((uint)S2 << 4)), 0,
                    (byte)SZ.Int16, (byte)((uint)S8 | ((uint)S2 << 4)), 1,
                    (byte)SZ.UInt32, (byte)((uint)S8 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Int32, (byte)((uint)S8 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Float16, (byte)((uint)S8 | ((uint)S2 << 4)), 1,
                    (byte)SZ.Float32, (byte)((uint)S8 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt8, (byte)((uint)S16 | ((uint)S1 << 4)), 0,
                    (byte)SZ.Int8, (byte)((uint)S16 | ((uint)S1 << 4)), 1,
                    (byte)SZ.UInt16, (byte)((uint)S16 | ((uint)S2 << 4)), 0,
                    (byte)SZ.Int16, (byte)((uint)S16 | ((uint)S2 << 4)), 1,
                    (byte)SZ.UInt32, (byte)((uint)S16 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Int32, (byte)((uint)S16 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt52, (byte)((uint)S16 | ((uint)S8 << 4)), 0,
                    (byte)SZ.UInt64, (byte)((uint)S16 | ((uint)S8 << 4)), 0,
                    (byte)SZ.Int64, (byte)((uint)S16 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Float16, (byte)((uint)S16 | ((uint)S2 << 4)), 1,
                    (byte)SZ.Float32, (byte)((uint)S16 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Float64, (byte)((uint)S16 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Packed32_BFloat16, (byte)((uint)S16 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt8, (byte)((uint)S32 | ((uint)S1 << 4)), 0,
                    (byte)SZ.Int8, (byte)((uint)S32 | ((uint)S1 << 4)), 1,
                    (byte)SZ.UInt16, (byte)((uint)S32 | ((uint)S2 << 4)), 0,
                    (byte)SZ.Int16, (byte)((uint)S32 | ((uint)S2 << 4)), 1,
                    (byte)SZ.UInt32, (byte)((uint)S32 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Int32, (byte)((uint)S32 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt52, (byte)((uint)S32 | ((uint)S8 << 4)), 0,
                    (byte)SZ.UInt64, (byte)((uint)S32 | ((uint)S8 << 4)), 0,
                    (byte)SZ.Int64, (byte)((uint)S32 | ((uint)S8 << 4)), 1,
                    (byte)SZ.UInt128, (byte)((uint)S32 | ((uint)S16 << 4)), 0,
                    (byte)SZ.Int128, (byte)((uint)S32 | ((uint)S16 << 4)), 1,
                    (byte)SZ.Float16, (byte)((uint)S32 | ((uint)S2 << 4)), 1,
                    (byte)SZ.Float32, (byte)((uint)S32 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Float64, (byte)((uint)S32 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Float128, (byte)((uint)S32 | ((uint)S16 << 4)), 1,
                    (byte)SZ.Packed32_BFloat16, (byte)((uint)S32 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt8, (byte)((uint)S64 | ((uint)S1 << 4)), 0,
                    (byte)SZ.Int8, (byte)((uint)S64 | ((uint)S1 << 4)), 1,
                    (byte)SZ.UInt16, (byte)((uint)S64 | ((uint)S2 << 4)), 0,
                    (byte)SZ.Int16, (byte)((uint)S64 | ((uint)S2 << 4)), 1,
                    (byte)SZ.UInt32, (byte)((uint)S64 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Int32, (byte)((uint)S64 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt52, (byte)((uint)S64 | ((uint)S8 << 4)), 0,
                    (byte)SZ.UInt64, (byte)((uint)S64 | ((uint)S8 << 4)), 0,
                    (byte)SZ.Int64, (byte)((uint)S64 | ((uint)S8 << 4)), 1,
                    (byte)SZ.UInt128, (byte)((uint)S64 | ((uint)S16 << 4)), 0,
                    (byte)SZ.Float32, (byte)((uint)S64 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Float64, (byte)((uint)S64 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Packed32_BFloat16, (byte)((uint)S64 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt32, (byte)((uint)S4 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Int32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Float32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt32, (byte)((uint)S4 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Int32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt52, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.UInt64, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.Int64, (byte)((uint)S8 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Float32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Float64, (byte)((uint)S8 | ((uint)S8 << 4)), 1,
                    (byte)SZ.UInt32, (byte)((uint)S4 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Int32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt52, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.UInt64, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.Int64, (byte)((uint)S8 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Float32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Float64, (byte)((uint)S8 | ((uint)S8 << 4)), 1,
                    (byte)SZ.UInt32, (byte)((uint)S4 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Int32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.UInt52, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.UInt64, (byte)((uint)S8 | ((uint)S8 << 4)), 0,
                    (byte)SZ.Int64, (byte)((uint)S8 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Float32, (byte)((uint)S4 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Float64, (byte)((uint)S8 | ((uint)S8 << 4)), 1,
                    (byte)SZ.Int16, (byte)((uint)S4 | ((uint)S2 << 4)), 1,
                    (byte)SZ.Int16, (byte)((uint)S4 | ((uint)S2 << 4)), 1,
                    (byte)SZ.Int16, (byte)((uint)S4 | ((uint)S2 << 4)), 1,
                    (byte)SZ.UInt32, (byte)((uint)S8 | ((uint)S4 << 4)), 0,
                    (byte)SZ.UInt32, (byte)((uint)S8 | ((uint)S4 << 4)), 0,
                    (byte)SZ.UInt32, (byte)((uint)S8 | ((uint)S4 << 4)), 0,
                    (byte)SZ.Int32, (byte)((uint)S8 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Int32, (byte)((uint)S8 | ((uint)S4 << 4)), 1,
                    (byte)SZ.Int32, (byte)((uint)S8 | ((uint)S4 << 4)), 1,
                    (byte)SZ.BFloat16, (byte)((uint)S4 | ((uint)S2 << 4)), 1,
                    (byte)SZ.BFloat16, (byte)((uint)S4 | ((uint)S2 << 4)), 1,
                    (byte)SZ.BFloat16, (byte)((uint)S4 | ((uint)S2 << 4)), 1,
                    };

    }

}