//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        public Outcome AsmFormsEmit()
        {
            var result = SdmOpCodeDetailLoad(out var details);
            if(result.Fail)
                return result;

            var dst = TableWs().Root + FS.file("asm.forms", FS.Txt);
            using var writer = dst.UnicodeWriter();
            var forms = AsmEtl.forms(details).View;
            var count = forms.Length;

            for(var i=0; i<count; i++)
            {
                ref readonly var form = ref skip(forms,i);
                writer.WriteLine(form);
                Write(form);
            }

            Emitted(dst);
            return result;
        }
    }
}