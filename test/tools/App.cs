//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class ToolsTestApp : TestApp<ToolsTestApp>
    {
        static void Main(params string[] args)
            => Run(args);

        public static void run(params string[] args)
            => Run(args);
    }

    public abstract class t_tools<T> : UnitTest<T>
        where T : t_tools<T>, new()
    {

    }
}