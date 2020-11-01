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

    public struct CmdStream
    {
        readonly TableSpan<CmdSpec> Commands;

        uint Index;

        uint Count;

        int Last;

        [MethodImpl(Inline)]
        public CmdStream(CmdSpec[] src)
        {
            insist(src.Length > 0, "The array, it must not be empty");
            Commands = src;
            Index = 0;
            Count = (uint)src.Length;
            Last = src.Length - 1;
        }

        [MethodImpl(Inline)]
        public ref readonly CmdSpec Next(out uint index)
        {
            index = Index;
            ref readonly var next = ref Commands[Index];
            if(Index == Last)
                Index = 0;
            else
                ++Index;
            return ref next;
        }
    }
}