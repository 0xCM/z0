//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Datatype]
    public readonly struct ArgQualifier : IDataType<ArgQualifier>
    {
        readonly AsciCharCode Code;

        [MethodImpl(Inline)]
        public ArgQualifier(AsciCharCode code)
            => Code = code;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code == AsciCharCode.Null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Code != AsciCharCode.Null;
        }

        [MethodImpl(Inline)]
        public string Format()
            => ((char)Code).ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator string(ArgQualifier src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator ArgQualifier(char src)
            => new ArgQualifier((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator ArgQualifier(AsciCharCode src)
            => new ArgQualifier(src);

        public static ArgQualifier Empty
            => new ArgQualifier(AsciCharCode.Null);

        public static ArgQualifier Space
            => new ArgQualifier(AsciCharCode.Space);

        public static ArgQualifier Colon
            => new ArgQualifier(AsciCharCode.Colon);

        public static ArgQualifier Eq
            => new ArgQualifier(AsciCharCode.Eq);
    }
}