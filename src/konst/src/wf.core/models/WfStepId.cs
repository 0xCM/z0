//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Identifies a workflow step - which is synonymous with its actuator/host/controller
    /// </summary>
    public readonly struct WfStepId : IWfStepId
    {
        /// <summary>
        /// The Step controller
        /// </summary>
        public Type Control {get;}

        /// <summary>
        /// The step name
        /// </summary>
        public string Name
            => Control.Name.Remove("Step");

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(Type control)
            => new WfStepId(control);

        [MethodImpl(Inline)]
        public WfStepId(Type control)
        {
            Control = control;
        }

        /// <summary>
        /// The step token
        /// </summary>
        public WfToken Token
        {
            [MethodImpl(Inline)]
            get => Workflow.token(WfPartKind.Step, Control);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Token.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Token.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public bool Equals(WfStepId src)
            => Token.Value == src.Token.Value;

        [MethodImpl(Inline)]
        public int CompareTo(WfStepId src)
            => Name.CompareTo(src.Name);

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => z.hash(Token);
        }

        public override int GetHashCode()
            => (int)Hashed;

        public override bool Equals(object src)
            => src is WfStepId i && Equals(i);

        public override string ToString()
            => Format();

        public static WfStepId Empty
            => new WfStepId(typeof(void));
    }
}