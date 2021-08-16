//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    partial class AsmCmdService
    {
        [CmdOp(".sdm-opcodes")]
        Outcome Opcodes(CmdArgs args)
        {
            var result = Outcome.Success;
            var opcodes = State.SdmOpCodes();
            if(opcodes.Length == 0)
            {
                result = LoadSdmOpcodes(out _);
                if(result.Fail)
                    return result;

                opcodes = State.SdmOpCodes();
            }

            var count = opcodes.Length;
            var sigfilter = EmptyString;
            var codefilter = EmptyString;

            if(args.Count >= 1)
                sigfilter = arg(args,0);
            if(args.Count >= 2)
                codefilter = arg(args,1);

            var selected = span<SdmOpCodeDetail>(count);
            var j=0;
            for(var i=0; i<count; i++)
            {
                var include = true;
                ref readonly var code = ref skip(opcodes,i);
                if(nonempty(sigfilter))
                {
                    ref readonly var sig = ref code.Sig;
                    if(SQ.index(sig.Data,sigfilter,false) < 0)
                        include = false;
                }

                if(nonempty(codefilter))
                {
                    ref readonly var oc = ref code.OpCode;
                    if(SQ.index(oc.Data,codefilter,false) < 0)
                        include = false;
                }
                if(include)
                    seek(selected,j++) = code;
            }

            selected = slice(selected,0,j);
            count = selected.Length;
            var sigpad = 0;
            var ocpad = 0;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(selected,i);
                ref readonly var sig = ref code.Sig;
                ref readonly var oc = ref code.OpCode;
                var siglen = sig.Length;
                if(siglen > sigpad)
                    sigpad = siglen;

                var oclen = oc.Length;
                if(oclen > ocpad)
                    ocpad= oclen;
            }

            sigpad += 2;
            sigpad = -sigpad;

            ocpad +=2;
            ocpad = -ocpad;

            for(var i=0; i<count; i++)
            {
                ref readonly var item = ref skip(selected,i);
                var s = string.Format(RP.pad(sigpad), item.Sig);
                var c = string.Format(RP.pad(ocpad), item.OpCode);
                var fmt = string.Format("{0} | {1} | {2}", s, c, item.Description);
                Write(fmt);
            }

            return result;
        }
   }
}