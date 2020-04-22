//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct CheckNumeric : ICheckNumeric 
    {
        public static ICheckNumeric Checker => default(CheckNumeric);    
    }    

    public interface ICheckNumeric : 
        ICheckGeneric, 
        ICheckSpans, 
        ICheckClose,
        ICheckPrimalSeq
    {
    }
}