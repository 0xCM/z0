//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Computation
    {
        public static ResultCode run<S,T>(Computation<S,T> comp, in S src, out T dst)
            => comp.Compute(src, out dst);

        public static ResultCode run<S,T>(Computation<S,T> comp, ReadOnlySpan<S> src, Span<T> dst)
            => comp.Compute(src, dst);
    }

    [ApiHost]
    public readonly struct ResultCodes
    {
        public static ResultCode Ok => default;

        public static ResultCode BufferTooSmall => new ResultCode(0x01);

        [Op]
        public unsafe static ResultCode from(Exception e)
        {
            return new ResultCode(uint.MaxValue);
        }
    }

    public readonly struct ResultCode
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public ResultCode(uint value)
        {
            Value = value;
        }

        public bool Ok
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator ResultCode(uint value)
            => new ResultCode(value);

        [MethodImpl(Inline)]
        public static bool operator true(ResultCode src)
            => src.Ok;

        [MethodImpl(Inline)]
        public static bool operator false(ResultCode src)
            => !src.Ok;
    }

    public abstract class Computation<S,T>
    {
        public abstract ResultCode Compute(in S src, out T dst);

        public virtual ResultCode Compute(ReadOnlySpan<S> src, Span<T> dst)
        {
            var count = src.Length;
            if(count > dst.Length)
                return ResultCodes.BufferTooSmall;

            var result = ResultCodes.Ok;
            try
            {
                for(var i=0; i<count; i++)
                {
                    result = Compute(skip(src,i), out seek(dst,i));
                    if(result)
                        continue;
                    else
                        break;
                }
            }
            catch(Exception e)
            {
                return ResultCodes.from(e);
            }

            return result;
        }
    }

    public abstract class Computation<C,S,T> : Computation<S,T>
    {
        protected C Context {get;}

        protected Computation(C context)
        {
            Context = context;
        }
    }
}