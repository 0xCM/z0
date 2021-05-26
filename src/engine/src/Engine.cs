//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;

    public partial class Engine : AppService<Engine>
    {
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