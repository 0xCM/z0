//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [ApiHost]
    public partial class IntelSdmProcessor : AppService<IntelSdmProcessor>
    {
        const string dataset ="sdm";

        const string logs = nameof(logs);

        const string datasetlogs = dataset + "." + logs;

        const string splits = nameof(splits);

        const string lined = nameof(lined);

        const string charmap = nameof(charmap);

        const string unicode = nameof(unicode);

        const string toc = nameof(toc);

        const string txt = nameof(txt);

        const string unmapped = nameof(unmapped);

        DocServices DocServices;

        AsmWorkspace Workspace;

        CharMapper CharMapper;

        protected override void OnInit()
        {
            Workspace = Wf.AsmWorkspace();
            DocServices = Wf.DocServices();
            CharMapper = Wf.CharMapper();
        }

        public void ClearTargets()
        {
            ImportRoot().Clear();
        }

        public Outcome Run()
        {
            var result = Outcome.Success;

            try
            {
                ClearTargets();

                result = EmitCharMaps();
                if(result.Fail)
                    return result;

                result = EmitLinedSdm();
                if(result.Fail)
                    return result;

                result = EmitSdmSplits();
                if(result.Fail)
                    return result;

                result = EmitCombinedToc();
                if(result.Fail)
                    return result;

                result = EmitAnalysis();
                if(result.Fail)
                    return result;
            }
            catch(Exception e)
            {
                Wf.Error(e);
                result = e;
            }

            return result;
        }
    }
}