//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    public struct ApiHostDataset
    {
        public ResolvedHost HostResolution;

        public ApiHostExtracts HostExtracts;

        public ApiMemberBlocks HostBlocks;

        public Index<AsmRoutine> Routines;

        public ApiHostUri Host
            => HostResolution.Host;

        public Index<ResolvedMethod> ResolvedMethods
            => HostResolution.Methods;

        public Index<ApiMember> Members
            => HostExtracts.Storage.Select(x => x.Member);

        public Index<ApiInstruction> Instructions
            => Routines.SelectMany(x => x.Instructions);
    }
}