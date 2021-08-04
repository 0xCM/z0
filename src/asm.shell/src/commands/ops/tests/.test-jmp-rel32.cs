//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmEncodings;

    partial class AsmCmdService
    {
        [CmdOp(".test-jmp-rel32")]
        Outcome TestJmpRel32(CmdArgs args)
        {
            var result = Outcome.Success;
            var @case = AsmCaseAssets.create().Switch();

            var @base = (MemoryAddress)0x7ffd4512bf30;
            var dst = @base + (MemoryAddress)0x10b7; //return address
            var sz = (byte)5;

            var l0 = 0x005a;
            var ip0 = @base + l0 + sz;
            var dx0 = asm.disp32(ip0, dst);
            var actual0 = Jumps.rel32(ip0, dst);
            var expect0 = asm.hexcode("e9 58 10 00 00");
            Write(string.Format("{0}:{1} -> {2}", dx0, ip0, dst));
            Write(string.Format("{0} ?=? {1}", expect0, actual0.Format()));
            var l1 = 0x0065;
            var ip1 = @base + l1 + sz;
            var dx1 = asm.disp32(ip1, dst);
            var actual1 = Jumps.rel32(ip1, dst);
            var expect1 = asm.hexcode("e9 4d 10 00 00");
            Write(string.Format("{0}:{1} -> {2}", dx1, ip1, dst));
            Write(string.Format("{0} ?=? {1}", expect1, actual1.Format()));
            var l2 = 0x0070;
            var ip2 = @base + l2 + sz;
            var dx2 = asm.disp32(ip2, dst);
            var actual2 = Jumps.rel32(ip2, dst);
            var expect2 = asm.hexcode("e9 42 10 00 00");

            Write(string.Format("{0}:{1} -> {2}", dx2, ip2, dst));
            if(!actual2.Equals(expect2))
                Error(string.Format("{0} != {1}", expect2, actual2));
            else
                Write(string.Format("{0} == {1}", expect2, actual2));

            var l3 = 0x007b;
            var ip3 = @base + l3 + sz;
            var dx3 = asm.disp32(ip3, dst);
            var actual3 = Jumps.rel32(ip3, dst);
            var expect3 = asm.hexcode("e9 37 10 00 00");
            Write(string.Format("{0}:{1} -> {2}", dx3, ip3, dst));
            if(!actual3.Equals(expect3))
                Error(string.Format("{0} != {1}", expect3, actual3));
            else
                Write(string.Format("{0} == {1}", expect3, actual3));

            return result;
        }
    }

    /*
BaseAddress = 7ffd4512bf30h
005ah jmp near ptr 10b7h | e9 58 10 00 00
0065h jmp near ptr 10b7h | e9 4d 10 00 00
0070h jmp near ptr 10b7h | e9 42 10 00 00
007bh jmp near ptr 10b7h | e9 37 10 00 00

    */
}