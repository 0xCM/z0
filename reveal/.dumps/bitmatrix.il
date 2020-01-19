// 2020-01-18 18:18:33:622
// Id := 100664304, Name := System.Int32 Z0.OpCodes.bitmatrix::cell_count_32x64x8()
// int cell_count_32x64x8()
// Managed
int cell_count_32x64x8()
{
    IL_0000: call Z0.N32 zfunc::get_n32()
    IL_0005: call Z0.N64 zfunc::get_n64()
    IL_000A: ldc.i4.0
    IL_000B: call System.Int32 Z0.BitMatrix::totalcells<Z0.N32,Z0.N64,System.Byte>(Z0.N32,Z0.N64,System.Byte)
    IL_0010: ret
}

// Id := 100664305, Name := Z0.TableIndex Z0.OpCodes.bitmatrix::tableindex_32x64x8(System.Int32,System.Int32)
// TableIndex tableindex_32x64x8(int row, int col)
// Managed
TableIndex tableindex_32x64x8(int row, int col)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.N32 zfunc::get_n32()
    IL_0007: call Z0.N64 zfunc::get_n64()
    IL_000C: ldc.i4.0
    IL_000D: call Z0.TableIndex Z0.BitMatrix::tableindex<Z0.N32,Z0.N64,System.Byte>(System.Int32,System.Int32,Z0.N32,Z0.N64,System.Byte)
    IL_0012: ret
}

