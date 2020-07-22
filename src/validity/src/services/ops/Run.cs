//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial class TestApp<A>
    {
        public static void Run(params string[] args)
        {
            var app = new A();            
            app.SetMode(InDiagnosticMode);            
            app.RunTests();
        }
    }
}