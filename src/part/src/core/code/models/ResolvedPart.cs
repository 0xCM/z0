//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ResolvedPart
    {
        public PartId Part {get;}

        public Index<ResolvedHost> Hosts {get;}

        [MethodImpl(Inline)]
        public ResolvedPart(PartId part, Index<ResolvedHost> hosts)
        {
            Part = part;
            Hosts = hosts;
        }

        public uint MethodCount
        {
            get => (uint)Hosts.Select(x => (int)x.MethodCount).Storage.Sum();
        }

        public static ResolvedPart Empty
        {
            [MethodImpl(Inline)]
            get => new ResolvedPart(PartId.None, sys.empty<ResolvedHost>());
        }
    }
}