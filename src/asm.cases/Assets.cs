//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class Assets : Assets<Assets>
    {
        public ResDescriptor AndAsm() => Asset("and.asm");
    }
}