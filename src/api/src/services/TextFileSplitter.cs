//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    public class TextFileSplitter : AppService<TextFileSplitter>
    {
        public Outcome<FileSplitInfo> Run(FileSplitSpec spec)
        {
            var writer = default(StreamWriter);
            try
            {
                var flow = Wf.Running(Msg.SplittingFile.Format(spec.SourceFile.ToUri(), spec.MaxLineCount));
                using var reader = spec.SourceFile.Utf8Reader();
                var paths = root.list<FS.FilePath>();
                var subcount = 0u;
                var linecount = 0u;
                var splitcount = 0u;
                var emptycount = 0;
                var emptylimit = 5;
                var path = NextPath(spec, ref splitcount);
                paths.Add(path);
                writer = path.Writer();
                var emitting = Wf.EmittingFile(path);
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if(text.empty(line))
                        emptycount++;
                    else
                        emptycount = 0;

                    if(emptycount > emptylimit)
                        continue;

                    writer.WriteLine(line);
                    subcount++;
                    if(subcount >= spec.MaxLineCount)
                    {
                        writer.Flush();
                        writer.Dispose();
                        Wf.EmittedFile(emitting, subcount);
                        path = NextPath(spec, ref splitcount);
                        paths.Add(path);
                        writer = path.Writer();
                        linecount += subcount;
                        subcount = 0;
                    }
                }

                Wf.Ran(flow, Msg.FinishedFileSplit.Format(linecount, spec.SourceFile.ToUri(), splitcount));
                return new FileSplitInfo(spec, paths.ToArray(), linecount);
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return e;
            }
            finally
            {
                writer.Flush();
                writer.Dispose();
            }
        }

        FS.FilePath NextPath(in FileSplitSpec spec, ref uint part)
            => (spec.TargetFolder + spec.SourceFile.FileName.WithoutExtension + FS.ext(string.Format("{0:D3}{1}", part++, spec.SourceFile.FileName.FileExt)));
    }

    partial struct Msg
    {
        public static MsgPattern<FS.FileUri,Count> SplittingFile => "Splitting {0} into parts with a maximum of {1} lines each";
        public static MsgPattern<Count,FS.FileUri,Count> FinishedFileSplit => "Partitioned {0} lines from {1} into {2} parts";
    }
}