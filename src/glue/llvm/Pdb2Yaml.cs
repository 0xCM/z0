//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Llvm
    {
        [Tool]
        public readonly struct Obj2Yaml : ITool<Obj2Yaml>
        {
            public ToolId Id => Toolspace.obj2yaml;
        }

        [Cmd]
        public struct Obj2YamlCmd : IToolCmd<Obj2YamlCmd,Obj2Yaml>
        {

        }
    }
}