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
            => Config = AsmFormatConfig.@default(out var _);

        public AsmRoutineFormatter(in AsmFormatConfig config)
            => Config = config;

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public AsmRoutineFormat Format(AsmRoutine src)
            => AsmFormatter.format(src, Config);
   }
}