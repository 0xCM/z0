//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;
    using static AsmTests;

    partial class AsmCmdService
    {
        [CmdOp(".test")]
        Outcome Test(CmdArgs args)
        {
            var result = Outcome.Success;

            result = TestAsmWidths();

            return result;
        }

        Outcome TestAsmWidths()
        {
            var result = bit.On;
            var pass = bit.Off;
            var test = default(AsmSizeCheck);
            var inputs = Symbols.index<AsmSizeKind>().Kinds;
            var count = inputs.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(inputs,i);
                test.Input = input;
                pass = check(ref test);
                result &= pass;
                Write(test, pass ? FlairKind.Status : FlairKind.Error);
            }

            // test.Input = AsmSizeKind.@byte;
            // pass = check(ref test);
            // result &= pass;
            // Write(test, pass ? FlairKind.Status : FlairKind.Error);

            // test.Input = AsmSizeKind.word;
            // pass = check(ref test);
            // result &= pass;
            // Write(test, pass ? FlairKind.Status : FlairKind.Error);

            // test.Input = AsmSizeKind.dword;
            // pass = check(ref test);
            // result &= pass;
            // Write(test, pass ? FlairKind.Status : FlairKind.Error);

            // test.Input = AsmSizeKind.qword;
            // pass = check(ref test);
            // result &= pass;
            // Write(test, pass ? FlairKind.Status : FlairKind.Error);

            // test.Input = AsmSizeKind.zmmword;
            // pass = check(ref test);
            // result &= pass;
            // Write(test, pass ? FlairKind.Status : FlairKind.Error);

            // test.Input = AsmSizeKind.ymmword;
            // pass = check(ref test);
            // result &= pass;
            // Write(test, pass ? FlairKind.Status : FlairKind.Error);

            // test.Input = AsmSizeKind.zmmword;
            // pass = check(ref test);
            // result &= pass;
            // Write(test, pass ? FlairKind.Status : FlairKind.Error);

            return (result, result ? "Pass" : "Fail");
        }
    }
}