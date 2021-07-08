//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Regs;
    using static core;

    using Fx = AsmInstructions;
    using H = HeapRegBanks;

    readonly struct EngineCore
    {
        public byte CoreNumber {get;}

        [MethodImpl(Inline)]
        public EngineCore(byte number)
        {
            CoreNumber = number;
        }

        public string Format()
            => string.Format("Core {0}", CoreNumber);

        public override string ToString()
            => Format();
    }

    public struct EngineSettings
    {
        public ulong Affinity;
    }

    public class Engine : AppCmdService<Engine>
    {
        const Byte CoreCount = Pow2.T06;

        Index<EngineCore> Cores;

        Index<H.GpRegBank> GpRegData;

        Index<H.ZmmRegBank> ZmmRegData;

        Index<H.MaskRegBank> MaskRegData;

        EngineSettings Settings;

        [MethodImpl(Inline)]
        ref H.GpRegBank GpRegs(byte index)
            => ref GpRegData[index];

        [MethodImpl(Inline)]
        ref H.ZmmRegBank ZmmRegs(byte index)
            => ref ZmmRegData[index];

        [MethodImpl(Inline)]
        ref H.MaskRegBank MaskRegs(byte index)
            => ref MaskRegData[index];

        void Allocate(in EngineSettings src)
        {
            var flow = Running(AllocatingCores.Capture(Bits.pop(Settings.Affinity)));
            Cores = alloc<EngineCore>(CoreCount);
            GpRegData = alloc<H.GpRegBank>(CoreCount);
            ZmmRegData = alloc<H.ZmmRegBank>(CoreCount);
            MaskRegData = alloc<H.MaskRegBank>(CoreCount);

            for(byte i=0; i<CoreCount; i++)
            {
                GpRegs(i) = new H.GpRegBank(alloc<Cell64>(16));
                ZmmRegs(i) = new H.ZmmRegBank(alloc<Cell512>(32));
                MaskRegs(i) = new H.MaskRegBank(alloc<Cell64>(8));
            }
            Ran(flow);
        }

        public Engine()
        {
        }

        [CmdOp(".test-keys")]
        Outcome TestKeys(CmdArgs args)
        {
            ushort rows = 39;
            ushort cols = 23;

            var keys = LookupTables.keys(rows,cols);
            for(var i=z16; i<rows; i++)
            for(var j=z16; j<cols; j++)
            {
                ref readonly var key = ref keys[i,j];
                Write(string.Format("({0},{1}) -> {2}", i, j, key));

            }


            return true;
        }

        [CmdOp(".test")]
        Outcome Test(CmdArgs args)
        {
            var src = FS.path(@"J:\dumps\images\machine.exe.asm");
            const uint Skip = 5;
            using var reader = AsciLineReader.open(src);
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
            Allocate(src);
        }

        protected override void Initialized()
        {
            var config = new EngineSettings();
            config.Affinity = BitMasks.lo<ulong>((byte)(Env.CpuCount - 1));
            Configure(config);
        }

        [CmdOp(".help")]
        public Outcome Help(CmdArgs args)
        {
            Write("Not yet");

            return true;
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

        public static MsgPattern<Count> AllocatingCores => "Allocating {0} cores";
    }
}