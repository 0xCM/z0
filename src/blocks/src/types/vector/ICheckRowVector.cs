//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;    

    using static Konst;
    using static Memories;

    public interface ICheckRowVector : TValidator
    {
        static ICheckRowVector<CheckRowVector> Checker => default(CheckRowVector);

        [MethodImpl(Inline)]           
        int length<T>(RowVector256<T> lhs, RowVector256<T> rhs)
            where T : unmanaged
                => CheckRowVector.length(lhs,rhs);        
    }

    public interface ICheckRowVector<C> : ICheckRowVector
        where C : ICheckRowVector<C>, new()
    {


    }

    public readonly struct CheckRowVector : ICheckRowVector<CheckRowVector>
    {
        [MethodImpl(Inline)]   
        public static int length<T>(RowVector256<T> lhs, RowVector256<T> rhs)
            where T : unmanaged
                => lhs.Length == rhs.Length ? lhs.Length  : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);
    }
}