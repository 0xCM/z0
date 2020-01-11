// 2020-01-11 03:38:49:887
Vector256<short> add_d256x16i(Vector256<short> x, Vector256<short> y)
{
//  Id := 100664129, Name := System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.inxoc::add_d256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  Vector256<short> add_d256x16i(Vector256<short> x, Vector256<short> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vadd(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
  IL_0007: ret
}

}
Vector256<short> add_g256x16i(Vector256<short> x, Vector256<short> y)
{
//  Id := 100664130, Name := System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.inxoc::add_g256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  Vector256<short> add_g256x16i(Vector256<short> x, Vector256<short> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.ginx::vadd<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
  IL_0007: ret
}

}
Vector256<short> add_o256x16i(Vector256<short> x, Vector256<short> y)
{
//  Id := 100664131, Name := System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.inxoc::add_o256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  Vector256<short> add_o256x16i(Vector256<short> x, Vector256<short> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.N256 zfunc::get_n256()
  IL_0007: ldc.i4.0
  IL_0008: call Z0.VXTypes/Add256`1<System.Int16> Z0.VX::vadd<System.Int16>(Z0.N256,System.Int16)
  IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Pipes::apply<Z0.VXTypes/Add256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,Z0.VXTypes/Add256`1<System.Int16>)
  IL_0012: ret
}

}
Vector256<short> abs_d256x16i(Vector256<short> src)
{
//  Id := 100664132, Name := System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.inxoc::abs_d256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  Vector256<short> abs_d256x16i(Vector256<short> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vabs(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
  IL_0006: ret
}

}
Vector256<short> abs_g256x16i(Vector256<short> src)
{
//  Id := 100664133, Name := System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.inxoc::abs_g256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  Vector256<short> abs_g256x16i(Vector256<short> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.ginx::vabs<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
  IL_0006: ret
}

}
Vector256<short> abs_o256x16i(Vector256<short> src)
{
//  Id := 100664134, Name := System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.inxoc::abs_o256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  Vector256<short> abs_o256x16i(Vector256<short> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.N256 zfunc::get_n256()
  IL_0006: ldc.i4.0
  IL_0007: call Z0.VXTypes/Abs256`1<System.Int16> Z0.VX::vabs<System.Int16>(Z0.N256,System.Int16)
  IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Pipes::apply<Z0.VXTypes/Abs256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,Z0.VXTypes/Abs256`1<System.Int16>)
  IL_0011: ret
}

}
Vector256<short> sub_d256x16i(Vector256<short> x, Vector256<short> y)
{
//  Id := 100664135, Name := System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.inxoc::sub_d256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  Vector256<short> sub_d256x16i(Vector256<short> x, Vector256<short> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
  IL_0007: ret
}

}
Vector256<short> sub_g256x16i(Vector256<short> x, Vector256<short> y)
{
//  Id := 100664136, Name := System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.inxoc::sub_g256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  Vector256<short> sub_g256x16i(Vector256<short> x, Vector256<short> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.ginx::vsub<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
  IL_0007: ret
}

}
ulong vcell_0_256x64u(Vector256<ulong> src)
{
//  Id := 100664137, Name := System.UInt64 Z0.inxoc::vcell_0_256x64u(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
//  ulong vcell_0_256x64u(Vector256<ulong> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.0
  IL_0002: call System.UInt64 zfunc::vcell<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Int32)
  IL_0007: ret
}

}
ulong vcell_1_256x64u(Vector256<ulong> src)
{
//  Id := 100664138, Name := System.UInt64 Z0.inxoc::vcell_1_256x64u(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
//  ulong vcell_1_256x64u(Vector256<ulong> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.1
  IL_0002: call System.UInt64 zfunc::vcell<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Int32)
  IL_0007: ret
}

}
ulong vcell_1_128x8u(Vector128<byte> src)
{
//  Id := 100664139, Name := System.UInt64 Z0.inxoc::vcell_1_128x8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
//  ulong vcell_1_128x8u(Vector128<byte> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.1
  IL_0002: call System.Byte zfunc::vcell<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Int32)
  IL_0007: conv.u8
  IL_0008: ret
}

}
ulong vcell_2_256x64u(Vector256<ulong> src)
{
//  Id := 100664140, Name := System.UInt64 Z0.inxoc::vcell_2_256x64u(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
//  ulong vcell_2_256x64u(Vector256<ulong> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.2
  IL_0002: call System.UInt64 zfunc::vcell<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Int32)
  IL_0007: ret
}

}
byte vcell_3_256x64u(Vector256<byte> src)
{
//  Id := 100664141, Name := System.Byte Z0.inxoc::vcell_3_256x64u(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
//  byte vcell_3_256x64u(Vector256<byte> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.3
  IL_0002: call System.Byte zfunc::vcell<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Int32)
  IL_0007: ret
}

}
uint vcell_256x32u_1(Vector256<uint> src)
{
//  Id := 100664142, Name := System.UInt32 Z0.inxoc::vcell_256x32u_1(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
//  uint vcell_256x32u_1(Vector256<uint> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.1
  IL_0002: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Int32)
  IL_0007: ret
}

}
uint vcell_256x32u_2(Vector256<uint> src)
{
//  Id := 100664143, Name := System.UInt32 Z0.inxoc::vcell_256x32u_2(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
//  uint vcell_256x32u_2(Vector256<uint> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.2
  IL_0002: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Int32)
  IL_0007: ret
}

}
Vector128<byte> swap_hl(Vector128<byte> src)
{
//  Id := 100664144, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.inxoc::swap_hl(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
//  Vector128<byte> swap_hl(Vector128<byte> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vswaphl<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
  IL_0006: ret
}

}
Vector128<ulong> hi_128x64u(Vector128<ulong> src)
{
//  Id := 100664145, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.inxoc::hi_128x64u(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
//  Vector128<ulong> hi_128x64u(Vector128<ulong> src)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0006: ret
}

}
Vector128<byte> hi_128x8u(Vector128<byte> src)
{
//  Id := 100664146, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.inxoc::hi_128x8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
//  Vector128<byte> hi_128x8u(Vector128<byte> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vhi<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
  IL_0006: ret
}

}
Vector128<ulong> lo_128x64u(Vector128<ulong> src)
{
//  Id := 100664147, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.inxoc::lo_128x64u(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
//  Vector128<ulong> lo_128x64u(Vector128<ulong> src)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vlo<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0006: ret
}

}
Vector128<byte> lo_128x8u(Vector128<byte> src)
{
//  Id := 100664148, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.inxoc::lo_128x8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
//  Vector128<byte> lo_128x8u(Vector128<byte> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vlo<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
  IL_0006: ret
}

}
void vlo_256x8u_out(Vector256<byte> src, out ulong x0, out ulong x1)
{
//  Id := 100664149, Name := System.Void Z0.inxoc::vlo_256x8u_out(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.UInt64&,System.UInt64&)
//  void vlo_256x8u_out(Vector256<byte> src, out ulong x0, out ulong x1)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call System.Void Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.UInt64&,System.UInt64&)
  IL_0008: ret
}

}
ref Pair<ulong> vlo_256x8u_pair(Vector256<byte> src, ref Pair<ulong> dst)
{
//  Id := 100664150, Name := Z0.Pair`1<System.UInt64>& Z0.inxoc::vlo_256x8u_pair(System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.Pair`1<System.UInt64>&)
//  ref Pair<ulong> vlo_256x8u_pair(Vector256<byte> src, ref Pair<ulong> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.Pair`1<System.UInt64>& Z0.ginx::vlo<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.Pair`1<System.UInt64>&)
  IL_0007: ret
}

}
void vlo_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
{
//  Id := 100664151, Name := System.Void Z0.inxoc::vlo_256x64u_out(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.UInt64&,System.UInt64&)
//  void vlo_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call System.Void Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.UInt64&,System.UInt64&)
  IL_0008: ret
}

}
ref Pair<ulong> vlo_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
{
//  Id := 100664152, Name := Z0.Pair`1<System.UInt64>& Z0.inxoc::vlo_256x64u_pair(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Pair`1<System.UInt64>&)
//  ref Pair<ulong> vlo_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.Pair`1<System.UInt64>& Z0.ginx::vlo<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Pair`1<System.UInt64>&)
  IL_0007: ret
}

}
void vhi_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
{
//  Id := 100664153, Name := System.Void Z0.inxoc::vhi_256x64u_out(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.UInt64&,System.UInt64&)
//  void vhi_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call System.Void Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.UInt64&,System.UInt64&)
  IL_0008: ret
}

}
ref Pair<ulong> vhi_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
{
//  Id := 100664154, Name := Z0.Pair`1<System.UInt64>& Z0.inxoc::vhi_256x64u_pair(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Pair`1<System.UInt64>&)
//  ref Pair<ulong> vhi_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.Pair`1<System.UInt64>& Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Pair`1<System.UInt64>&)
  IL_0007: ret
}

}
