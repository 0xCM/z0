//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    partial struct Recapture
    {
        Option<AsmFunctionCode> CreateFunction(CapturedCode capture)
        {
            var decoded = Context.FunctionDecoder.Decode(capture);
            if(decoded)
                return new AsmFunctionCode(decoded.Value, capture);
            else
                return z.none<AsmFunctionCode>();
        }
    }
}