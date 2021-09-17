//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;


    public readonly partial struct RegMachines
    {

    }


    [ApiHost]
    public unsafe class RegMachine : IDisposable
    {
        public static RegMachine create()
            => new RegMachine(RegBanks.allocate(w64,w512));

        RegBank Regs;

        byte* R8;

        ushort* R16;

        uint* R32;

        ulong* R64;

        Cell512* R512;

        RegMachine(RegBank regs)
        {
            Regs = regs;
            R64 = regs[0].BaseAddress.Pointer<ulong>();
            R512 = regs[1].BaseAddress.Pointer<Cell512>();
            R32 = (uint*)R64;
            R16 = (ushort*)R64;
            R8 = (byte*)R64;
        }

        public void State(ITextBuffer dst)
        {
            var allocations = Regs.Allocations;
            var count = allocations.Length;
            var offset = Address16.Zero;
            for(var i=0; i<count; i++)
            {
                ref var a = ref seek(allocations,i);
                var def = a.Definition;
                dst.AppendLine(string.Format("[bank{0:D2}:{1}:{2}]", i, a.Range, def.Format()));
                for(var j=0u; j<def.RegCount; j++)
                {
                    var address = a.RegAddress(j);
                    var content = cover<byte>(address, def.RegSize);
                    dst.AppendFormat("[reg{0:D2}:{1}:{2}] ", j, offset, address.Format());
                    for(var k=0; k<def.RegSize; k++)
                    {
                        ref var cell = ref seek(content,k);
                        dst.Append(cell.FormatHex(specifier:false));
                    }
                    dst.AppendLine();
                    offset += (Address16)(ulong)def.RegSize;
                }
            }
        }

        [MethodImpl(Inline), Op]
        ref ulong reg64(RegIndex index)
            => ref @ref(R64 + (byte)index);

        [MethodImpl(Inline), Op]
        ref uint reg32(RegIndex index)
            => ref u32(reg64(index));

        [MethodImpl(Inline), Op]
        ref uint reg32b(RegIndex index)
            => ref @ref(R32 + 2*(byte)(index));

        [MethodImpl(Inline), Op]
        ref ushort reg16(RegIndex index)
            => ref u16(reg64(index));

        [MethodImpl(Inline), Op]
        ref ushort reg16b(RegIndex index)
            => ref @ref(R16 + 4*(byte)(index));

        [MethodImpl(Inline), Op]
        ref byte reg8(RegIndex index)
            => ref u8(reg64(index));

        [MethodImpl(Inline), Op]
        ref byte reg8b(RegIndex index)
            => ref @ref(R8 + 8*(byte)(index));

        [MethodImpl(Inline), Op]
        ref Cell512 reg512(RegIndex index)
            => ref @ref(R512 + (byte)index);

        [MethodImpl(Inline), Op]
        ref Cell256 reg256(RegIndex index)
            => ref @as<Cell512,Cell256>(reg512(index));

        [MethodImpl(Inline), Op]
        ref Cell128 reg128(RegIndex index)
            => ref @as<Cell512,Cell128>(reg512(index));

        public void Run(in AsmInstruction a)
        {
            var id = a.OpCode;


        }

        bit IsMov(in AsmInstruction a)
            => a.OpCode >= AsmId.MOV16ao16 && a.OpCode <= AsmId.MOV8rr_NOREX;

        void mov(in AsmInstruction a)
        {
            switch(a.OpCode)
            {
                case AsmId.MOV8rm:
                break;
                case AsmId.MOV8mr:
                break;
                case AsmId.MOV8rr:
                break;
                case AsmId.MOV8ri:
                break;
                case AsmId.MOV8mi:
                break;
            }
        }


        public void Dispose()
        {
            Regs.Dispose();
        }
    }
}