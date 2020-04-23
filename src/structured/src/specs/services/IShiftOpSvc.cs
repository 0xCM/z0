//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;        

    using static Seed; 

    public interface IShiftOpSvc<T> : IUnaryImm8Op<T>, ISpanShiftImm8<T>
        where T : unmanaged
    {
        
    }

    public interface IShiftOpSvc<K,T> : IShiftOpSvc<T>, IBitShiftKind<K,T>
        where T : unmanaged
        where K : unmanaged, IBitShiftKind
    {

    }

    public interface IVarShiftOpSvc<T> : IVarSpanShift<T>
        where T : unmanaged
    {

    }

    public interface IVarShiftOpSvc<K,T> : IVarShiftOpSvc<T>, IBitShiftKind<K,T>
        where K : unmanaged, IBitShiftKind
        where T : unmanaged
    {

    }    
}