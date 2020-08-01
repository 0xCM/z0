//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Json
    {
        public readonly string Content;

        public static implicit operator Json(string src)
            => new Json(src);
        
        public Json(string src)
        {
            Content = src;
        }

        public bool IsEmpty
        {
            get => text.blank(Content);
        }
    }
}