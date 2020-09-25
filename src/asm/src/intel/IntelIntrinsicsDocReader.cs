//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml;
    using System.IO;
    using System.Collections.Generic;

    using static Part;
    using static IntelIntrinsicsDoc;
    using static z;

    // See: https://github.com/zbjornson/iop
    // https://github.com/zwegner/x86-sat
    /// <summary>
    /// [intrinsics_list version="3.5.3" date="06/30/2020">]
    /// </summary>
    [ApiHost]
    public struct IntelIntrinsicsDocReader
    {
        public static intrinsic[] read()
        {
            var svc = ResExtractor.Service();
            var doc = svc.Extract(x => x.Contains("intel-intrinsics.xml"));
            return read(doc);
        }

        public static FolderName folder(FileExtension kind)
        {
            return FolderName.Define("algorithms");
        }

        static XmlReader readxml(string src)
            => XmlReader.Create(new StringReader(src));

        [Op]
        public static intrinsic[] read(AppResource src)
        {
            if(src.IsEmpty)
            {
                term.error("Resource not found");
                return sys.empty<intrinsic>();
            }

            var entries = new intrinsic[7500];
            var i = -1;
            using var reader = readxml(src.Content);
            while (reader.Read() && i < entries.Length - 1)
            {
                if(reader.NodeType == XmlNodeType.Element)
                {
                    switch(reader.Name)
                    {
                        case IntrinsicElement:
                            i++;
                            entries[i] = intrinsic.init(reader.Value);
                            entries[i].tech = reader[nameof(intrinsic.tech)];
                            entries[i].name = reader[nameof(intrinsic.name)];
                        break;

                        case OperationElement:
                            read(reader, ref entries[i].operation);
                        break;

                        case DescriptionElement:
                            read(reader, ref entries[i].description);
                        break;

                        case ReturnElement:
                            read(reader, ref entries[i].@return);
                        break;

                        case CpuIdElement:
                            read(reader, ref entries[i].CPUID);
                        break;

                        case CategoryElement:
                            read(reader, ref entries[i].category);
                        break;

                        case InstructionElement:
                            read(reader, entries[i].instructions);
                        break;

                        case InstructionTypeElement:
                            read(reader, entries[i].types);
                        break;

                        case ParameterElement:
                            read(reader, entries[i].parameters);
                        break;
                    }
                }
            }

            return span(entries).Slice(0,i).ToArray();
        }


        static void read(XmlReader reader, ref Operation dst)
        {
            dst.Content = reader.ReadInnerXml();
        }

        static void read(XmlReader reader, ref CpuId dst)
        {
            dst.Content = reader.Value;
        }

        static void read(XmlReader reader, ref Category dst)
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
            var x = default(Parameter);
            x.varname = reader[nameof(Parameter.varname)];
            x.etype = reader[nameof(Parameter.etype)];
            x.type = reader[nameof(Parameter.type)];
            x.memwidth =  reader[nameof(Parameter.memwidth)];
            dst.Add(x);
        }

        static void read(XmlReader reader, List<InstructionType> dst)
        {
            var x = default(InstructionType);
            x.Content = reader.ReadInnerXml();
            dst.Add(x);
        }

        static void read(XmlReader reader, List<instruction> dst)
        {
            var x = instruction.Empty;
            x.name = reader[nameof(instruction.name)];
            x.form = reader[nameof(instruction.form)];
            x.xed = reader[nameof(instruction.xed)];
            dst.Add(x);
        }
    }
}