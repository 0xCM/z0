//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial struct CodeSolutions
    {
        public class Scanner : IDisposable
        {
            readonly StringReader _reader;

            int _currentLineNumber;

            public Scanner(string text)
            {
                _reader = new StringReader(text);
            }

            public void Dispose()
            {
                _reader.Dispose();
            }

            public string NextLine()
            {
                var line = _reader.ReadLine();

                _currentLineNumber++;

                if (line != null)
                {
                    line = line.Trim();
                }

                return line;
            }
        }
    }
}