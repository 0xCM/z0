//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IOrderedOps<T> 
    {
        bool Lt(T lhs, T rhs);
        
        bool LtEq(T lhs, T rhs);
        
        bool Gt(T lhs, T rhs);  
        
        bool GtEq(T lhs, T rhs);              
    }    
}