//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Singleton]
    public sealed class ApiCodeStore : WfService<ApiCodeStore>
    {
        ApiBlockIndex ApiBlocks;

        int Sequence;

        uint Offset;

        public ApiCodeStore()
        {
            Sequence = 0;
            Offset = 0;
            ApiBlocks = ApiBlockIndex.Empty;
        }

        public ApiBlockIndex IndexedBlocks()
        {
            if(ApiBlocks.IsEmpty)
                ApiBlocks = Wf.ApiIndexBuilder().IndexApiBlocks();
            return ApiBlocks;
        }
   }
}