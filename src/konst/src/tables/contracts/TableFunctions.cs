//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableFunctions
    {
        public delegate ref T Map<S,T>(in S src, ref T dst);

        public delegate Y MapTable<T,Y>(in T src)
            where T : struct;

        public delegate void Receive<T>(in T src)
            where T : struct;
    }
}