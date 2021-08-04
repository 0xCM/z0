//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class IntelSdm
    {
        public Outcome EmitCombinedToc()
        {
            var result = Outcome.Success;
            var src = TocPaths();
            if(src.IsEmpty)
                return (false, "Found no toc's to combine");

            var encoding = pair(TextEncodingKind.Unicode, TextEncodingKind.Unicode);
            var dst = TocImportPath();
            var flow = Wf.Running(string.Format("Creating combined toc from {0} source files", src.Length));
            DocServices.CombineDocs(src, dst, encoding);
            Wf.Ran(flow);
            return result;
        }

        static bool IsTocPart(FS.FilePath src)
        {
            var f = src.FileName.Format();
            if(src.Ext == FS.Txt)
            {
                var name = src.WithoutExtension.Format();
                if(name.Contains(toc) && name.EndsWithDigit())
                    return true;
            }
            return false;
        }
    }
}