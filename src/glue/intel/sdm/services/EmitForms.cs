//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class IntelSdm
    {
        public ReadOnlySpan<Table> ReadSourceTables()
        {
            var src = Ws.Sources().Datasets(AsmTableScopes.SdmInstructions).Files(FS.Csv).ToReadOnlySpan();
            var svc = Wf.IntelSdm();
            return svc.ReadCsvTables(src);
        }

        public ReadOnlySpan<AsmForm> EmitForms(ReadOnlySpan<SdmOpCodeDetail> opcodes)
        {
            const string Pattern = "{0,-80} | {1}:{2} | {3}:{4}";
            var dst = Ws.Tables().Root + FS.file("asm.forms", FS.Txt);
            using var writer = dst.UnicodeWriter();
            var _forms = asm.forms(opcodes).View;
            var count = _forms.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(_forms,i));

            return _forms;
        }
    }
}