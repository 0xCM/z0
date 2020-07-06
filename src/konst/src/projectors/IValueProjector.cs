//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
 
    public interface IValueProjector
    {
        ValueFunc F {get;}
        
        ValueType Project(ValueType src)
            => F(src);
        
        object Project(object src)
            => F((ValueType)src);

        ref T Project<T>(object src)
            where T : struct
                => ref core.unbox<T>(Project(src));
    }
    
    public interface IValueProjector<T> : IValueProjector
        where T : struct
    {
        new ValueFunc<T> F {get;}

        ValueFunc IValueProjector.F 
            => x => F(x);
        
        new ref T Project(object src);

        object IValueProjector.Project(object src)
            =>  Project(src);
    }

    public interface IValueProjector<S,T> : IValueProjector<T>
        where S : struct
        where T : struct
    {
        new ValueFunc<S,T> F {get;}
        
        ValueFunc IValueProjector.F
            => src => F((S)src);
        
        ref T Project(in S src)
            => ref F(src);

        ref T IValueProjector<T>.Project(object src)
            => ref Project(core.unbox<T>(src));        
    }
}