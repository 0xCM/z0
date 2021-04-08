//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial class Nasm
    {
        [Op]
        public void RenderSource(in TextBlock src, ITextBuffer dst)
        {
            dst.AppendFormat("{0}{1}", RenderDelimiter, src);
        }
    }
}