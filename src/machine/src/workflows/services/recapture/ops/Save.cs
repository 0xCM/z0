//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial struct Recapture
    {
        void Save(X86ApiCapture capture, StreamWriter dst)
        {
            var asm = Context.RoutineDecoder.Decode(capture).Require();
            var formatted = Context.Formatter.FormatFunction(asm);
            dst.Write(formatted);
        }
    }
}