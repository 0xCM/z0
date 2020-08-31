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

    public struct WfEventLog : IMultiSink, IWfEventLog
    {
        readonly StreamWriter Status;

        readonly StreamWriter Errors;

        readonly IWfEventLog Relay;

        readonly object ErrorLock;

        readonly object StatusLock;

        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]
        public WfEventLog(FS.FilePath status, FS.FilePath errors, IWfEventLog relay, CorrelationToken ct)
        {
            Ct = ct;
            StatusLock = new object();
            ErrorLock = new object();
            Status = status.Timestamped().Writer();
            Errors = errors.Timestamped().Writer();
            Relay = relay;
        }

         public void Deposit(IWfEvent src)
         {
            var formatted = src.Format();

            if(src.IsError)
            {
                lock(ErrorLock)
                    Errors.WriteLine(formatted);
            }
            else
            {
                lock(StatusLock)
                    Status.WriteLine(formatted);
            }

            Relay.Deposit(src);
        }

        public void Deposit(IAppEvent src)
        {
            Deposit(new WfStatus<string>(WfStepId.Empty, src.Format(), Ct, src.Flair));
        }

        public void Deposit(IAppMsg src)
        {
            var formatted = src.Format();
            if(src.IsError)
            {
                lock(ErrorLock)
                    Errors.WriteLine(formatted);
            }
            else
            {
                lock(StatusLock)
                    Status.WriteLine(formatted);
            }

            Relay.Deposit(src);
        }

        public void Deposit(in WfTermEvent src)
            => Deposit(src as IWfEvent);

         public void Dispose()
         {
            Status.Flush();
            Status.Dispose();

            Errors.Flush();
            Errors.Dispose();

            Relay.Deposit(new WfStepRan<string>(nameof(WfEventLog), "Bye", Ct));
            Relay.Dispose();
        }
   }
}