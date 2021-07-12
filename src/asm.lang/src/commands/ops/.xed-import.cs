//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static XedMarkers;

    readonly struct XedEnclosures
    {
        public static string origin(string content)
            => string.Format("origin<{0}>", content);

        public static string comment(string content)
            => string.Format("comment<{0}>", content);
    }

    partial class AsmCmdService
    {
        [CmdOp(".xed-import-all")]
        Outcome XedImportDatasets(CmdArgs args)
        {
            const string CmdName = ".xed-import";

            var src = XedDatasets.all();
            var count = src.Length;
            var outcome = Outcome.Success;
            for(var i=1; i<count; i++)
            {
                outcome = Dispatch(CmdName, skip(src,i).Name);
                if(outcome.Fail)
                    break;
            }

            return outcome;
        }

        [CmdOp(".xed-import")]
        Outcome XedImport(CmdArgs args)
        {
            var dir = Workspace.DataSource(xed);
            var file = FS.file(arg(args,0).Value, FS.Txt);
            var path = dir + file;
            if(path.Missing)
                return (false, FS.missing(path));

            var data = span(path.ReadText());
            var number = 0u;
            var pos = 0u;
            var logpath = Workspace.EtlLog(xed, file.ChangeExtension(FS.Log));
            var flow = EmittingFile(logpath);
            var counter = 0u;
            var skipping = false;
            var i=TextIndex.Empty;
            using var log = logpath.AsciWriter();
            while(pos < data.Length)
            {
                Lines.line(data, ref number, ref pos, out var line);
                var content = line.Content;

                i = text.index(content, BeginLegal);
                if(i.IsNonEmpty)
                {
                    skipping = true;
                    continue;
                }

                i = text.index(content, EndLegal);
                if(i.IsNonEmpty)
                {
                    skipping = false;
                    continue;
                }

                if(skipping)
                    continue;

                i = text.index(content, XedMarkers.File);
                if(i.IsNonEmpty)
                {
                    //var filename = text.format(text.right(content, i + XedMarkers.File.Length));
                    //log.WriteLine(string.Format("{0} {1}", Lines.format(line.LineNumber), origin(filename)));
                    continue;
                }

                if(line.IsNonEmpty)
                {
                    log.WriteLine(line.Format());
                    // i = text.index(content, XedMarkers.InlineComment);
                    // if(i.IsNonEmpty)
                    //     log.WriteLine(line.LineNumber.Format() + ":" + text.format(text.left(content,i)) + comment(text.format(text.right(content, i + XedMarkers.InlineComment.Length)).Trim()));
                    // else
                    //     log.WriteLine(line.Format());
                    counter++;
                }
            }

            EmittedFile(flow, counter);
            return true;
        }
    }
}