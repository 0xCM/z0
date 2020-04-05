//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Core;

    /// <summary>
    /// Defines common messages that are issued during setup/execution
    /// </summary>
    static class FsmMessages
    {
        public static AppMsg Transition<S>(string machine, S s1, S s2)
            => msg($"{machine} Transitioned {s1} -> {s2}", AppMsgKind.HiliteCL);

        public static AppMsg Completed(string machine, FsmStats stats, bool asPlanned)
            => msg($"{machine} executed for {stats.Runtime.Ms} ms and completed" 
            + (asPlanned ? $" as planned after receiving {stats.ReceiptCount} events and experiencing {stats.TransitionCount} transitions" : " abnormally"), 
                AppMsgKind.HiliteBL);
        
        public static AppMsg Receipt<E>(string machine, E input, ulong receipts)
            => msg($"{machine} received event {input.ToString().PadLeft(6)} | Total Receipts: {receipts}", AppMsgKind.Babble);

        public static AppMsg Error(string machine, Exception error)
            => msg($"{machine} encountered an error: {error}", AppMsgKind.Error);

        public static AppMsg ReceiptAfterFinish(string machine)
            => msg($"{machine} continuing to receive input after finished has been signaled", AppMsgKind.Warning);

        public static AppMsg ReceiptBeforeStart(string machine)
            => msg($"{machine} received input before start", AppMsgKind.Warning);
    }
}