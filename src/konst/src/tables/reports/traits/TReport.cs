//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    interface TReport<F,R> : IReport
        where F : unmanaged, Enum
        where R : struct, ITabular
    {
        R[] Records {get;}

        string IReport.ReportName
            => typeof(R).DisplayName();

        TableStore<F,R> Log
            => default;

        int IReport.RecordCount
        {
            [MethodImpl(Inline)]
            get => Records.Length;
        }

        bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => RecordCount == 0;
        }

        bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => RecordCount != 0;
        }

        string[] IReport.HeaderLabels
        {
            [MethodImpl(Inline)]
            get => Tabular.Headers<F>();
        }

        [MethodImpl(Inline)]
        Option<FilePath> Save(FilePath dst)
            => Log.Save(Records, dst);

        TableRenderSpec<F> RenderSpec
        {
            [MethodImpl(Inline)]
            get => Table.renderspec<F>();
        }
    }
}