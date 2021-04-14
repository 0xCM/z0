//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static Part;
    using static memory;

    public readonly struct TextDoc : IIndex<TextRow>
    {
        [MethodImpl(Inline), Op]
        static bool skipline(TextLine src, in TextDocFormat spec)
            => src.IsEmpty || src.StartsWith(spec.CommentPrefix) || src.StartsWith(spec.RowBlockSep);

        public static ParseResult<TextDoc> parse(string data, TextDocFormat? format = null)
        {
            using var stream = data.Stream();
            using var reader = new StreamReader(stream);
            return parse(reader, format);
        }

        public static ParseResult<T> parse<T>(string data, Func<TextDoc,ParseResult<T>> pfx)
        {
            using var stream = Streams.memory(data);
            using var reader = Streams.reader(stream);
            return from doc in parse(reader)
                from content in pfx(doc)
                select content;
        }

        /// <summary>
        /// Parses a row from a line of text
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="spec">The text format spec</param>
        [Op]
        public static bool row(TextLine src, in TextDocFormat spec, out TextRow dst)
        {
            if(skipline(src, spec))
            {
                dst = TextRow.Empty;
                return false;
            }
            else
            {
                if(spec.HasHeader)
                {
                    var parts = src.Split(spec);
                    var count = parts.Length;
                    var buffer = memory.alloc<TextBlock>(count);
                    ref var target= ref first(buffer);
                    for(var i=0u; i<count; i++)
                        seek(target, i) = new TextBlock(parts[i].Trim());
                    dst= new TextRow(buffer);
                }
                else
                    dst = new TextRow(new TextBlock(src.Content));

                return true;
            }
        }

        /// <summary>
        /// Attempts to parse a text document and returns the result if successful
        /// </summary>
        /// <param name="src">The source document path</param>
        /// <param name="format">The document format</param>
        /// <param name="observer">An optional observer to witness intersting events</param>
        public static ParseResult<TextDoc> parse(StreamReader reader, TextDocFormat? format = null)
        {
            var rows = root.list<TextRow>();
            var counter = 1u;
            var fmt = format ?? TextDocFormat.Structured();
            var comment = fmt.CommentPrefix;
            var rowsep = fmt.RowBlockSep;
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

                    if(fmt.HasHeader && docheader.IsNone() && rows.Count == 0)
                    {
                        if(header(line, fmt, out var _docheader))
                            docheader = _docheader;
                    }
                    else
                    {
                        if(row(line,fmt, out var _row))
                            rows.Add(_row);
                    }
                }

                var doc = new TextDoc(fmt, docheader ? docheader.Value : TextDocHeader.Empty, counter, rows.ToArray());
                return root.parsed(string.Empty, doc);
            }
            catch(Exception e)
            {
                return root.unparsed<TextDoc>(EmptyString,e);
            }
        }

        /// <summary>
        /// Parses a header row from a line of text
        /// </summary>
        /// <param name="src">The source line</param>
        /// <param name="spec">The text format</param>
        [Op]
        public static bool header(TextLine src, in TextDocFormat spec, out TextDocHeader dst)
        {
            var parts = src.Split(spec);
            var count = parts.Length;
            var buffer = root.list<string>();

            if(parts.Length != 0)
            {
                for(var i=0; i<count; i++)
                {
                    var part = parts[i].Trim();
                    if(text.nonempty(part))
                        buffer.Add(part);
                }
            }

            if(buffer.Count != 0)
            {
                dst = new TextDocHeader(buffer.ToArray());
                return true;
            }

            dst = TextDocHeader.Empty;
            return false;
        }



        public Index<TextRow> RowData {get;}

        public TextDocFormat Format {get;}

        public TextDocHeader Header {get;}

        public uint LineCount {get;}

        [MethodImpl(Inline)]
        public TextDoc(TextDocFormat format, TextDocHeader header, uint count, params TextRow[] rows)
        {
            RowData = rows;
            Header = header;
            Format = format;
            LineCount = count;
        }

        public ReadOnlySpan<TextRow> Rows
        {
            [MethodImpl(Inline)]
            get => RowData.View;
        }

        public TextRow[] Storage
        {
            [MethodImpl(Inline)]
            get => RowData.Storage;
        }

        public string Content
        {
            [MethodImpl(Inline)]
            get => RowData.Map(r => r.Format()).Join(Eol);
        }

        public ref readonly TextRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref RowData[index];
        }

        public int RowCount
        {
            [MethodImpl(Inline)]
            get => Rows.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Rows.Length;
        }

        public bool HasHeader
        {
            [MethodImpl(Inline)]
            get => Header.IsNonEmpty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => LineCount == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => LineCount != 0;
        }

        public IEnumerable<TextRows> Partition(int offset, Func<TextRow,bool> f)
        {
            var part = root.list<TextRow>();
            for(var i=offset; i<RowCount; i++)
            {
                var row = this[i];
                if(f(row))
                {
                    yield return new TextRows(part.ToArray());
                    part.Clear();
                }
                else
                    part.Add(row);
            }
        }

        public void Parse<T>(Span<T> dst, Func<TextRow,T> parser)
        {
            var rows = RowData.View;
            var count = rows.Length;
            for(var i=0; i<count; i++)
               seek(dst,i) = parser(skip(rows,i));
        }

        public static TextDoc Empty
            => new TextDoc(TextDocFormat.Empty, default, 0, sys.empty<TextRow>());
    }
}