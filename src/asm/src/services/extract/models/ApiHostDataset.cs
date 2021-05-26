//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Root;

    public struct ApiHostDataset
    {
        public ResolvedHost HostResolution;

        public ApiHostExtracts HostExtracts;

        public ApiMemberBlocks HostBlocks;

        public Index<AsmRoutine> Routines;

        public uint HostBlockCount
        {
            [MethodImpl(Inline)]
            get=> HostBlocks.Count;
        }

        public ApiHostUri Host
        {
            [MethodImpl(Inline)]
            get => HostResolution.Host;
        }

        public Index<ResolvedMethod> ResolvedMethods
        {
            [MethodImpl(Inline)]
            get => HostResolution.Methods;
        }

        public Index<ApiMember> Members
        {
            get => HostExtracts.Storage.Select(x => x.Member);
        }

        public Index<ApiInstruction> Instructions
            => Routines.SelectMany(x => x.Instructions);

    }
}