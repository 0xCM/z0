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
        public Outcome EmitAsmForms()
        {
            const string Pattern = "{0,-80} | {1}:{2} | {3}:{4}";
            var result = LoadSdmOpCodeDetails(out var details);
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
                // var oc = form.OpCode;
                // Write(string.Format(Pattern, form,
                //     "rex", oc.Rex,
                //     "rex.w", oc.RexW
                //     ));
            }

            Emitted(dst);
            return result;
        }
    }
}