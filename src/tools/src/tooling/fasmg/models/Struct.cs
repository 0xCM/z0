//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;
    using static Typed;

    partial class FasmG
    {
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct Struct
        {
            public ByteBlock16 Name;

            public ByteBlock8 Type;

            public ByteBlock64 Comment;
        }

        [Op]
        public static ref Struct define(string name, string type, string comment, out Struct dst)
        {
            ByteBlocks.asci(n16, name, out dst.Name);
            ByteBlocks.asci(n8, type, out dst.Type);
            ByteBlocks.asci(n64, comment, out dst.Comment);
            return ref dst;
        }
    }
}