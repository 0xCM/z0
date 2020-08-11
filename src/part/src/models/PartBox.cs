//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
            
    public struct PartBox
    {        
        object Boxed;

        [MethodImpl(Inline)]
        public PartBox(object src)
            => Boxed = src;

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Boxed != null && !(Boxed is sbyte x && x == -1);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Boxed is sbyte x && x == -1;
        }

        [MethodImpl(Inline)]
        public T Extract<T>()
            => (T)Boxed;        


        [MethodImpl(Inline)]
        public static ref PartBox Update(object src, ref PartBox dst)
        {
            dst.Boxed = src;
            return ref dst;
        }

        public static PartBox Empty 
            => new PartBox((sbyte)-1);        
    }
}