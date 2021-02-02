//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public unsafe ref struct CodeExtractor
    {
        readonly Span<byte> Buffer;

        readonly Span<byte> Instruction;

        uint BufferPos;

        byte InstructionPos;

        MemoryAddress Source;

        byte* Memory;

        bool Finished;

        byte ZeroCount;

        byte MaxZeroCount;

        uint BufferLimit;

        byte InstructionLimit;

        [MethodImpl(Inline)]
        public CodeExtractor(byte[] buffer)
        {
            Buffer = buffer;
            BufferPos = 0;
            InstructionPos = 0;
            Source = MemoryAddress.Zero;
            Memory = Source.Pointer<byte>();
            Finished = false;
            ZeroCount = 0;
            MaxZeroCount = 10;
            BufferLimit = (uint)Buffer.Length - 1;
            Instruction = alloc<byte>(16);
            InstructionLimit = (byte)(Instruction.Length - 1);
        }

        public CodeExtractor(uint size)
            : this(alloc<byte>(size))
        {


        }

        void Reset(MemoryAddress src)
        {
            Buffer.Clear();
            Instruction.Clear();
            Source = src;
            BufferPos = 0;
            InstructionPos = 0;
            Memory = Source.Pointer<byte>();
            ZeroCount = 0;
        }

        public ref readonly byte First(MemoryAddress src)
        {
            Reset(src);
            Advance();
            return ref skip(Buffer, BufferPos);
        }

        ref readonly byte Current
        {
            [MethodImpl(Inline)]
            get => ref skip(Buffer, BufferPos);
        }

        [MethodImpl(Inline), Op]
        void Advance()
        {
            seek(Buffer, BufferPos++) = *Memory++;
            if(Current == 0)
                ZeroCount++;
            else
                ZeroCount = 0;

            if(InstructionPos < InstructionLimit)
                seek(Instruction, InstructionPos++) = Current;
        }

        bool InstructionComplete()
        {
            return false;
        }

        [Op]
        public bool Next(out byte dst)
        {
            if(!Finished)
            {
                Advance();
                if(ZeroCount < MaxZeroCount && BufferPos < BufferLimit)
                {
                    dst = Current;
                    return true;
                }
            }
            dst = z8;
            return false;
        }
    }
}