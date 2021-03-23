//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Defines an untyped characterization of a wokflow operand
    /// </summary>
    [Free]
    public interface IWfFuncArg
    {
        /// <summary>
        /// An integer that identifies an argument within the context of the defining step
        /// </summary>
        byte Index {get;}

        /// <summary>
        /// The encoded argument value
        /// </summary>
        ulong Value {get;}
    }

    /// <summary>
    /// Characterizes a workflow operand
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [Free]
    public interface IWfFuncArg<T> : IWfFuncArg
    {
        new T Value {get;}

        ulong IWfFuncArg.Value
            => memory.uint64(Value);
    }

    /// <summary>
    /// Characterizes a workflow operand argument with parametric index type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="H">The operand type</typeparam>
    [Free]
    public interface IWfFuncArg<I,T> : IWfFuncArg<T>
        where I : unmanaged
    {
        new I Index {get;}

        byte IWfFuncArg.Index
            => memory.uint8(Index);
    }
}