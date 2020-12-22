//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public abstract class Report<R> : IReport, INullity
        where R : struct
    {
        public R[] Records {get;}

        public TableRenderSpec RenderSpec {get;}

        public Report(R[] records, TableRenderSpec format)
        {
            Records = records;
            RenderSpec = format;
        }

        public string[] HeaderLabels
        {
            [MethodImpl(Inline)]
            get => RenderSpec.Headers;
        }

        public int FieldCount
        {
             [MethodImpl(Inline)]
             get => RenderSpec.FieldCount;
        }
        public ref readonly R this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Records[index];
        }

        public int RecordCount
        {
            [MethodImpl(Inline)]
            get => Records.Length;
        }

        public bool IsEmpty
            => RecordCount == 0;

        public bool IsNonEmpty
            => RecordCount != 0;

        public abstract Option<FS.FilePath> Save(FS.FilePath dst);

        public virtual string ReportName
            => GetType().DisplayName();
    }

    public class Report<F,R> : Report<R>, TReport<F,R>
        where F : unmanaged, Enum
        where R : struct, ITabular
    {
        public static DatasetArchive<F,R> Log => default;

        public static Report<F,R> Empty
            => new Report<F,R>();

        public new TableRenderSpec<F> RenderSpec {get;}

        public Report(R[] records)
            : base(records, Table.renderspec<F>())
        {
            RenderSpec = Table.renderspec<F>();
        }

        public Report()
            : base(Array.Empty<R>(), Table.renderspec<F>())
        {
            RenderSpec = Table.renderspec<F>();
        }

        [MethodImpl(Inline)]
        public override Option<FS.FilePath> Save(FS.FilePath dst)
            => Log.Save(Records, dst);
    }

   public class Report<B,F,R> : Report<F,R>, INullary<B>
        where F : unmanaged, Enum
        where R : struct, ITabular
        where B : Report<B,F,R>, new()
    {
        public static new B Empty => new B();

        public Report(R[] records)
            : base(records)
        {

        }

        public Report()
            : base(new R[]{})
        {

        }

        public B Zero
            => Empty;
    }
}