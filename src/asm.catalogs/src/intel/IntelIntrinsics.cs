//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Xml;
    using System.IO;

    using static Root;
    using static core;
    using static XedModels;
    using static IntrinsicsModels;

    public class IntelIntrinsics  : AppService<IntelIntrinsics>
    {
        const string DocName = "intrinsics";

        public ReadOnlySpan<Intrinsic> Emit()
            => Emit(Db.CatalogDir("asm") + FS.folder("intrinsics"));

        static FS.FolderName AlgFolder
            => FS.folder("algorithms");

        FS.FolderPath AlgDir(FS.FolderPath root)
            => root + AlgFolder;

        public ReadOnlySpan<Intrinsic> Emit(FS.FolderPath dst)
        {
            var refpath = dst + FS.file(DocName, FS.Xml);
            var src = doc();
            refpath.Overwrite(src.Content);
            var parsed = Parse(src);
            var elements = parsed.View;
            var count = elements.Length;
            var logpath = dst + FS.file(DocName, FS.Log);
            var flow = Wf.EmittingFile(logpath);
            using var writer = logpath.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(elements,i).Format());
            Wf.EmittedFile(flow, count);

            var algodir = AlgDir(dst);
            algodir.Clear();

            EmitSummary(parsed, dst + FS.file(DocName, FS.Csv));
            EmitPseudoHeader(parsed, dst + FS.file(DocName, FS.ext("h")));
            EmitAlogrithms(parsed, algodir);
            return parsed;
        }

        void EmitAlogrithms(ReadOnlySpan<Intrinsic> src, FS.FolderPath dst)
        {
            var count = src.Length;
            using var unknown =  (dst + FS.file("None",FS.Alg)).Writer();
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
                        path = dst + FS.file(xed.ToString(), FS.Alg);
                        writer = path.Writer(true);
                    }
                    else
                    {
                        xed = ix.xed;
                        if(!writer.Equals(unknown))
                        {
                            writer.Flush();
                            writer.Dispose();
                            path = dst + FS.file(xed.ToString(), FS.Alg);
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
        }

        void EmitPseudoHeader(ReadOnlySpan<Intrinsic> src, FS.FilePath dst)
        {
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

        void EmitSummary(ReadOnlySpan<Intrinsic> src, FS.FilePath dst)
        {
            const string Pattern = "{0,-100} | {1,-48} | {2}";
            var flow = Wf.EmittingFile(dst);
            var count = src.Length;
            using var writer = dst.Writer();
            writer.WriteLine(string.Format(Pattern, "Signature", "Intruction", "XedIForm"));
            for(var i=0; i<count; i++)
            {
                ref readonly var intrinsic = ref skip(src,i);
                if(instruction(intrinsic, out var  ix))
                    writer.WriteLine(string.Format(Pattern,
                            sig(intrinsic), string.Format("{0} {1}", ix.name, ix.form), ix.xed));
                else
                    writer.WriteLine(string.Format(Pattern, sig(intrinsic), EmptyString, EmptyString));
            }

            Wf.EmittedFile(flow, count);
        }

        public static XmlDoc doc()
            => text.xml(Resources.utf8(AsmData.Assets.IntelIntrinsicsXml()));

        public Index<Intrinsic> Parse()
            => Parse(doc());

        static Intrinsic create()
        {
            var dst = new Intrinsic();
            dst.tech = EmptyString;
            dst.name = EmptyString;
            dst.content = EmptyString;
            dst.types = new InstructionTypes();
            dst.CPUID = EmptyString;
            dst.category = EmptyString;
            dst.@return = Return.Empty;
            dst.parameters = new Parameters();
            dst.description = EmptyString;
            dst.operation = new Operation(root.list<TextLine>());
            dst.instructions = new Instructions();
            dst.header = EmptyString;
            return dst;
        }

        public Index<Intrinsic> Parse(XmlDoc src)
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
                            read(reader, ref entries[i].CPUID);
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

        static void read(XmlReader reader, ref CpuId dst)
            => dst.Content = reader.ReadInnerXml();

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
    }
}