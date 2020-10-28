//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
// Source     : J:\lang\net\symreader-converter\src\Pdb2Pdb.Tests\TempFiles
//-----------------------------------------------------------------------------
namespace System.IO
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static TempFiles;

    public sealed class TempRoot : IDisposable
    {
        readonly List<IDisposable> _temps = new List<IDisposable>();

        public static readonly string Root;

        static TempRoot()
        {
            Root = Path.Combine(Path.GetTempPath(), nameof(TempFiles));
            Directory.CreateDirectory(Root);
        }

        public void Dispose()
        {
            if (_temps != null)
            {
                DisposeAll(_temps);
                _temps.Clear();
            }
        }

        private static void DisposeAll(IEnumerable<IDisposable> temps)
        {
            foreach (var temp in temps)
            {
                try
                {
                    if (temp != null)
                    {
                        temp.Dispose();
                    }
                }
                catch
                {
                    // ignore
                }
            }
        }

        public TempDir CreateDirectory()
        {
            var dir = new DisposableDirectory(this);
            _temps.Add(dir);
            return dir;
        }

        public TempFile CreateFile(string prefix = null, string extension = null, string directory = null, [CallerFilePath]string callerSourcePath = null, [CallerLineNumber]int callerLineNumber = 0)
        {
            return AddFile(new DisposableFile(prefix, extension, directory, callerSourcePath, callerLineNumber));
        }

        public DisposableFile AddFile(DisposableFile file)
        {
            _temps.Add(file);
            return file;
        }

        internal static void CreateStream(string fullPath)
        {
            using (var file = new FileStream(fullPath, FileMode.CreateNew)) { }
        }
    }
}