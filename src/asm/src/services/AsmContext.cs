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

        public IWfRuntime Wf {get;}

        public IAppMsgQueue MessageQueue {get;}

        public event Action<IAppMsg> Next;

        public ICaptureServices CaptureServices {get;}

        public IPolyrand Random {get;}

        [MethodImpl(Inline)]
        public AsmContext(IAppContext app, IWfRuntime wf)
        {
            ContextRoot = app;
            Wf = wf;
            MessageQueue = app.MessageQueue;
            Next = app.MessageRelay;
            app.MessageQueue.Next += Relay;
            Random = app.Random;
            CaptureServices = Wf.CaptureServices(this);
        }

        [MethodImpl(Inline)]
        void Relay(IAppMsg msg)
            => Next(msg);

        public void Deposit(IAppMsg msg)
            => MessageQueue.Deposit(msg);

        public void Notify(string msg, LogLevel? severity = null)
            => MessageQueue.Notify(msg, severity);

        public IReadOnlyList<IAppMsg> Dequeue()
            => MessageQueue.Dequeue();

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => MessageQueue.Flush(e);

        public void Emit(FS.FilePath dst)
            => MessageQueue.Emit(dst);
    }
}