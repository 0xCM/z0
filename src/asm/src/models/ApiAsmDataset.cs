//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public sealed class ApiAsmDataset
    {
        public ApiBlockIndex Blocks {get;}

        public Index<ApiPartRoutines> Routines {get;}

        ApiAsmDataset()
        {
            Blocks = ApiBlockIndex.Empty;
            Routines = Index<ApiPartRoutines>.Empty;
        }

        internal ApiAsmDataset(ApiBlockIndex blocks, Index<ApiPartRoutines> routines)
        {
            Blocks = blocks;
            Routines = routines;
        }

        public static ApiAsmDataset Empty
            => new ApiAsmDataset();
    }
}