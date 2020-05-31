//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{

    /// <summary>
    /// Characterizes data of known width
    /// </summary>
    public interface IOpData
    {
        
    }

    /// <summary>
    /// Characterizes data of parametric width
    /// </summary>
    /// <typeparam name="W">The data width</typeparam>
    public interface IOpData<W> : ISized<W>
        where W : unmanaged, IDataWidth
    {        

    }

    /// <summary>
    /// Characterizes (immutable) data of parametric width and type
    /// </summary>
    /// <typeparam name="W">The data width</typeparam>
    /// <typeparam name="S">The data type</typeparam>
    public interface IOpData<W,S> : IOpData<W>
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
    public interface IOpData<F,W,T> : IOpData<W,T>
        where F : struct, IOpData<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {        
                                
    }
}