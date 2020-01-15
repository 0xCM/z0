// 2020-01-15 03:57:58:771
int convert_g32f_to_g32i(float src)
{
//  Id := 100664565, Name := System.Int32 Z0.OpCodes.sconvert::convert_g32f_to_g32i(System.Single)
//  int convert_g32f_to_g32i(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.Single,System.Int32>(System.Single)
  IL_0006: ret
}

}
uint convert_g32f_to_g32u(float src)
{
//  Id := 100664566, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g32f_to_g32u(System.Single)
//  uint convert_g32f_to_g32u(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.Single,System.UInt32>(System.Single)
  IL_0006: ret
}

}
long convert_g32f_to_g64i(float src)
{
//  Id := 100664567, Name := System.Int64 Z0.OpCodes.sconvert::convert_g32f_to_g64i(System.Single)
//  long convert_g32f_to_g64i(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.Single,System.Int64>(System.Single)
  IL_0006: ret
}

}
ulong convert_g32f_to_g64u(float src)
{
//  Id := 100664568, Name := System.UInt64 Z0.OpCodes.sconvert::convert_g32f_to_g64u(System.Single)
//  ulong convert_g32f_to_g64u(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.Single,System.UInt64>(System.Single)
  IL_0006: ret
}

}
float convert_g32f_to_g32f(float src)
{
//  Id := 100664569, Name := System.Single Z0.OpCodes.sconvert::convert_g32f_to_g32f(System.Single)
//  float convert_g32f_to_g32f(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.Single,System.Single>(System.Single)
  IL_0006: ret
}

}
double convert_g32f_to_g64f(float src)
{
//  Id := 100664570, Name := System.Double Z0.OpCodes.sconvert::convert_g32f_to_g64f(System.Single)
//  double convert_g32f_to_g64f(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.Single,System.Double>(System.Single)
  IL_0006: ret
}

}
Char convert_g32f_to_gch16(float src)
{
//  Id := 100664571, Name := System.Char Z0.OpCodes.sconvert::convert_g32f_to_gch16(System.Single)
//  Char convert_g32f_to_gch16(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Char Z0.Converter::convert<System.Single,System.Char>(System.Single)
  IL_0006: ret
}

}
sbyte convert_64f_to_8i(double src)
{
//  Id := 100664572, Name := System.SByte Z0.OpCodes.sconvert::convert_64f_to_8i(System.Double)
//  sbyte convert_64f_to_8i(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i1
  IL_0002: ret
}

}
sbyte convert_64f_to_g8i(double src)
{
//  Id := 100664573, Name := System.SByte Z0.OpCodes.sconvert::convert_64f_to_g8i(System.Double)
//  sbyte convert_64f_to_g8i(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.Double)
  IL_0006: ret
}

}
sbyte convert_g64f_to_g8i(double src)
{
//  Id := 100664574, Name := System.SByte Z0.OpCodes.sconvert::convert_g64f_to_g8i(System.Double)
//  sbyte convert_g64f_to_g8i(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.Double,System.SByte>(System.Double)
  IL_0006: ret
}

}
byte convert_64f_to_8u(double src)
{
//  Id := 100664575, Name := System.Byte Z0.OpCodes.sconvert::convert_64f_to_8u(System.Double)
//  byte convert_64f_to_8u(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i8
  IL_0002: conv.u1
  IL_0003: ret
}

}
byte convert_g64f_to_g8u(double src)
{
//  Id := 100664576, Name := System.Byte Z0.OpCodes.sconvert::convert_g64f_to_g8u(System.Double)
//  byte convert_g64f_to_g8u(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.Double,System.Byte>(System.Double)
  IL_0006: ret
}

}
short convert_64f_to_16i(double src)
{
//  Id := 100664577, Name := System.Int16 Z0.OpCodes.sconvert::convert_64f_to_16i(System.Double)
//  short convert_64f_to_16i(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i2
  IL_0002: ret
}

}
short convert_g64f_to_g16i(double src)
{
//  Id := 100664578, Name := System.Int16 Z0.OpCodes.sconvert::convert_g64f_to_g16i(System.Double)
//  short convert_g64f_to_g16i(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.Double,System.Int16>(System.Double)
  IL_0006: ret
}

}
ushort convert_64f_to_g16u(double src)
{
//  Id := 100664579, Name := System.UInt16 Z0.OpCodes.sconvert::convert_64f_to_g16u(System.Double)
//  ushort convert_64f_to_g16u(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.Double)
  IL_0006: ret
}

}
ushort convert_g64f_to_g16u(double src)
{
//  Id := 100664580, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g64f_to_g16u(System.Double)
//  ushort convert_g64f_to_g16u(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.Double,System.UInt16>(System.Double)
  IL_0006: ret
}

}
int convert_g64f_to_g32i(double src)
{
//  Id := 100664581, Name := System.Int32 Z0.OpCodes.sconvert::convert_g64f_to_g32i(System.Double)
//  int convert_g64f_to_g32i(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.Double,System.Int32>(System.Double)
  IL_0006: ret
}

}
uint convert_64f_to_g32u(double src)
{
//  Id := 100664582, Name := System.UInt32 Z0.OpCodes.sconvert::convert_64f_to_g32u(System.Double)
//  uint convert_64f_to_g32u(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.Double)
  IL_0006: ret
}

}
uint convert_g64f_to_g32u(double src)
{
//  Id := 100664583, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g64f_to_g32u(System.Double)
//  uint convert_g64f_to_g32u(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.Double,System.UInt32>(System.Double)
  IL_0006: ret
}

}
long convert_g64f_to_g64i(double src)
{
//  Id := 100664584, Name := System.Int64 Z0.OpCodes.sconvert::convert_g64f_to_g64i(System.Double)
//  long convert_g64f_to_g64i(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.Double,System.Int64>(System.Double)
  IL_0006: ret
}

}
ulong convert_g64f_to_g64u(double src)
{
//  Id := 100664585, Name := System.UInt64 Z0.OpCodes.sconvert::convert_g64f_to_g64u(System.Double)
//  ulong convert_g64f_to_g64u(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.Double,System.UInt64>(System.Double)
  IL_0006: ret
}

}
float convert_g64f_to_g32f(double src)
{
//  Id := 100664586, Name := System.Single Z0.OpCodes.sconvert::convert_g64f_to_g32f(System.Double)
//  float convert_g64f_to_g32f(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.Double,System.Single>(System.Double)
  IL_0006: ret
}

}
double convert_g64f_to_g64f(double src)
{
//  Id := 100664587, Name := System.Double Z0.OpCodes.sconvert::convert_g64f_to_g64f(System.Double)
//  double convert_g64f_to_g64f(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.Double,System.Double>(System.Double)
  IL_0006: ret
}

}
Char convert_g64f_to_gch16(double src)
{
//  Id := 100664588, Name := System.Char Z0.OpCodes.sconvert::convert_g64f_to_gch16(System.Double)
//  Char convert_g64f_to_gch16(double src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Char Z0.Converter::convert<System.Double,System.Char>(System.Double)
  IL_0006: ret
}

}
sbyte convert_ch16_to_8i(Char src)
{
//  Id := 100664589, Name := System.SByte Z0.OpCodes.sconvert::convert_ch16_to_8i(System.Char)
//  sbyte convert_ch16_to_8i(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i1
  IL_0002: ret
}

}
sbyte convert_gch16_to_g8i(Char src)
{
//  Id := 100664590, Name := System.SByte Z0.OpCodes.sconvert::convert_gch16_to_g8i(System.Char)
//  sbyte convert_gch16_to_g8i(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.Char,System.SByte>(System.Char)
  IL_0006: ret
}

}
byte convert_gch16_to_g8u(Char src)
{
//  Id := 100664591, Name := System.Byte Z0.OpCodes.sconvert::convert_gch16_to_g8u(System.Char)
//  byte convert_gch16_to_g8u(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.Char,System.Byte>(System.Char)
  IL_0006: ret
}

}
short convert_ch16_to_16i(Char src)
{
//  Id := 100664592, Name := System.Int16 Z0.OpCodes.sconvert::convert_ch16_to_16i(System.Char)
//  short convert_ch16_to_16i(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i2
  IL_0002: ret
}

}
short convert_gch16_to_g16i(Char src)
{
//  Id := 100664593, Name := System.Int16 Z0.OpCodes.sconvert::convert_gch16_to_g16i(System.Char)
//  short convert_gch16_to_g16i(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.Char,System.Int16>(System.Char)
  IL_0006: ret
}

}
ushort convert_ch16_to_16u(Char src)
{
//  Id := 100664594, Name := System.UInt16 Z0.OpCodes.sconvert::convert_ch16_to_16u(System.Char)
//  ushort convert_ch16_to_16u(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
ushort convert_gch16_to_g16u(Char src)
{
//  Id := 100664595, Name := System.UInt16 Z0.OpCodes.sconvert::convert_gch16_to_g16u(System.Char)
//  ushort convert_gch16_to_g16u(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.Char,System.UInt16>(System.Char)
  IL_0006: ret
}

}
int convert_gch16_to_g32i(Char src)
{
//  Id := 100664596, Name := System.Int32 Z0.OpCodes.sconvert::convert_gch16_to_g32i(System.Char)
//  int convert_gch16_to_g32i(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.Char,System.Int32>(System.Char)
  IL_0006: ret
}

}
uint convert_gch16_to_g32u(Char src)
{
//  Id := 100664597, Name := System.UInt32 Z0.OpCodes.sconvert::convert_gch16_to_g32u(System.Char)
//  uint convert_gch16_to_g32u(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.Char,System.UInt32>(System.Char)
  IL_0006: ret
}

}
long convert_gch16_to_g64i(Char src)
{
//  Id := 100664598, Name := System.Int64 Z0.OpCodes.sconvert::convert_gch16_to_g64i(System.Char)
//  long convert_gch16_to_g64i(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.Char,System.Int64>(System.Char)
  IL_0006: ret
}

}
ulong convert_gch16_to_g64u(Char src)
{
//  Id := 100664599, Name := System.UInt64 Z0.OpCodes.sconvert::convert_gch16_to_g64u(System.Char)
//  ulong convert_gch16_to_g64u(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.Char,System.UInt64>(System.Char)
  IL_0006: ret
}

}
float convert_gch16_to_g32f(Char src)
{
//  Id := 100664600, Name := System.Single Z0.OpCodes.sconvert::convert_gch16_to_g32f(System.Char)
//  float convert_gch16_to_g32f(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.Char,System.Single>(System.Char)
  IL_0006: ret
}

}
double convert_gch16_to_g64f(Char src)
{
//  Id := 100664601, Name := System.Double Z0.OpCodes.sconvert::convert_gch16_to_g64f(System.Char)
//  double convert_gch16_to_g64f(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.Char,System.Double>(System.Char)
  IL_0006: ret
}

}
Char convert_gch16_to_gch16(Char src)
{
//  Id := 100664602, Name := System.Char Z0.OpCodes.sconvert::convert_gch16_to_gch16(System.Char)
//  Char convert_gch16_to_gch16(Char src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Char Z0.Converter::convert<System.Char,System.Char>(System.Char)
  IL_0006: ret
}

}
byte convert_8i_to_8u(sbyte src)
{
//  Id := 100664437, Name := System.Byte Z0.OpCodes.sconvert::convert_8i_to_8u(System.SByte)
//  byte convert_8i_to_8u(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u1
  IL_0002: ret
}

}
byte convert_g8i_to_g8u(sbyte src)
{
//  Id := 100664438, Name := System.Byte Z0.OpCodes.sconvert::convert_g8i_to_g8u(System.SByte)
//  byte convert_g8i_to_g8u(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.SByte,System.Byte>(System.SByte)
  IL_0006: ret
}

}
sbyte convert_8i_to_8i(sbyte src)
{
//  Id := 100664439, Name := System.SByte Z0.OpCodes.sconvert::convert_8i_to_8i(System.SByte)
//  sbyte convert_8i_to_8i(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
byte convert_g8i_to_g8i(sbyte src)
{
//  Id := 100664440, Name := System.Byte Z0.OpCodes.sconvert::convert_g8i_to_g8i(System.SByte)
//  byte convert_g8i_to_g8i(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.SByte,System.Byte>(System.SByte)
  IL_0006: ret
}

}
short convert_8i_to_16i(sbyte src)
{
//  Id := 100664441, Name := System.Int16 Z0.OpCodes.sconvert::convert_8i_to_16i(System.SByte)
//  short convert_8i_to_16i(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
short convert_g8i_to_g16i(sbyte src)
{
//  Id := 100664442, Name := System.Int16 Z0.OpCodes.sconvert::convert_g8i_to_g16i(System.SByte)
//  short convert_g8i_to_g16i(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.SByte,System.Int16>(System.SByte)
  IL_0006: ret
}

}
ushort convert_8i_to_16u(sbyte src)
{
//  Id := 100664443, Name := System.UInt16 Z0.OpCodes.sconvert::convert_8i_to_16u(System.SByte)
//  ushort convert_8i_to_16u(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u2
  IL_0002: ret
}

}
ushort convert_g8i_to_g16u(sbyte src)
{
//  Id := 100664444, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g8i_to_g16u(System.SByte)
//  ushort convert_g8i_to_g16u(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.SByte,System.UInt16>(System.SByte)
  IL_0006: ret
}

}
int convert_8i_to_32i(sbyte src)
{
//  Id := 100664445, Name := System.Int32 Z0.OpCodes.sconvert::convert_8i_to_32i(System.SByte)
//  int convert_8i_to_32i(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
int convert_g8i_to_g32i(sbyte src)
{
//  Id := 100664446, Name := System.Int32 Z0.OpCodes.sconvert::convert_g8i_to_g32i(System.SByte)
//  int convert_g8i_to_g32i(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.SByte,System.Int32>(System.SByte)
  IL_0006: ret
}

}
uint convert_8i_to_g32(sbyte src)
{
//  Id := 100664447, Name := System.UInt32 Z0.OpCodes.sconvert::convert_8i_to_g32(System.SByte)
//  uint convert_8i_to_g32(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
uint convert_g8i_to_g32u(sbyte src)
{
//  Id := 100664448, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g8i_to_g32u(System.SByte)
//  uint convert_g8i_to_g32u(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.SByte,System.UInt32>(System.SByte)
  IL_0006: ret
}

}
long convert_8i_to_64i(sbyte src)
{
//  Id := 100664449, Name := System.Int64 Z0.OpCodes.sconvert::convert_8i_to_64i(System.SByte)
//  long convert_8i_to_64i(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i8
  IL_0002: ret
}

}
long convert_g8i_to_g64i(sbyte src)
{
//  Id := 100664450, Name := System.Int64 Z0.OpCodes.sconvert::convert_g8i_to_g64i(System.SByte)
//  long convert_g8i_to_g64i(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.SByte,System.Int64>(System.SByte)
  IL_0006: ret
}

}
ulong convert_8i_to_64u(sbyte src)
{
//  Id := 100664451, Name := System.UInt64 Z0.OpCodes.sconvert::convert_8i_to_64u(System.SByte)
//  ulong convert_8i_to_64u(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i8
  IL_0002: ret
}

}
ulong convert_g8i_to_g64u(sbyte src)
{
//  Id := 100664452, Name := System.UInt64 Z0.OpCodes.sconvert::convert_g8i_to_g64u(System.SByte)
//  ulong convert_g8i_to_g64u(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.SByte,System.UInt64>(System.SByte)
  IL_0006: ret
}

}
float convert_8i_to_32f(sbyte src)
{
//  Id := 100664453, Name := System.Single Z0.OpCodes.sconvert::convert_8i_to_32f(System.SByte)
//  float convert_8i_to_32f(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.r4
  IL_0002: ret
}

}
float convert_g8i_to_g32f(sbyte src)
{
//  Id := 100664454, Name := System.Single Z0.OpCodes.sconvert::convert_g8i_to_g32f(System.SByte)
//  float convert_g8i_to_g32f(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.SByte,System.Single>(System.SByte)
  IL_0006: ret
}

}
double convert_8i_to_64f(sbyte src)
{
//  Id := 100664455, Name := System.Double Z0.OpCodes.sconvert::convert_8i_to_64f(System.SByte)
//  double convert_8i_to_64f(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.r8
  IL_0002: ret
}

}
double convert_g8i_to_g64f(sbyte src)
{
//  Id := 100664456, Name := System.Double Z0.OpCodes.sconvert::convert_g8i_to_g64f(System.SByte)
//  double convert_g8i_to_g64f(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.SByte,System.Double>(System.SByte)
  IL_0006: ret
}

}
Char convert_8i_to_ch16(sbyte src)
{
//  Id := 100664457, Name := System.Char Z0.OpCodes.sconvert::convert_8i_to_ch16(System.SByte)
//  Char convert_8i_to_ch16(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u2
  IL_0002: ret
}

}
Char convert_g8i_to_gch16(sbyte src)
{
//  Id := 100664458, Name := System.Char Z0.OpCodes.sconvert::convert_g8i_to_gch16(System.SByte)
//  Char convert_g8i_to_gch16(sbyte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Char Z0.Converter::convert<System.SByte,System.Char>(System.SByte)
  IL_0006: ret
}

}
short convert_8u_to_16i(byte src)
{
//  Id := 100664462, Name := System.Int16 Z0.OpCodes.sconvert::convert_8u_to_16i(System.Byte)
//  short convert_8u_to_16i(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
short convert_g8u_to_g16i(byte src)
{
//  Id := 100664463, Name := System.Int16 Z0.OpCodes.sconvert::convert_g8u_to_g16i(System.Byte)
//  short convert_g8u_to_g16i(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.Byte,System.Int16>(System.Byte)
  IL_0006: ret
}

}
ushort convert_8u_to_16u(byte src)
{
//  Id := 100664464, Name := System.UInt16 Z0.OpCodes.sconvert::convert_8u_to_16u(System.Byte)
//  ushort convert_8u_to_16u(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
ushort convert_g8u_to_g16u(byte src)
{
//  Id := 100664465, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g8u_to_g16u(System.Byte)
//  ushort convert_g8u_to_g16u(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.Byte,System.UInt16>(System.Byte)
  IL_0006: ret
}

}
int convert_g8u_to_g32i(byte src)
{
//  Id := 100664466, Name := System.Int32 Z0.OpCodes.sconvert::convert_g8u_to_g32i(System.Byte)
//  int convert_g8u_to_g32i(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.Byte,System.Int32>(System.Byte)
  IL_0006: ret
}

}
uint convert_g8u_to_g32u(byte src)
{
//  Id := 100664467, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g8u_to_g32u(System.Byte)
//  uint convert_g8u_to_g32u(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.Byte,System.UInt32>(System.Byte)
  IL_0006: ret
}

}
long convert_8u_to_g64i(byte src)
{
//  Id := 100664468, Name := System.Int64 Z0.OpCodes.sconvert::convert_8u_to_g64i(System.Byte)
//  long convert_8u_to_g64i(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.Byte)
  IL_0006: ret
}

}
long convert_g8u_to_g64i(byte src)
{
//  Id := 100664469, Name := System.Int64 Z0.OpCodes.sconvert::convert_g8u_to_g64i(System.Byte)
//  long convert_g8u_to_g64i(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.Byte,System.Int64>(System.Byte)
  IL_0006: ret
}

}
ulong convert_g8u_to_g64u(byte src)
{
//  Id := 100664470, Name := System.UInt64 Z0.OpCodes.sconvert::convert_g8u_to_g64u(System.Byte)
//  ulong convert_g8u_to_g64u(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.Byte,System.UInt64>(System.Byte)
  IL_0006: ret
}

}
float convert_g8u_to_g32f(byte src)
{
//  Id := 100664471, Name := System.Single Z0.OpCodes.sconvert::convert_g8u_to_g32f(System.Byte)
//  float convert_g8u_to_g32f(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.Byte,System.Single>(System.Byte)
  IL_0006: ret
}

}
double convert_g8u_to_g64f(byte src)
{
//  Id := 100664472, Name := System.Double Z0.OpCodes.sconvert::convert_g8u_to_g64f(System.Byte)
//  double convert_g8u_to_g64f(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.Byte,System.Double>(System.Byte)
  IL_0006: ret
}

}
Char convert_g8u_to_gch16(byte src)
{
//  Id := 100664473, Name := System.Char Z0.OpCodes.sconvert::convert_g8u_to_gch16(System.Byte)
//  Char convert_g8u_to_gch16(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Char Z0.Converter::convert<System.Byte,System.Char>(System.Byte)
  IL_0006: ret
}

}
byte convert_g16i_to_g8u(short src)
{
//  Id := 100664474, Name := System.Byte Z0.OpCodes.sconvert::convert_g16i_to_g8u(System.Int16)
//  byte convert_g16i_to_g8u(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.Int16,System.Byte>(System.Int16)
  IL_0006: ret
}

}
sbyte convert_g16i_to_g8i(short src)
{
//  Id := 100664475, Name := System.SByte Z0.OpCodes.sconvert::convert_g16i_to_g8i(System.Int16)
//  sbyte convert_g16i_to_g8i(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.Int16,System.SByte>(System.Int16)
  IL_0006: ret
}

}
ushort convert_g16i_to_g16u(short src)
{
//  Id := 100664476, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g16i_to_g16u(System.Int16)
//  ushort convert_g16i_to_g16u(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.Int16,System.UInt16>(System.Int16)
  IL_0006: ret
}

}
short convert_g16i_to_g16i(short src)
{
//  Id := 100664477, Name := System.Int16 Z0.OpCodes.sconvert::convert_g16i_to_g16i(System.Int16)
//  short convert_g16i_to_g16i(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.Int16,System.Int16>(System.Int16)
  IL_0006: ret
}

}
int convert_g16i_to_g32i(short src)
{
//  Id := 100664478, Name := System.Int32 Z0.OpCodes.sconvert::convert_g16i_to_g32i(System.Int16)
//  int convert_g16i_to_g32i(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.Int16,System.Int32>(System.Int16)
  IL_0006: ret
}

}
uint convert_g16i_to_g32u(short src)
{
//  Id := 100664479, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g16i_to_g32u(System.Int16)
//  uint convert_g16i_to_g32u(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.Int16,System.UInt32>(System.Int16)
  IL_0006: ret
}

}
long convert_g16i_to_g64i(short src)
{
//  Id := 100664480, Name := System.Int64 Z0.OpCodes.sconvert::convert_g16i_to_g64i(System.Int16)
//  long convert_g16i_to_g64i(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.Int16,System.Int64>(System.Int16)
  IL_0006: ret
}

}
ulong convert_g16i_to_g64u(short src)
{
//  Id := 100664481, Name := System.UInt64 Z0.OpCodes.sconvert::convert_g16i_to_g64u(System.Int16)
//  ulong convert_g16i_to_g64u(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.Int16,System.UInt64>(System.Int16)
  IL_0006: ret
}

}
float convert_g16i_to_g32f(short src)
{
//  Id := 100664482, Name := System.Single Z0.OpCodes.sconvert::convert_g16i_to_g32f(System.Int16)
//  float convert_g16i_to_g32f(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.Int16,System.Single>(System.Int16)
  IL_0006: ret
}

}
double convert_g16i_to_g64f(short src)
{
//  Id := 100664483, Name := System.Double Z0.OpCodes.sconvert::convert_g16i_to_g64f(System.Int16)
//  double convert_g16i_to_g64f(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.Int16,System.Double>(System.Int16)
  IL_0006: ret
}

}
Char convert_g16i_to_gch16(short src)
{
//  Id := 100664484, Name := System.Char Z0.OpCodes.sconvert::convert_g16i_to_gch16(System.Int16)
//  Char convert_g16i_to_gch16(short src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Char Z0.Converter::convert<System.Int16,System.Char>(System.Int16)
  IL_0006: ret
}

}
sbyte convert_16u_to_g8i(ushort src)
{
//  Id := 100664485, Name := System.SByte Z0.OpCodes.sconvert::convert_16u_to_g8i(System.UInt16)
//  sbyte convert_16u_to_g8i(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.UInt16,System.SByte>(System.UInt16)
  IL_0006: ret
}

}
byte convert_g16u_to_g8u(ushort src)
{
//  Id := 100664486, Name := System.Byte Z0.OpCodes.sconvert::convert_g16u_to_g8u(System.UInt16)
//  byte convert_g16u_to_g8u(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.UInt16,System.Byte>(System.UInt16)
  IL_0006: ret
}

}
short convert_g16u_to_g16i(ushort src)
{
//  Id := 100664487, Name := System.Int16 Z0.OpCodes.sconvert::convert_g16u_to_g16i(System.UInt16)
//  short convert_g16u_to_g16i(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.UInt16,System.Int16>(System.UInt16)
  IL_0006: ret
}

}
ushort convert_g16u_to_g16u(ushort src)
{
//  Id := 100664488, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g16u_to_g16u(System.UInt16)
//  ushort convert_g16u_to_g16u(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16,System.UInt16>(System.UInt16)
  IL_0006: ret
}

}
int convert_g16u_to_g32i(ushort src)
{
//  Id := 100664489, Name := System.Int32 Z0.OpCodes.sconvert::convert_g16u_to_g32i(System.UInt16)
//  int convert_g16u_to_g32i(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.UInt16,System.Int32>(System.UInt16)
  IL_0006: ret
}

}
uint convert_g16u_to_g32u(ushort src)
{
//  Id := 100664490, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g16u_to_g32u(System.UInt16)
//  uint convert_g16u_to_g32u(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt16,System.UInt32>(System.UInt16)
  IL_0006: ret
}

}
long convert_g16u_to_g64i(ushort src)
{
//  Id := 100664491, Name := System.Int64 Z0.OpCodes.sconvert::convert_g16u_to_g64i(System.UInt16)
//  long convert_g16u_to_g64i(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.UInt16,System.Int64>(System.UInt16)
  IL_0006: ret
}

}
float convert_g16u_to_g32f(ushort src)
{
//  Id := 100664492, Name := System.Single Z0.OpCodes.sconvert::convert_g16u_to_g32f(System.UInt16)
//  float convert_g16u_to_g32f(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.UInt16,System.Single>(System.UInt16)
  IL_0006: ret
}

}
double convert_g16u_to_g64f(ushort src)
{
//  Id := 100664493, Name := System.Double Z0.OpCodes.sconvert::convert_g16u_to_g64f(System.UInt16)
//  double convert_g16u_to_g64f(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.UInt16,System.Double>(System.UInt16)
  IL_0006: ret
}

}
sbyte convert_32i_to_gi(int src)
{
//  Id := 100664494, Name := System.SByte Z0.OpCodes.sconvert::convert_32i_to_gi(System.Int32)
//  sbyte convert_32i_to_gi(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i1
  IL_0002: ret
}

}
sbyte convert_g32i_to_g8i(int src)
{
//  Id := 100664495, Name := System.SByte Z0.OpCodes.sconvert::convert_g32i_to_g8i(System.Int32)
//  sbyte convert_g32i_to_g8i(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.Int32,System.SByte>(System.Int32)
  IL_0006: ret
}

}
byte convert_32i_to_8u(int src)
{
//  Id := 100664496, Name := System.Byte Z0.OpCodes.sconvert::convert_32i_to_8u(System.Int32)
//  byte convert_32i_to_8u(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u1
  IL_0002: ret
}

}
byte convert_g32i_to_g8u(int src)
{
//  Id := 100664497, Name := System.Byte Z0.OpCodes.sconvert::convert_g32i_to_g8u(System.Int32)
//  byte convert_g32i_to_g8u(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.Int32,System.Byte>(System.Int32)
  IL_0006: ret
}

}
short convert_32i_to_16i(int src)
{
//  Id := 100664498, Name := System.Int16 Z0.OpCodes.sconvert::convert_32i_to_16i(System.Int32)
//  short convert_32i_to_16i(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i2
  IL_0002: ret
}

}
short convert_g32i_to_g16i(int src)
{
//  Id := 100664499, Name := System.Int16 Z0.OpCodes.sconvert::convert_g32i_to_g16i(System.Int32)
//  short convert_g32i_to_g16i(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.Int32,System.Int16>(System.Int32)
  IL_0006: ret
}

}
ushort convert_32i_to_16u(int src)
{
//  Id := 100664500, Name := System.UInt16 Z0.OpCodes.sconvert::convert_32i_to_16u(System.Int32)
//  ushort convert_32i_to_16u(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u2
  IL_0002: ret
}

}
ushort convert_g32i_to_g16u(int src)
{
//  Id := 100664501, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g32i_to_g16u(System.Int32)
//  ushort convert_g32i_to_g16u(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.Int32,System.UInt16>(System.Int32)
  IL_0006: ret
}

}
int convert_32i_to_32i(int src)
{
//  Id := 100664502, Name := System.Int32 Z0.OpCodes.sconvert::convert_32i_to_32i(System.Int32)
//  int convert_32i_to_32i(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
int convert_g32i_to_g32i(int src)
{
//  Id := 100664503, Name := System.Int32 Z0.OpCodes.sconvert::convert_g32i_to_g32i(System.Int32)
//  int convert_g32i_to_g32i(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.Int32,System.Int32>(System.Int32)
  IL_0006: ret
}

}
uint convert_32i_to_32u(int src)
{
//  Id := 100664504, Name := System.UInt32 Z0.OpCodes.sconvert::convert_32i_to_32u(System.Int32)
//  uint convert_32i_to_32u(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
uint convert_g32i_to_g32u(int src)
{
//  Id := 100664505, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g32i_to_g32u(System.Int32)
//  uint convert_g32i_to_g32u(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.Int32,System.UInt32>(System.Int32)
  IL_0006: ret
}

}
long convert_32i_to_64i(int src)
{
//  Id := 100664506, Name := System.Int64 Z0.OpCodes.sconvert::convert_32i_to_64i(System.Int32)
//  long convert_32i_to_64i(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i8
  IL_0002: ret
}

}
long convert_g32i_to_g64i(int src)
{
//  Id := 100664507, Name := System.Int64 Z0.OpCodes.sconvert::convert_g32i_to_g64i(System.Int32)
//  long convert_g32i_to_g64i(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.Int32,System.Int64>(System.Int32)
  IL_0006: ret
}

}
ulong convert_32i_to_64u(int src)
{
//  Id := 100664508, Name := System.UInt64 Z0.OpCodes.sconvert::convert_32i_to_64u(System.Int32)
//  ulong convert_32i_to_64u(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i8
  IL_0002: ret
}

}
ulong convert_g32i_to_g64u(int src)
{
//  Id := 100664509, Name := System.UInt64 Z0.OpCodes.sconvert::convert_g32i_to_g64u(System.Int32)
//  ulong convert_g32i_to_g64u(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.Int32,System.UInt64>(System.Int32)
  IL_0006: ret
}

}
float convert_32i_to_32f(int src)
{
//  Id := 100664510, Name := System.Single Z0.OpCodes.sconvert::convert_32i_to_32f(System.Int32)
//  float convert_32i_to_32f(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.r4
  IL_0002: ret
}

}
float convert_g32i_to_g32f(int src)
{
//  Id := 100664511, Name := System.Single Z0.OpCodes.sconvert::convert_g32i_to_g32f(System.Int32)
//  float convert_g32i_to_g32f(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.Int32,System.Single>(System.Int32)
  IL_0006: ret
}

}
double convert_32i_to_64f(int src)
{
//  Id := 100664512, Name := System.Double Z0.OpCodes.sconvert::convert_32i_to_64f(System.Int32)
//  double convert_32i_to_64f(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.r8
  IL_0002: ret
}

}
double convert_g32i_to_g64f(int src)
{
//  Id := 100664513, Name := System.Double Z0.OpCodes.sconvert::convert_g32i_to_g64f(System.Int32)
//  double convert_g32i_to_g64f(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.Int32,System.Double>(System.Int32)
  IL_0006: ret
}

}
Char convert_32i_to_ch16(int src)
{
//  Id := 100664514, Name := System.Char Z0.OpCodes.sconvert::convert_32i_to_ch16(System.Int32)
//  Char convert_32i_to_ch16(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u2
  IL_0002: ret
}

}
Char convert_g32i_to_gch16(int src)
{
//  Id := 100664515, Name := System.Char Z0.OpCodes.sconvert::convert_g32i_to_gch16(System.Int32)
//  Char convert_g32i_to_gch16(int src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Char Z0.Converter::convert<System.Int32,System.Char>(System.Int32)
  IL_0006: ret
}

}
sbyte convert_32u_to_8i(uint src)
{
//  Id := 100664516, Name := System.SByte Z0.OpCodes.sconvert::convert_32u_to_8i(System.UInt32)
//  sbyte convert_32u_to_8i(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i1
  IL_0002: ret
}

}
sbyte convert_g32u_to_g8i(uint src)
{
//  Id := 100664517, Name := System.SByte Z0.OpCodes.sconvert::convert_g32u_to_g8i(System.UInt32)
//  sbyte convert_g32u_to_g8i(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.UInt32,System.SByte>(System.UInt32)
  IL_0006: ret
}

}
byte convert_32u_to_8u(uint src)
{
//  Id := 100664518, Name := System.Byte Z0.OpCodes.sconvert::convert_32u_to_8u(System.UInt32)
//  byte convert_32u_to_8u(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u1
  IL_0002: ret
}

}
byte convert_g32u_to_g8u(uint src)
{
//  Id := 100664519, Name := System.Byte Z0.OpCodes.sconvert::convert_g32u_to_g8u(System.UInt32)
//  byte convert_g32u_to_g8u(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.UInt32,System.Byte>(System.UInt32)
  IL_0006: ret
}

}
short convert_32u_to_16i(uint src)
{
//  Id := 100664520, Name := System.Int16 Z0.OpCodes.sconvert::convert_32u_to_16i(System.UInt32)
//  short convert_32u_to_16i(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.i2
  IL_0002: ret
}

}
short convert_g32u_to_g16i(uint src)
{
//  Id := 100664521, Name := System.Int16 Z0.OpCodes.sconvert::convert_g32u_to_g16i(System.UInt32)
//  short convert_g32u_to_g16i(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.UInt32,System.Int16>(System.UInt32)
  IL_0006: ret
}

}
ushort convert_32u_to_16u(uint src)
{
//  Id := 100664522, Name := System.UInt16 Z0.OpCodes.sconvert::convert_32u_to_16u(System.UInt32)
//  ushort convert_32u_to_16u(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u2
  IL_0002: ret
}

}
ushort convert_g32u_to_g16u(uint src)
{
//  Id := 100664523, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g32u_to_g16u(System.UInt32)
//  ushort convert_g32u_to_g16u(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt32,System.UInt16>(System.UInt32)
  IL_0006: ret
}

}
int convert_32u_to_32i(uint src)
{
//  Id := 100664524, Name := System.Int32 Z0.OpCodes.sconvert::convert_32u_to_32i(System.UInt32)
//  int convert_32u_to_32i(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
int convert_g32u_to_g32i(uint src)
{
//  Id := 100664525, Name := System.Int32 Z0.OpCodes.sconvert::convert_g32u_to_g32i(System.UInt32)
//  int convert_g32u_to_g32i(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.UInt32,System.Int32>(System.UInt32)
  IL_0006: ret
}

}
uint convert_32u_to_32u(uint src)
{
//  Id := 100664526, Name := System.UInt32 Z0.OpCodes.sconvert::convert_32u_to_32u(System.UInt32)
//  uint convert_32u_to_32u(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ret
}

}
uint convert_g32u_to_g32u(uint src)
{
//  Id := 100664527, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g32u_to_g32u(System.UInt32)
//  uint convert_g32u_to_g32u(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32,System.UInt32>(System.UInt32)
  IL_0006: ret
}

}
long convert_32u_to_64i(uint src)
{
//  Id := 100664528, Name := System.Int64 Z0.OpCodes.sconvert::convert_32u_to_64i(System.UInt32)
//  long convert_32u_to_64i(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u8
  IL_0002: ret
}

}
long convert_g32u_to_g64i(uint src)
{
//  Id := 100664529, Name := System.Int64 Z0.OpCodes.sconvert::convert_g32u_to_g64i(System.UInt32)
//  long convert_g32u_to_g64i(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.UInt32,System.Int64>(System.UInt32)
  IL_0006: ret
}

}
ulong convert_32u_to_64u(uint src)
{
//  Id := 100664530, Name := System.UInt64 Z0.OpCodes.sconvert::convert_32u_to_64u(System.UInt32)
//  ulong convert_32u_to_64u(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u8
  IL_0002: ret
}

}
ulong convert_g32u_to_g64u(uint src)
{
//  Id := 100664531, Name := System.UInt64 Z0.OpCodes.sconvert::convert_g32u_to_g64u(System.UInt32)
//  ulong convert_g32u_to_g64u(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt32,System.UInt64>(System.UInt32)
  IL_0006: ret
}

}
float convert_32u_to_32f(uint src)
{
//  Id := 100664532, Name := System.Single Z0.OpCodes.sconvert::convert_32u_to_32f(System.UInt32)
//  float convert_32u_to_32f(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.r.un
  IL_0002: conv.r4
  IL_0003: ret
}

}
float convert_g32u_to_g32f(uint src)
{
//  Id := 100664533, Name := System.Single Z0.OpCodes.sconvert::convert_g32u_to_g32f(System.UInt32)
//  float convert_g32u_to_g32f(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.UInt32,System.Single>(System.UInt32)
  IL_0006: ret
}

}
double convert_32u_to_64f(uint src)
{
//  Id := 100664534, Name := System.Double Z0.OpCodes.sconvert::convert_32u_to_64f(System.UInt32)
//  double convert_32u_to_64f(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.r.un
  IL_0002: conv.r8
  IL_0003: ret
}

}
double convert_g32u_to_g64f(uint src)
{
//  Id := 100664535, Name := System.Double Z0.OpCodes.sconvert::convert_g32u_to_g64f(System.UInt32)
//  double convert_g32u_to_g64f(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.UInt32,System.Double>(System.UInt32)
  IL_0006: ret
}

}
Char convert_32u_to_ch(uint src)
{
//  Id := 100664536, Name := System.Char Z0.OpCodes.sconvert::convert_32u_to_ch(System.UInt32)
//  Char convert_32u_to_ch(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u2
  IL_0002: ret
}

}
Char convert_g32u_to_gch16(uint src)
{
//  Id := 100664537, Name := System.Char Z0.OpCodes.sconvert::convert_g32u_to_gch16(System.UInt32)
//  Char convert_g32u_to_gch16(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Char Z0.Converter::convert<System.UInt32,System.Char>(System.UInt32)
  IL_0006: ret
}

}
byte convert_g64i_to_g8u(long src)
{
//  Id := 100664538, Name := System.Byte Z0.OpCodes.sconvert::convert_g64i_to_g8u(System.Int64)
//  byte convert_g64i_to_g8u(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.Int64,System.Byte>(System.Int64)
  IL_0006: ret
}

}
sbyte convert_g64i_to_g8i(long src)
{
//  Id := 100664539, Name := System.SByte Z0.OpCodes.sconvert::convert_g64i_to_g8i(System.Int64)
//  sbyte convert_g64i_to_g8i(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.Int64,System.SByte>(System.Int64)
  IL_0006: ret
}

}
ushort convert_g64i_to_g16u(long src)
{
//  Id := 100664540, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g64i_to_g16u(System.Int64)
//  ushort convert_g64i_to_g16u(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.Int64,System.UInt16>(System.Int64)
  IL_0006: ret
}

}
short convert_g64i_to_g16i(long src)
{
//  Id := 100664541, Name := System.Int16 Z0.OpCodes.sconvert::convert_g64i_to_g16i(System.Int64)
//  short convert_g64i_to_g16i(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.Int64,System.Int16>(System.Int64)
  IL_0006: ret
}

}
int convert_g64i_to_g32i(long src)
{
//  Id := 100664542, Name := System.Int32 Z0.OpCodes.sconvert::convert_g64i_to_g32i(System.Int64)
//  int convert_g64i_to_g32i(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.Int64,System.Int32>(System.Int64)
  IL_0006: ret
}

}
uint convert_g64i_to_g32u(long src)
{
//  Id := 100664543, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g64i_to_g32u(System.Int64)
//  uint convert_g64i_to_g32u(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.Int64,System.UInt32>(System.Int64)
  IL_0006: ret
}

}
long convert_g64i_to_g64i(long src)
{
//  Id := 100664544, Name := System.Int64 Z0.OpCodes.sconvert::convert_g64i_to_g64i(System.Int64)
//  long convert_g64i_to_g64i(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.Int64,System.Int64>(System.Int64)
  IL_0006: ret
}

}
ulong convert_g64i_to_g64u(long src)
{
//  Id := 100664545, Name := System.UInt64 Z0.OpCodes.sconvert::convert_g64i_to_g64u(System.Int64)
//  ulong convert_g64i_to_g64u(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.Int64,System.UInt64>(System.Int64)
  IL_0006: ret
}

}
float convert_g64i_to_g32f(long src)
{
//  Id := 100664546, Name := System.Single Z0.OpCodes.sconvert::convert_g64i_to_g32f(System.Int64)
//  float convert_g64i_to_g32f(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.Int64,System.Single>(System.Int64)
  IL_0006: ret
}

}
double convert_g64i_to_g64f(long src)
{
//  Id := 100664547, Name := System.Double Z0.OpCodes.sconvert::convert_g64i_to_g64f(System.Int64)
//  double convert_g64i_to_g64f(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.Int64,System.Double>(System.Int64)
  IL_0006: ret
}

}
Char convert_g64i_to_gch16(long src)
{
//  Id := 100664548, Name := System.Char Z0.OpCodes.sconvert::convert_g64i_to_gch16(System.Int64)
//  Char convert_g64i_to_gch16(long src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Char Z0.Converter::convert<System.Int64,System.Char>(System.Int64)
  IL_0006: ret
}

}
sbyte convert_g64u_to_g8i(ulong src)
{
//  Id := 100664549, Name := System.SByte Z0.OpCodes.sconvert::convert_g64u_to_g8i(System.UInt64)
//  sbyte convert_g64u_to_g8i(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.UInt64,System.SByte>(System.UInt64)
  IL_0006: ret
}

}
byte convert_g64u_to_g8u(ulong src)
{
//  Id := 100664550, Name := System.Byte Z0.OpCodes.sconvert::convert_g64u_to_g8u(System.UInt64)
//  byte convert_g64u_to_g8u(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.UInt64,System.Byte>(System.UInt64)
  IL_0006: ret
}

}
short convert_g64u_to_g16i(ulong src)
{
//  Id := 100664551, Name := System.Int16 Z0.OpCodes.sconvert::convert_g64u_to_g16i(System.UInt64)
//  short convert_g64u_to_g16i(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.UInt64,System.Int16>(System.UInt64)
  IL_0006: ret
}

}
ushort convert_g64u_to_g16u(ulong src)
{
//  Id := 100664552, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g64u_to_g16u(System.UInt64)
//  ushort convert_g64u_to_g16u(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt64,System.UInt16>(System.UInt64)
  IL_0006: ret
}

}
int convert_g64u_to_g32i(ulong src)
{
//  Id := 100664553, Name := System.Int32 Z0.OpCodes.sconvert::convert_g64u_to_g32i(System.UInt64)
//  int convert_g64u_to_g32i(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int32 Z0.Converter::convert<System.UInt64,System.Int32>(System.UInt64)
  IL_0006: ret
}

}
uint convert_64u_to_32u(ulong src)
{
//  Id := 100664554, Name := System.UInt32 Z0.OpCodes.sconvert::convert_64u_to_32u(System.UInt64)
//  uint convert_64u_to_32u(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.u4
  IL_0002: ret
}

}
uint convert_g64u_to_g32u(ulong src)
{
//  Id := 100664555, Name := System.UInt32 Z0.OpCodes.sconvert::convert_g64u_to_g32u(System.UInt64)
//  uint convert_g64u_to_g32u(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt64,System.UInt32>(System.UInt64)
  IL_0006: ret
}

}
long convert_g64u_to_g64i(ulong src)
{
//  Id := 100664556, Name := System.Int64 Z0.OpCodes.sconvert::convert_g64u_to_g64i(System.UInt64)
//  long convert_g64u_to_g64i(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int64 Z0.Converter::convert<System.UInt64,System.Int64>(System.UInt64)
  IL_0006: ret
}

}
ulong convert_g64u_to_g64u(ulong src)
{
//  Id := 100664557, Name := System.UInt64 Z0.OpCodes.sconvert::convert_g64u_to_g64u(System.UInt64)
//  ulong convert_g64u_to_g64u(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64,System.UInt64>(System.UInt64)
  IL_0006: ret
}

}
float convert_g64u_to_g32f(ulong src)
{
//  Id := 100664558, Name := System.Single Z0.OpCodes.sconvert::convert_g64u_to_g32f(System.UInt64)
//  float convert_g64u_to_g32f(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Single Z0.Converter::convert<System.UInt64,System.Single>(System.UInt64)
  IL_0006: ret
}

}
double convert_64u_to_64f(ulong src)
{
//  Id := 100664559, Name := System.Double Z0.OpCodes.sconvert::convert_64u_to_64f(System.UInt64)
//  double convert_64u_to_64f(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: conv.r8
  IL_0002: ret
}

}
double convert_g64u_to_g64f(ulong src)
{
//  Id := 100664560, Name := System.Double Z0.OpCodes.sconvert::convert_g64u_to_g64f(System.UInt64)
//  double convert_g64u_to_g64f(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Double Z0.Converter::convert<System.UInt64,System.Double>(System.UInt64)
  IL_0006: ret
}

}
sbyte convert_g32f_to_g8i(float src)
{
//  Id := 100664561, Name := System.SByte Z0.OpCodes.sconvert::convert_g32f_to_g8i(System.Single)
//  sbyte convert_g32f_to_g8i(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.SByte Z0.Converter::convert<System.Single,System.SByte>(System.Single)
  IL_0006: ret
}

}
byte convert_g32f_to_g8u(float src)
{
//  Id := 100664562, Name := System.Byte Z0.OpCodes.sconvert::convert_g32f_to_g8u(System.Single)
//  byte convert_g32f_to_g8u(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte Z0.Converter::convert<System.Single,System.Byte>(System.Single)
  IL_0006: ret
}

}
short convert_g32f_to_g16i(float src)
{
//  Id := 100664563, Name := System.Int16 Z0.OpCodes.sconvert::convert_g32f_to_g16i(System.Single)
//  short convert_g32f_to_g16i(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Int16 Z0.Converter::convert<System.Single,System.Int16>(System.Single)
  IL_0006: ret
}

}
ushort convert_g32f_to_g16u(float src)
{
//  Id := 100664564, Name := System.UInt16 Z0.OpCodes.sconvert::convert_g32f_to_g16u(System.Single)
//  ushort convert_g32f_to_g16u(float src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.UInt16 Z0.Converter::convert<System.Single,System.UInt16>(System.Single)
  IL_0006: ret
}

}
