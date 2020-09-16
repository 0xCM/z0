//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IStateless
    {
        Type HostType {get;}


        Type ContractType {get;}

        uint HostId
            => (uint)HostType.MetadataToken;

        uint ContractId => (uint)ContractType.MetadataToken;

        ulong ServiceId
            => (ulong)HostId | ((ulong)ContractId << 32);
    }

    public interface IStateless<C> : IStateless
    {
        C Service {get;}
    }
}