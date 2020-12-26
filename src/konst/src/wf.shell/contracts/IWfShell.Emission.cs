//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static WfEvents;

    partial interface IWfShell
    {
        WfExecFlow EmittingTable(Type type, FS.FilePath dst)
        {
            signal(this).TableEmitting(type, dst);
            return Flow();
        }

        WfExecFlow EmittingTable<T>(FS.FilePath dst)
            where T : struct
        {
            signal(this).TableEmitting<T>(dst);
            return Flow();
        }

        void EmittedTable<T>(WfStepId step, Count count, FS.FilePath dst)
            where T : struct
                => Raise(tableOut<T>(step, count, dst, Ct));

        void EmittedTable<T>(Count count, FS.FilePath dst, WfExecFlow flow)
            where T : struct
                => Raise(tableOut<T>(Host, count, dst, Ct));

        void EmittedTable<T>(Count count, FS.FilePath dst)
            where T : struct
                => Raise(tableOut<T>(Host, count, dst, Ct));

        void EmittedTable(Type type, Count count, FS.FilePath dst)
            => Raise(tableOut(Host, type, count, dst, Ct));

        void EmittingFile<T>(T source, FS.FilePath dst)
            => Raise(fileEmitting<T>(Host, source, dst, Ct));

        void EmittedFile<T>(T source, Count count, FS.FilePath dst)
            => Raise(fileOut(Host, source, count, dst, Ct));

        void EmittedFile(Count count, FS.FilePath dst)
            => Raise(fileOut(Host, dst, count, Ct));
    }
}