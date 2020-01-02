//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;


    partial class AsmEncoding
    {

        /// <summary>
        /// Represents an opocode of variable length 1, 2, or 3 bytes
        /// </summary>
        public readonly struct OpCode
        {
            readonly byte Part1;

            readonly byte Part2;

            readonly byte Part3;

            /// <summary>
            /// The length of the op ocde in bytes, btween 1 and 3 inclusive
            /// </summary>
            public readonly ByteSize Size;            

            public OpCode(byte part1)
                : this()
            {
                this.Part1 = part1;
                this.Size = 1;

            }

            public OpCode(byte part1, byte part2)
                : this()
            {
                this.Part1 = part1;
                this.Part2 = part2;
                this.Size = part2 != 0 ? 2 : 1;
            }

            public OpCode(byte part1, byte part2, byte part3)
                : this()
            {
                this.Part1 = part1;
                this.Part2 = part2;
                this.Part3 = part3;
                this.Size = part3 != 0 ? 3 : (part2 != 0 ? 2 : 1);
            }

            /// <summary>
            /// The opcode value as a variable-length array
            /// </summary>
            public byte[] Encoding
            {
                get
                {
                    if(Size == 1)
                        return new byte[]{Part1};
                    else if(Size == 2)
                        return new byte[]{Part1, Part2};
                    else
                        return new byte[]{Part1,Part2,Part3};
                }
            }
        }
    }

}