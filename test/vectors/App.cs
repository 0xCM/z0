//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VectorTest)]

namespace Z0.Parts
{        
    using System;

    public sealed class VectorizedTest : Part<VectorizedTest>
    {

    }
}

namespace Z0 
{
     class App : TestApp<App> 
     { 
         public static void Main(params string[] args) 
         => Run(args); 
    } 
}