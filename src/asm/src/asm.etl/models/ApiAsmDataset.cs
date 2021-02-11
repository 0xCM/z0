//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    public class UriIndex<T> : Dictionary<OpUri,T>
    {
        public bool Include(OpUri key, T value)
            => TryAdd(key, value);

    }


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