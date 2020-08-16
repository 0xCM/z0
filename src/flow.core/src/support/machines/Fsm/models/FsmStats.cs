//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Captures state machine execution metrics
    /// </summary>
    public class FsmStats
    {        
        /// <summary>
        /// Identifies the machine within the executing process
        /// </summary>
        public string MachineId {get; set;}

        /// <summary>
        /// The time the machine received the start signal
        /// </summary>
        public ulong? StartTime {get; set;}

        /// <summary>
        /// The time the machine workflow completed
        /// </summary>
        public ulong? EndTime {get; set;}

        /// <summary>
        /// The number of received events
        /// </summary>
        public ulong ReceiptCount {get; set;}

        /// <summary>
        /// The number of state transitions that have occurred
        /// </summary>
        public uint TransitionCount {get; set;}      

        /// <summary>
        /// The time spent during active execution
        /// </summary>
        public Duration Runtime {get; set;}  

        public override int GetHashCode()
            => MachineId.GetHashCode();
    }
}