//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a sign-reversal operation
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IResignableOps<T> : ISignableOps<T>, INegatableOps<T>
        where T : unmanaged
    {
        /// <summary>
        /// Aligns the value with a specified sign
        /// </summary>
        T Resign(T x, PolarityKind s);
    }
}