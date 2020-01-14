// 2020-01-13 21:43:23:190
uint bl_and32(uint a, uint b)
{
//  Id := 100664632, Name := System.UInt32 Z0.OpCodes.gxops::bl_and32(System.UInt32,System.UInt32)
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
//  Id := 100664633, Name := System.UInt32 Z0.OpCodes.gxops::logic_machine(System.UInt32,System.UInt32)
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
//  Id := 100664634, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.gxops::vlogic_machine(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
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
//  Id := 100664635, Name := Z0.bit Z0.OpCodes.gxops::eq_d16u(System.UInt16,System.UInt16)
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
//  Id := 100664636, Name := Z0.bit Z0.OpCodes.gxops::eq_g16u(System.UInt16,System.UInt16)
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
//  Id := 100664637, Name := Z0.bit Z0.OpCodes.gxops::eq_o16u(System.UInt16,System.UInt16)
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
//  Id := 100664638, Name := System.String Z0.OpCodes.gxops::eq_moniker()
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
//  Id := 100664639, Name := System.String Z0.OpCodes.gxops::the_name()
//  string the_name()
//  Managed
{
  IL_0000: ldstr "thename"
  IL_0005: ret
}

}
