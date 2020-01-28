//-----------------------------------------------------------------------------
// Taken from https://github.com/0xd4d/JitDasm/tree/master/JitDasm;
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;

    using static zfunc;

    partial class Symbolizer
    {
        public sealed class FilenameProvider 
        {
            const int MAX_NAME_LEN = 100;

            readonly HashSet<string> usedFilenames;
            readonly FilenameFormat filenameFormat;
            readonly string outputDir;
            readonly string extension;

            public FilenameProvider(FilenameFormat filenameFormat, string outputDir, string extension) {
                usedFilenames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                this.filenameFormat = filenameFormat;
                this.outputDir = outputDir;
                if (!extension.StartsWith("."))
                    this.extension = "." + extension;
                else
                    this.extension = extension;
            }

            public string GetFilename(uint token, string name) {
                string candidate;
                switch (filenameFormat) {
                case FilenameFormat.MemberName:
                    candidate = name;
                    break;

                case FilenameFormat.TokenMemberName:
                    candidate = token.ToString("X8") + "_" + name;
                    break;

                case FilenameFormat.Token:
                    candidate = token.ToString("X8");
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(filenameFormat));
                }

                if (candidate == string.Empty)
                    candidate = "<UNKNOWN>";
                candidate = ReplaceInvalidFilenameChars(candidate);
                if (candidate.Length > MAX_NAME_LEN)
                    candidate = candidate.Substring(0, MAX_NAME_LEN) + "-";
                if (!usedFilenames.Add(candidate)) {
                    for (int i = 1; i < int.MaxValue; i++) {
                        var newCand = candidate + "_" + i.ToString();
                        if (usedFilenames.Add(newCand)) {
                            candidate = newCand;
                            break;
                        }
                    }
                }
                return Path.Combine(outputDir, candidate + extension);
            }

            static string ReplaceInvalidFilenameChars(string candidate) {
                var invalidChars = Path.GetInvalidFileNameChars();
                if (candidate.IndexOfAny(invalidChars) < 0)
                    return candidate;
                var sb = new System.Text.StringBuilder();
                foreach (var c in candidate) {
                    if (Array.IndexOf(invalidChars, c) >= 0)
                        sb.Append('-');
                    else
                        sb.Append(c);
                }
                return sb.ToString();
            }
        }
    }
}