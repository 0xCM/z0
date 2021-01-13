//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    using static Part;
    using static z;

    partial struct TextDocParser
    {
        public static ParseResult<T> parse<T>(string data, Func<TextDoc,ParseResult<T>> pfx)
        {
            using var stream = Streams.memory(data);
            using var reader = Streams.reader(stream);
            return from doc in parse(reader)
                from content in pfx(doc)
                select content;
        }

        public static ParseResult<string,TextDoc> parse(FS.FilePath src, TextDocFormat? format = null)
            => parse(FilePath.Define(src.Name), format);

        public static ParseResult<string,TextDoc> parse(FilePath src, TextDocFormat? format = null)
        {
            if(!src.Exists)
            {
                term.error($"No such file {src}");
                return unparsed(src.Name, default(TextDoc));
            };

            using var reader = src.Reader();
            return parse(reader,format).Select(doc => parsed(src.Name, doc)).Value;
        }

        /// <summary>
        /// Attempts to parse a text document and returns the result if successful
        /// </summary>
        /// <param name="src">The source document path</param>
        /// <param name="format">The document format</param>
        /// <param name="observer">An optional observer to witness intersting events</param>
        public static ParseResult<TextDoc> parse(StreamReader reader, TextDocFormat? format = null)
        {
            var rows = new List<TextRow>();
            var counter = 1u;
            var fmt = format ?? TextDocFormat.Structured;
            var comment = fmt.CommentPrefix;
            var rowsep = fmt.RowSeparator;
            Option<TextDocHeader> docheader = default;
            try
            {
                while(!reader.EndOfStream)
                {
                    var data = reader.ReadLine().Trim();

                    counter++;

                    // Nothing to see here
                    if(text.blank(data))
                        continue;

                    var line = new TextLine(counter, data);
                    var lead = line[0];

                    // skip comments
                    if(lead == comment)
                        continue;

                    // skip row separators
                    if(line.Content.StartsWith(rowsep))
                        continue;

                    if(fmt.HasDataHeader && docheader.IsNone() && rows.Count == 0)
                        docheader = header(line,fmt).ValueOrDefault(TextDocHeader.Empty);
                    else
                        row(line,fmt).OnSome(row => rows.Add(row));
                }

                var doc = new TextDoc(fmt, docheader, counter, rows.ToArray());
                return parsed(string.Empty, doc);
            }
            catch(Exception e)
            {
                term.error(e);
                return unparsed<TextDoc>(EmptyString,e);
            }
        }
    }
}