//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    [ApiHost]
    public readonly struct Stateless : IStateless<object>
    {
        [Op]
        public static Type[] hosts(Assembly src)
            => src.GetTypes().Where(t => Attribute.IsDefined(t,typeof(StatelessAttribute)));

        [Op]
        public static Stateless<C> activate<C>(Type host)
            => new Stateless<C>(host, typeof(C), (C)Activator.CreateInstance(host));

        [Op]
        public static Stateless activate(Type host, Type contract)
            => new Stateless(host, contract, Activator.CreateInstance(host));

        public Type HostType {get;}

        public uint HostId {get;}

        public Type ContractType {get;}

        public uint ContractId {get;}

        public ulong ServiceId {get;}

        public object Service {get;}

        [MethodImpl(Inline)]
        public Stateless(Type host, Type contract, object svc)
        {
            HostType = host;
            HostId = (uint)host.MetadataToken;
            ContractType = contract;
            ContractId = (uint)contract.MetadataToken;
            Service = svc;
            ServiceId = (ulong)HostId | ((ulong)ContractId << 32);
        }
    }
}