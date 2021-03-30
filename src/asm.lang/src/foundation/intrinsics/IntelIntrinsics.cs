//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml;
    using System.IO;

    using static Part;
    using static memory;

    public partial class IntelIntrinsics : WfService<IntelIntrinsics>
    {
        public Index<Intrinsic> Emit()
        {
            var doc = IntelIntrinsics.doc();
            var name = "intel-intrinsics";
            Db.Doc(name, FS.Extensions.Xml).Overwrite(doc.Content);
            var intrinsics = Wf.IntelCpuIntrinsics();
            var parsed = intrinsics.Parse(doc);
            var elements = parsed.View;
            var count = elements.Length;
            var path = Db.Doc(name, FS.Extensions.Log);
            var flow = Wf.EmittingFile(path);
            using var writer = path.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(elements,i).Format());
            Wf.EmittedFile(flow, count);
            return parsed;
        }

        public static XmlDoc doc()
            => text.xml(Resources.utf8(Assets.create().InstrinsicXml()));

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

        public static string format(Intrinsic src)
        {
            var dst = text.buffer();
            dst.AppendLine(string.Format("# Intrinsic: {0} {1}({2})", src.@return,  src.name, src.parameters));

            var classes = root.list<string>(3);
            if(text.nonempty(src.tech))
                classes.Add(src.tech);
            if(src.CPUID.IsNonEmpty)
                classes.Add(src.CPUID.Format());
            if(src.category.IsNonEmpty)
                classes.Add(src.category.Format());
            if(classes.Count != 0)
                dst.AppendLineFormat("# Classification: {0}", TextRules.Format.join(", ", classes));

            dst.AppendLineFormat("# Header: {0}", src.header);
            dst.Append(src.instructions.Format());
            dst.AppendLineFormat("# Description: {0}", src.description);
            dst.AppendLine("BEGIN");
            dst.Append(src.operation.Format());
            dst.AppendLine("END");
            return dst.Emit();
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

                        case Category.ElementName:
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

            return span(entries).Slice(0,i).ToArray();
        }

        static void read(XmlReader reader, ref Operation dst)
        {
            var content = reader.ReadInnerXml().Replace(XmlEntities.gt, ">").Replace(XmlEntities.lt, "<");
            var lines = TextRules.Parse.lines(content).View;
            var count = lines.Length;
            if(count != 0)
            {
                for(var i=0; i<count; i++)
                {
                    ref readonly var line = ref skip(lines,i);
                    if(line.IsNonEmpty)
                        dst.Content.Add(line);
                }
            }
        }

        static void read(XmlReader reader, ref CpuId dst)
            => dst.Content = reader.ReadInnerXml();

        static void read(XmlReader reader, ref Category dst)
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
            var element = Instruction.Empty;
            element.name = reader[nameof(Instruction.name)];
            element.form = reader[nameof(Instruction.form)];
            element.xed = reader[nameof(Instruction.xed)];
            dst.Add(element);
        }
    }
}