//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LL = LiteralLookups;

    static partial class ToEnumConverter 
    {        
      public static bool TryCode(string value, out Code code) 
            => LL.Codes.TryGetValue(value, out code);

      public static Code GetCode(string value) 
            => TryCode(value, out var code) 
            ? code : throw new InvalidOperationException($"Invalid Code value: {value}");

      public static IEnumerable<string> GetCodeNames() 
            => LL.Codes.OrderBy(a => a.Value).Select(a => a.Key);

      public static bool TryRegister(string value, out Register register) 
            => LL.Registers.TryGetValue(value, out register);

      public static Register GetRegister(string value) 
            => TryRegister(value, out var register) 
      ? register : throw new InvalidOperationException($"Invalid Register value: {value}");

      public static Dictionary<string, Register> CloneRegisterDict() 
            => new Dictionary<string, Register>(LL.Registers, StringComparer.Ordinal);

      public static bool TryMemorySize(string value, out MemorySize memorySize) 
      => LL.MemorySizes.TryGetValue(value, out memorySize);

      public static MemorySize GetMemorySize(string value) 
      => TryMemorySize(value, out var memorySize)
      ? memorySize : throw new InvalidOperationException($"Invalid MemorySize value: {value}");

      public static bool TryMnemonic(string value, out Mnemonic mnemonic) 
      => LL.Mnemonics.TryGetValue(value, out mnemonic);

      public static Mnemonic GetMnemonic(string value) 
            => TryMnemonic(value, out var mnemonic) 
            ? mnemonic : throw new InvalidOperationException($"Invalid Mnemonic value: {value}");
    }    
}
