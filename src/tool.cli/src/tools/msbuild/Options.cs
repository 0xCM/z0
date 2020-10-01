//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;

    public readonly partial struct MsBuild
    {
        public enum LoggerVerbosity : byte
        {
            Quiet,

            Minimal,

            Normal,

            Detailed,

            Diagnostic
        }
    }

}