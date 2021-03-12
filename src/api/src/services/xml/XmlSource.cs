//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static XmlParts;

    using N = System.Xml.XmlNodeType;
    using SysXml = System.Xml;

    public readonly struct XmlLevel
    {
        public sbyte Depth {get;}

        public string Name {get;}

        [MethodImpl(Inline)]
        public XmlLevel(sbyte depth, string name)
        {
            Depth = depth;
            Name = name;
        }

        [MethodImpl(Inline)]
        public static implicit operator XmlLevel((int depth, string name) src)
            => new XmlLevel((sbyte)src.depth, src.name);
    }

    public struct XmlSource : IXmlSource
    {
        readonly IWfShell Wf;

        readonly StreamReader Source;

        readonly SysXml.XmlReader Reader;

        bool TriggerCompletion;

        public static XmlSource create(IWfShell wf, FS.FilePath src)
            => new XmlSource(wf, src);

        [MethodImpl(Inline)]
        public XmlSource(IWfShell wf, FS.FilePath path)
        {
            Wf = wf;
            Source = path.Reader();
            var settings = new SysXml.XmlReaderSettings();
            Reader = SysXml.XmlReader.Create(Source, settings);
            TriggerCompletion = false;
            CurrentPart = XmlParts.doc(path.Name);
            PriorPart = XmlParts.empty();
        }

        IXmlPart PriorPart;

        IXmlPart CurrentPart;

        public void Dispose()
        {
            Source?.Dispose();
            Reader?.Dispose();
        }

        public void Read(ElementHandlers handlers)
        {
            while(Read(out var content))
            {
                if(content is IXmlElement x && handlers.TryGetValue(x.Name, out var handler))
                {
                    handler(x);
                    if(Reader.IsEmptyElement)
                        CurrentPart = x.Ancestor;
                }
            }
        }

        XmlAttributes ReadAttributes()
        {
            var dst = attributes();

            if(Reader.HasAttributes)
            {
                var count = Reader.AttributeCount;

                Reader.MoveToFirstAttribute();
                var a = attribute(Reader.Name, Reader.Value);
                dst.Add(a);

                while(Reader.MoveToNextAttribute())
                    dst.Add(attribute(Reader.Name, Reader.Value));

                root.require(dst.Count == count, () => $"{dst.Count} != {count}");
                Reader.MoveToElement();
                return dst;
            }
            return dst;
        }

        public bool Read(out IXmlPart dst)
        {
            if(Reader.Read())
            {
                switch(Reader.NodeType)
                {
                    case N.Element:
                        var attributes = ReadAttributes();
                        PriorPart = CurrentPart;
                        CurrentPart = element(PriorPart, Reader.Name, attributes);
                        dst = CurrentPart;
                    break;
                    case N.Attribute:
                        dst = attribute(Reader.Name, Reader.Value);
                    break;
                    case N.Text:
                        dst = xmltext(Reader.Value);
                    break;
                    case N.CDATA:
                        dst = cdata(Reader.Value);
                    break;
                    case N.EntityReference:
                        dst = entityref(Reader.Name);
                    break;
                    case N.Entity:
                        dst = entity(Reader.Name, true);
                    break;
                    case N.ProcessingInstruction:
                        dst = instruction(Reader.Name, Reader.Value);
                    break;
                    case N.Comment:
                        dst = comment(Reader.Value);
                    break;
                    case N.Document:
                        dst = xmltext(Reader.Name);
                    break;
                    case N.DocumentType:
                        dst = doctype(Reader.Name, Reader.Value);
                    break;
                    case N.DocumentFragment:
                        dst = fragment(Reader.Value);
                    break;
                    case N.Notation:
                        dst = notation(Reader.Value);
                    break;
                    case N.Whitespace:
                        dst = whitespace(Reader.Value, false);
                    break;
                    case N.SignificantWhitespace:
                        dst = whitespace(Reader.Value, true);
                    break;
                    case N.EndElement:
                        dst = close(Reader.Name);
                        //CurrentPart = Current;
                    break;
                    case N.EndEntity:
                        dst = entity(Reader.Name, false);
                    break;
                    case N.XmlDeclaration:
                        dst = declaration(Reader.Value);
                    break;
                    default:
                        dst = xmltext(EmptyString);
                        return false;
                }

                return true;
            }
            dst = xmltext(EmptyString);
            return false;
        }
    }
}