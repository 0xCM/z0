[assembly: PartId(PartId.GenericNumericsTest)]

//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{       
    public class App : TestApp<App>
    {                   
        public static void Main(params string[] args) => Run(args);
    }
}


namespace Z0.Parts
{ 
    public sealed class GMathTest : Part<GMathTest>
    {

    }
}