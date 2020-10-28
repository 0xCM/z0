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

    public enum CmdStreamKind : byte
    {
        ShellCmd
    }

    public ref struct CmdStreamSource
    {
        public CmdStreamKind StreamKind {get;}

        readonly ReadOnlySpan<BinaryCode> Commands;

        uint Index;

        uint Count;

        int Last;

        [MethodImpl(Inline)]
        public CmdStreamSource(CmdStreamKind kind, BinaryCode[] src)
        {
            insist(src.Length > 0, "The array, it must not be empty");
            StreamKind = kind;
            Commands = src;
            Index = 0;
            Count = (uint)src.Length;
            Last = src.Length - 1;
        }

        [MethodImpl(Inline)]
        public ref readonly BinaryCode Next(out uint index)
        {
            index = Index;
            ref readonly var next = ref skip(Commands,Index);
            if(Index == Last)
                Index = 0;
            else
                ++Index;
            return ref next;
        }
    }
}