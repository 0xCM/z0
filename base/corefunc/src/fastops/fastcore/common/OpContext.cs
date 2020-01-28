//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IOpContext : IContext
    {
        
    }

    /// <summary>
    ///  Characterizes absolutely nothing
    /// </summary>
    public interface IOpService
    {
        
    }

    public interface IOpService<T> : IOpService
        where T : IOpContext
    {
        T Context {get;}
    }
    
    public abstract class OpContext<T> : Context<T>, IOpContext
        where T : OpContext<T>
    {                
        protected OpContext(IPolyrand random)
            : base(random)            
        {

        }
    }   
}