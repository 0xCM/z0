//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface IRegRef
    {

    }

    /// <summary>
    /// Identifies a register
    /// </summary>
    public class RegRef :  IRegRef
    {



    }

    public interface IRegRef<T> : IRegRef
        where T : unmanaged, Enum
    {
        
        T Kind {get;}

    }   

    /// <summary>
    /// Defines a reference to a register
    /// </summary>
    /// <typeparam name="T">The kind identifier</typeparam>
    public abstract class RegRef<T> :  RegRef, IRegRef<T>
        where T : unmanaged, Enum
    {
        public T Kind {get;}

        protected RegRef(T Kind)
        {
            this.Kind = Kind;
        }
    }

}