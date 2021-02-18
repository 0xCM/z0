//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static AsmSigTokens;

    partial struct AsmCases
    {
        [Op]
        public static Index<CallRel32> callrel32(Rel32 rel32)
        {
            var caller = new AsmCaller(0x7ffe6818a0e0ul, asm.symbol("canonical/abi2/Run"));
            var cases = alloc<CallRel32>(4);
            var buffer = span(cases);
            var index = 0;
            // 7ffe6818a108h 0028h call 7ffe65135260h | E8 cd | e8 53 b1 fa fc
            load(caller, 0x7ffe6818a108, 0x7ffe6818a10d, 0x7ffe65135260, asm.encoding("e8 53 b1 fa fc"), ref seek(buffer,index++));
            // 7ffe6818a120h 0040h call 7ffe65135268h | E8 cd | e8 43 b1 fa fc
            load(caller, 0x7ffe6818a120, 0x7ffe6818a125, 0x7ffe65135268, asm.encoding("e8 43 b1 fa fc"), ref seek(buffer,index++));
            // 7ffe6818a13bh 005bh call 7ffe65135270h | E8 cd |  e8 30 b1 fa fc
            load(caller, 0x7ffe6818a13b, 0x7ffe6818a140, 0x7ffe65135270, asm.encoding("e8 30 b1 fa fc"), ref seek(buffer,index++));
            // 7ffe6818a154h 0074h call 7ffe65135278h | E8 cd | e8 1f b1 fa fc
            load(caller, 0x7ffe6818a154, 0x7ffe6818a159, 0x7ffe65135278, asm.encoding("e8 1f b1 fa fc"), ref seek(buffer,index++));
            return cases;
        }

        static ref CallRel32 load(AsmCaller caller, MemoryAddress ip, MemoryAddress next, MemoryAddress target, AsmHexCode encoding, ref CallRel32 dst)
        {
            dst.Caller= caller;
            dst.Ip = ip;
            dst.NextIp = next;
            dst.Target = target;
            dst.RelTarget = (uint)(target - next);
            dst.Encoding = encoding;
            return ref dst;
        }
    }
}