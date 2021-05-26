//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using static Part;
    using static AsmRegs;
    using static core;

    using H = HeapRegBanks;

    readonly struct EngineCore
    {
        public byte CpuCore {get;}

        [MethodImpl(Inline)]
        public EngineCore(byte number)
        {
            CpuCore = number;
        }
    }

    public struct EngineSettings
    {

        public Flags<ulong> Affinity;
    }


    public class Engine : AppService<Engine>
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

        void Allocate()
        {
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

        }

        public Engine()
        {
        }

        [MethodImpl(Inline), Op]
        public void Configure(in EngineSettings src)
        {
            Settings = src;
        }

        protected override void OnInit()
        {

        }


        public void Submit(BinaryCode src)
        {

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

        void ShowRegBits()
        {
            const string FormatPattern = "{0,-8} | {1,-10} | {2,-5} | {3,-10} | {4}";

            var query = AsmRegs.query();
            var classes = AsmRegs.classes();

            using var log = ShowLog("register-bits", FS.Log);

            foreach(var k in classes)
            {
                var registers = query.Where(k);
                foreach(var r in registers)
                    log.Show(r);
            }
        }
    }
}