//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    using W = NumericWidth;

    partial class MicroExpression
    {
        [MethodImpl(Inline)]
        public static BranchKind bk<E>()
            where E : unmanaged, Enum
        {
            if(typeof(E) == typeof(Branch8))
                return BranchKind.Branch8;
            else if(typeof(E) == typeof(Branch16))
                return BranchKind.Brach16;
            else if(typeof(E) == typeof(Branch32))
                return BranchKind.Branch32;
            else if(typeof(E) == typeof(Branch64))
                return BranchKind.Branch64;
            else
                return BranchKind.None;
        }

        /// <summary>
        /// Defines a branch spec/target: a value that represents a branch specification together with a consequent
        /// value predicated on that specification
        /// </summary>
        /// <param name="branch">The branch spec</param>
        /// <param name="target">The consequent value</param>
        /// <typeparam name="E">The branch kind</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static BranchTarget<E,T> target<E,T>(Branch<E> branch, T target)
            where E : unmanaged, Enum
                => new BranchTarget<E,T>(branch,target);

        /// <summary>
        /// Defines a branch target of kind Branch8
        /// </summary>
        /// <param name="decision">The decision</param>
        /// <param name="target">The consequent value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static BranchTarget<Branch8,T> target<T>(Branch8 decision, T target)
            => new BranchTarget<Branch8,T>(branch(decision), target);

        /// <summary>
        /// Defines a branch target of kind Branch16
        /// </summary>
        /// <param name="decision">The decision</param>
        /// <param name="target">The consequent value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static BranchTarget<Branch16,T> target<T>(Branch16 decision, T target)
            => new BranchTarget<Branch16,T>(branch(decision), target);

        /// <summary>
        /// Defines a branch target of kind Branch32
        /// </summary>
        /// <param name="decision">The decision</param>
        /// <param name="target">The consequent value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static BranchTarget<Branch32,T> target<T>(Branch32 decision, T target)
            => new BranchTarget<Branch32,T>(branch(decision), target);

        /// <summary>
        /// Defines a branch target of kind Branch32
        /// </summary>
        /// <param name="decision">The decision</param>
        /// <param name="target">The consequent value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static BranchTarget<Branch64,T> target<T>(Branch64 decision, T target)
            => new BranchTarget<Branch64,T>(branch(decision), target);

        /// <summary>
        /// Forms a branch over a decisision value
        /// </summary>
        /// <param name="decision">The decision value</param>
        /// <typeparam name="E">The branch decision kind</typeparam>
        [MethodImpl(Inline)]
        public static Branch<E> branch<E>(E decision)
            where E : unmanaged, Enum
                => new Branch<E>(decision);

        /// <summary>
        /// A branch label nonparametric variant
        /// </summary>
        public readonly struct Branch
        {
            [MethodImpl(Inline)]
            public Branch(ulong decision, BranchKind kind)
            {
                this.Decision = decision;
                this.Kind = kind;
            }

            /// <summary>
            /// The decision value
            /// </summary>
            public ulong Decision {get;}


            /// <summary>
            /// The decision value discriminator
            /// </summary>
            public BranchKind Kind {get;}
            
        }

        /// <summary>
        /// Defines a parametric type that may be closed over 1 of 4 possible branch kinds 
        /// </summary>
        /// <remarks>
        /// Unfortunately, the language provides no means to express this constraint
        /// </remarks>
        public readonly struct Branch<E>
            where E : unmanaged, Enum
        {
            [MethodImpl(Inline)]
            public static implicit operator E(Branch<E> src)
                => src.Decision;

            [MethodImpl(Inline)]
            public static implicit operator Branch(Branch<E> src)
                => new Branch(Enums.u64(src.Decision), bk<E>());

            [MethodImpl(Inline)]
            public Branch(E src)
            {
                Decision = src;
            }
            
            public E Decision {get;}

            public BranchKind Kind 
            {
                [MethodImpl(Inline)]
                get => bk<E>();
            }
        }

        /// <summary>
        /// Defines a branch-predicated target value
        /// </summary>
        public readonly struct BranchTarget<E,T>
            where E : unmanaged, Enum
        {
            [MethodImpl(Inline)]
            public BranchTarget(Branch<E> branch, T target)
            {
                this.Branch = branch;
                this.Target = target;
            }

            /// <summary>
            /// The branch decision
            /// </summary>
            public Branch<E> Branch {get;}

            /// <summary>
            /// The value produced as a consequence of the branch decision
            /// </summary>
            public T Target {get;}
        }

        public enum BranchKind : byte
        {
            /// <summary>
            /// Unspecified kind of branch
            /// </summary>
            None = 0,

            /// <summary>
            /// An 8-bit branch
            /// </summary>
            Branch8 = W.W8,

            /// <summary>
            /// A 16-bit branch
            /// </summary>
            Brach16 = W.W16,

            /// <summary>
            /// A 32-bit branch
            /// </summary>
            Branch32 = W.W32,

            /// <summary>
            /// A 64-bit branch
            /// </summary>
            Branch64 = W.W64
        }

        /// <summary>
        /// Represents byte.MaxValue - 1 potential decisisions, some of which are explicitly listed
        /// </summary>
        public enum Branch8 : byte
        {
            /// <summary>
            /// If you choose not to decide you have still made a choice
            /// </summary>
            None = 0,

            Case1 = 1,

            Case2 = 2,

            Case3 = 3,

            Case4 = 4,

            Case5 = 5,

            Case6 = 6,

            Max = byte.MaxValue,
        }

        /// <summary>
        /// Represents ushort.MaxValue - 1 potential decisisions, some of which are explicitly listed
        /// </summary>
        public enum Branch16 : ushort
        {
            /// <summary>
            /// If you choose not to decide you have still made a choice
            /// </summary>
            None = 0,

            Case0 = 0,

            Case1 = 1,

            Case2 = 2,

            Case3 = 3,

            Case4 = 4,

            Case5 = 5,

            Case6 = 6,

            Max = ushort.MaxValue,

        }

        /// <summary>
        /// Represents uint.MaxValue - 1 potential decisisions, some of which are explicitly listed
        /// </summary>
        public enum Branch32 : uint
        {
            /// <summary>
            /// If you choose not to decide you have still made a choice
            /// </summary>
            None = 0,
            
            Case0 = 0,

            Case1 = 1,

            Case2 = 2,

            Case3 = 3,

            Case4 = 4,

            Case5 = 5,

            Case6 = 6,

            Max = uint.MaxValue,
        }

        /// <summary>
        /// Represents ulong.MaxValue - 1 potential decisisions, some of which are explicitly listed
        /// </summary>
        public enum Branch64 : ulong
        {
            /// <summary>
            /// If you choose not to decide you have still made a choice
            /// </summary>
            None = 0,
            
            Case0 = 0,

            Case1 = 1,

            Case2 = 2,

            Case3 = 3,

            Case4 = 4,

            Case5 = 5,

            Case6 = 6,

            Max = ulong.MaxValue,
        }
    }
}