//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class CoreTestApp : TestApp<CoreTestApp>
    {
        static PartId[] Parts => root.array(PartId.Core);

        static void Main(params string[] args)
            => Run(Parts, args);
    }
}
