//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct Checker : IChecker
    {
        public static IChecker Check => default(Checker);
    }

    public interface IChecker : 
        ICheckError, 
        ICheckInvariant, 
        ICheckLengths, 
        ICheckFileSystem, 
        ICheckNull, 
        ICheckOptions, 
        ICheckPrimal,
        ICheckSets
    {
    
    }

    public interface IChecker<V> : IChecker
        where V : struct, IValidator
    {
        static V Checker => default(V);
    }
}