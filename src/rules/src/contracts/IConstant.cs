//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Rules;

    /// <summary>
    /// Characterizes a constant value
    /// </summary>
    /// <typeparam name="T">The constant type</typeparam>
    public interface IConstant<T>
    {
        T Value {get;}

        ConstantKind Kind {get;}
    }
}