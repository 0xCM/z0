//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public class AsmRoutineFormatter : IAsmRoutineFormatter
    {
        public AsmFormatConfig Config {get;}

        public AsmRoutineFormatter()
        {
            Config = AsmFormatConfig.@default(out var _);
        }

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string Format(AsmRoutine src)
            => AsmFormatter.format(src, Config);

        public void Render(in AsmRoutine src, ITextBuffer dst)
            => AsmFormatter.format(src, Config, dst);
   }
}