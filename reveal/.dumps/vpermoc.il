// 2020-01-11 03:38:50:490
Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> vand_delgate()
{
//  Id := 100664695, Name := System.Func`3<System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>> Z0.OpCodes.vpermoc::vand_delgate()
//  Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> vand_delgate()
//  NoInlining
{
  IL_0000: ldtoken System.Runtime.Intrinsics.X86.Avx2
  IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
  IL_000A: ldstr "And"
  IL_000F: ldc.i4.2
  IL_0010: newarr System.Type
  IL_0015: dup
  IL_0016: ldc.i4.0
  IL_0017: ldtoken System.Runtime.Intrinsics.Vector256`1<System.UInt32>
  IL_001C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
  IL_0021: stelem.ref
  IL_0022: dup
  IL_0023: ldc.i4.1
  IL_0024: ldtoken System.Runtime.Intrinsics.Vector256`1<System.UInt32>
  IL_0029: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
  IL_002E: stelem.ref
  IL_002F: call System.Reflection.MethodInfo System.Type::GetMethod(System.String,System.Type[])
  IL_0034: stloc.0
  IL_0035: ldloc.0
  IL_0036: ldloca.s V_2
  IL_0038: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
  IL_003E: ldloc.2
  IL_003F: call System.Func`3<System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>> Z0.Reflections::BinOpCalli<System.Runtime.Intrinsics.Vector256`1<System.UInt32>>(System.Reflection.MethodInfo,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
  IL_0044: stloc.1
  IL_0045: ldloc.1
  IL_0046: ret
}

}
Vector256<uint> vand_dynamic(Vector256<uint> a, Vector256<uint> b)
{
//  Id := 100664696, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vpermoc::vand_dynamic(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
//  Vector256<uint> vand_dynamic(Vector256<uint> a, Vector256<uint> b)
//  Managed
{
  IL_0000: call System.Func`3<System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>> Z0.OpCodes.vpermoc::vand_delgate()
  IL_0005: ldarg.0
  IL_0006: ldarg.1
  IL_0007: callvirt System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Func`3<System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>>::Invoke(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
  IL_000C: ret
}

}
Vector512<ulong> vperm2x128(Vector512<ulong> src)
{
//  Id := 100664697, Name := Z0.Vector512`1<System.UInt64> Z0.OpCodes.vpermoc::vperm2x128(Z0.Vector512`1<System.UInt64>)
//  Vector512<ulong> vperm2x128(Vector512<ulong> src)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldc.i4.s 48
  IL_0004: ldc.i4.s 33
  IL_0006: call Z0.Vector512`1<System.UInt64> Z0.ginx::vperm2x128<System.UInt64>(Z0.Vector512`1<System.UInt64>&,Z0.Perm2x4,Z0.Perm2x4)
  IL_000B: ret
}

}
Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
{
//  Id := 100664698, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vpermoc::vbswap_128x16u(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
//  Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vbyteswap(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
  IL_0006: ret
}

}
Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
{
//  Id := 100664699, Name := System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.OpCodes.vpermoc::vpermvar8x32_256x32i(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
//  Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vperm8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
  IL_0007: ret
}

}
Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
{
//  Id := 100664700, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vpermoc::vpermvar8x32_256x32u(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
//  Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vperm8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
  IL_0007: ret
}

}
Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
{
//  Id := 100664701, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpermoc::vpermvar32x8_256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
//  Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vshuf32x8(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
  IL_0007: ret
}

}
Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
{
//  Id := 100664702, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vpermoc::vshuffle_128x8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
//  Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vshuf16x8(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
  IL_0007: ret
}

}
Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
{
//  Id := 100664703, Name := System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.OpCodes.vpermoc::vshuffle_128x8i(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
//  Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vshuf16x8(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
  IL_0007: ret
}

}
Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
{
//  Id := 100664704, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpermoc::vshuffle_256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
//  Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vshuf16x8(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
  IL_0007: ret
}

}
Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
{
//  Id := 100664705, Name := System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.OpCodes.vpermoc::vshuffle_256x8i(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
//  Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vshuf16x8(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
  IL_0007: ret
}

}
void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)
{
//  Id := 100664706, Name := System.Void Z0.OpCodes.vpermoc::vtranspose(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&)
//  void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: ldarg.3
  IL_0004: call System.Void Z0.dinx::vtranspose(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&)
  IL_0009: ret
}

}
