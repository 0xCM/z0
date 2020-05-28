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

    using static Seed;
    
    public static class TextParser
    {
        /// <summary>
        /// Attempts to parse a text document and returns the result if successful
        /// </summary>
        /// <param name="src">The source document path</param>
        /// <param name="format">The document format</param>
        /// <param name="observer">An optional observer to witness intersting events</param>
        public static Option<TextDoc> ParseDocument(this StreamReader reader, TextFormat? format = null)
        {            
            var rows = new List<TextRow>();
            var counter = 1u;
            var fmt = format ?? TextFormat.Structured;
            Option<TextHeader> header = default;
            try
            {
                while(!reader.EndOfStream)
                {
                    var text = new TextLine(counter, reader.ReadLine().Trim());                    

                    counter++;
                    
                    if(text.IsBlank)
                        continue;

                    // skip comments                    
                    if(text.LineText[0] == fmt.CommentPrefix)
                        continue;

                    // skip row separators
                    if(text.LineText.StartsWith(fmt.RowSeparator))
                        continue;


                    if(fmt.HasDataHeader && header.IsNone() && rows.Count == 0)
                        header = text.ParseHeader(fmt).ValueOrDefault(TextHeader.Empty);   
                    else
                        text.ParseRow(fmt).OnSome(row => rows.Add(row));
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }

            return new TextDoc(fmt, header, counter, rows.ToArray());
        }

        /// <summary>
        /// Parses a header row from a line of text
        /// </summary>
        /// <param name="src">The source line</param>
        /// <param name="spec">The text format</param>
        /// <param name="observer">An observer to witness interesting events</param>
        public static Option<TextHeader> ParseHeader(this TextLine src, in TextFormat spec)
            => new TextHeader(src.LineText.SplitLine(spec).Select(x => x.Trim()).Where(x => x != string.Empty).ToArray());
            
        public static TextLine[] ParseLines(string text)
        {
            var lines = new List<TextLine>();
            var lineNumber = 0u;
            using (var reader = new StringReader(text))
            {
                var next = reader.ReadLine();
                while (next != null)
                {
                    lines.Add(new TextLine(++lineNumber, next));
                }
            }
            return lines.ToArray();
        }

        /// <summary>
        /// Parses a row from a line of text
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="spec">The text format spec</param>
        public static Option<TextRow> ParseRow(this TextLine src, in TextFormat spec)
        {            
            if(src.IsBlank || (spec.CommentPrefix != null && src[0] == spec.CommentPrefix))
                return default;
            else
            {            
                if(spec.HasDataHeader)
                {
                    var parts = src.LineText.SplitLine(spec);
                    var data = new TextCell[parts.Length];
                    for(var i=0u; i<parts.Length; i++)
                        data[i] = new TextCell(src.LineNumber, i, parts[i].Trim());
                    return new TextRow(data);
                }
                else
                    return new TextRow(new TextCell(src.LineNumber, 0, src.LineText));
            }
        }

        public static Option<TextDoc> ReadTextDoc(this StreamReader src, TextFormat? format = null)
            => src.ParseDocument(format);

        public static Option<TextDoc> ReadTextDoc(this FilePath src, TextFormat? format = null)
        {
            if(!src.Exists)
            {
                term.error($"No such file {src}");
                return Option.none<TextDoc>();
            };

            using var reader = src.Reader();
            return reader.ReadTextDoc(format);
        }


        static Option<TextLine> ParseLine(this StreamReader reader, uint lineNumber)
        {
            var result = reader.ReadLine();
            return result == null ? default : new TextLine(lineNumber, result.Trim());            
        }

        static bool IsComment(this Option<TextLine> line, TextFormat format)
            =>  line.Map(src => !src.IsBlank && src.LineText[0] == format.CommentPrefix, () => false);
    
        [MethodImpl(Inline)]
        static string[] SplitLine(this string src, in TextFormat spec)
            => src[0]  == spec.Delimiter 
                    ? src.Substring(1).Split(spec.Delimiter) 
                    : src.Split(spec.Delimiter);
    }
}