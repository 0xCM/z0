//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct CodeBlocks
    {
        public static void render(in BinarySourceBlock src, ITextBuffer dst)
        {
            switch(src.Render)
            {
                default:
                    dst.AppendLine(src.Code.Format());
                    break;
            }
        }
    }
}