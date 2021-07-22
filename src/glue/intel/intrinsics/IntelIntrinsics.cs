//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Xml;
    using System.IO;
    using System.Collections.Generic;

    using static Root;
    using static core;
    using static XedModels;
    using static IntrinsicsModels;

    public class IntelIntrinsics  : AppService<IntelIntrinsics>
    {
        const string dataset = "intrinsics";

        AsmWorkspace Workspace;

        protected override void Initialized()
        {
            Workspace = Wf.AsmWs();
        }

        public ReadOnlySpan<Intrinsic> Emit()
        {
            var parsed = Parse();
            EmitLog(parsed);
            EmitTable(parsed);
            EmitHeader(parsed);
            EmitAlogrithms(parsed);
            return parsed;
        }

        XmlDoc XmlSouceDoc()
        {
            var src = Workspace.DataSource(dataset) + FS.file("intel-intrinsics", FS.Xml);
            return text.xml(src.ReadUtf8());
        }

        ReadOnlySpan<Intrinsic> Parse()
            => Parse(XmlSouceDoc());

        void EmitLog(ReadOnlySpan<Intrinsic> src)
        {
            var count = src.Length;
            var dst = Workspace.ImportDir(dataset) + FS.file(dataset, FS.Log);
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(src,i).Format());
            Wf.EmittedFile(flow, count);
        }

        void EmitAlogrithms(ReadOnlySpan<Intrinsic> src)
        {
            var dir = Workspace.ImportDir("intrinsics.alg");
            dir.Clear();
            var count = src.Length;

            var flow = Wf.Running(string.Format("Emitting algorithms for {0} intrinsics to {1}", count, dir));
            using var unknown =  (dir + FS.file("None",FS.Alg)).Writer();
            var xed = IFormType.None;
            var writer = default(StreamWriter);
            var path = FS.FilePath.Empty;
            var buffer = text.buffer();

            for(var i=0; i<count; i++)
            {
                ref readonly var intrinsic = ref skip(src,i);
                body(intrinsic, buffer);
                if(instruction(intrinsic, out var ix) && ix.xed != 0)
                {
                    if(xed == 0)
                    {
                        xed = ix.xed;
                        path = dir + FS.file(xed.ToString(), FS.Alg);
                        writer = path.Writer(true);
                    }
                    else
                    {
                        xed = ix.xed;
                        if(!writer.Equals(unknown))
                        {
                            writer.Flush();
                            writer.Dispose();
                            path = dir + FS.file(xed.ToString(), FS.Alg);
                            writer = path.Writer(true);
                        }
                    }
                }

                if(writer == null)
                    writer = unknown;

                writer.WriteLine(sig(intrinsic));
                writer.WriteLine(buffer.Emit());
            }

            if(writer != null)
            {
                writer.Flush();
                writer.Dispose();
            }

            Wf.Ran(flow, string.Format("Emitted {0} algoirthms", count));
        }

        void EmitHeader(ReadOnlySpan<Intrinsic> src)
        {
            var dst = Workspace.ImportDir(dataset) + FS.file(dataset, FS.H);
            var flow = Wf.EmittingFile(dst);
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(string.Format("{0};", sig(skip(src,i))));
            Wf.EmittedFile(flow, count);
        }

        static bool instruction(Intrinsic src, out Instruction dst)
        {
            var instructions = src.instructions;
            if(instructions.Count!=0)
            {
                dst = instructions[0];
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        void Summarize(ReadOnlySpan<Intrinsic> src, List<IntelIntrinsic> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                Fill(skip(src,i),out var record);
                dst.Add(record);
            }
        }

        void Fill(in Intrinsic src, out IntelIntrinsic dst)
        {
            dst.Name = src.name;
            dst.CpuId = src.CPUID.Map(x => x.Content);
            dst.Types = src.types.Map(x => x.Content);
            dst.Category = src.category;
            dst.Signature = sig(src);

            if(instruction(src, out var ix))
            {
                dst.Instruction = string.Format("{0} {1}", ix.name, ix.form);
                dst.IForm = ix.xed;
            }
            else
            {
                dst.Instruction = EmptyString;
                dst.IForm = default;
            }
        }

        void EmitTable(ReadOnlySpan<Intrinsic> src)
        {
            var dst = Workspace.ImportTable<IntelIntrinsic>();
            var flow = Wf.EmittingTable<IntelIntrinsic>(dst);
            var rows = list<IntelIntrinsic>();
            Summarize(src, rows);
            var count = Tables.emit(rows.ViewDeposited(), IntelIntrinsic.RenderWidths,dst);
            EmittedTable(flow,count);
        }

        ReadOnlySpan<Intrinsic> Parse(XmlDoc src)
        {
            const ushort max = 7500;
            var entries = new Intrinsic[max];
            var i = -1;
            using var reader = XmlReader.Create(new StringReader(src.Content));
            while (reader.Read() && i<max - 1)
            {
                if(reader.NodeType == XmlNodeType.Element)
                {
                    switch(reader.Name)
                    {
                        case Intrinsic.ElementName:
                            i++;
                            entries[i] = create();
                            entries[i].content = reader.Value;
                            entries[i].tech = reader[nameof(Intrinsic.tech)];
                            entries[i].name = reader[nameof(Intrinsic.name)];
                        break;

                        case Operation.ElementName:
                            read(reader, ref entries[i].operation);
                        break;

                        case Description.ElementName:
                            read(reader, ref entries[i].description);
                        break;

                        case Return.ElementName:
                            read(reader, ref entries[i].@return);
                        break;

                        case CpuId.ElementName:
                            read(reader, entries[i].CPUID);
                        break;

                        case IntrinsicsModels.Category.ElementName:
                            read(reader, ref entries[i].category);
                        break;

                        case Instruction.ElementName:
                            read(reader, entries[i].instructions);
                        break;

                        case InstructionType.ElementType:
                            read(reader, entries[i].types);
                        break;

                        case Parameter.ElementName:
                            read(reader, entries[i].parameters);
                        break;
                        case Header.ElementName:
                            read(reader, ref entries[i].header);
                        break;
                    }
                }
            }

            return slice(span(entries),0,i).ToArray();
        }

        static void read(XmlReader reader, ref Operation dst)
        {
            var content = reader.ReadInnerXml().Replace(XmlEntities.gt, ">").Replace(XmlEntities.lt, "<");
            foreach(var line in Lines.read(content))
                dst.Content.Add(line);
        }

        static void read(XmlReader reader, CpuIdMembership dst)
            => dst.Add(reader.ReadInnerXml());

        static void read(XmlReader reader, ref IntrinsicsModels.Category dst)
            => dst.Content = reader.ReadInnerXml();

        static void read(XmlReader reader, ref Header dst)
            => dst.Content = reader.ReadInnerXml();

        static void read(XmlReader reader, ref Description dst)
            => dst.Content = reader.ReadInnerXml();

        static void read(XmlReader reader, ref Return dst)
        {
            dst.varname = reader[nameof(Return.varname)];
            dst.etype = reader[nameof(Return.etype)];
            dst.type = reader[nameof(Return.type)];
            dst.memwidth =  reader[nameof(Return.memwidth)];
        }

        static void read(XmlReader reader, Parameters dst)
        {
            var element = new Parameter();
            element.varname = reader[nameof(Parameter.varname)];
            element.etype = reader[nameof(Parameter.etype)];
            element.type = reader[nameof(Parameter.type)];
            element.memwidth =  reader[nameof(Parameter.memwidth)];
            dst.Add(element);
        }

        static void read(XmlReader reader, InstructionTypes dst)
        {
            var element = new InstructionType();
            element.Content = reader.ReadInnerXml();
            dst.Add(element);
        }

        static void read(XmlReader reader, Instructions dst)
        {
            var element = new Instruction();
            element.name = reader[nameof(Instruction.name)];
            element.form = reader[nameof(Instruction.form)];
            element.xed = Enums.parse(reader[nameof(Instruction.xed)], IFormType.None);
            dst.Add(element);
        }

        static Intrinsic create()
        {
            var dst = new Intrinsic();
            dst.tech = EmptyString;
            dst.name = EmptyString;
            dst.content = EmptyString;
            dst.types = new InstructionTypes();
            dst.CPUID = new CpuIdMembership();
            dst.category = EmptyString;
            dst.@return = Return.Empty;
            dst.parameters = new Parameters();
            dst.description = EmptyString;
            dst.operation = new Operation(list<TextLine>());
            dst.instructions = new Instructions();
            dst.header = EmptyString;
            return dst;
        }

        internal static void render(Operation src, ITextBuffer dst)
        {
            if(src.Content != null)
                iter(src.Content, x => dst.AppendLine("  " + x.Content));
        }

        internal static string format(Instruction src)
             => string.Format("# Instruction: {0} {1}\r\n", src.name, src.form) + string.Format("# Iform: {0}", src.xed);

        internal static void render(Instructions src, ITextBuffer dst)
            => iter(src, x => dst.AppendLine(format(x)));

        internal static string sig(Intrinsic src)
            => string.Format("{0} {1}({2})", src.@return,  src.name,  string.Join(", ", src.parameters.ToArray()));

        internal static void body(Intrinsic src, ITextBuffer dst)
        {
            dst.AppendLine("{");
            render(src.operation, dst);
            dst.AppendLine("}");
        }

        internal static string format(Intrinsic src)
        {
            var dst = text.buffer();
            overview(src, dst);
            body(src, dst);
            return dst.Emit();
        }

        internal static void overview(Intrinsic src, ITextBuffer dst)
        {
            dst.AppendLine(string.Format("# Intrinsic: {0}", sig(src)));

            var classes = list<string>(3);
            if(nonempty(src.tech))
                classes.Add(src.tech);
            if(src.CPUID.Count != 0)
                classes.Add(string.Join(Chars.Comma, src.CPUID));
            if(src.category.IsNonEmpty)
                classes.Add(src.category.Content);
            if(classes.Count != 0)
                dst.AppendLineFormat("# Classification: {0}", string.Join(", ", classes));

            render(src.instructions, dst);
            dst.AppendLineFormat("# Description: {0}", src.description);
        }
    }
}