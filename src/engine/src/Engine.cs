//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static RegModels;
    using static FunctionModels;
    using static CpuModels;

    using static core;

    using Fx = AsmInstructions;


    public ref struct CpuRuntime
    {
        const uint DefaultBufferSize = CpuBuffer.BufferSize;

        readonly IWfRuntime Wf;

        readonly CpuBuffers Buffers;

        int ProcessedCount;

        [MethodImpl(Inline)]
        public CpuRuntime(IWfRuntime wf)
        {
            Wf = wf;
            Buffers = CpuBuffers.create(DefaultBufferSize);
            ProcessedCount = 0;
        }

        public void Dispose()
        {

        }

        [Op]
        public void Run()
        {
            var flow = Wf.Running();
            try
            {
                var buffer =  Buffers.Run();
                var steps = buffer.Slice(0, ProcessedCount);
                var log = Buffers.Log();
                var count = Hex.render(steps, log);
                var hex =  text.format(slice(log,0,count));
                Wf.Status(hex);
            }
            catch(Exception error)
            {
                Wf.Error(error);
            }
            Wf.Ran(flow);
        }
    }

    public struct EngineSettings
    {
        public ulong Affinity;
    }

    public class Engine : AppCmdService<Engine>
    {
        EngineSettings Settings;

        RegBank Registers;

        public Engine()
        {
            Registers = RegBanks.allocate(w64,w512);
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


        [CmdOp(".test")]
        Outcome Test(CmdArgs args)
        {
            var src = FS.path(@"J:\dumps\images\machine.exe.asm");
            const uint Skip = 5;
            using var reader = src.AsciLineReader();
            var counter = 0u;
            var skipping = Skip != 0;
            while(reader.Next(out var line))
            {
                counter++;

                if(counter == Skip)
                {
                    skipping = false;
                    Write(line.Format());
                }

                if(skipping)
                    continue;

                if(counter % 100000 == 0)
                {
                    Write(line.Format());
                }

            }
            return true;
        }

        public void Configure(in EngineSettings src)
        {
            Settings = src;

        }

        protected override void Initialized()
        {
            var config = new EngineSettings();
            config.Affinity = BitMasks.lo<ulong>((byte)(Env.CpuCount - 1));
            Configure(config);
        }

        [MethodImpl(Inline), Op]
        public rax Exec(Fx.Imul fx, RegVec<rcx,rdx> args)
        {
            var dst = math.mul(uint64(args.r0), uint64(args.r1));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static CpuId cpuid(eax f, ecx sf)
            => CpuId.request(f, sf);

        [MethodImpl(Inline), Op]
        public static ref CpuId cpuid(in Cell128 src, ref CpuId dst)
            => ref CpuId.response(src, ref dst);

        [MethodImpl(Inline), Op]
        public static ref CpuId clear(ref CpuId dst)
            => ref CpuId.clear(ref dst);

        [Op]
        public static string format(in AsmComment src)
            => src.Content.IsNonEmpty ? string.Format("; {0}",src.Content) : EmptyString;

        [Op]
        public static string format(in CpuId src)
        {
            const string FormatPattern = "fx:{0} subfx:{1} => eax:{2} ebx:{3} ecx:{4} edx:{5}";
            return text.format(FormatPattern, src.Fx, src.SubFx, src.Eax, src.Ebx, src.Ecx, src.Edx);
        }
    }
}