//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class App
    {
        public static void Main(params string[] args)
            => root.@try(() => Capture.run(args), e => term.error(e));
    }
}