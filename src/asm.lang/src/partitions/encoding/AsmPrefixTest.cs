//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static OperatingMode;
    using static OperandSize;
    using static AsmRefs;

    [ApiHost]
    public readonly struct AsmPrefixTest
    {
        /// <summary>
        /// Determines whether a 66h prefix is required to indicate an operand-size override
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="default"></param>
        /// <param name="effective"></param>
        [Op, Doc(Amd + V3 + C1 + S2 + T2)]
        public static bit prefix66(OperatingMode mode, OperandSize @default, OperandSize effective)
            => mode switch{
                Mode64 => effective switch {
                    W16 => 1,
                    W32 => 0,
                    W64 => 0,
                    _ => 0,
                },

                Compatibilty => effective switch {
                    W16 => @default switch{
                        W16 => 1,
                        W32 => 0,
                        _ => 0,
                    },

                    W32 => @default switch{
                        W16 => 0,
                        W32 => 1,
                        _ => 0,
                    },

                    _ => 0
                },

                Protected => effective switch {
                    W16 => @default switch {
                        W16 => 1,
                        W32 => 0,
                        _ => 0,
                    },
                    W32 => @default switch {
                        W16 => 0,
                        W32 => 1,
                        _ => 0,
                    },
                    _ => 0
                },

                Virtual8086 => effective switch {
                    W16 => @default switch {
                        W16 => 1,
                        W32 => 0,
                        _ => 0,
                    },
                    W32 => @default switch {
                        W16 => 0,
                        W32 => 1,
                        _ => 0,
                    },
                    _ => 0
                },

                Real => effective switch {
                    W16 => @default switch {
                        W16 => 1,
                        W32 => 0,
                        _ => 0,
                    },
                    W32 => @default switch {
                        W16 => 0,
                        W32 => 1,
                        _ => 0,
                    },
                    _ => 0
                },
              _ => 0
            };
    }
}