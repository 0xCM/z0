//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using Z0.Asm;
    using llvm;

    using static Root;
    using static core;

    public class X86Emulator : AppCmdService<X86Emulator>
    {
        RegBank Registers;

        EngineSettings Settings;

        public X86Emulator()
        {
            Registers = RegBanks.allocate(w64,w512);
        }

        protected override void Initialized()
        {
            var config = new EngineSettings();
            config.Affinity = BitMasks.lo<ulong>((byte)(Env.CpuCount - 1));
            Settings = config;
        }


        public void Emulate(ReadOnlySpan<char> spec)
        {
            var count = spec.Length;
            for(var i=0; i<count; i++)
            {

            }
        }

        [CmdOp(".regs")]
        Outcome Regs(CmdArgs args)
        {
            var file = Registers.File;
            var allocations = Registers.Allocations;
            var count = allocations.Length;
            var output = text.buffer();
            var offset = Address16.Zero;
            for(var i=0; i<count; i++)
            {
                ref var a = ref seek(allocations,i);
                var def = a.Definition;
                Write(string.Format("{0}:{1}", a.BaseAddress, def.Format()));
                for(var j=0u; j<def.RegCount; j++)
                {
                    var address = a.RegAddress(j);
                    var content = cover<byte>(address, def.RegSize);
                    output.AppendFormat("[reg{0:D2}:{1}:{2}] ", j, offset, address.Format());
                    for(var k=0; k<def.RegSize; k++)
                    {
                        ref var cell = ref seek(content,k);
                        output.Append(cell.FormatHex(specifier:false));
                    }
                    Write(output.Emit());
                    offset += (Address16)(ulong)def.RegSize;
                }

            }
            return true;
        }
    }
}