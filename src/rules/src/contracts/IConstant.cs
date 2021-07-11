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
        T Value {get;}

        Rules.ConstantKind Kind {get;}
    }
}