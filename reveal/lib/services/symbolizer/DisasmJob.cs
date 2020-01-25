//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.IO;

    using static zfunc;

    using Iced.Intel;

    /// <summary>
    /// The symbolizer code is based on code extraced from https://github.com/0xd4d/JitDasm/tree/master/JitDasm; see license file
    /// </summary>
    partial class Symbolizer
    {
		public sealed class DisasmJob 
        {
			public readonly Func<(TextWriter writer, bool close)> GetTextWriter;
			public readonly DisasmInfo[] Methods;
			public DisasmJob(Func<(TextWriter writer, bool close)> getTextWriter, DisasmInfo[] methods) {
				GetTextWriter = getTextWriter;
				Methods = methods;
			}
		}

        public sealed class DisasmJobContext : IDisposable 
        {
            readonly SourceCodeProvider sourceCodeProvider;
            public readonly Disassembler Disassembler;
            public readonly Formatter Formatter;
            public DisasmJobContext(int bitness, KnownSymbols knownSymbols, SourceCodeProvider sourceCodeProvider, DisassemblerOutputKind disassemblerOutputKind, bool diffable, bool showAddresses, bool showHexBytes, bool showSourceCode) {
                var disassemblerOptions = DisassemblerOptions.None;
                if (diffable)
                    disassemblerOptions |= DisassemblerOptions.Diffable;
                if (showAddresses)
                    disassemblerOptions |= DisassemblerOptions.ShowAddresses;
                if (showHexBytes)
                    disassemblerOptions |= DisassemblerOptions.ShowHexBytes;
                if (showSourceCode)
                    disassemblerOptions |= DisassemblerOptions.ShowSourceCode;
                string commentPrefix;
                switch (disassemblerOutputKind) {
                case DisassemblerOutputKind.Masm:
                case DisassemblerOutputKind.Nasm:
                case DisassemblerOutputKind.Intel:
                    commentPrefix = "; ";
                    break;
                case DisassemblerOutputKind.Gas:
                    commentPrefix = "// ";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(disassemblerOutputKind));
                }
                this.sourceCodeProvider = sourceCodeProvider;
                Disassembler = new Disassembler(bitness, commentPrefix, sourceCodeProvider, knownSymbols, disassemblerOptions);
                Formatter = CreateFormatter(Disassembler.SymbolResolver, diffable, disassemblerOutputKind);
            }
            public void Dispose() => sourceCodeProvider.Dispose();
        }

    
   		static Func<(TextWriter writer, bool close)> CreateGetTextWriter(string filename) =>
			() => (File.CreateText(filename), true);

		static readonly char[] typeSeps = new[] { '.', '+' };
		
        static string GetTypeName(string fullname) {
			int index = fullname.LastIndexOfAny(typeSeps);
			if (index >= 0)
				fullname = fullname.Substring(index + 1);
			return fullname;
		}

		public static DisasmJob[] GetJobs(DisasmInfo[] methods, string outputDir, FileOutputKind fileOutputKind, FilenameFormat filenameFormat, out string baseDir) 
        {
			FilenameProvider filenameProvider;
			var jobs = new List<DisasmJob>();

			switch (fileOutputKind) {
			case FileOutputKind.Stdout:
				baseDir = null;
				return new[] { new DisasmJob(() => (Console.Out, false), methods) };

			case FileOutputKind.OneFile:
				if (string.IsNullOrEmpty(outputDir))
					throw new ApplicationException("Missing filename");
				baseDir = Path.GetDirectoryName(outputDir);
				return new[] { new DisasmJob(() => (File.CreateText(outputDir), true), methods) };

			case FileOutputKind.OneFilePerType:
				if (string.IsNullOrEmpty(outputDir))
					throw new ApplicationException("Missing output dir");
				baseDir = outputDir;
				filenameProvider = new FilenameProvider(filenameFormat, baseDir, DASM_EXT);
				var types = new Dictionary<uint, List<DisasmInfo>>();
				foreach (var method in methods) {
					if (!types.TryGetValue(method.TypeToken, out var typeMethods))
						types.Add(method.TypeToken, typeMethods = new List<DisasmInfo>());
					typeMethods.Add(method);
				}
				var allTypes = new List<List<DisasmInfo>>(types.Values);
				allTypes.Sort((a, b) => StringComparer.Ordinal.Compare(a[0].TypeFullName, b[0].TypeFullName));
				foreach (var typeMethods in allTypes) {
					uint token = typeMethods[0].TypeToken;
					var name = GetTypeName(typeMethods[0].TypeFullName);
					var getTextWriter = CreateGetTextWriter(filenameProvider.GetFilename(token, name));
					jobs.Add(new DisasmJob(getTextWriter, typeMethods.ToArray()));
				}
				return jobs.ToArray();

			case FileOutputKind.OneFilePerMethod:
				if (string.IsNullOrEmpty(outputDir))
					throw new ApplicationException("Missing output dir");
				baseDir = outputDir;
				filenameProvider = new FilenameProvider(filenameFormat, baseDir, DASM_EXT);
				foreach (var method in methods) {
					uint token = method.MethodToken;
					var name = method.MethodName.Replace('.', '_');
					var getTextWriter = CreateGetTextWriter(filenameProvider.GetFilename(token, name));
					jobs.Add(new DisasmJob(getTextWriter, new[] { method }));
				}
				return jobs.ToArray();

			default:
				throw new InvalidOperationException();
			}
		}

        const string DASM_EXT = ".dasm";

        // Sorted by name, except if names match, in which case the tokens are also compared
        static int SortMethods(DisasmInfo x, DisasmInfo y) {
            int c;
            c = StringComparer.Ordinal.Compare(x.TypeFullName, y.TypeFullName);
            if (c != 0)
                return c;
            c = x.TypeToken.CompareTo(y.TypeToken);
            if (c != 0)
                return c;
            c = StringComparer.Ordinal.Compare(x.MethodName, y.MethodName);
            if (c != 0)
                return c;
            c = StringComparer.Ordinal.Compare(x.MethodFullName, y.MethodFullName);
            if (c != 0)
                return c;
            return x.MethodToken.CompareTo(y.MethodToken);
        }

        public static void Disassemble(DisasmJobContext context, DisasmJob job) 
        {
            var (writer, disposeWriter) = job.GetTextWriter();
            try {
                var methods = job.Methods;
                Array.Sort(methods, SortMethods);
                for (int i = 0; i < methods.Length; i++) {
                    if (i > 0)
                        writer.WriteLine();

                    var method = methods[i];
                    context.Disassembler.Disassemble(context.Formatter, writer, method);
                }
            }
            finally {
                if (disposeWriter)
                    writer.Dispose();
            }
        }

 		public static Formatter CreateFormatter(Iced.Intel.ISymbolResolver symbolResolver, bool diffable, DisassemblerOutputKind disassemblerOutputKind) {
			Formatter formatter;
			switch (disassemblerOutputKind) {
			case DisassemblerOutputKind.Masm:
				formatter = new MasmFormatter(new MasmFormatterOptions { AddDsPrefix32 = false }, symbolResolver);
				break;

			case DisassemblerOutputKind.Nasm:
				formatter = new NasmFormatter(new NasmFormatterOptions(), symbolResolver);
				break;

			case DisassemblerOutputKind.Gas:
				formatter = new GasFormatter(new GasFormatterOptions(), symbolResolver);
				break;

			case DisassemblerOutputKind.Intel:
				formatter = new IntelFormatter(new IntelFormatterOptions(), symbolResolver);
				break;

			default:
				throw new ArgumentOutOfRangeException(nameof(disassemblerOutputKind));
			}
			formatter.Options.FirstOperandCharIndex = 8;
			formatter.Options.MemorySizeOptions = MemorySizeOptions.Minimum;
			formatter.Options.ShowBranchSize = !diffable;

			return formatter;
		}   
    }
}