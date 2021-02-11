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
        public ApiCodeBlocks Blocks {get; private set;}

        public Index<ApiPartRoutines> Routines {get;private set;}

        public AsmRowSets<IceMnemonic> RowSets {get;private set;}

        public Index<AsmJmpRow> Jumps {get;private set;}

        public Index<AsmCallRow> Calls {get;private set;}

        ApiAsmDataset()
        {
            Blocks = ApiCodeBlocks.Empty;
            Routines = Index<ApiPartRoutines>.Empty;
            RowSets = AsmRowSets<IceMnemonic>.Empty;
            Jumps = Index<AsmJmpRow>.Empty;
            Calls = Index<AsmCallRow>.Empty;
        }

        internal ApiAsmDataset(ApiCodeBlocks blocks)
        {
            Blocks = blocks;
            Routines = Index<ApiPartRoutines>.Empty;
            RowSets = AsmRowSets<IceMnemonic>.Empty;
            Jumps = Index<AsmJmpRow>.Empty;
            Calls = Index<AsmCallRow>.Empty;
        }

        internal ApiAsmDataset(ApiCodeBlocks blocks, Index<ApiPartRoutines> routines)
        {
            Blocks = blocks;
            Routines = routines;
            RowSets = AsmRowSets<IceMnemonic>.Empty;
            Jumps = Index<AsmJmpRow>.Empty;
            Calls = Index<AsmCallRow>.Empty;
        }

        internal ApiAsmDataset(ApiCodeBlocks blocks, Index<ApiPartRoutines> routines, AsmRowSets<IceMnemonic> rows, Index<AsmJmpRow> jumps, Index<AsmCallRow> calls)
        {
            Blocks = blocks;
            Routines = routines;
            RowSets = rows;
            Jumps = jumps;
            Calls = calls;

        }

        internal ApiAsmDataset With(ApiCodeBlocks src)
        {
            Blocks = src;
            return this;
        }

        internal ApiAsmDataset With(Index<ApiPartRoutines> src)
        {
            Routines = src;
            return this;
        }

        internal ApiAsmDataset With(AsmRowSets<IceMnemonic> src)
        {
            RowSets = src;
            return this;
        }

        internal ApiAsmDataset With(Index<AsmJmpRow> src)
        {
            Jumps = src;
            return this;
        }

        internal ApiAsmDataset With(Index<AsmCallRow> src)
        {
            Calls = src;
            return this;
        }

        public static ApiAsmDataset Empty
            => new ApiAsmDataset();
    }
}