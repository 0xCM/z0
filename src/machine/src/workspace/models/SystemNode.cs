//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using N = SystemNode;

    public sealed class SystemNode : SystemNode<SystemNode>
    {
        static string ExecutingNodeName { get; }
            = "Node00"; //EnvironmentVariables.SystemNode.ResolveValue().ValueOrDefault("localhost");

        public static implicit operator SystemNodeIdentifier(SystemNode n)
            => n.NodeIdentifier;

        public static SystemNode Local 
            => new SystemNode(ExecutingNodeName);
 
        SystemNode(string NodeName)
            : base(NodeName)
        {

        }

        public SystemNode(string NodeName, SystemNodeIdentifier NodeIdentifier, string NodeServer, int? Port = null, bool IsLocal = false)
            : base(NodeName, NodeIdentifier, NodeServer, Port, IsLocal)
        {

        }

        public SystemNode(string NodeName, SystemNodeIdentifier NodeIdentifier, string NodeServer)
            : base(NodeName, NodeIdentifier, NodeServer)
        {

        }

        public SystemNode(string NodeName, SystemNodeIdentifier NodeIdentifier,  string NodeServer, string NetworkName, string ExternalIP, 
                int? Port = null, bool IsLocal = false)
            : base(NodeName, NodeIdentifier, NodeServer, NetworkName, ExternalIP, Port, IsLocal)
        {

        }

        public Link<SystemNode> LinkTo(SystemNode dst)
            => new Link<SystemNode>(this, dst);

        public Link<SystemNode> LinkToSelf()
            => new Link<SystemNode>(this, this);
    }
}