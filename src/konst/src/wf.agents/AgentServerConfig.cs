//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines a server configuration record
    /// </summary>
    public readonly struct AgentServerConfig
    {
        /// <summary>
        /// Identifies the server to which the configuration applies
        /// </summary>
        public readonly uint ServerId;

        /// <summary>
        /// A descriptive name
        /// </summary>
        public readonly string ServerName;

        /// <summary>
        /// The CPU core to which the server is assigned
        /// </summary>
        public readonly uint CoreNumber;

        public AgentServerConfig(uint id, string name, uint core)
        {
            ServerId = id;
            ServerName = name;
            CoreNumber = core;
        }

        public override string ToString()
            => $"Server {ServerId}, Core={CoreNumber}";
    }
}