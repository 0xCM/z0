//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;

    public class AsmContext : IAsmContext
    {
        public IAppContext ContextRoot {get;}

        public IWfShell Wf {get;}

        public event Action<IAppMsg> Next;

        public IAppMsgQueue MessageQueue {get;}

        public ICaptureServices CaptureServices {get;}

        public IPolyrand Random {get;}

        [MethodImpl(Inline)]
        void Relay(IAppMsg msg)
            => Next(msg);

        [MethodImpl(Inline)]
        public AsmContext(IAppContext root)
        {
            ContextRoot = root;
            MessageQueue = root.MessageQueue;
            Next = root.MessageRelay;
            root.MessageQueue.Next += Relay;
            CaptureServices = Capture.Services;
            Random = root.Random;
        }

        [MethodImpl(Inline)]
        public AsmContext(IAppContext app, IWfShell wf)
        {
            Wf = wf;
            ContextRoot = app;
            MessageQueue = app.MessageQueue;
            Next = app.MessageRelay;
            app.MessageQueue.Next += Relay;
            CaptureServices = Capture.Services;
            Random = app.Random;
        }

        public void Deposit(IAppMsg msg)
            => MessageQueue.Deposit(msg);

        public void Notify(string msg, LogLevel? severity = null)
            => MessageQueue.Notify(msg, severity);

        public IReadOnlyList<IAppMsg> Dequeue()
            => MessageQueue.Dequeue();

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => MessageQueue.Flush(e);

        public void Emit(FilePath dst)
            => MessageQueue.Emit(dst);
    }
}