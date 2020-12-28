//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    /// <summary>
    /// Characterizes a constant value
    /// </summary>
    /// <typeparam name="T">The constant type</typeparam>
    public interface IConstant<T>
    {
        Identifier Name {get;}

        T Value {get;}

        LiteralKind Kind
            => LiteralKinds.kind<T>();
    }

    /// <summary>
    /// Characterizes a reified constant value
    /// </summary>
    /// <typeparam name="T">The constant type</typeparam>
    public interface IConstant<H,T> : IConstant<T>
        where H : struct, IConstant<H,T>
    {

    }
}