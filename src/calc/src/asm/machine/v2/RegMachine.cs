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
    public unsafe partial class RegMachine : IDisposable
    {
        public static RegMachine intel64()
            => new RegMachine(RegBanks.intel64());

        RegBank Regs;

        byte* R8;

        ushort* R16;

        uint* R32;

        ulong* R64;

        Cell512* R512;

        ulong* K;

        ulong* SYS;

        RegMachine(RegBank regs)
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


        public void Dispose()
        {
            Regs.Dispose();
        }
    }
}