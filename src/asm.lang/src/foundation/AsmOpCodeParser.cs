//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;


    using static Part;
    using static memory;
    using static Chars;

    [ApiHost]
    public ref struct AsmOpCodeParser
    {
        ReadOnlySpan<char> Data;

        readonly string Content;

        bool? _HasRex;

        bool? _HasVex;

        [MethodImpl(Inline)]
        public AsmOpCodeParser(string src)
        {
            Data = src;
            Content = src;
            _HasRex = null;
            _HasVex = null;
        }

        [Op]
        public bool HasRex()
        {
            if(_HasRex == null)
                _HasRex = Content.StartsWith("REX");
            return _HasRex.Value;
        }

        [Op]
        public bool HasVex()
        {
            if(_HasRex == null)
                _HasRex = Content.StartsWith("VEX");
            return _HasRex.Value;
        }

    }
}