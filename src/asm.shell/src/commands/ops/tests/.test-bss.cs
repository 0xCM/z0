//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;
    using static Rules;

    partial class AsmCmdService
    {
        [CmdOp(".test-bss")]
        Outcome TestBss(CmdArgs args)
        {
            var result = Outcome.Success;

            Bss.dispense(0, out var entry);

            Write(entry.Capacity());
            var machine = Machines.machine(n8, entry);
            var input = Random.Bytes(span<byte>(256));
            var count = input.Length;
            var accepted = bit.On;
            for(var i=0; i<count && accepted; i++)
            {
                ref readonly var b = ref skip(input,i);
                accepted = machine.Accept(b);
            }

            var buffer = span<byte>(512);
            var k = machine.Accepted(buffer);
            var desc = text.buffer();
            for(var j=0; j<k; j++)
            {
                ref readonly var b0 = ref skip(input,j);
                ref readonly var b1 = ref skip(buffer,j);
                var claim = Rules.eq(b0,b1);
                var join = math.join(b0,b1);
                desc.Append(b0.FormatHex(specifier:false));
                desc.Append(Chars.Space);
                desc.Append(Chars.Dash);
                desc.Append(Chars.Gt);
                desc.Append(Chars.Space);
                desc.Append(b0.FormatHex(specifier:false));
                if(j != k-1)
                {
                    desc.Append(Chars.Space);
                    desc.Append(Chars.Pipe);
                    desc.Append(Chars.Space);
                }

                if((j+1) % 4 == 0)
                {
                    desc.Append(Chars.Eol);
                }

            }

            Write(desc.Emit());

            return result;
       }
    }
}