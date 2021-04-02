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
    using static Rules;

    [ApiHost]
    public ref struct FenceExprPaser
    {
        ReadOnlySpan<char> Input;

        readonly char Left;

        readonly char Right;

        readonly Span<Paired<sbyte,string>> Output;

        sbyte Depth;

        int Position;

        byte Counter;

        public static FenceExprPaser create(Fence<char> fence, byte capacity = 255)
            => new FenceExprPaser(fence, capacity);

        [MethodImpl(Inline)]
        public FenceExprPaser(Fence<char> fence, byte capacity)
        {
            Left = fence.Left;
            Right = fence.Right;
            Output = alloc<Paired<sbyte,string>>(capacity);
            Depth = 0;
            Position = 0;
            Input = default;
            Counter = 0;
        }

        uint LastPosition
        {
            [MethodImpl(Inline)]
            get => (uint)Input.Length - 1;
        }

        [Op]
        void Reset(string src)
        {
            Depth = 0;
            Position = -1;
            Input = src;
            Counter = 0;
        }

        [Op]
        public ReadOnlySpan<Paired<sbyte,string>> Parse(string src)
        {
            Reset(src);

            while(Depth >= 0 && Position < LastPosition)
            {
                Next();
            }

            return slice(Output,0,Counter);
        }

        [Op]
        ref Paired<sbyte,string> InitTarget()
        {
            ref var current = ref seek(Output, Depth);
            if(current.Left < 0)
                current = DefineTarget(Depth, EmptyString);
            return ref current;
        }

        ref Paired<sbyte,string> CurrentTarget
        {
            [MethodImpl(Inline)]
            get => ref InitTarget();
        }

        ref readonly char CurrentInput
        {
            [MethodImpl(Inline)]
            get => ref skip(Input,Position);
        }

        bool IsLeftFence
        {
            [MethodImpl(Inline)]
            get => CurrentInput == Left;
        }

        bool IsRightFence
        {
            [MethodImpl(Inline)]
            get  => CurrentInput == Right;
        }

        [Op]
        static string concat(string src, char c)
        {
            if(text.empty(src))
                return c.ToString();
            else
                return src + c;
        }

        [Op]
        void Next()
        {
            Position++;

            if(IsRightFence)
            {
                Depth--;
                return;
            }
            else if(IsLeftFence)
            {
                Depth++;
                Counter++;
            }
            else
                CurrentTarget = DefineTarget(Depth, concat(CurrentTarget.Right,  CurrentInput));
        }

        [MethodImpl(Inline), Op]
        static Paired<sbyte,string> DefineTarget(sbyte depth, string content)
            => root.paired(depth,content);
    }
}