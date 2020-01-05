// 2020-01-05 02:30:51:814
Vector128<uint> and_class(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: call Z0.VXTypes/CAnd128`1<System.UInt32> Z0.VXTypes/CAnd128`1<System.UInt32>::get_Op()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: callvirt System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpSkeleta/VBinOp`3<Z0.N128,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32>::Invoke(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000C: ret

}
uint and_class_scalar(uint x, uint y)
{
    IL_0000: call Z0.VXTypes/CAnd128`1<System.UInt32> Z0.VXTypes/CAnd128`1<System.UInt32>::get_Op()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: callvirt System.UInt32 Z0.OpSkeleta/VBinOpD`3<Z0.N128,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32>::InvokeScalar(System.UInt32,System.UInt32)
    IL_000C: ret

}
uint and_class_scalar(CAnd128<uint> f, uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: callvirt System.UInt32 Z0.OpSkeleta/VBinOpD`3<Z0.N128,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32>::InvokeScalar(System.UInt32,System.UInt32)
    IL_0008: ret

}
Vector128<uint> and_struct(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: call Z0.VXTypes/And128`1<System.UInt32> Z0.VXTypes/And128`1<System.UInt32>::get_Op()
    IL_0005: stloc.0
    IL_0006: ldloca.s V_0
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.VXTypes/And128`1<System.UInt32>::Invoke(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000F: ret

}
uint and_struct_scalar(uint x, uint y)
{
    IL_0000: call Z0.VXTypes/And128`1<System.UInt32> Z0.VXTypes/And128`1<System.UInt32>::get_Op()
    IL_0005: stloc.0
    IL_0006: ldloca.s V_0
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: call System.UInt32 Z0.VXTypes/And128`1<System.UInt32>::InvokeScalar(System.UInt32,System.UInt32)
    IL_000F: ret

}
void loop_1(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: call Z0.GXTypes/Negate`1<System.UInt32> Z0.GX::negate<System.UInt32>(System.UInt32)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call System.Void Z0.Loop::run<Z0.GXTypes/Negate`1<System.UInt32>,System.UInt32>(Z0.GXTypes/Negate`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
    IL_000D: ret

}
void loop_2(ArrayExchange<uint> src, ArrayExchange<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: call Z0.GXTypes/Negate`1<System.UInt32> Z0.GX::negate<System.UInt32>(System.UInt32)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call System.Void Z0.Loop::run<Z0.GXTypes/Negate`1<System.UInt32>,System.UInt32>(Z0.GXTypes/Negate`1<System.UInt32>,Z0.ArrayExchange`1<System.UInt32>,Z0.ArrayExchange`1<System.UInt32>)
    IL_000D: ret

}
void pipeline_1(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: call Z0.GXTypes/Negate`1<System.UInt32> Z0.GX::negate<System.UInt32>(System.UInt32)
    IL_0006: stloc.0
    IL_0007: ldc.i4.0
    IL_0008: call Z0.GXTypes/Not`1<System.UInt32> Z0.GX::not<System.UInt32>(System.UInt32)
    IL_000D: stloc.1
    IL_000E: ldarga.s dst
    IL_0010: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_0015: stloc.2
    IL_0016: ldc.i4.0
    IL_0017: stloc.3
    IL_0018: br.s IL_0035
    IL_001A: ldarg.1
    IL_001B: ldloc.3
    IL_001C: call System.UInt32& zfunc::seek<System.UInt32>(System.Span`1<System.UInt32>,System.Int32)
    IL_0021: ldarg.0
    IL_0022: ldloc.3
    IL_0023: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Int32)
    IL_0028: ldind.u4
    IL_0029: ldloc.0
    IL_002A: ldloc.1
    IL_002B: call System.UInt32 Z0.Pipes::pipe<Z0.GXTypes/Negate`1<System.UInt32>,Z0.GXTypes/Not`1<System.UInt32>,System.UInt32>(System.UInt32,Z0.GXTypes/Negate`1<System.UInt32>,Z0.GXTypes/Not`1<System.UInt32>)
    IL_0030: stind.i4
    IL_0031: ldloc.3
    IL_0032: ldc.i4.1
    IL_0033: add
    IL_0034: stloc.3
    IL_0035: ldloc.3
    IL_0036: ldloc.2
    IL_0037: blt.s IL_001A
    IL_0039: ret

}
void pipeline_2(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: call Z0.GXTypes/Negate`1<System.UInt32> Z0.GX::negate<System.UInt32>(System.UInt32)
    IL_0006: stloc.0
    IL_0007: ldc.i4.0
    IL_0008: call Z0.GXTypes/And`1<System.UInt32> Z0.GX::and<System.UInt32>(System.UInt32)
    IL_000D: stloc.1
    IL_000E: ldarga.s dst
    IL_0010: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_0015: stloc.2
    IL_0016: ldc.i4.0
    IL_0017: stloc.3
    IL_0018: br.s IL_0035
    IL_001A: ldarg.1
    IL_001B: ldloc.3
    IL_001C: call System.UInt32& zfunc::seek<System.UInt32>(System.Span`1<System.UInt32>,System.Int32)
    IL_0021: ldarg.0
    IL_0022: ldloc.3
    IL_0023: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Int32)
    IL_0028: ldind.u4
    IL_0029: ldloc.1
    IL_002A: ldloc.0
    IL_002B: call System.UInt32 Z0.Pipes::compose<Z0.GXTypes/And`1<System.UInt32>,Z0.GXTypes/Negate`1<System.UInt32>,System.UInt32>(System.UInt32,Z0.GXTypes/And`1<System.UInt32>,Z0.GXTypes/Negate`1<System.UInt32>)
    IL_0030: stind.i4
    IL_0031: ldloc.3
    IL_0032: ldc.i4.1
    IL_0033: add
    IL_0034: stloc.3
    IL_0035: ldloc.3
    IL_0036: ldloc.2
    IL_0037: blt.s IL_001A
    IL_0039: ret

}
uint and_negate(uint x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0007: call System.UInt32 Z0.math::and(System.UInt32,System.UInt32)
    IL_000C: ret

}
uint and_negate_ops(uint x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.GXTypes/Negate`1<System.UInt32> Z0.GX::negate<System.UInt32>(System.UInt32)
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: call Z0.GXTypes/And`1<System.UInt32> Z0.GX::and<System.UInt32>(System.UInt32)
    IL_000D: stloc.1
    IL_000E: ldarg.0
    IL_000F: ldloc.1
    IL_0010: ldloc.0
    IL_0011: call System.UInt32 Z0.Pipes::compose<Z0.GXTypes/And`1<System.UInt32>,Z0.GXTypes/Negate`1<System.UInt32>,System.UInt32>(System.UInt32,Z0.GXTypes/And`1<System.UInt32>,Z0.GXTypes/Negate`1<System.UInt32>)
    IL_0016: ret

}
uint vxor_128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4.0
    IL_0006: call Z0.VXTypes/Xor128`1<System.UInt32> Z0.VX::vxor<System.UInt32>(Z0.N128,System.UInt32)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.VXTypes/Xor128`1<System.UInt32>::Invoke(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldarg.0
    IL_0019: call System.UInt32 Z0.xfunc::FirstCell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001E: ldarg.1
    IL_001F: call System.UInt32 Z0.xfunc::LastCell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0024: call System.UInt32 Z0.VXTypes/Xor128`1<System.UInt32>::InvokeScalar(System.UInt32,System.UInt32)
    IL_0029: stloc.2
    IL_002A: ldloc.2
    IL_002B: ret

}
