//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Characterizes a service reification
    /// </summary>
    public readonly struct ServiceSpec
    {
        public Type Host {get;}

        public uint Discriminator {get;}

        public Type ContractType {get;}

        public Type[] ContractArgs {get;}

        [MethodImpl(Inline)]
        public ServiceSpec(Type host, Type contract, params Type[] args)
        {
            Host = host;
            ContractType = contract;
            ContractArgs = args;
            Discriminator = 0;
        }

        [MethodImpl(Inline)]
        public ServiceSpec(Type host, Type contract, uint discriminator, params Type[] args)
        {
            Host = host;
            ContractType = contract;
            ContractArgs = args;
            Discriminator = discriminator;
        }
    }
}