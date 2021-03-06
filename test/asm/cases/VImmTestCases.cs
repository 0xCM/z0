//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static Part;

    public static class VMethods
    {
        public static VMethodSearch Search => default(VMethodSearch);

        public static MethodInfo vbroadcast<W>(this VMethodSearch search, Type tCell, W w = default)
            where W : unmanaged, ITypeWidth
            => typeof(cpu).DeclaredMethods()
                    .WithName("vbroadcast")
                    .WithParameterTypes(w.GetType(), tCell)
                    .WithParameterCount(2)
                    .Single();
    }

    public readonly struct VMethodSearch
    {

    }

    static class VImmTestCases
    {
        public static MethodInfo[] V128UnaryShifts
            => typeof(VImmTestCases).DeclaredStaticMethods().WithNameLike("vsll_128");

        public static MethodInfo[] V256UnaryShifts
            => typeof(VImmTestCases).DeclaredStaticMethods().WithNameLike("vsll_256");

        [MethodImpl(Inline)]
        public static Vector128<short> vsll_128x16i(Vector128<short> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vsll_128x16u(Vector128<ushort> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector128<int> vsll_128x32i(Vector128<int> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector128<uint> vsll_128x32u(Vector128<uint> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector128<long> vsll_128x64i(Vector128<long> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector128<ulong> vsll_128x64u(Vector128<ulong> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector256<short> vsll_256x16i(Vector256<short> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector256<ushort> vsll_256x16u(Vector256<ushort> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector256<int> vsll_256x32i(Vector256<int> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector256<uint> vsll_256x32u(Vector256<uint> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector256<long> vsll_256x64i(Vector256<long> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline)]
        public static Vector256<ulong> vsll_256x64u(Vector256<ulong> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);
    }
}