//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public sealed partial class Nasm : ToolService<Nasm>
    {
        readonly BitFormatter<byte> BitFormat;


        public Nasm()
        {
            Id = Toolsets.nasm;
            BitFormat = BitFormatter.create<byte>(4);
        }
   }
}