//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using Z0.Asm;

    partial class Nasm
    {
        public Index<AssembledAsm> LoadAssembledAsm(Identifier listname)
            => Assembled(LoadListedBlocks(listname));
    }
}