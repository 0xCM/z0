//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The symbolizer code is based on code extraced from https://github.com/0xd4d/JitDasm/tree/master/JitDasm; see license file
    /// </summary>
    partial class Symbolizer
    {
        public sealed class SourceDocumentProvider 
        {
            readonly object lockObj;
            readonly Dictionary<string, Document> toDocument;

            sealed class Document {
                public readonly string[] Lines;

                public Document(string filename) =>
                    Lines = File.ReadAllLines(filename);
            }

            public SourceDocumentProvider() {
                lockObj = new object();
                toDocument = new Dictionary<string, Document>(StringComparer.OrdinalIgnoreCase);
            }

            Document GetDocument(string file) {
                lock (lockObj) {
                    if (toDocument.TryGetValue(file, out var document))
                        return document;
                    if (!File.Exists(file))
                        return null;
                    document = new Document(file);
                    toDocument.Add(file, document);
                    return document;
                }
            }

            public IEnumerable<(string line, Span span, bool partial)> GetLines(string file, int startLine, int startColumn, int endLine, int endColumn) {
                if (startLine < 1 || endLine < 1 || startColumn < 1 || endColumn < 1)
                    yield break;
                var lines = GetDocument(file)?.Lines;
                if (lines is null || lines.Length == 0)
                    yield break;
                startLine = Math.Min(startLine, lines.Length);
                endLine = Math.Min(endLine, lines.Length);
                startLine--;
                endLine--;
                startColumn--;
                endColumn--;
                if (endLine < startLine)
                    yield break;
                if (startLine == endLine && endColumn < startColumn)
                    yield break;
                for (int lineNo = startLine; lineNo <= endLine; lineNo++) {
                    var line = lines[lineNo];
                    int scol = 0;
                    int ecol = line.Length;
                    if (lineNo == startLine)
                        scol = startColumn;
                    if (lineNo == endLine)
                        ecol = endColumn;
                    // Sometimes happens with .xaml files
                    if (scol > line.Length || ecol > line.Length || scol > ecol)
                        break;
                    bool partial = IsPartial(line, startLine, endLine, startColumn, endColumn, lineNo);
                    yield return (line, new Span(scol, ecol), partial);
                }
            }

            static bool IsPartial(string line, int startLine, int endLine, int startColumn, int endColumn, int lineNo) {
                if (lineNo != startLine)
                    return false;

                int realStart = 0;
                while (realStart < line.Length) {
                    if (!char.IsWhiteSpace(line[realStart]))
                        break;
                    realStart++;
                }
                int realEnd = line.Length;
                while (realEnd > 0) {
                    if (!char.IsWhiteSpace(line[realEnd - 1]))
                        break;
                    realEnd--;
                }
                if (startColumn <= realStart && endColumn >= realEnd)
                    return false;
                return true;
            }
        }
    }
}