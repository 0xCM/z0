//-----------------------------------------------------------------------------
// Taken from https://github.com/0xd4d/JitDasm/tree/master/JitDasm;
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using static zfunc;

    partial class Symbolizer
    {
        [Flags]
        public enum DisassemblerOptions 
        {
            None				= 0,
            Diffable			= 0x00000001,
            ShowAddresses		= 0x00000002,
            ShowHexBytes		= 0x00000004,
            ShowSourceCode		= 0x00000008,
        }

        public enum FileOutputKind 
        {
            Stdout,
            OneFile,
            OneFilePerType,
            OneFilePerMethod,
        }

        public enum FilenameFormat 
        {
            MemberName,
            TokenMemberName,
            Token,
        }

        public enum DisassemblerOutputKind 
        {
            Masm,
            Nasm,
            Gas,
            Intel,
        }

        public sealed class JitDasmOptions 
        {
            public int Pid;

            public string ModuleName = string.Empty;

            public string LoadModule;

            public string OutputDir = string.Empty;

            public readonly List<string> AssemblySearchPaths = new List<string>();

            public readonly MemberFilter TypeFilter = new MemberFilter();

            public readonly MemberFilter MethodFilter = new MemberFilter();

            public bool Diffable = false;

            public bool ShowAddresses = true;

            public bool ShowHexBytes = true;

            public bool ShowSourceCode = true;

            public bool HeapSearch = false;

            public bool RunClassConstructors = true;

            public FilenameFormat FilenameFormat = FilenameFormat.MemberName;

            public FileOutputKind FileOutputKind = FileOutputKind.Stdout;

            public DisassemblerOutputKind DisassemblerOutputKind = DisassemblerOutputKind.Masm;
        }

    }

}
