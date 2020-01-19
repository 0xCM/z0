//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;
    using System.Text;

    public sealed class NativeWriter : StreamWriter
    {
        public NativeWriter(StreamWriter stream)
            : base(stream.BaseStream)
        {

        }

        public NativeWriter(FilePath path, bool append = false)
            : base(path.FullPath, append)
        {

        }

        /// <summary>
        /// Writes a standard timestamped header
        /// </summary>
        public void WriteHeader()
        {
            WriteLine($"; {now().ToLexicalString()}");
            WriteLine(new string(AsciSym.Dash, 80));

        }

    }

}