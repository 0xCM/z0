//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial struct CodeProjects
    {
        class FileSystemHelper
        {
            private static string s_directorySeparatorChar = Path.DirectorySeparatorChar.ToString();

            public static string GetRelativePath(string fullPath, string basePath)
            {
                // if any of them is not set, abort
                if (string.IsNullOrWhiteSpace(basePath) || string.IsNullOrWhiteSpace(fullPath)) return null;

                // paths must be rooted
                if (!Path.IsPathRooted(basePath) || !Path.IsPathRooted(fullPath)) return null;

                // if they are the same, abort
                if (fullPath.Equals(basePath, StringComparison.Ordinal)) return null;

                if (!Path.HasExtension(basePath) && !basePath.EndsWith(s_directorySeparatorChar))
                {
                    basePath += Path.DirectorySeparatorChar;
                }

                var baseUri = new Uri(basePath);
                var fullUri = new Uri(fullPath);
                var relativeUri = baseUri.MakeRelativeUri(fullUri);
                var relativePath = Uri.UnescapeDataString(relativeUri.ToString()).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
                return relativePath;
            }
        }
    }
}