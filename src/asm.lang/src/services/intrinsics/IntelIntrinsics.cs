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
    using System.Collections.Generic;

    using static Part;
    using static IntelIntrinsicsModel;
    using static memory;
    using static TextRules;

    public partial class IntelIntrinsics : WfService<IntelIntrinsics>
    {
        public static string identifier(Intrinsic src)
        {
            var count = src.instructions.Count;
            if(count != 0)
                return src.instructions[0].name;
            else
                return EmptyString;
        }

        public static string label(Intrinsic src)
            => text.concat("## ", src.instructions.Count != 0
            ? text.concat(identifier(src), Space, Chars.Dash, Space, src.name)
            : identifier(src));

        public static XmlDoc doc()
            => text.xml(Resources.utf8(Assets.create().InstrinsicXml()));

        public Index<Intrinsic> Parse()
            => Parse(doc());


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
                        case IntrinsicElement:
                            i++;
                            entries[i] = Intrinsic.create();
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

                        case ReturnElement:
                            read(reader, ref entries[i].@return);
                        break;

                        case CpuIdElement:
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
                        case HeaderElement:
                            read(reader, ref entries[i].header);
                        break;
                    }
                }
            }

            return span(entries).Slice(0,i).ToArray();
        }

        static void read(XmlReader reader, ref Operation dst)
        {
            var content = reader.ReadInnerXml();
            content = content.Replace(XmlEntities.gt, ">").Replace(XmlEntities.lt, "<");
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
        {
            dst.Content = reader.Value;
        }

        static void read(XmlReader reader, ref Category dst)
        {
            dst.Content = reader.Value;
        }

        static void read(XmlReader reader, ref Header dst)
        {
            dst.Content = reader.Value;
        }

        static void read(XmlReader reader, ref Description dst)
        {
            dst.Content = reader.ReadInnerXml();
        }

        static void read(XmlReader reader, ref Return dst)
        {
            dst.varname = reader[nameof(Parameter.varname)];
            dst.etype = reader[nameof(Parameter.etype)];
            dst.memwidth =  reader[nameof(Parameter.memwidth)];
        }

        static void read(XmlReader reader, List<Parameter> dst)
        {
            var element = default(Parameter);
            element.varname = reader[nameof(Parameter.varname)];
            element.etype = reader[nameof(Parameter.etype)];
            element.type = reader[nameof(Parameter.type)];
            element.memwidth =  reader[nameof(Parameter.memwidth)];
            dst.Add(element);
        }

        static void read(XmlReader reader, List<InstructionType> dst)
        {
            var element = default(InstructionType);
            element.Content = reader.ReadInnerXml();
            dst.Add(element);
        }

        static void read(XmlReader reader, List<Instruction> dst)
        {
            var element = Instruction.Empty;
            element.name = reader[nameof(Instruction.name)];
            element.form = reader[nameof(Instruction.form)];
            element.xed = reader[nameof(Instruction.xed)];
            dst.Add(element);
        }
    }
}