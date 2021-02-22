//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;

    partial struct Llvm
    {
        [Tool]
        public readonly struct PdbToYaml : ITool<PdbToYaml>
        {
            public Name ToolName => ToolNames.pdb2yaml;
        }

        [Cmd]
        public struct PdbToYamlCmd : IToolCmd<PdbToYamlCmd,PdbToYaml>
        {

        }
    }
}