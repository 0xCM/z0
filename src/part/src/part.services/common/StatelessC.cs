//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Stateless<C> : IStateless<C>
    {
        public Type HostType {get;}

        public uint HostId {get;}

        public Type ContractType {get;}

        public uint ContractId {get;}

        public ulong ServiceId {get;}

        public C Service {get;}

        [MethodImpl(Inline)]
        public Stateless(Type host, Type contract, C svc)
        {
            HostType = host;
            HostId = (uint)host.MetadataToken;
            ContractType = contract;
            ContractId = (uint)contract.MetadataToken;
            Service = svc;
            ServiceId = (ulong)HostId | ((ulong)ContractId << 32);
        }

        [MethodImpl(Inline)]
        public static implicit operator C(Stateless<C> src)
            => src.Service;
    }
}