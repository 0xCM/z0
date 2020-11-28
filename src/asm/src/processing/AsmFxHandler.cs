//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity]
    public delegate void AsmFxHandler(in Instruction src);



    public interface IAsmNodeSink<T> : IValueSink<T>
        where T : struct
    {

    }

    public interface IAsmConditionTest<T> : IDataConditionTest<T>
        where T : struct
    {

    }

    public interface IAsmInstructionSink : IAsmNodeSink<Instruction>
    {

    }
}