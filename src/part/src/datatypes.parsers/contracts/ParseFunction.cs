//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Parsers
    {
        public delegate bool ParseFunction<T>(string src, out T dst);
    }
}