//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    partial struct TextDocParser
    {
        public static ParseResult<T> parse<T>(string data, Func<TextDoc,ParseResult<T>> pfx)
        {
            using var stream = text.stream(data);
            using var reader = new StreamReader(stream);
            return TextDocParser.parse(reader).TryMap(pfx).ValueOrDefault(ParseResult.Fail<T>(data));            
        }

        public static Option<TextDoc> parse(FilePath src, TextDocFormat? format = null)
        {
            if(!src.Exists)
            {
                term.error($"No such file {src}");
                return Option.none<TextDoc>();
            };

            using var reader = src.Reader();
            return parse(reader,format);
        }            

        
        /// <summary>
        /// Attempts to parse a text document and returns the result if successful
        /// </summary>
        /// <param name="src">The source document path</param>
        /// <param name="format">The document format</param>
        /// <param name="observer">An optional observer to witness intersting events</param>
        public static Option<TextDoc> parse(StreamReader reader, TextDocFormat? format = null)
        {            
            var rows = new List<TextRow>();
            var counter = 1u;
            var fmt = format ?? TextDocFormat.Structured;
            Option<TextDocHeader> docheader = default;
            try
            {
                while(!reader.EndOfStream)
                {
                    var data = reader.ReadLine().Trim(Chars.Space);
                    var line = new TextDocLine(counter, data);                    

                    counter++;
                    
                    if(text.empty(data))
                        continue;
                                        
                    // skip comments                    
                    if(line[0] == fmt.CommentPrefix)
                        continue;

                    // skip row separators
                    if(line.LineText.StartsWith(fmt.RowSeparator))
                        continue;


                    if(fmt.HasDataHeader && docheader.IsNone() && rows.Count == 0)
                        docheader = header(line,fmt).ValueOrDefault(TextDocHeader.Empty);   
                    else
                        row(line,fmt).OnSome(row => rows.Add(row));
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }

            return new TextDoc(fmt, docheader, counter, rows.ToArray());
        }
    }
}