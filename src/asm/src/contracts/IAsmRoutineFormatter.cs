//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines service contract for asm text formatting support
    /// </summary>
    public interface IAsmRoutineFormatter
    {
        /// <summary>
        /// The configuration used when rendering the formatted text
        /// </summary>
        AsmFormatConfig Config {get;}

        /// <summary>
        /// Creates a detailed presentation of decoded x86 asm data per the accompanying configuration spec
        /// </summary>
        /// <param name="src">The function to render as asm text</param>
        AsmRoutineFormat Format(AsmRoutine src);

        /// <summary>
        /// Renders a routine to a caller-supplied buffer
        /// </summary>
        /// <param name="src">The source routine</param>
        /// <param name="dst">The target buffer</param>
        void Render(in AsmRoutine src, ITextBuffer dst);
    }
}