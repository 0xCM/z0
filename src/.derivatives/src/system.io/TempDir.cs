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
    using System.IO;
    using System.Diagnostics;

    using static TempFiles;

    public class TempDir
    {
        readonly string _path;

        readonly TempRoot _root;

        protected TempDir(TempRoot root)
            : this(CreateUniqueDirectory(TempRoot.Root), root)
        {
        }

        private TempDir(string path, TempRoot root)
        {
            Debug.Assert(path != null);
            Debug.Assert(root != null);

            _path = path;
            _root = root;
        }

        private static string CreateUniqueDirectory(string basePath)
        {
            while (true)
            {
                string dir = System.IO.Path.Combine(basePath, Guid.NewGuid().ToString());
                try
                {
                    Directory.CreateDirectory(dir);
                    return dir;
                }
                catch (IOException)
                {
                    // retry
                }
            }
        }

        public string Path
        {
            get { return _path; }
        }

        /// <summary>
        /// Creates a file in this directory.
        /// </summary>
        /// <param name="name">File name.</param>
        public TempFile CreateFile(string name)
        {
            string filePath = System.IO.Path.Combine(_path, name);
            TempRoot.CreateStream(filePath);
            return _root.AddFile(new DisposableFile(filePath));
        }

        /// <summary>
        /// Creates a file in this directory that is a copy of the specified file.
        /// </summary>
        public TempFile CopyFile(string originalPath)
        {
            string name = System.IO.Path.GetFileName(originalPath);
            string filePath = System.IO.Path.Combine(_path, name);
            File.Copy(originalPath, filePath);
            return _root.AddFile(new DisposableFile(filePath));
        }

        /// <summary>
        /// Creates a subdirectory in this directory.
        /// </summary>
        /// <param name="name">Directory name or unrooted directory path.</param>
        public TempDir CreateDirectory(string name)
        {
            string dirPath = System.IO.Path.Combine(_path, name);
            Directory.CreateDirectory(dirPath);
            return new TempDir(dirPath, _root);
        }

        public override string ToString()
        {
            return _path;
        }
    }
}