//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AppErrorMsg;

    public readonly struct CheckNumeric : ICheckNumeric 
    {
        public static ICheckNumeric Checker => default(CheckNumeric);    
    }    

    public interface ICheckNumeric : 
        ICheckGenericNumeric, 
        ICheckSpans, 
        ICheckClose,
        ICheckPrimalSeq
    {
    }
}