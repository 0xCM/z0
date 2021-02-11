//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class ApiAsmDataset
    {
        public ApiCodeBlocks Blocks {get;}

        public Index<ApiPartRoutines> Routines {get;}

        ApiAsmDataset()
        {
            Blocks = ApiCodeBlocks.Empty;
            Routines = Index<ApiPartRoutines>.Empty;
        }

        internal ApiAsmDataset(ApiCodeBlocks blocks, Index<ApiPartRoutines> routines)
        {
            Blocks = blocks;
            Routines = routines;
        }

        public static ApiAsmDataset Empty
            => new ApiAsmDataset();
    }
}