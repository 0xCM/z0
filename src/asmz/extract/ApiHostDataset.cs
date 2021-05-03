//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public struct ApiHostDataset
    {
        public ResolvedHost Resolution;

        public ApiHostExtracts HostExtracts;

        public ApiMemberBlocks HostBlocks;

        public Index<AsmRoutine> Routines;
    }
}