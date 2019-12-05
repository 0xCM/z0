// 2019-12-04 23:04:09:213
uint pack32x1(ConstBlock256<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Bits::pack8x1(Z0.ConstBlock256`1<System.Byte>&)
    IL_0007: ret

}
