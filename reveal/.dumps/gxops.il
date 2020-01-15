// 2020-01-15 03:58:00:309
Span<uint> and_32u_span(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
//  Id := 100664639, Name := System.Span`1<System.UInt32> Z0.OpCodes.gxops::and_32u_span(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
//  Span<uint> and_32u_span(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/And`1<System.UInt32> Z0.GX::and<System.UInt32>(System.UInt32)
  IL_0006: stloc.0
  IL_0007: ldloca.s V_0
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: ldarg.2
  IL_000C: call System.Span`1<System.UInt32> Z0.GXTypes/And`1<System.UInt32>::Invoke(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
  IL_0011: ret
}

}
Span<uint> nand_32u_span(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
//  Id := 100664640, Name := System.Span`1<System.UInt32> Z0.OpCodes.gxops::nand_32u_span(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
//  Span<uint> nand_32u_span(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/Nand`1<System.UInt32> Z0.GX::nand<System.UInt32>(System.UInt32)
  IL_0006: stloc.0
  IL_0007: ldloca.s V_0
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: ldarg.2
  IL_000C: call System.Span`1<System.UInt32> Z0.GXTypes/Nand`1<System.UInt32>::Invoke(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
  IL_0011: ret
}

}
Span<ulong> select_64u_span(ReadOnlySpan<ulong> a, ReadOnlySpan<ulong> b, ReadOnlySpan<ulong> c, Span<ulong> dst)
{
//  Id := 100664641, Name := System.Span`1<System.UInt64> Z0.OpCodes.gxops::select_64u_span(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>)
//  Span<ulong> select_64u_span(ReadOnlySpan<ulong> a, ReadOnlySpan<ulong> b, ReadOnlySpan<ulong> c, Span<ulong> dst)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: conv.i8
  IL_0002: call Z0.GXTypes/Select`1<System.UInt64> Z0.GX::select<System.UInt64>(System.UInt64)
  IL_0007: stloc.0
  IL_0008: ldloca.s V_0
  IL_000A: ldarg.0
  IL_000B: ldarg.1
  IL_000C: ldarg.2
  IL_000D: ldarg.3
  IL_000E: call System.Span`1<System.UInt64> Z0.GXTypes/Select`1<System.UInt64>::Invoke(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>)
  IL_0013: ret
}

}
uint bl_and32(uint a, uint b)
{
//  Id := 100664642, Name := System.UInt32 Z0.OpCodes.gxops::bl_and32(System.UInt32,System.UInt32)
//  uint bl_and32(uint a, uint b)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/BitLogicOps`1<System.UInt32> Z0.GX::bitlogic<System.UInt32>(System.UInt32)
  IL_0006: stloc.0
  IL_0007: ldloca.s V_0
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: call System.UInt32 Z0.GXTypes/BitLogicOps`1<System.UInt32>::and(System.UInt32,System.UInt32)
  IL_0010: ret
}

}
uint logic_machine(uint a, uint b)
{
//  Id := 100664643, Name := System.UInt32 Z0.OpCodes.gxops::logic_machine(System.UInt32,System.UInt32)
//  uint logic_machine(uint a, uint b)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/BitLogicOps`1<System.UInt32> Z0.GX::bitlogic<System.UInt32>(System.UInt32)
  IL_0006: ldc.i4.0
  IL_0007: call Z0.LogicMachine`2<Z0.GXTypes/BitLogicOps`1<System.UInt32>,System.UInt32> Z0.LogicMachine::Create<Z0.GXTypes/BitLogicOps`1<System.UInt32>,System.UInt32>(Z0.GXTypes/BitLogicOps`1<System.UInt32>,System.UInt32)
  IL_000C: stloc.0
  IL_000D: ldloca.s V_0
  IL_000F: ldloca.s V_0
  IL_0011: ldarg.0
  IL_0012: ldarg.1
  IL_0013: call System.UInt32 Z0.LogicMachine`2<Z0.GXTypes/BitLogicOps`1<System.UInt32>,System.UInt32>::and(System.UInt32,System.UInt32)
  IL_0018: ldarg.1
  IL_0019: call System.UInt32 Z0.LogicMachine`2<Z0.GXTypes/BitLogicOps`1<System.UInt32>,System.UInt32>::xor(System.UInt32,System.UInt32)
  IL_001E: ret
}

}
Vector128<uint> vlogic_machine(Vector128<uint> a, Vector128<uint> b)
{
//  Id := 100664644, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.gxops::vlogic_machine(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  Vector128<uint> vlogic_machine(Vector128<uint> a, Vector128<uint> b)
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: ldc.i4.0
  IL_0006: call Z0.VXTypes/BitLogic128`1<System.UInt32> Z0.VX::vbitlogic<System.UInt32>(Z0.N128,System.UInt32)
  IL_000B: ldarg.0
  IL_000C: call Z0.LogicMachine`2<Z0.VXTypes/BitLogic128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>> Z0.LogicMachine::Create<Z0.VXTypes/BitLogic128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>>(Z0.VXTypes/BitLogic128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_0011: stloc.0
  IL_0012: ldloca.s V_0
  IL_0014: ldloca.s V_0
  IL_0016: ldarg.0
  IL_0017: ldarg.1
  IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.LogicMachine`2<Z0.VXTypes/BitLogic128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>>::and(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_001D: ldarg.1
  IL_001E: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.LogicMachine`2<Z0.VXTypes/BitLogic128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>>::xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_0023: ret
}

}
bit eq_d16u(ushort a, ushort b)
{
//  Id := 100664645, Name := Z0.bit Z0.OpCodes.gxops::eq_d16u(System.UInt16,System.UInt16)
//  bit eq_d16u(ushort a, ushort b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.math::eq(System.UInt16,System.UInt16)
  IL_0007: ret
}

}
bit eq_g16u(ushort a, ushort b)
{
//  Id := 100664646, Name := Z0.bit Z0.OpCodes.gxops::eq_g16u(System.UInt16,System.UInt16)
//  bit eq_g16u(ushort a, ushort b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.gmath::eq<System.UInt16>(System.UInt16,System.UInt16)
  IL_0007: ret
}

}
bit eq_o16u(ushort a, ushort b)
{
//  Id := 100664647, Name := Z0.bit Z0.OpCodes.gxops::eq_o16u(System.UInt16,System.UInt16)
//  bit eq_o16u(ushort a, ushort b)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/Eq`1<System.UInt16> Z0.GX::eq<System.UInt16>(System.UInt16)
  IL_0006: stloc.0
  IL_0007: ldloca.s V_0
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: call Z0.bit Z0.GXTypes/Eq`1<System.UInt16>::Invoke(System.UInt16,System.UInt16)
  IL_0010: ret
}

}
string eq_moniker()
{
//  Id := 100664648, Name := System.String Z0.OpCodes.gxops::eq_moniker()
//  string eq_moniker()
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/Eq`1<System.UInt16> Z0.GX::eq<System.UInt16>(System.UInt16)
  IL_0006: stloc.0
  IL_0007: ldloca.s V_0
  IL_0009: call Z0.Moniker Z0.GXTypes/Eq`1<System.UInt16>::get_Moniker()
  IL_000E: call System.String Z0.Moniker::op_Implicit(Z0.Moniker)
  IL_0013: ret
}

}
string the_name()
{
//  Id := 100664649, Name := System.String Z0.OpCodes.gxops::the_name()
//  string the_name()
//  Managed
{
  IL_0000: ldstr "thename"
  IL_0005: ret
}

}
