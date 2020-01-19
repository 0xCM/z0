// 2020-01-18 18:18:33:840
// Id := 100664380, Name := System.Int64 Z0.OpCodes.loops::loop_inc(System.Int32,System.Int32,System.Int64)
// long loop_inc(int start, int max, long count)
// AggressiveInlining
long loop_inc(int start, int max, long count)
{
    IL_0000: ldarg.2
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: stloc.1
    IL_0004: br.s IL_000F
    IL_0006: ldloc.0
    IL_0007: ldloc.1
    IL_0008: conv.i8
    IL_0009: add
    IL_000A: stloc.0
    IL_000B: ldloc.1
    IL_000C: ldc.i4.1
    IL_000D: add
    IL_000E: stloc.1
    IL_000F: ldloc.1
    IL_0010: ldarg.1
    IL_0011: blt.s IL_0006
    IL_0013: ldloc.0
    IL_0014: ret
}

// Id := 100664381, Name := System.Int64 Z0.OpCodes.loops::loop_inc_test_neq(System.Int32,System.Int32,System.Int64)
// long loop_inc_test_neq(int start, int test, long count)
// AggressiveInlining
long loop_inc_test_neq(int start, int test, long count)
{
    IL_0000: ldarg.2
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: stloc.1
    IL_0004: br.s IL_000F
    IL_0006: ldloc.0
    IL_0007: ldloc.1
    IL_0008: conv.i8
    IL_0009: add
    IL_000A: stloc.0
    IL_000B: ldloc.1
    IL_000C: ldc.i4.1
    IL_000D: add
    IL_000E: stloc.1
    IL_000F: ldloc.1
    IL_0010: ldarg.1
    IL_0011: bne.un.s IL_0006
    IL_0013: ldloc.0
    IL_0014: ret
}

// Id := 100664382, Name := System.Int64 Z0.OpCodes.loops::loop_dec(System.Int32,System.Int32,System.Int64)
// long loop_dec(int start, int min, long count)
// AggressiveInlining
long loop_dec(int start, int min, long count)
{
    IL_0000: ldarg.2
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: stloc.1
    IL_0004: br.s IL_000F
    IL_0006: ldloc.0
    IL_0007: ldloc.1
    IL_0008: conv.i8
    IL_0009: add
    IL_000A: stloc.0
    IL_000B: ldloc.1
    IL_000C: ldc.i4.1
    IL_000D: sub
    IL_000E: stloc.1
    IL_000F: ldloc.1
    IL_0010: ldarg.1
    IL_0011: bge.s IL_0006
    IL_0013: ldloc.0
    IL_0014: ret
}

// Id := 100664383, Name := System.Int64 Z0.OpCodes.loops::loop_inc_step(System.Int32,System.Int32,System.Int32,System.Int64)
// long loop_inc_step(int start, int max, int step, long count)
// AggressiveInlining
long loop_inc_step(int start, int max, int step, long count)
{
    IL_0000: ldarg.3
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: stloc.1
    IL_0004: br.s IL_000F
    IL_0006: ldloc.0
    IL_0007: ldloc.1
    IL_0008: conv.i8
    IL_0009: add
    IL_000A: stloc.0
    IL_000B: ldloc.1
    IL_000C: ldarg.2
    IL_000D: add
    IL_000E: stloc.1
    IL_000F: ldloc.1
    IL_0010: ldarg.1
    IL_0011: blt.s IL_0006
    IL_0013: ldloc.0
    IL_0014: ret
}

// Id := 100664384, Name := System.Int64 Z0.OpCodes.loops::loop_dec_step(System.Int32,System.Int32,System.Int32,System.Int64)
// long loop_dec_step(int start, int min, int step, long count)
// AggressiveInlining
long loop_dec_step(int start, int min, int step, long count)
{
    IL_0000: ldarg.3
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: stloc.1
    IL_0004: br.s IL_000F
    IL_0006: ldloc.0
    IL_0007: ldloc.1
    IL_0008: conv.i8
    IL_0009: add
    IL_000A: stloc.0
    IL_000B: ldloc.1
    IL_000C: ldarg.2
    IL_000D: sub
    IL_000E: stloc.1
    IL_000F: ldloc.1
    IL_0010: ldarg.1
    IL_0011: bge.s IL_0006
    IL_0013: ldloc.0
    IL_0014: ret
}

// Id := 100664385, Name := System.Int64 Z0.OpCodes.loops::loop_inc_call(System.Int64)
// long loop_inc_call(long count)
// Managed
long loop_inc_call(long count)
{
    IL_0000: ldc.i4.s 102
    IL_0002: ldc.i4 1638
    IL_0007: ldarg.0
    IL_0008: call System.Int64 Z0.OpCodes.loops::loop_inc(System.Int32,System.Int32,System.Int64)
    IL_000D: ret
}

// Id := 100664386, Name := System.Int64 Z0.OpCodes.loops::loop_inc_test_neq_call(System.Int64)
// long loop_inc_test_neq_call(long count)
// Managed
long loop_inc_test_neq_call(long count)
{
    IL_0000: ldc.i4.s 102
    IL_0002: ldc.i4 1638
    IL_0007: ldarg.0
    IL_0008: call System.Int64 Z0.OpCodes.loops::loop_inc_test_neq(System.Int32,System.Int32,System.Int64)
    IL_000D: ret
}

// Id := 100664387, Name := System.Int64 Z0.OpCodes.loops::loop_inc_step_call(System.Int64)
// long loop_inc_step_call(long count)
// Managed
long loop_inc_step_call(long count)
{
    IL_0000: ldc.i4.s 102
    IL_0002: ldc.i4 1638
    IL_0007: ldc.i4.6
    IL_0008: ldarg.0
    IL_0009: call System.Int64 Z0.OpCodes.loops::loop_inc_step(System.Int32,System.Int32,System.Int32,System.Int64)
    IL_000E: ret
}

// Id := 100664388, Name := System.Int64 Z0.OpCodes.loops::loop_dec_call(System.Int64)
// long loop_dec_call(long count)
// Managed
long loop_dec_call(long count)
{
    IL_0000: ldc.i4 1638
    IL_0005: ldc.i4.s 102
    IL_0007: ldarg.0
    IL_0008: call System.Int64 Z0.OpCodes.loops::loop_dec(System.Int32,System.Int32,System.Int64)
    IL_000D: ret
}

// Id := 100664389, Name := System.Int64 Z0.OpCodes.loops::loop_dec_step_call(System.Int64)
// long loop_dec_step_call(long count)
// Managed
long loop_dec_step_call(long count)
{
    IL_0000: ldc.i4 1638
    IL_0005: ldc.i4.s 102
    IL_0007: ldc.i4.6
    IL_0008: ldarg.0
    IL_0009: call System.Int64 Z0.OpCodes.loops::loop_dec_step(System.Int32,System.Int32,System.Int32,System.Int64)
    IL_000E: ret
}

// Id := 100664390, Name := System.Int32 Z0.OpCodes.loops::FindByte(System.UInt64)
// int FindByte(ulong src)
// AggressiveInlining
int FindByte(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: neg
    IL_0003: and
    IL_0004: ldc.i4.8
    IL_0005: shr.un
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldc.i8 36311929895191424
    IL_0011: mul
    IL_0012: ldc.i4.s 55
    IL_0014: shr.un
    IL_0015: conv.i4
    IL_0016: ldc.i4.7
    IL_0017: and
    IL_0018: ret
}

// Id := 100664391, Name := System.Int32 Z0.OpCodes.loops::FindByte(Z0.Block256`1<System.Byte>&)
// int FindByte(in Block256<byte> src)
// AggressiveInlining
int FindByte(in Block256<byte> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0018
    IL_0007: ldarg.0
    IL_0008: ldloc.1
    IL_0009: call System.Byte& Z0.Block256`1<System.Byte>::get_Item(System.Int32)
    IL_000E: ldind.u1
    IL_000F: conv.u8
    IL_0010: stloc.0
    IL_0011: ldloc.0
    IL_0012: brtrue.s IL_001D
    IL_0014: ldloc.1
    IL_0015: ldc.i4.1
    IL_0016: add
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: ldc.i4.s 33
    IL_001B: blt.s IL_0007
    IL_001D: ldloc.1
    IL_001E: ldc.i4.8
    IL_001F: mul
    IL_0020: ldloc.0
    IL_0021: call System.Int32 Z0.OpCodes.loops::FindByte(System.UInt64)
    IL_0026: add
    IL_0027: ret
}

// Id := 100664392, Name := System.Int32 Z0.OpCodes.loops::downBy2ne(System.Int32)
// int downBy2ne(int amount)
// Managed
int downBy2ne(int amount)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.1
    IL_0002: ldc.i4.s 9
    IL_0004: stloc.0
    IL_0005: br.s IL_000F
    IL_0007: ldloc.1
    IL_0008: ldarg.0
    IL_0009: add
    IL_000A: stloc.1
    IL_000B: ldloc.0
    IL_000C: ldc.i4.2
    IL_000D: sub
    IL_000E: stloc.0
    IL_000F: ldloc.0
    IL_0010: ldc.i4.1
    IL_0011: bne.un.s IL_0007
    IL_0013: ldloc.1
    IL_0014: ldloc.0
    IL_0015: add
    IL_0016: ret
}

// Id := 100664393, Name := System.Int32 Z0.OpCodes.loops::upBy1ne(System.Int32)
// int upBy1ne(int amount)
// Managed
int upBy1ne(int amount)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.1
    IL_0002: ldc.i4.1
    IL_0003: stloc.0
    IL_0004: br.s IL_000E
    IL_0006: ldloc.1
    IL_0007: ldarg.0
    IL_0008: add
    IL_0009: stloc.1
    IL_000A: ldloc.0
    IL_000B: ldc.i4.1
    IL_000C: add
    IL_000D: stloc.0
    IL_000E: ldloc.0
    IL_000F: ldc.i4.8
    IL_0010: bne.un.s IL_0006
    IL_0012: ldloc.1
    IL_0013: ldloc.0
    IL_0014: add
    IL_0015: ret
}

// Id := 100664394, Name := System.Int32 Z0.OpCodes.loops::downBy1ne(System.Int32)
// int downBy1ne(int amount)
// Managed
int downBy1ne(int amount)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.1
    IL_0002: ldc.i4.s 9
    IL_0004: stloc.0
    IL_0005: br.s IL_000F
    IL_0007: ldloc.1
    IL_0008: ldarg.0
    IL_0009: add
    IL_000A: stloc.1
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_000D: sub
    IL_000E: stloc.0
    IL_000F: ldloc.0
    IL_0010: ldc.i4.2
    IL_0011: bne.un.s IL_0007
    IL_0013: ldloc.1
    IL_0014: ldloc.0
    IL_0015: add
    IL_0016: ret
}

// Id := 100664395, Name := System.Int32 Z0.OpCodes.loops::upBy2ne(System.Int32)
// int upBy2ne(int amount)
// Managed
int upBy2ne(int amount)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.1
    IL_0002: ldc.i4.1
    IL_0003: stloc.0
    IL_0004: br.s IL_000E
    IL_0006: ldloc.1
    IL_0007: ldarg.0
    IL_0008: add
    IL_0009: stloc.1
    IL_000A: ldloc.0
    IL_000B: ldc.i4.2
    IL_000C: add
    IL_000D: stloc.0
    IL_000E: ldloc.0
    IL_000F: ldc.i4.s 9
    IL_0011: bne.un.s IL_0006
    IL_0013: ldloc.1
    IL_0014: ldloc.0
    IL_0015: add
    IL_0016: ret
}

// Id := 100664396, Name := System.Int32 Z0.OpCodes.loops::upBy3neWrap(System.Int32)
// int upBy3neWrap(int amount)
// Managed
int upBy3neWrap(int amount)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.1
    IL_0002: ldc.i4.1
    IL_0003: stloc.0
    IL_0004: br.s IL_000F
    IL_0006: ldloc.1
    IL_0007: ldarg.0
    IL_0008: add
    IL_0009: stloc.1
    IL_000A: ldloc.0
    IL_000B: ldc.i4.3
    IL_000C: add
    IL_000D: conv.i2
    IL_000E: stloc.0
    IL_000F: ldloc.0
    IL_0010: ldc.i4.8
    IL_0011: bne.un.s IL_0006
    IL_0013: ldloc.1
    IL_0014: ldloc.0
    IL_0015: add
    IL_0016: ret
}

// Id := 100664397, Name := System.Int32 Z0.OpCodes.loops::downBy3neWrap(System.Int32)
// int downBy3neWrap(int amount)
// Managed
int downBy3neWrap(int amount)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.1
    IL_0002: ldc.i4.8
    IL_0003: stloc.0
    IL_0004: br.s IL_000F
    IL_0006: ldloc.1
    IL_0007: ldarg.0
    IL_0008: add
    IL_0009: stloc.1
    IL_000A: ldloc.0
    IL_000B: ldc.i4.3
    IL_000C: sub
    IL_000D: conv.i2
    IL_000E: stloc.0
    IL_000F: ldloc.0
    IL_0010: ldc.i4.1
    IL_0011: bne.un.s IL_0006
    IL_0013: ldloc.1
    IL_0014: ldloc.0
    IL_0015: add
    IL_0016: ret
}

