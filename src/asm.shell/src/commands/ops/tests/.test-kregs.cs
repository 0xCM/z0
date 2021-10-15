//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;
    using static RegClasses;
    using static RegMachines;

    partial class AsmCmdService
    {
        [CmdOp(".test-kregs")]
        public Outcome KRegTests(CmdArgs args)
        {
            var result = Outcome.Success;
            var grid = default(Grid8x64);
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
    }
}