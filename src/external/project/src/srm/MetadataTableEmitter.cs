//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
// Source     : https://github.com/microsoft/dotnet-samples/blob/master/System.Reflection.Metadata/MdDumper/Visualization/MetadataVisualizer.cs
//-----------------------------------------------------------------------------
using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

namespace SRM
{
    public readonly struct MetadataTableEmitter
    {
        public static void emit(string[] args)
        {
            if (args.Length == 0 || new[] {"/?", "-?", "-h", "--help"}.Any(x => string.Equals(args[0], x, StringComparison.OrdinalIgnoreCase)))
            {
                PrintUsage();
                return;
            }

            foreach (var fileName in args)
            {
                Console.WriteLine(fileName);
                Console.WriteLine(new string('*', 80));

                try
                {
                    using (var stream = File.OpenRead(fileName))
                    using (var peFile = new PEReader(stream))
                    {
                        var metadataReader = peFile.GetMetadataReader();
                        var visualizer = new MetadataTraverser(metadataReader, Console.Out);
                        visualizer.Visualize();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Emits cli metadata from a source file to a target file
        /// </summary>
        /// <param name="src">The source path</param>
        /// <param name="dst">The target path</param>
        public static (bool, string) emit(string src, string dst)
        {
            const string ErrorMsg = "Emission of {0} to {1} failed:{2}";
            const string StatusMsg = "Emitted {0} to {1}";
            try
            {
                using var stream = File.OpenRead(src);
                using var peFile = new PEReader(stream);
                using var target = new StreamWriter(dst, false);
                var reader = peFile.GetMetadataReader();
                var viz = new MetadataTraverser(reader, target);
                viz.Visualize();

                return (true, string.Format(StatusMsg, src, dst));
            }
            catch(Exception e)
            {
                return (false, string.Format(ErrorMsg, src, dst, e));
            }
        }
        private static void PrintUsage()
        {
            Console.WriteLine("This tool dumps the contents of all tables in a set of PE files.");
            Console.WriteLine("usage: mddumper <file>...");
        }
    }
}