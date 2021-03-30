//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    [WfHost]
    public sealed class EmitFieldLiterals : WfHost<EmitFieldLiterals>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = FieldLiteralEmitter.create(wf);
            step.Run();
        }
    }

    public class FieldLiteralEmitter : WfService<FieldLiteralEmitter>
    {
        public FieldLiteralEmitter()
        {

        }

        FS.FolderPath Target
            => Wf.Db().TableRoot() + FS.folder(CliFieldName.TableId);

        Index<Paired<FieldRef,string>> Emit(ApiPartTypes src)
        {
            var fields = Clr.fieldrefs(src.Types);
            if(fields.Length != 0)
                return Emit(fields, Target + FS.file(src.Part.Format(), FS.Csv));
            else
                return Index<Paired<FieldRef,string>>.Empty;
        }

        public void Run()
        {
            Target.Clear();
            var parts = span(Wf.Api.Parts.Map(part => ApiPartTypes.from(part)));
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

        Index<Paired<FieldRef,string>> Emit(FieldRef[] src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var input = span(src);
            var count = input.Length;
            var buffer = sys.alloc<Paired<FieldRef,string>>(count);
            ref var emissions = ref first(buffer);

            using var writer = dst.Writer();
            writer.WriteLine(FormatHeader());

            for(var i=0u; i<count; i++)
            {
                try
                {
                    ref readonly var field = ref skip(input,i);
                    var formatted = formatLine(field);
                    seek(emissions, i) = (field,formatted);

                    writer.WriteLine(formatted);
                }
                catch(Exception e)
                {
                    Wf.Warn(e.Message);
                }
            }

            Wf.EmittedFile(flow, count);
            return buffer;
        }
    }
}