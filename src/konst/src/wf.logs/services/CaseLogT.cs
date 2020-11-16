//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;
    using static z;

    using api = CaseLogs;

    public class CaseLog<F,R> : ICaseLog<R>
        where R : ITabular
        where F : unmanaged, Enum
    {
        object Locker;

        int Counter;

        readonly FileStream Status;

        readonly FS.FilePath Target;

        internal CaseLog(FS.FilePath dst)
        {
            Target = dst;
            Locker = new object();
            Status = dst.Stream();
            api.write(api.header<F>(), Status);
            Counter = 0;
        }

        public void Deposit(params R[] src)
        {
            try
            {
                lock(Locker)
                    api.deposit(src, Status);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Dispose()
            => Status.Dispose();
    }
}