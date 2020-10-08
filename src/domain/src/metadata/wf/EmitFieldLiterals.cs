//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

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
            => Wf.Paths.TableRoot + FS.folder(ImageLiteralFieldTable.TableId);

        public EmitFieldLiteralsStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf;

            Wf.Created(Host);
        }

        void Emit(ApiPartTypes src)
        {
            var fields = Refs.fields(src.Types);
            if(fields.Length != 0)
                Emit(fields, Target + FS.file(src.Part.Format(), FileExtensions.Csv));
        }

        public void Run()
        {
            Target.Clear();
            var parts = span(Wf.Api.Storage.Map(part => ApiQuery.types(part)));
            foreach(var part in parts)
            {
                try
                {
                    Emit(part);
                }
                catch(Exception e)
                {
                    term.error(e);
                }
            }
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        const string Sep = "| ";

        [Op]
        public static string[] strings(Type src)
        {
            var fields = Literals.strings(src);
            var @base = address(src);
            var count = fields.Length;
            var offset = MemoryAddress.Empty;
            var buffer = sys.alloc<string>(count);
            var dst = span(buffer);

            for(var j=0u; j<count; j++)
            {
                ref readonly var field = ref fields[j];
                var content = Literals.@string(field) ?? EmptyString;
                seek(dst,j) = content;
                if(!text.blank(content))
                    offset += Refs.field(@base, offset, field).DataSize;
            }
            return buffer;
        }

        [Op]
        public static string formatLine(in FieldRef src)
        {
            const string Sep = "| ";

            var content = Literals.format(src).PadRight(48);
            var address = src.Address.Format().PadRight(16);
            var width = src.Width.Count.ToString().PadRight(16);
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
            Wf.Running(Host, dst.Name);
            var input = span(src);
            var count = input.Length;

            using var writer = dst.Writer();
            writer.WriteLine(FormatHeader());

            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(input,i);
                writer.WriteLine(formatLine(field));
            }

            Wf.Ran(Host, dst.Name);
        }
    }
}