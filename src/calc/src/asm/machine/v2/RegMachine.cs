//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public unsafe partial class RegMachine : IDisposable
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
    }
}