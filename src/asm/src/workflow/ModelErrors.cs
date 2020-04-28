//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    static class ModelErrors
    {
        public static AppMsg InstructionSizeMismatch(MemoryAddress location, int offset, int actual, int reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.Error(text.concat(
                    $"The encoded instruction length does not match the reported instruction length:", 
                    $"address = {location}, datalen = {reported}, offset = {offset}, bytelen = {reported}"),
                        caller, file, line);
                        
        public static AppMsg InstructionBlockSizeMismatch(MemoryRange origin, int actual, int reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.Error(text.concat(
                    $"The encoded instruction block length does not match the reported total instruction length:", 
                    $"origin = {origin}, block length = {reported}, reported length = {reported}"),
                        caller, file, line);
    }
}