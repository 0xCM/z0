//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Llvm
    {
        public struct Lli : ITool<Lli>
        {
            public string ToolName => "lli";
        }

        public struct LliCmd : IToolCmd<Lli,LliCmd>
        {

        }
    }
}