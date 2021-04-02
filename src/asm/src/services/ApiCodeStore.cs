//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Singleton]
    public sealed class ApiCodeStore : WfService<ApiCodeStore>
    {
        ApiCodeBlocks _CodeBlocks;

        int Sequence;

        uint Offset;

        public ApiCodeStore()
        {
            Sequence = 0;
            Offset = 0;
            _CodeBlocks = ApiCodeBlocks.Empty;
        }

        public ApiCodeBlocks CodeBlocks()
        {
            if(_CodeBlocks.IsEmpty)
                _CodeBlocks = Wf.ApiHexIndexer().IndexApiBlocks();
            return _CodeBlocks;
        }

        public void EmitAnalyses(ApiCodeBlocks src)
        {
            var routines = Wf.ApiIndexDecoder().Decode(src).Routines;
            var rowstore = Wf.AsmRowStore();
            rowstore.EmitCallRows(routines);
            rowstore.EmitJmpRows(routines);
        }
   }
}