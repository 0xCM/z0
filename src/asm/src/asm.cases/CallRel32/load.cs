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
    using static AsmInstructions;

    partial struct AsmCases
    {
        [Op]
        public static Index<CallRel32Case> load(Call call, Rel32 rel32)
        {
            var callerAddress = 0x7ffe6818a0e0ul;
            var callerName = "canonical/abi2/Run";
            var caller = new AsmCaller(0x7ffe6818a0e0ul, "canonical/abi2/Run");
            var cases = alloc<CallRel32Case>(4);
            var buffer = span(cases);
            var index = 0;
            define(caller, 0x7ffe6818a108, 0x7ffe6818a10d, 0x7ffe65135260, Numeric.join64u(0xfc, 0xfa, 0xb1, 0x53, 0xe8), ref seek(buffer,index++));
            define(caller, 0x7ffe6818a120, 0x7ffe6818a125, 0x7ffe65135268, Numeric.join64u(0xfc, 0xfa, 0xb1, 0x43, 0xe8), ref seek(buffer,index++));
            define(caller, 0x7ffe6818a13b, 0x7ffe6818a140, 0x7ffe65135270, Numeric.join64u(0xfc, 0xfa, 0xb1, 0x30, 0xe8), ref seek(buffer,index++));
            define(caller, 0x7ffe6818a154, 0x7ffe6818a159, 0x7ffe65135278, Numeric.join64u(0xfc, 0xfa, 0xb1, 0x1f, 0xe8), ref seek(buffer,index++));
            return cases;
        }

        static ref CallRel32Case define(AsmCaller caller, MemoryAddress ip, MemoryAddress next, MemoryAddress target, ulong encoding, ref CallRel32Case dst)
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