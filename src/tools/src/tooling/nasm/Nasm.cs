//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    [ApiHost]
    public sealed partial class Nasm : WfService<Nasm>, ITool<Nasm>
    {
        public Nasm()
        {

        }

        [MethodImpl(Inline)]
        public static Nasm tool(IEnvPaths paths)
            => new Nasm(paths);

        public FS.FolderPath InDir
            => Paths.ToolInDir(Id);

        public FS.FolderPath OutDir
            => Paths.ToolOutDir(Id);

        public FS.Files Inputs()
            => Paths.ToolInDir(Id).AllFiles;

        public FS.FileExt ListingExt
            => FS.ext("list") + FS.Asm;

        public FS.Files Listings()
            => OutDir.Files(ListingExt, true);

        public FS.Files Outputs()
            => Paths.ToolOutDir(Id).AllFiles;

        public bool IsListing(FS.FilePath src)
            => src.Format().EndsWith(ListingExt.Format());

        public NasmListing Listing(FS.FilePath src)
        {
            var dst = root.list<NasmListLine>();
            using var reader = src.Reader();
            var i = 1u;
            while(!reader.EndOfStream)
                dst.Add(new NasmListLine(new TextLine(i++, reader.ReadLine())));
            return new NasmListing(src, dst.ToArray());
        }

        public void Render(in NasmListEntry src, ITextBuffer dst)
        {
            const string Delimiter = RP.SpacedPipe;

            dst.AppendFormat("{0,-8}", src.LineNumber);

            if(src.Label.IsNonEmpty)
            {
                dst.AppendFormat("{0}{1,-16}", Delimiter, EmptyString);
                dst.AppendFormat("{0}{1,-24}", Delimiter, EmptyString);
                dst.AppendFormat("{0}{1,-48}", Delimiter, EmptyString);
                dst.AppendFormat("{0}{1}", Delimiter, src.Label);
            }
            else
            {
                dst.AppendFormat("{0}{1,-16}", Delimiter, src.Offset);
                dst.AppendFormat("{0}{1,-24}", Delimiter, src.Encoding);

                if(src.Encoding.IsNonEmpty)
                {
                    var bitstring = BitFormat.Format(src.Encoding.Storage.Reverse());
                    dst.AppendFormat("{0}{1,-48}", Delimiter, bitstring);
                }
                else
                {
                    dst.AppendFormat("{0}{1,-48}", Delimiter, EmptyString);
                }

                dst.AppendFormat("{0}{1}", Delimiter, src.SourceText);
            }
        }

        public static Outcome entry(NasmListLine src, out NasmListEntry dst)
        {
            const byte DataWidth = NasmListLine.DataWidth;

            dst = default;
            var content = span(src.Content);

            if(content.Length < DataWidth)
                return (false, "Line length too short");

            var output = text.format(slice(content, 0, DataWidth));
            var input = text.format(slice(content, DataWidth)).Trim();
            if(text.empty(output))
                return false;

            dst.SourceText = input;
            var outparts = output.SplitClean(Chars.Space);
            var outcount = outparts.Length;
            var part0 = outcount >= 1 ? outparts[0] : EmptyString;
            var part1 = outcount >= 2 ? outparts[1] : EmptyString;
            var part2 = outcount >= 2 ? outparts[2] : EmptyString;
            if(outcount != 0)
            {
                if(outcount == 1)
                {
                    Numeric.parse(part0, out uint ln);
                    dst.LineNumber = ln;

                    if(text.nonempty(input) && input.Contains(Chars.Colon))
                        dst.Label = input.RemoveAny(Chars.Colon);
                }
                else if(outcount == 3)
                {
                    if(Numeric.parse(part0, out uint ln))
                        dst.LineNumber = ln;
                    else
                        return (false, string.Format($"Parse {outparts[0]} failed"));

                    if(HexNumericParser.parse64u(part1, out var offset))
                        dst.Offset = offset;
                    else
                        return (false, string.Format($"HexNumericParser failed on {part1}"));

                    var bytestring = text.intersperse(part2, Chars.Space, 2);
                    if(HexByteParser.parse(bytestring, out var data))
                        dst.Encoding = data;
                    else
                        return (false, string.Format($"HexByteParser failed on {bytestring}"));

                    dst.SourceText = input;
                }
                else
                {
                    return (false, "Unexpected line number count");
                }
            }

            return true;
        }

        readonly IEnvPaths Paths;

        [MethodImpl(Inline)]
        Nasm(IEnvPaths paths)
        {
            Paths = paths;
            BitFormat = BitFormatter.create<byte>(4);
        }

        readonly BitFormatter<byte> BitFormat;

        public ToolId Id => Toolsets.nasm;
    }
}