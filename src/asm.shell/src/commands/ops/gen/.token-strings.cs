//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".gen-token-specs")]
        Outcome GenTokenSpecs(CmdArgs args)
        {
            var result = Outcome.Success;
            var symbols = Symbols.index<AsmOpCodeTokens.ModRmToken>();
            var src = Z0.Tokens.concat(symbols);
            var dst = Ws.Gen().Root + FS.file("token-specs", FS.Cs);
            var svc = Wf.Generators().StringLiterals();
            svc.Emit("ModRmTokens", src, dst);
            return result;
        }

        [CmdOp(".gen-enums")]
        Outcome GenEnums(CmdArgs args)
        {
            var result = Outcome.Success;
            var svc = Wf.Generators().CsEnum();
            var spec = SymbolSets.from(typeof(AsmOpCodeTokens.ModRmToken));
            var type = spec.DataType;
            Write(string.Format("DataType:{0}",type));
            var buffer = text.buffer();
            svc.Generate(0,spec,buffer);
            Write(buffer.Emit());
            return result;
        }

        [CmdOp(".tokenstrings")]
        Outcome EmitTokenStrings(CmdArgs args)
        {
            // "----\0----\0----\0"
            var result = Outcome.Success;
            var dst = text.buffer();
            var spec = new char[12];
            var j=0u;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Null;

            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Null;

            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Null;

            var ts = TokenStrings.define(spec);
            Write(ts.TokenCount);

            return result;
        }
    }
}