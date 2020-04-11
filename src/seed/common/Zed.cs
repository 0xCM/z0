//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IZed
    {
        
    }


    public interface IZed<Z> : IZed
        where Z : INullary<Z>, new()
    {
        
    }

    public readonly struct Zed 
    {
        
    }

    public readonly struct Zed<Z> : IZed<Z>
        where Z : INullary<Z>, new()
    {
        public Z Zero => new Z();

    }

    partial class Seed
    {
        public static Zed Zed => default(Zed);

        public static Z Zero<Z>(this Zed z)
            where Z : INullary<Z>, new()
                => new Z();                
    }
}