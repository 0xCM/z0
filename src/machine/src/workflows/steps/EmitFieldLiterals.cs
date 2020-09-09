//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Asm;

    using static z;
    using static Konst;
    using static EmitFieldLiteralsStep;

    public readonly ref struct EmitFieldLiterals
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        FolderPath Target
            => Wf.ResourceRoot + FolderName.Define("fields");

        ApiModules Modules
            => ApiQuery.modules();

        public EmitFieldLiterals(IWfShell context, CorrelationToken ct)
        {
            Ct = ct;
            Wf = context;
            Wf.Created(StepId);
        }

        void Emit(PartTypes src)
        {
            var fields = Refs.fields(src.Types);
            if(fields.Length != 0)
                Emit(fields, Target + FileName.define(src.Part.Format(), FileExtensions.Csv));
        }

        public void Run()
        {
            Target.Clear();
            var parts = span(Modules.Parts.Storage.Map(part => PartTypes.from(part)));
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
            Wf.Disposed(StepId);
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

        static string FormatLine(FieldRef src)
        {
            var content = Literals.format(src).PadRight(48);
            var address = src.Address.Format().PadRight(16);
            var width = src.Width.Count.ToString().PadRight(16);
            var type = src.Field.DeclaringType.Name.PadRight(36);
            var field = src.Field.Name.PadRight(36);
            var line = text.concat(address, Sep, width, Sep,type, Sep, field, Sep, content, Sep);
            return line;
        }

        void Emit(FieldRef[] src, FilePath dst)
        {
            Wf.Running(StepId, dst.Name);
            var input = span(src);
            var count = input.Length;

            using var writer = dst.Writer();
            writer.WriteLine(FormatHeader());

            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(input,i);
                writer.WriteLine(formatLine(field));
            }

            Wf.Ran(StepId, dst.Name);
        }
    }
}