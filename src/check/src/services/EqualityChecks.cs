//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines common equality check contracts
    /// </summary>
    public readonly partial struct EqualityChecks
    {
        public interface IEqualCheck<T>
        {
            bool Equal(T a, T b);
        }


        public interface IStructuralCheck<T>
            where T : struct
        {
            bool Equal(T a, T b);
        }

        public interface IUnmanagedCheck<T>
            where T : unmanaged
        {
            bool Equal(T a, T b);
        }

        public interface IEquatableCheck<T>
            where T : IEquatable<T>
        {
            bool Equal(T a, T b);
        }


    }
}