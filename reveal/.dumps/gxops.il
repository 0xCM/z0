// 2020-01-11 03:38:51:083
bit eq_d16u(ushort a, ushort b)
{
//  Id := 100664613, Name := Z0.bit Z0.OpCodes.gxops::eq_d16u(System.UInt16,System.UInt16)
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
//  Id := 100664614, Name := Z0.bit Z0.OpCodes.gxops::eq_g16u(System.UInt16,System.UInt16)
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
//  Id := 100664615, Name := Z0.bit Z0.OpCodes.gxops::eq_o16u(System.UInt16,System.UInt16)
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
//  Id := 100664616, Name := System.String Z0.OpCodes.gxops::eq_moniker()
//  string eq_moniker()
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.GXTypes/Eq`1<System.UInt16> Z0.GX::eq<System.UInt16>(System.UInt16)
  IL_0006: stloc.0
  IL_0007: ldloca.s V_0
  IL_0009: call System.String Z0.GXTypes/Eq`1<System.UInt16>::get_Moniker()
  IL_000E: ret
}

}
string the_name()
{
//  Id := 100664617, Name := System.String Z0.OpCodes.gxops::the_name()
//  string the_name()
//  Managed
{
  IL_0000: ldstr "thename"
  IL_0005: ret
}

}
