//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct ToolCmdStream
    {
        readonly TableSpan<ToolExecSpec> Commands;

        uint Index;

        uint Count;

        int Last;

        [MethodImpl(Inline)]
        public ToolCmdStream(ToolExecSpec[] src)
        {
            Commands = src;
            Index = 0;
            Count = (uint)src.Length;
            Last = src.Length - 1;
        }

        [MethodImpl(Inline)]
        public ref readonly ToolExecSpec Next(out uint index)
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