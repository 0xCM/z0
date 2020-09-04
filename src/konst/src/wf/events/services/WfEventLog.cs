//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    public struct WfEventLog : IWfEventLog
    {
        readonly Lazy<StreamWriter> _Status;

        readonly Lazy<StreamWriter> _Errors;

        readonly IWfEventLog Relay;

        readonly object ErrorLock;

        readonly object StatusLock;

        public CorrelationToken Ct {get;}

        readonly ulong SessionId;

        static long SessionIdSource;

        [MethodImpl(Inline)]
        public WfEventLog(FS.FilePath status, FS.FilePath errors, IWfEventLog relay, CorrelationToken ct)
        {
            Ct = ct;
            StatusLock = new object();
            ErrorLock = new object();
            _Status = defer(() => status.Timestamped().Writer());
            _Errors = defer(() => errors.Timestamped().Writer());
            Relay = relay;
            SessionId = (ulong)atomic(ref SessionIdSource);
            Relay.Deposit(lifecycle("EventLogCreated"));
        }


         public void Deposit(IWfEvent src)
         {
            var emitted = Emit(src.Format(), src.IsError);
            Relay.Deposit(src);
         }

        public void Deposit(IAppEvent src)
        {
            Deposit(new WfStatus<string>(WfStepId.Empty, src.Format(), Ct, src.Flair));
            Relay.Deposit(src);
        }

        [MethodImpl(Inline)]
        public void Deposit<T>(in AppMsg<T> src)
        {
            var emitted = Emit(src.Format(), src.Kind == MessageKind.Error);
            Relay.Deposit(src);
        }

        [MethodImpl(Inline)]
        public void Deposit(in WfTermEvent src)
        {
            var emitted = Emit(src.Format(), src.Flair == FlairKind.Error);
            Relay.Deposit(src);
        }

        public void Deposit(IAppMsg src)
        {
            var emitted = Emit(src.Format(), src.IsError);
            Relay.Deposit(src);
        }

        bool WriteError(string content)
        {
            try
            {
                lock(ErrorLock)
                    Errors.WriteLine(content);
                return true;
            }
            catch(Exception e)
            {
                term.error(e);
                return false;
            }
        }

        bool WriteStatus(string content)
        {
            try
            {
                lock(StatusLock)
                    Status.WriteLine(content);
                return true;
            }
            catch(Exception e)
            {
                term.error(e);
                return false;
            }
        }

        StreamWriter Errors
        {
            [MethodImpl(Inline)]
            get => _Errors.IsValueCreated ? _Errors.Value : WriteHeader(ErrorLock, _Errors.Value);
        }

        StreamWriter Status
        {
            [MethodImpl(Inline)]
            get => _Status.IsValueCreated ? _Status.Value : WriteHeader(ErrorLock, _Status.Value);
        }

        StreamWriter WriteHeader(object locker, StreamWriter dst)
        {
            lock(locker)
            {
                dst.WriteLine(lifecycle("FirstEmission"));
                dst.WriteLine(text.PageBreak);
            }
            return dst;
        }

        [MethodImpl(Inline)]
        bool Emit(string content, bool error)
            => error ? WriteError(content) : WriteStatus(content);

        public void Dispose()
        {
            if(_Status.IsValueCreated)
            {
                Status.WriteLine(lifecycle("StatusLogDisposing"));
                Status.Flush();
                Status.Dispose();
            }

            if(_Errors.IsValueCreated)
            {
                Status.WriteLine(lifecycle("ErrorLogDisposing"));
                Errors.Flush();
                Errors.Dispose();
            }

            Relay.Deposit(lifecycle("EventLogDisposing"));
            Relay.Dispose();
        }

        [MethodImpl(Inline)]
        AppMsg lifecycle(string label)
            => AppMsg.info(text.format("## {0} | {1} | {2}", nameof(WfEventLog), SessionId, label));
   }
}