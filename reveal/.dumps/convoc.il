// 2019-11-02 09:11:45:780
int convert_g32f_to_g32i(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Single,System.Int32>(System.Single)
    IL_0006: ret

}
uint convert_g32f_to_g32u(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.Single,System.UInt32>(System.Single)
    IL_0006: ret

}
long convert_g32f_to_g64i(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Single,System.Int64>(System.Single)
    IL_0006: ret

}
ulong convert_g32f_to_g64u(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.Single,System.UInt64>(System.Single)
    IL_0006: ret

}
float convert_g32f_to_g32f(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single,System.Single>(System.Single)
    IL_0006: ret

}
double convert_g32f_to_g64f(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Single,System.Double>(System.Single)
    IL_0006: ret

}
Char convert_g32f_to_gch16(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Single,System.Char>(System.Single)
    IL_0006: ret

}
sbyte convert_64f_to_8i(double src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_64f_to_g8i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.Double)
    IL_0006: ret

}
sbyte convert_g64f_to_g8i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.Double,System.SByte>(System.Double)
    IL_0006: ret

}
byte convert_64f_to_8u(double src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: conv.u1
    IL_0003: ret

}
byte convert_g64f_to_g8u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Double,System.Byte>(System.Double)
    IL_0006: ret

}
short convert_64f_to_16i(double src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i2
    IL_0002: ret

}
short convert_g64f_to_g16i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Double,System.Int16>(System.Double)
    IL_0006: ret

}
ushort convert_64f_to_g16u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.Double)
    IL_0006: ret

}
ushort convert_g64f_to_g16u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.Double,System.UInt16>(System.Double)
    IL_0006: ret

}
int convert_g64f_to_g32i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Double,System.Int32>(System.Double)
    IL_0006: ret

}
uint convert_64f_to_g32u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.Double)
    IL_0006: ret

}
uint convert_g64f_to_g32u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.Double,System.UInt32>(System.Double)
    IL_0006: ret

}
long convert_g64f_to_g64i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Double,System.Int64>(System.Double)
    IL_0006: ret

}
ulong convert_g64f_to_g64u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.Double,System.UInt64>(System.Double)
    IL_0006: ret

}
float convert_g64f_to_g32f(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Double,System.Single>(System.Double)
    IL_0006: ret

}
double convert_g64f_to_g64f(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double,System.Double>(System.Double)
    IL_0006: ret

}
Char convert_g64f_to_gch16(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Double,System.Char>(System.Double)
    IL_0006: ret

}
sbyte convert_ch16_to_8i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_gch16_to_g8i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.Char,System.SByte>(System.Char)
    IL_0006: ret

}
byte convert_gch16_to_g8u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Char,System.Byte>(System.Char)
    IL_0006: ret

}
short convert_ch16_to_16i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i2
    IL_0002: ret

}
short convert_gch16_to_g16i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Char,System.Int16>(System.Char)
    IL_0006: ret

}
ushort convert_ch16_to_16u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
ushort convert_gch16_to_g16u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.Char,System.UInt16>(System.Char)
    IL_0006: ret

}
int convert_gch16_to_g32i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Char,System.Int32>(System.Char)
    IL_0006: ret

}
uint convert_gch16_to_g32u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.Char,System.UInt32>(System.Char)
    IL_0006: ret

}
long convert_gch16_to_g64i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Char,System.Int64>(System.Char)
    IL_0006: ret

}
ulong convert_gch16_to_g64u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.Char,System.UInt64>(System.Char)
    IL_0006: ret

}
float convert_gch16_to_g32f(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Char,System.Single>(System.Char)
    IL_0006: ret

}
double convert_gch16_to_g64f(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Char,System.Double>(System.Char)
    IL_0006: ret

}
Char convert_gch16_to_gch16(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char,System.Char>(System.Char)
    IL_0006: ret

}
byte convert_8i_to_8u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ret

}
byte convert_g8i_to_g8u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.SByte,System.Byte>(System.SByte)
    IL_0006: ret

}
sbyte convert_8i_to_8i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
byte convert_g8i_to_g8i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.SByte,System.Byte>(System.SByte)
    IL_0006: ret

}
short convert_8i_to_16i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
short convert_g8i_to_g16i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.SByte,System.Int16>(System.SByte)
    IL_0006: ret

}
ushort convert_8i_to_16u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
ushort convert_g8i_to_g16u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.SByte,System.UInt16>(System.SByte)
    IL_0006: ret

}
int convert_8i_to_32i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
int convert_g8i_to_g32i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.SByte,System.Int32>(System.SByte)
    IL_0006: ret

}
uint convert_8i_to_g32(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
uint convert_g8i_to_g32u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.SByte,System.UInt32>(System.SByte)
    IL_0006: ret

}
long convert_8i_to_64i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
long convert_g8i_to_g64i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.SByte,System.Int64>(System.SByte)
    IL_0006: ret

}
ulong convert_8i_to_64u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
ulong convert_g8i_to_g64u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.SByte,System.UInt64>(System.SByte)
    IL_0006: ret

}
float convert_8i_to_32f(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: ret

}
float convert_g8i_to_g32f(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.SByte,System.Single>(System.SByte)
    IL_0006: ret

}
double convert_8i_to_64f(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ret

}
double convert_g8i_to_g64f(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.SByte,System.Double>(System.SByte)
    IL_0006: ret

}
Char convert_8i_to_ch16(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
Char convert_g8i_to_gch16(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.SByte,System.Char>(System.SByte)
    IL_0006: ret

}
sbyte convert_8u_to_8i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_g8u_to_g8i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.Byte,System.SByte>(System.Byte)
    IL_0006: ret

}
byte convert_g8u_to_g8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte,System.Byte>(System.Byte)
    IL_0006: ret

}
short convert_8u_to_16i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
short convert_g8u_to_g16i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Byte,System.Int16>(System.Byte)
    IL_0006: ret

}
ushort convert_8u_to_16u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
ushort convert_g8u_to_g16u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.Byte,System.UInt16>(System.Byte)
    IL_0006: ret

}
int convert_g8u_to_g32i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Byte,System.Int32>(System.Byte)
    IL_0006: ret

}
uint convert_g8u_to_g32u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.Byte,System.UInt32>(System.Byte)
    IL_0006: ret

}
long convert_8u_to_g64i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.Byte)
    IL_0006: ret

}
long convert_g8u_to_g64i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Byte,System.Int64>(System.Byte)
    IL_0006: ret

}
ulong convert_g8u_to_g64u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.Byte,System.UInt64>(System.Byte)
    IL_0006: ret

}
float convert_g8u_to_g32f(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Byte,System.Single>(System.Byte)
    IL_0006: ret

}
double convert_g8u_to_g64f(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Byte,System.Double>(System.Byte)
    IL_0006: ret

}
Char convert_g8u_to_gch16(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Byte,System.Char>(System.Byte)
    IL_0006: ret

}
byte convert_g16i_to_g8u(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Int16,System.Byte>(System.Int16)
    IL_0006: ret

}
sbyte convert_g16i_to_g8i(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.Int16,System.SByte>(System.Int16)
    IL_0006: ret

}
ushort convert_g16i_to_g16u(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.Int16,System.UInt16>(System.Int16)
    IL_0006: ret

}
short convert_g16i_to_g16i(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16,System.Int16>(System.Int16)
    IL_0006: ret

}
int convert_g16i_to_g32i(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int16,System.Int32>(System.Int16)
    IL_0006: ret

}
uint convert_g16i_to_g32u(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.Int16,System.UInt32>(System.Int16)
    IL_0006: ret

}
long convert_g16i_to_g64i(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int16,System.Int64>(System.Int16)
    IL_0006: ret

}
ulong convert_g16i_to_g64u(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.Int16,System.UInt64>(System.Int16)
    IL_0006: ret

}
float convert_g16i_to_g32f(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Int16,System.Single>(System.Int16)
    IL_0006: ret

}
double convert_g16i_to_g64f(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Int16,System.Double>(System.Int16)
    IL_0006: ret

}
Char convert_g16i_to_gch16(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Int16,System.Char>(System.Int16)
    IL_0006: ret

}
sbyte convert_16u_to_g8i(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.UInt16,System.SByte>(System.UInt16)
    IL_0006: ret

}
byte convert_g16u_to_g8u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.UInt16,System.Byte>(System.UInt16)
    IL_0006: ret

}
short convert_g16u_to_g16i(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.UInt16,System.Int16>(System.UInt16)
    IL_0006: ret

}
ushort convert_g16u_to_g16u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16,System.UInt16>(System.UInt16)
    IL_0006: ret

}
int convert_g16u_to_g32i(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.UInt16,System.Int32>(System.UInt16)
    IL_0006: ret

}
uint convert_g16u_to_g32u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt16,System.UInt32>(System.UInt16)
    IL_0006: ret

}
long convert_g16u_to_g64i(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.UInt16,System.Int64>(System.UInt16)
    IL_0006: ret

}
float convert_g16u_to_g32f(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.UInt16,System.Single>(System.UInt16)
    IL_0006: ret

}
double convert_g16u_to_g64f(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.UInt16,System.Double>(System.UInt16)
    IL_0006: ret

}
sbyte convert_32i_to_gi(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_g32i_to_g8i(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.Int32,System.SByte>(System.Int32)
    IL_0006: ret

}
byte convert_32i_to_8u(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ret

}
byte convert_g32i_to_g8u(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Int32,System.Byte>(System.Int32)
    IL_0006: ret

}
short convert_32i_to_16i(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i2
    IL_0002: ret

}
short convert_g32i_to_g16i(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int32,System.Int16>(System.Int32)
    IL_0006: ret

}
ushort convert_32i_to_16u(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
ushort convert_g32i_to_g16u(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.Int32,System.UInt16>(System.Int32)
    IL_0006: ret

}
int convert_32i_to_32i(int src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
int convert_g32i_to_g32i(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32,System.Int32>(System.Int32)
    IL_0006: ret

}
uint convert_32i_to_32u(int src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
uint convert_g32i_to_g32u(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.Int32,System.UInt32>(System.Int32)
    IL_0006: ret

}
long convert_32i_to_64i(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
long convert_g32i_to_g64i(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int32,System.Int64>(System.Int32)
    IL_0006: ret

}
ulong convert_32i_to_64u(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
ulong convert_g32i_to_g64u(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.Int32,System.UInt64>(System.Int32)
    IL_0006: ret

}
float convert_32i_to_32f(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: ret

}
float convert_g32i_to_g32f(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Int32,System.Single>(System.Int32)
    IL_0006: ret

}
double convert_32i_to_64f(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ret

}
double convert_g32i_to_g64f(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Int32,System.Double>(System.Int32)
    IL_0006: ret

}
Char convert_32i_to_ch16(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
Char convert_g32i_to_gch16(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Int32,System.Char>(System.Int32)
    IL_0006: ret

}
sbyte convert_32u_to_8i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_g32u_to_g8i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.UInt32,System.SByte>(System.UInt32)
    IL_0006: ret

}
byte convert_32u_to_8u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ret

}
byte convert_g32u_to_g8u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.UInt32,System.Byte>(System.UInt32)
    IL_0006: ret

}
short convert_32u_to_16i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i2
    IL_0002: ret

}
short convert_g32u_to_g16i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.UInt32,System.Int16>(System.UInt32)
    IL_0006: ret

}
ushort convert_32u_to_16u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
ushort convert_g32u_to_g16u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt32,System.UInt16>(System.UInt32)
    IL_0006: ret

}
int convert_32u_to_32i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
int convert_g32u_to_g32i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.UInt32,System.Int32>(System.UInt32)
    IL_0006: ret

}
uint convert_32u_to_32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
uint convert_g32u_to_g32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32,System.UInt32>(System.UInt32)
    IL_0006: ret

}
long convert_32u_to_64i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ret

}
long convert_g32u_to_g64i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.UInt32,System.Int64>(System.UInt32)
    IL_0006: ret

}
ulong convert_32u_to_64u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ret

}
ulong convert_g32u_to_g64u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt32,System.UInt64>(System.UInt32)
    IL_0006: ret

}
float convert_32u_to_32f(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r4
    IL_0003: ret

}
float convert_g32u_to_g32f(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.UInt32,System.Single>(System.UInt32)
    IL_0006: ret

}
double convert_32u_to_64f(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: ret

}
double convert_g32u_to_g64f(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.UInt32,System.Double>(System.UInt32)
    IL_0006: ret

}
Char convert_32u_to_ch(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
Char convert_g32u_to_gch16(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.UInt32,System.Char>(System.UInt32)
    IL_0006: ret

}
byte convert_g64i_to_g8u(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Int64,System.Byte>(System.Int64)
    IL_0006: ret

}
sbyte convert_g64i_to_g8i(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.Int64,System.SByte>(System.Int64)
    IL_0006: ret

}
ushort convert_g64i_to_g16u(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.Int64,System.UInt16>(System.Int64)
    IL_0006: ret

}
short convert_g64i_to_g16i(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int64,System.Int16>(System.Int64)
    IL_0006: ret

}
int convert_g64i_to_g32i(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int64,System.Int32>(System.Int64)
    IL_0006: ret

}
uint convert_g64i_to_g32u(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.Int64,System.UInt32>(System.Int64)
    IL_0006: ret

}
long convert_g64i_to_g64i(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64,System.Int64>(System.Int64)
    IL_0006: ret

}
ulong convert_g64i_to_g64u(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.Int64,System.UInt64>(System.Int64)
    IL_0006: ret

}
float convert_g64i_to_g32f(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Int64,System.Single>(System.Int64)
    IL_0006: ret

}
double convert_g64i_to_g64f(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Int64,System.Double>(System.Int64)
    IL_0006: ret

}
Char convert_g64i_to_gch16(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Int64,System.Char>(System.Int64)
    IL_0006: ret

}
sbyte convert_g64u_to_g8i(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.UInt64,System.SByte>(System.UInt64)
    IL_0006: ret

}
byte convert_g64u_to_g8u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.UInt64,System.Byte>(System.UInt64)
    IL_0006: ret

}
short convert_g64u_to_g16i(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.UInt64,System.Int16>(System.UInt64)
    IL_0006: ret

}
ushort convert_g64u_to_g16u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt64,System.UInt16>(System.UInt64)
    IL_0006: ret

}
int convert_g64u_to_g32i(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.UInt64,System.Int32>(System.UInt64)
    IL_0006: ret

}
uint convert_64u_to_32u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u4
    IL_0002: ret

}
uint convert_g64u_to_g32u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt64,System.UInt32>(System.UInt64)
    IL_0006: ret

}
long convert_g64u_to_g64i(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.UInt64,System.Int64>(System.UInt64)
    IL_0006: ret

}
ulong convert_g64u_to_g64u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64,System.UInt64>(System.UInt64)
    IL_0006: ret

}
float convert_g64u_to_g32f(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.UInt64,System.Single>(System.UInt64)
    IL_0006: ret

}
double convert_64u_to_64f(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ret

}
double convert_g64u_to_g64f(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.UInt64,System.Double>(System.UInt64)
    IL_0006: ret

}
sbyte convert_g32f_to_g8i(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.Single,System.SByte>(System.Single)
    IL_0006: ret

}
byte convert_g32f_to_g8u(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Single,System.Byte>(System.Single)
    IL_0006: ret

}
short convert_g32f_to_g16i(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Single,System.Int16>(System.Single)
    IL_0006: ret

}
ushort convert_g32f_to_g16u(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.Single,System.UInt16>(System.Single)
    IL_0006: ret

}
