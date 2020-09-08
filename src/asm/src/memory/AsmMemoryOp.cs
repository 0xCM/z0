//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
     using System;

    /// <summary>
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public struct AsmMemoryOp<T>
        where T : unmanaged, IAsmMemoryOp<T>
    {
        public T Data;
    }

    /// <summary>
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public struct AsmMemoryOp<W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged, IAsmMemoryOp<W,T>
    {
        public T Data;

    }

    /// <summary>
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public struct AsmMemoryOp<M,W,T>
        where M : unmanaged, IAsmMemoryOp<M,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged, IAsmMemoryOp<W,T>
    {
        public T Data;

    }

    public struct AsmMemoryOp
    {

    }
}