//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    using static Konst;
    using static Memories;

    /// <summary>
    /// Defines common messages that are issued during setup/execution
    /// </summary>
    static class FsmMessages
    {
        public static AppMsg Transition<S>(string machine, S s1, S s2)
            => AppMsg.Colorize($"{machine} Transitioned {s1} -> {s2}", AppMsgColor.Cyan);

        public static AppMsg Completed(string machine, FsmStats stats, bool asPlanned)
            => AppMsg.Colorize($"{machine} executed for {stats.Runtime.Ms} ms and completed" 
            + (asPlanned ? $" as planned after receiving {stats.ReceiptCount} events and experiencing {stats.TransitionCount} transitions" : " abnormally"), 
                AppMsgColor.Blue);
        
        public static AppMsg Receipt<E>(string machine, E input, ulong receipts)
            => AppMsg.Babble($"{machine} received event {input.ToString().PadLeft(6)} | Total Receipts: {receipts}");

        public static AppMsg Error(string machine, Exception error)
            => AppMsg.Error($"{machine} encountered an error: {error}");

        public static AppMsg ReceiptAfterFinish(string machine)
            => AppMsg.Warn($"{machine} continuing to receive input after finished has been signaled");

        public static AppMsg ReceiptBeforeStart(string machine)
            => AppMsg.Warn($"{machine} received input before start");
    }
}