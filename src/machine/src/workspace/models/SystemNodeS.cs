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

    /// <summary>
    /// Represents an describes a computational resource
    /// </summary>
    /// <typeparam name="T">The specialized subtype</typeparam>
    public abstract class SystemNode<T> : DataObject<T>, ISystemNode
        where T : SystemNode<T>
    {
        public string NodeName { get; }

        public string NodeServer { get; }

        public string NetworkName { get; }

        public SystemNodeIdentifier NodeIdentifier {get;}

        public string ExternalIP {get;}
        
        public int? Port {get;}

        public bool IsLocal { get; }

        public static implicit operator SystemNodeIdentifier(SystemNode<T> n)
            => n.NodeIdentifier;

        protected SystemNode(string name, SystemNodeIdentifier id, string server, int? port = null, bool local = false)
        {
            NodeName = name;
            NodeIdentifier = id;
            NodeServer = server;
            Port = port;
            IsLocal = local;
        }

        protected SystemNode(string name, SystemNodeIdentifier id, string server)
        {
            NodeName = name;
            NodeServer = server;
            NodeIdentifier = id;
        }

        protected SystemNode(string name, SystemNodeIdentifier id,  string server, string networkId, string ip, int? port = null, bool local = false)
        {
            NodeName = name;
            NodeServer = server;
            NodeIdentifier = id;
            NetworkName = networkId;
            ExternalIP = ip;
            Port = port;
            IsLocal = local;
        }

        protected SystemNode(string name)
        {
            NodeName = name;
            NodeServer = name;
            NodeIdentifier = name.Replace("Node", "n");
            IsLocal = true;
            NetworkName = "localhost";                    
        }

        public override string ToString()
            => NodeName;
    }
}