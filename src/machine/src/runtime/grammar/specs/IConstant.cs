//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    /// <summary>
    /// Characterizes invariant data
    /// </summary>
    public interface IConstant
    {

    }

    /// <summary>
    /// Characterizes invariant data of known width, parametric in representation type
    /// </summary>
    /// <typeparam name="T">The data representation type</typeparam>
    public interface IConstant<T> : IConstant
        where T : unmanaged
    {
        /// <summary>
        /// The constant value
        /// </summary>
        T Literal {get;}
        

        DataWidth Width => (DataWidth)Widths.measure<T>();
    }

    /// <summary>
    /// Characterizes invariant data, parametric in both width and representation type
    /// </summary>
    /// <typeparam name="W">The data width</typeparam>
    /// <typeparam name="T">The data representation type type</typeparam>
    public interface IConstant<W,T> : IConstant<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {        
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic representation of invariant data, parametric in both width and representation type
    /// </summary>
    /// <typeparam name="W">The data width</typeparam>
    /// <typeparam name="T">The data representation type type</typeparam>
    public interface IConstant<F,W,T> : IConstant<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {        


    }

}