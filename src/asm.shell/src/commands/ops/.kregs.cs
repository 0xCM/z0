//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static RegClasses;

    partial class AsmCmdService
    {
        [MethodImpl(Inline)]
        public static NamedRegValue<T> regval<T>(RegName name, T value)
            where T : unmanaged
                => new NamedRegValue<T>(name,value);

        [CmdOp(".kregs")]
        public Outcome KRegTests(CmdArgs args)
        {
            var result = Outcome.Success;

            var grid = default(RegGrid8x64);
            var regs = Machines.regs(n8,w64);
            var names = recover<RegName>(ByteBlock64.Empty.Bytes);
            var pairs = recover<NamedRegValue<ulong>>(ByteBlock128.Empty.Bytes);

            for(byte i=0; i<7; i++)
            {
                regs[i] = i;
                seek(names,i) = AsmRegNames.name(KReg, (RegIndexCode)i);
                grid[i]= regval(skip(names,i), regs[i]);
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
                Write(regval(skip(names,i),regs[i]));
            }

            return result;
        }
    }
}