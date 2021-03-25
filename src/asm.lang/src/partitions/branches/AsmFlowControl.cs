//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmMnemonicCode;

    [ApiHost]
    public class AsmFlowControl : WfService<AsmFlowControl>
    {
        [Op]
        public ref JccCode EvalJccCode(JccKind src, out JccCode code)
        {
            code = 0;
            return ref code;
        }

        public bool IsJcc(AsmHexCode src)
        {
            return default;
        }

   }
}