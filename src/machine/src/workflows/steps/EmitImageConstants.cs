//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;
    using static z;

    using F = ImageConstantField;
    using W = ImageConstantFieldWidth;

    public readonly ref struct EmitImageConstants
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly FolderPath TargetDir;

        readonly IPart[] Parts;

        [MethodImpl(Inline)]
        public EmitImageConstants(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = Wf.Api.Storage;
            TargetDir = wf.ResourceRoot + FolderName.Define("constants");
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host);

            foreach(var part in Parts)
            {
                try
                {
                    Emit(part);
                }
                catch(Exception e)
                {
                    Wf.Error(Host, e);
                }
            }

            Wf.Ran(Host);
        }

        ReadOnlySpan<ImageConstantRecord> Read(IPart part)
        {
            using var reader = PeTableReader.open(part.PartPath());
            return reader.ReadConstants();
        }

        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath = TargetDir + FileName.define(id.Format(), DataExt);
            Wf.Running(Host, dstPath.Name);

            var data = Read(part);
            var count = data.Length;
            var dst = Table.formatter<F,W>();

            dst.EmitHeader();
            for(var i=0u; i<count; i++)
                format(skip(data,i), dst);

            using var writer = dstPath.Writer();
            writer.Write(dst.Render());

            Wf.Ran(Host, delimit(id, count));
        }

        static ref readonly RecordFormatter<F,W> format(in ImageConstantRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.ParentId, src.ParentId);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.DataType, src.DataType);
            dst.Delimit(F.Value, src.Content);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}