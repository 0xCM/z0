//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Identifies a workflow step
    /// </summary>
    public readonly struct WfStepId<T> : IWfStepId
        where T : new()
    {
        [MethodImpl(Inline)]
        public static implicit operator WfStepId(WfStepId<T> src)
            => new WfStepId(src.Control);

        [MethodImpl(Inline)]
        public static implicit operator WfStepId<T>(Type effect)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator WfToken(WfStepId<T> src)
            => src.Token;

        /// <summary>
        /// The step name
        /// </summary>
        public string Name
            => Control.Name.Remove("Step");

        /// <summary>
        /// The step controller
        /// </summary>
        public Type Control
            => typeof(T);

        /// <summary>
        /// The step effector
        /// </summary>
        public Type Effect
            => Control;

        /// <summary>
        /// The step token
        /// </summary>
        public WfToken Token
        {
            [MethodImpl(Inline)]
            get => Workflow.token(WfPartKind.Step, Effect);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Effect == null || Effect.IsEmpty();
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Effect != null && !Effect.IsEmpty();
        }

        [MethodImpl(Inline)]
        public bool Equals(WfStepId<T> src)
            => Effect == src.Effect;

        [MethodImpl(Inline)]
        public int CompareTo(WfStepId<T> src)
            => (src.IsEmpty || IsEmpty)? 0 : Effect.FullName.CompareTo(src.Effect.FullName);

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        [MethodImpl(Inline)]
        public string Format(bool full)
            => full ? Effect.FullName : Effect.Name;

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)Effect.GetHashCode();
        }

        public override int GetHashCode()
            => (int)Hashed;


        public override bool Equals(object src)
            => src is WfStepId x && Equals(x);

        public override string ToString()
            => Format();

        public static WfStepId<T> Empty
            => default;
    }
}