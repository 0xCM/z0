//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using Microsoft.Diagnostics.Runtime;
    using System.IO;

    using static zfunc;

    /// <summary>
    /// The symbolizer code is based on code extraced from https://github.com/0xd4d/JitDasm/tree/master/JitDasm; see license file
    /// </summary>
    partial class Symbolizer
    {
		public static int Run(string[] args) 
        {
			try 
            {
				switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture) {
				case System.Runtime.InteropServices.Architecture.X64:
				case System.Runtime.InteropServices.Architecture.X86:
					break;
				default:
					throw new ApplicationException($"Unsupported CPU arch: {System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}");
				}

				var jitDasmOptions = CommandLineParser.Parse(args);
				if (!string.IsNullOrEmpty(jitDasmOptions.LoadModule)) {
#if DEBUG
					Console.Error.WriteLine($"Trying to jit methods in module '{jitDasmOptions.LoadModule}' but JitDasm is a debug build, not a release build!");
#endif
					MethodJitter.JitMethods(jitDasmOptions.LoadModule, jitDasmOptions.TypeFilter, jitDasmOptions.MethodFilter, jitDasmOptions.RunClassConstructors, jitDasmOptions.AssemblySearchPaths);
				}
				var (bitness, methods, knownSymbols) = GetMethodsToDisassemble(jitDasmOptions.Pid, jitDasmOptions.ModuleName, jitDasmOptions.TypeFilter, jitDasmOptions.MethodFilter, jitDasmOptions.HeapSearch);
				var jobs = GetJobs(methods, jitDasmOptions.OutputDir, jitDasmOptions.FileOutputKind, jitDasmOptions.FilenameFormat, out var baseDir);
				if (!string.IsNullOrEmpty(baseDir))
					Directory.CreateDirectory(baseDir);
				var sourceDocumentProvider = new SourceDocumentProvider();
				using (var mdProvider = new MetadataProvider()) {
					var sourceCodeProvider = new SourceCodeProvider(mdProvider, sourceDocumentProvider);
					using (var context = new DisasmJobContext(bitness, knownSymbols, sourceCodeProvider, jitDasmOptions.DisassemblerOutputKind, jitDasmOptions.Diffable, jitDasmOptions.ShowAddresses, jitDasmOptions.ShowHexBytes, jitDasmOptions.ShowSourceCode)) {
						foreach (var job in jobs)
							Disassemble(context, job);
					}
				}
				return 0;
			}
			catch (ShowCommandLineHelpException) {
				CommandLineParser.ShowHelp();
				return 1;
			}
			catch (CommandLineParserException ex) {
				Console.WriteLine(ex.Message);
				return 1;
			}
			catch (ApplicationException ex) {
				Console.WriteLine(ex.Message);
				return 1;
			}
			catch (ClrDiagnosticsException ex) {
				Console.WriteLine(ex.Message);
				Console.WriteLine("Make sure this process has the same bitness as the target process");
				return 1;
			}
			catch (Exception ex) {
				Console.WriteLine(ex.ToString());
				return 1;
			}

        }
    }

}
    