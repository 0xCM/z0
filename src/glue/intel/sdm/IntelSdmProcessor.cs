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

        const string toc = nameof(toc);

        DocServices DocServices;

        AsmWorkspace Workspace;

        protected override void OnInit()
        {
            Workspace = Wf.AsmWorkspace();
            DocServices = Wf.DocServices();
        }

        public Outcome Run()
        {
            var result = Outcome.Success;

            try
            {
                ImportRoot().Clear();

                result = EmitCharMaps();
                if(result.Fail)
                    return result;

                result = EmitLinedSdm();
                if(result.Fail)
                    return result;

                result = EmitSplitSdm();
                if(result.Fail)
                    return result;

                result = EmitCombinedToc();
                if(result.Fail)
                    return result;

                result = EmitTocAnalysis();
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