//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ICaptureServices
    {
        ICaptureCore CaptureCore {get;}

        /// <summary>
        /// Creates a function decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        IAsmDecoder RoutineDecoder {get;}

        IAsmRoutineFormatter RoutineFormatter {get;}
    }
}