//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static Tables;

    public class TableReader<T> : IDisposable
        where T : struct
    {
        readonly StreamReader Stream;

        readonly string HeaderText;

        uint Counter;

        readonly Tables.RowParser<T> Parser;

        public TableReader(FS.FilePath src, bool header = true)
        {
            Stream = src.Reader();
            if(header)
            HeaderText = header ? Stream.ReadLine() : EmptyString;
            Counter = 1;
            Parser = DefaultParser;
        }

        public TableReader(FS.FilePath src, Tables.RowParser<T> parser, bool header = true)
        {
            Stream = src.Reader();
            if(header)
            HeaderText = header ? Stream.ReadLine() : EmptyString;
            Counter = 1;
            Parser = parser;
        }

        public bool Complete => Stream.EndOfStream;

        Outcome DefaultParser(TextLine src, out T dst)
        {
            dst = default;
            return false;
        }

        public Outcome ReadLine(out TextLine dst)
        {
            if(!Stream.EndOfStream)
            {
                dst = (Counter++,Stream.ReadLine());
                return true;
            }
            else
            {
                dst = TextLine.Empty;
                return false;
            }
        }

        public Outcome ReadRow(out T dst)
        {
            if(ReadLine(out var line))
                return Parser(line, out dst);
            else
            {
                dst = default;
                return false;
            }
        }

        public string Header
        {
            get => HeaderText;
        }


        public void Dispose()
        {
            Stream?.Dispose();
        }
    }
}