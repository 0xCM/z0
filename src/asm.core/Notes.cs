//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    struct Notes
    {
        public const string FlatMemoryModel = @"Memory appears to a program as a single, continuous address space. This space is
called a linear address space. Code, data, and stacks are all contained in this address space.
Linear address space is byte addressable, with addresses running contiguously from 0 to 232 - 1 (if not in 64-bit mode).
An address for any byte in linear address space is called a linear address.";

        public const string SegmentedMemoryModel = @"Memory appears to a program as a group of independent address spaces
called segments. Code, data, and stacks are typically contained in separate segments. To address a byte in a
segment, a program issues a logical address. This consists of a segment selector and an offset (logical
addresses are often referred to as far pointers). The segment selector identifies the segment to be accessed
and the offset identifies a byte in the address space of the segment. Programs running on an IA-32 processor
can address up to 16,383 segments of different sizes and types, and each segment can be as large as 232
bytes.
Internally, all the segments that are defined for a system are mapped into the processor’s linear address space.
To access a memory location, the processor thus translates each logical address into a linear address. This
translation is transparent to the application program.
The primary reason for using segmented memory is to increase the reliability of programs and systems. For
example, placing a program’s stack in a separate segment prevents the stack from growing into the code or
data space and overwriting instructions or data, respectively.";

        public const string RealMemoryModel = @"This is the memory model for the Intel 8086 processor. It is
supported to provide compatibility with existing programs written to run on the Intel 8086 processor. The real-
address mode uses a specific implementation of segmented memory in which the linear address space for the
program and the operating system/executive consists of an array of segments of up to 64 KBytes in size each.
The maximum size of the linear address space in real-address mode is 220 bytes.";

    }

}