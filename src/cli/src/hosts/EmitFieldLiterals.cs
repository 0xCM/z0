//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;

    [WfHost]
    public sealed class EmitFieldLiterals : WfHost<EmitFieldLiterals>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitFieldLiteralsStep(wf, this);
            step.Run();
        }
    }

    readonly ref struct EmitFieldLiteralsStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        FS.FolderPath Target
            => Wf.Db().TableRoot() + FS.folder(CliFieldName.TableId);

        public EmitFieldLiteralsStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(host);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        void Emit(ApiPartTypes src)
        {
            var fields = Clr.fieldrefs(src.Types);
            if(fields.Length != 0)
                Emit(fields, Target + FS.file(src.Part.Format(), FileExtensions.Csv));
        }

        public void Run()
        {
            Target.Clear();
            var parts = span(Wf.Api.Parts.Map(part => ApiQuery.types(part)));
            foreach(var part in parts)
            {
                try
                {
                    Emit(part);
                }
                catch(Exception e)
                {
                    Wf.Error(e);
                }
            }
        }


        const string Sep = "| ";

        [Op]
        public static string formatLine(in FieldRef src)
        {
            const string Sep = "| ";

            var content = ClrLiterals.format(src).PadRight(48);
            var address = src.Address.Format().PadRight(16);
            var width = src.Width.Content.ToString().PadRight(16);
            var type = src.Field.DeclaringType.Name.PadRight(36);
            var field = src.Field.Name.PadRight(36);
            var line = text.concat(address, Sep, width, Sep,type, Sep, field, Sep, content, Sep);
            return line;
        }

        static string FormatHeader()
            => text.concat(
                "FieldAddress".PadRight(16), Sep,
                "FieldWidth".PadRight(16), Sep,
                "DeclaringType".PadRight(36), Sep,
                "FieldName".PadRight(36), Sep,
                "Value".PadRight(48), Sep
                );

        void Emit(FieldRef[] src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var input = span(src);
            var count = input.Length;

            using var writer = dst.Writer();
            writer.WriteLine(FormatHeader());

            for(var i=0u; i<count; i++)
            {
                try
                {
                    ref readonly var field = ref skip(input,i);
                    writer.WriteLine(formatLine(field));
                }
                catch(Exception e)
                {
                    Wf.Warn(e.Message);
                }
            }

            Wf.EmittedFile(flow, (Count)count, dst);
        }
    }
}