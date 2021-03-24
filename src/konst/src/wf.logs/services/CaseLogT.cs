//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Part;
    using static memory;

    class CaseLog<F,R> : ICaseLog<R>
        where R : struct, ITextual
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
            FS.write(Datasets.header53<F>(), Status);
            Counter = 0;
        }

        public void Deposit(params R[] src)
        {
            if(src == null || src.Length == 0)
                return;

            var count = src.Length;
            var records = @readonly(src);
            try
            {
                lock(Locker)
                {
                    for(var i=0; i<count; i++)
                        FS.write(skip(records,i).Format(), Status);
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Dispose()
            => Status?.Dispose();
    }
}