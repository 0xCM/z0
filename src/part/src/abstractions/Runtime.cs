//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    
    public abstract class Runtime
    {
        PartBox Box;

        [MethodImpl(Inline)]
        protected Runtime(PartBox data)
            => Box = data;

        [MethodImpl(Inline)]
        public T Extract<T>()
            => Box.Extract<T>();
        
        [MethodImpl(Inline)]
        public ref T Store<T>(in T src)
        {
             PartBox.Update(src, ref Box);
             return ref Unsafe.AsRef(src);
        }
    }

    public class Runtime<P> : Runtime
        where P : Part<P>, IPart<P>, new()    
    {        
        [MethodImpl(Inline)]
        public Runtime(PartBox data)
            : base(data)
        {

        }
    }                        
}