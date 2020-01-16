// 2020-01-15 19:20:39:148
bit check_and_1(Vector128<uint> x, Vector128<uint> y)
{
//  Id := 100664157, Name := Z0.bit Z0.vxops::check_and_1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  bit check_and_1(Vector128<uint> x, Vector128<uint> y)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/BitLogicOps`1<System.UInt32> Z0.GX::bitlogic<System.UInt32>(System.UInt32)
  IL_0006: stloc.0
  IL_0007: call Z0.N128 zfunc::get_n128()
  IL_000C: ldc.i4.0
  IL_000D: call Z0.VXTypes/BitLogic128`1<System.UInt32> Z0.VX::vbitlogic<System.UInt32>(Z0.N128,System.UInt32)
  IL_0012: stloc.s V_7
  IL_0014: ldloca.s V_7
  IL_0016: ldarg.0
  IL_0017: ldarg.1
  IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.VXTypes/BitLogic128`1<System.UInt32>::and(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_001D: stloc.1
  IL_001E: ldloca.s V_0
  IL_0020: ldarg.0
  IL_0021: ldc.i4.0
  IL_0022: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
  IL_0027: ldarg.1
  IL_0028: ldc.i4.0
  IL_0029: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
  IL_002E: call System.UInt32 Z0.GXTypes/BitLogicOps`1<System.UInt32>::and(System.UInt32,System.UInt32)
  IL_0033: stloc.2
  IL_0034: ldloca.s V_0
  IL_0036: ldarg.0
  IL_0037: ldc.i4.1
  IL_0038: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
  IL_003D: ldarg.1
  IL_003E: ldc.i4.1
  IL_003F: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
  IL_0044: call System.UInt32 Z0.GXTypes/BitLogicOps`1<System.UInt32>::and(System.UInt32,System.UInt32)
  IL_0049: stloc.3
  IL_004A: ldloca.s V_0
  IL_004C: ldarg.0
  IL_004D: ldc.i4.2
  IL_004E: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
  IL_0053: ldarg.1
  IL_0054: ldc.i4.2
  IL_0055: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
  IL_005A: call System.UInt32 Z0.GXTypes/BitLogicOps`1<System.UInt32>::and(System.UInt32,System.UInt32)
  IL_005F: stloc.s V_4
  IL_0061: ldloca.s V_0
  IL_0063: ldarg.0
  IL_0064: ldc.i4.3
  IL_0065: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
  IL_006A: ldarg.1
  IL_006B: ldc.i4.3
  IL_006C: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
  IL_0071: call System.UInt32 Z0.GXTypes/BitLogicOps`1<System.UInt32>::and(System.UInt32,System.UInt32)
  IL_0076: stloc.s V_5
  IL_0078: call Z0.N128 zfunc::get_n128()
  IL_007D: ldloc.2
  IL_007E: ldloc.3
  IL_007F: ldloc.s V_4
  IL_0081: ldloc.s V_5
  IL_0083: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.CpuVector::vparts(Z0.N128,System.UInt32,System.UInt32,System.UInt32,System.UInt32)
  IL_0088: stloc.s V_6
  IL_008A: ldloc.1
  IL_008B: ldloc.s V_6
  IL_008D: call Z0.bit Z0.ginx::vsame<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_0092: ret
}

}
Vector128<uint> and_class(Vector128<uint> x, Vector128<uint> y)
{
//  Id := 100664158, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.vxops::and_class(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  Vector128<uint> and_class(Vector128<uint> x, Vector128<uint> y)
//  Managed
{
  IL_0000: call Z0.AndSkeleton/CAnd128`1<System.UInt32> Z0.AndSkeleton/CAnd128`1<System.UInt32>::get_Op()
  IL_0005: ldarg.0
  IL_0006: ldarg.1
  IL_0007: callvirt System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpSkeleta/VBinOp`3<Z0.N128,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32>::Invoke(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_000C: ret
}

}
uint and_class_scalar(uint x, uint y)
{
//  Id := 100664159, Name := System.UInt32 Z0.vxops::and_class_scalar(System.UInt32,System.UInt32)
//  uint and_class_scalar(uint x, uint y)
//  Managed
{
  IL_0000: call Z0.AndSkeleton/CAnd128`1<System.UInt32> Z0.AndSkeleton/CAnd128`1<System.UInt32>::get_Op()
  IL_0005: ldarg.0
  IL_0006: ldarg.1
  IL_0007: callvirt System.UInt32 Z0.OpSkeleta/VBinOpD`3<Z0.N128,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32>::InvokeScalar(System.UInt32,System.UInt32)
  IL_000C: ret
}

}
uint and_class_scalar(CAnd128<uint> f, uint x, uint y)
{
//  Id := 100664160, Name := System.UInt32 Z0.vxops::and_class_scalar(Z0.AndSkeleton/CAnd128`1<System.UInt32>,System.UInt32,System.UInt32)
//  uint and_class_scalar(CAnd128<uint> f, uint x, uint y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: callvirt System.UInt32 Z0.OpSkeleta/VBinOpD`3<Z0.N128,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32>::InvokeScalar(System.UInt32,System.UInt32)
  IL_0008: ret
}

}
Vector128<uint> and_struct(Vector128<uint> x, Vector128<uint> y)
{
//  Id := 100664161, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.vxops::and_struct(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  Vector128<uint> and_struct(Vector128<uint> x, Vector128<uint> y)
//  Managed
{
  IL_0000: call Z0.VXTypes/And128`1<System.UInt32> Z0.VXTypes/And128`1<System.UInt32>::get_Op()
  IL_0005: stloc.0
  IL_0006: ldloca.s V_0
  IL_0008: ldarg.0
  IL_0009: ldarg.1
  IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.VXTypes/And128`1<System.UInt32>::Invoke(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_000F: ret
}

}
uint and_struct_scalar(uint x, uint y)
{
//  Id := 100664162, Name := System.UInt32 Z0.vxops::and_struct_scalar(System.UInt32,System.UInt32)
//  uint and_struct_scalar(uint x, uint y)
//  Managed
{
  IL_0000: call Z0.VXTypes/And128`1<System.UInt32> Z0.VXTypes/And128`1<System.UInt32>::get_Op()
  IL_0005: stloc.0
  IL_0006: ldloca.s V_0
  IL_0008: ldarg.0
  IL_0009: ldarg.1
  IL_000A: call System.UInt32 Z0.VXTypes/And128`1<System.UInt32>::InvokeScalar(System.UInt32,System.UInt32)
  IL_000F: ret
}

}
void loop_1(ReadOnlySpan<uint> src, Span<uint> dst)
{
//  Id := 100664163, Name := System.Void Z0.vxops::loop_1(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
//  void loop_1(ReadOnlySpan<uint> src, Span<uint> dst)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/Negate`1<System.UInt32> Z0.GX::negate<System.UInt32>(System.UInt32)
  IL_0006: ldarg.0
  IL_0007: ldarg.1
  IL_0008: call System.Void Z0.SpanFunc::run<Z0.GXTypes/Negate`1<System.UInt32>,System.UInt32>(Z0.GXTypes/Negate`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
  IL_000D: ret
}

}
void loop_2(ArrayExchange<uint> src, ArrayExchange<uint> dst)
{
//  Id := 100664164, Name := System.Void Z0.vxops::loop_2(Z0.ArrayExchange`1<System.UInt32>,Z0.ArrayExchange`1<System.UInt32>)
//  void loop_2(ArrayExchange<uint> src, ArrayExchange<uint> dst)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/Negate`1<System.UInt32> Z0.GX::negate<System.UInt32>(System.UInt32)
  IL_0006: ldarg.0
  IL_0007: ldarg.1
  IL_0008: call System.Void Z0.SpanFunc::run<Z0.GXTypes/Negate`1<System.UInt32>,System.UInt32>(Z0.GXTypes/Negate`1<System.UInt32>,Z0.ArrayExchange`1<System.UInt32>,Z0.ArrayExchange`1<System.UInt32>)
  IL_000D: ret
}

}
void pipeline_1(ReadOnlySpan<uint> src, Span<uint> dst)
{
//  Id := 100664165, Name := System.Void Z0.vxops::pipeline_1(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
//  void pipeline_1(ReadOnlySpan<uint> src, Span<uint> dst)
//  Managed
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

}
void pipeline_2(ReadOnlySpan<uint> src, Span<uint> dst)
{
//  Id := 100664166, Name := System.Void Z0.vxops::pipeline_2(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
//  void pipeline_2(ReadOnlySpan<uint> src, Span<uint> dst)
//  Managed
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

}
uint and_negate(uint x)
{
//  Id := 100664167, Name := System.UInt32 Z0.vxops::and_negate(System.UInt32)
//  uint and_negate(uint x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.0
  IL_0002: call System.UInt32 Z0.math::negate(System.UInt32)
  IL_0007: call System.UInt32 Z0.math::and(System.UInt32,System.UInt32)
  IL_000C: ret
}

}
uint and_negate_ops(uint x)
{
//  Id := 100664168, Name := System.UInt32 Z0.vxops::and_negate_ops(System.UInt32)
//  uint and_negate_ops(uint x)
//  Managed
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

}
uint vxor_128x32u_1(Vector128<uint> x, Vector128<uint> y)
{
//  Id := 100664169, Name := System.UInt32 Z0.vxops::vxor_128x32u_1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  uint vxor_128x32u_1(Vector128<uint> x, Vector128<uint> y)
//  Managed
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

}
