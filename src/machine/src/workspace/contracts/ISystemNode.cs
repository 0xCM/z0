//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{

    public interface ISystemNode
    {
        string NodeName { get; }

        string NodeServer { get; }

        int? Port { get; }

        bool IsLocal { get; }

        SystemNodeIdentifier NodeIdentifier { get; }
    }
}