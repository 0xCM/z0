//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public sealed class t_asm_registers : t_asm<t_asm_registers>
    {
        public void t_register_lookup()
        {
            const string HeaderPattern = "{0} - {1}";
            const string PageBreak = RP.PageBreak80;
            var lookup = AsmRegs.lookup();
            var dst = CasePath(FS.ext("csv"));
            using var writer = dst.Writer();

            var name = "Gp8";
            var registers = lookup.Gp8;
            writer.WriteLine(string.Format(HeaderPattern, name, registers.Length));
            writer.WriteLine(PageBreak);
            root.iter(registers, r => writer.WriteLine(r));

            name = "Gp16";
            registers = lookup.Gp16;
            writer.WriteLine(string.Format(HeaderPattern, name, registers.Length));
            writer.WriteLine(PageBreak);
            root.iter(registers, r => writer.WriteLine(r));

            name = "Gp32";
            registers = lookup.Gp32;
            writer.WriteLine(string.Format(HeaderPattern, name, registers.Length));
            writer.WriteLine(PageBreak);
            root.iter(registers, r => writer.WriteLine(r));

            name = "Gp64";
            registers = lookup.Gp64;
            writer.WriteLine(string.Format(HeaderPattern, name, registers.Length));
            writer.WriteLine(PageBreak);
            root.iter(registers, r => writer.WriteLine(r));
        }
    }
}
