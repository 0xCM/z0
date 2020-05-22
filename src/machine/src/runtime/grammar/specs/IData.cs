//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{

    /// <summary>
    /// Characterizes data of known width
    /// </summary>
    public interface IData
    {
        
    }

    /// <summary>
    /// Characterizes data of parametric width
    /// </summary>
    /// <typeparam name="W">The data width</typeparam>
    public interface IData<W> : ISized<W>
        where W : unmanaged, IDataWidth
    {        

    }

    /// <summary>
    /// Characterizes (immutable) data of parametric width and type
    /// </summary>
    /// <typeparam name="W">The data width</typeparam>
    /// <typeparam name="S">The data type</typeparam>
    public interface IData<W,S> : IData<W>
        where W : unmanaged, IDataWidth
        where S : unmanaged
    {        
        /// <summary>
        /// The encapsuated data
        /// </summary>
        S State {get;}
    }

    /// <summary>
    /// Characterizes data of parametric width and type
    /// </summary>
    /// <typeparam name="W">The data width</typeparam>
    /// <typeparam name="T">The data type</typeparam>
    public interface IData<F,W,T> : IData<W,T>
        where F : struct, IData<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {        
                                
    }
}