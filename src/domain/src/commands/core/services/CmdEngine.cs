//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Diagnostics;

    using static Konst;

    public enum CmdEngineKind : byte
    {
        CmdExe = 1,

        Bash = 2,

        Custom = 4
    }

    public delegate void CmdEngineMessage(string content);

    public delegate void CmdEngineError(string content);

    public class CmdEngine : SystemAgent
    {
        CmdEngineSettings Settings {get;}

        ProcessStartInfo StartInfo {get;}

        CmdEngineMessage MessageReceiver {get;}

        CmdEngineError ErrorReceiver {get;}

        [MethodImpl(Inline)]
        public CmdEngine(IWfShell wf, CmdEngineSettings settings, ProcessStartInfo start,  CmdEngineMessage message, CmdEngineError error)
            : base(new WfAgentContext(wf), new AgentIdentity(10u,10u))
        {
            Settings = settings;
            StartInfo = start;
            MessageReceiver += message;
            ErrorReceiver += error;
        }
    }

    public struct CmdEngineSettings
    {
        public CmdEngineKind EngineKind;

        public FS.FilePath Path;
    }
}