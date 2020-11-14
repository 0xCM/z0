//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class GVecTestApp : TestApp<GVecTestApp>
    {
        protected override void RunTests(params string[] filters)
            => base.RunTests(filters);

        static void Main(params string[] args)
            => Run(args);

        public static void run(params string[] args)
            => Run(args);
    }
}