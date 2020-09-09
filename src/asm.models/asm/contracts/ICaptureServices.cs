//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ICaptureServices : IAsmServices
    {
        ICaptureCore CaptureCore {get;}

        IImmSpecializer ImmSpecializer(IAsmDecoder decoder);

        /// <summary>
        /// Creates a function decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        IAsmDecoder RoutineDecoder(in AsmFormatSpec? format = null);
    }
}