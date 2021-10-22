//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines.X86
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using Asm;

    [ApiHost]
    public unsafe class RegMachine : IDisposable
    {
        RegBank Regs;

        byte* R8;

        ushort* R16;

        uint* R32;

        ulong* R64;

        Cell512* R512;

        ulong* K;

        ulong* SYS;

        internal RegMachine(RegBank regs)
        {
            Regs = regs;
            R64 = regs[0].BaseAddress.Pointer<ulong>();
            R512 = regs[1].BaseAddress.Pointer<Cell512>();
            K = regs[2].BaseAddress.Pointer<ulong>();
            SYS = regs[3].BaseAddress.Pointer<ulong>();
            R32 = (uint*)R64;
            R16 = (ushort*)R64;
            R8 = (byte*)R64;
        }

        internal RegBank Bank
        {
            [MethodImpl(Inline)]
            get => Regs;
        }

        public void Dispose()
        {
            Regs.Dispose();
        }


        [MethodImpl(Inline), Op]
        public ref byte reg8(RegIndex index)
            => ref @ref(R8 + 8*(byte)(index));

        [MethodImpl(Inline), Op]
        public ref ushort reg16(RegIndex index)
            => ref @ref(R16 + 4*(byte)(index));

        [MethodImpl(Inline), Op]
        public ref uint reg32(RegIndex index)
            => ref @ref(R32 + 2*(byte)(index));

        [MethodImpl(Inline), Op]
        public ref ulong reg64(RegIndex index)
            => ref @ref(R64 + (byte)index);

        [MethodImpl(Inline), Op]
        public ref Cell512 reg512(RegIndex index)
            => ref @ref(R512 + (byte)index);

        [MethodImpl(Inline), Op]
        public ref Cell256 reg256(RegIndex index)
            => ref @as<Cell512,Cell256>(reg512(index));

        [MethodImpl(Inline), Op]
        public ref Cell128 reg128(RegIndex index)
            => ref @as<Cell512,Cell128>(reg512(index));

        [MethodImpl(Inline), Op]
        public ref ulong mask(RegIndex index)
            => ref @ref(K + (byte)index);

        [MethodImpl(Inline), Op]
        public ref ulong rflags()
            => ref @ref(SYS);

        [MethodImpl(Inline), Op]
        public ref ulong rip()
            => ref @ref(SYS + 1);
    }
}