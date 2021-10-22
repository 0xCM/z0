//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines.X86
{
    using System;

    using Asm;

    using static Root;
    using static core;
    using static Asm.RegClasses;

    public class X86Emulator : AppCmdService<X86Emulator>
    {
        RegBank Registers;

        EngineSettings Settings;

        public X86Emulator()
        {
            Registers = RegBanks.intel64();
        }

        protected override void Initialized()
        {
            var config = new EngineSettings();
            config.Affinity = BitMasks.lo<ulong>((byte)(Env.CpuCount - 1));
            Settings = config;
        }

        protected override void Disposing()
        {
            Registers.Dispose();
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


        [CmdOp(".test-kregs")]
        Outcome KRegTests(CmdArgs args)
        {
            var result = Outcome.Success;
            var grid = default(RegGrid8x64);
            var regs = RegMachines.regs(n8,w64);
            var names = recover<AsmRegName>(ByteBlock64.Empty.Bytes);
            var pairs = recover<AsmRegValue<ulong>>(ByteBlock128.Empty.Bytes);

            for(byte i=0; i<7; i++)
            {
                regs[i] = i;
                seek(names,i) = AsmRegs.name(KReg, (RegIndexCode)i);
                grid[i]= asm.regval(skip(names,i), regs[i]);
            }

            for(byte i=0; i<7; i++)
            {
                ref readonly var name = ref skip(names,i);
                ref readonly var value = ref regs[i];
                var output = grid[i].Format();
                Write(output);
            }

            var input = (ulong)PermLits.Perm16Identity;
            for(byte i=0; i<7; i++)
            {
                regs[i] = input << i*3;
                Write(asm.regval(skip(names,i), regs[i]));
            }

            return result;
        }


        [CmdOp(".test-regs")]
        Outcome TestRegs(CmdArgs args)
        {
            var result = Outcome.Success;

            var machine = RegMachines.intel64();
            var buffer = text.buffer();
            RegMachines.state(machine,buffer);
            Write(buffer.Emit());

            return result;
        }

        [CmdOp(".test-bss")]
        Outcome TestBss(CmdArgs args)
        {
            var result = Outcome.Success;
            var dispenser = BssSections.dispenser();
            var entries = dispenser.Entries();
            var count = entries.Length;
            const sbyte Pad = -16;

            Write(RP.attrib(nameof(dispenser.EntryCount), count));
            for(ushort i=0; i<count; i++)
            {
                //ref readonly var entry = ref skip(entries,i);
                ref readonly var entry = ref dispenser.Entry(i);
                var desc = entry.Descriptor();
                var capacity = desc.Capacity;
                Write(RP.PageBreak32);
                Write(RP.attrib(Pad, nameof(desc.Index), desc.Index));
                Write(RP.attrib(Pad, nameof(desc.BaseAddress), desc.BaseAddress));
                Write(RP.attrib(Pad, nameof(desc.EndAddress), desc.EndAddress));
                Write(RP.attrib(Pad, nameof(capacity.Indicator), capacity.Indicator));
                Write(RP.attrib(Pad, nameof(capacity.CellSize), capacity.CellSize));
                Write(RP.attrib(Pad, nameof(capacity.CellsPerSeg), capacity.CellsPerSeg));
                Write(RP.attrib(Pad, nameof(capacity.SegSize), capacity.SegSize));
                Write(RP.attrib(Pad, nameof(capacity.SegCount), capacity.SegCount));
                Write(RP.attrib(Pad, nameof(capacity.SegsPerBlock), capacity.SegsPerBlock));
                Write(RP.attrib(Pad, nameof(capacity.BlockCount), capacity.BlockCount));
                Write(RP.attrib(Pad, nameof(capacity.BlockSize), capacity.BlockSize));
                Write(RP.attrib(Pad, nameof(capacity.TotalSize), capacity.TotalSize));
            }

            return result;
       }

        [CmdOp(".test-stack")]
        Outcome TestStack(CmdArgs args)
        {
            var result = Outcome.Success;
            var stack = CpuModels.stack<ulong>(24);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            while(stack.Pop(out var cell))
            {
                Write(cell);
            }
            return result;
        }

        [CmdOp(".test-mm")]
        Outcome TestMatchMachine(CmdArgs args)
            => TestMatchMachine();

        Outcome TestMatchMachine()
        {
            var result = Outcome.Success;
            result &= Match(2, first32u(MatchTarget0), MatchInput);
            result &= Match(2, first32u(MatchTarget1), MatchInput);
            result &= Match(3, first32u(MatchTarget2), MatchInput);
            result &= Match(1, first32u(MatchTarget3), MatchInput);
            result &= Match(3, first32u(MatchTarget4), MatchInput);
            return result ? (true, "Pass") : (false, "Fail");
        }

        Outcome Match(byte n, uint src, ReadOnlySpan<byte> input)
        {
            var result = Outcome.Success;
            var spec = Match3x8.specify(n,src);
            var machine = Match3x8.create(spec);
            Write(spec.Format());

            var i = machine.Run(input);
            var matched = i>=0;
            var msg = matched ? string.Format("Matched: i={0}",i) : "Unmatched";
            result = (matched, msg);
            Write(result.Message);
            return result;
        }

        static ReadOnlySpan<byte> MatchTarget0 => new byte[4]{0x24,0x12,0x00,0x00};

        static ReadOnlySpan<byte> MatchTarget1 => new byte[4]{0xCC,0x00,0x00,0x00};

        static ReadOnlySpan<byte> MatchTarget2 => new byte[4]{0x48,0x16,0x19,0x00};

        static ReadOnlySpan<byte> MatchTarget3 => new byte[4]{0x19,0x00,0x00,0x00};

        static ReadOnlySpan<byte> MatchTarget4 => new byte[4]{0xCC,0x00,0x19,0x00};

        static ReadOnlySpan<byte> MatchInput => new byte[]{
            0x52,0x21,0x18,0x00,
            0x23,0x48,0x16,0x19,
            0x22,0x24,0x12,0xCC,
            0xCC,0x00,0x19,0x00
            };
    }
}