//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Datatype]
    public readonly struct CmdArgQualifier : IDataType<CmdArgQualifier>
    {
        readonly AsciCharCode Code;

        [MethodImpl(Inline)]
        public CmdArgQualifier(AsciCharCode code)
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
        public static implicit operator string(CmdArgQualifier src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdArgQualifier(char src)
            => new CmdArgQualifier((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator CmdArgQualifier(AsciCharCode src)
            => new CmdArgQualifier(src);

        public static CmdArgQualifier Empty
            => default;

        public static CmdArgQualifier Colon
            => new CmdArgQualifier(AsciCharCode.Colon);

        public static CmdArgQualifier Eq
            => new CmdArgQualifier(AsciCharCode.Eq);

        public static CmdArgQualifier Space
            => new CmdArgQualifier(AsciCharCode.Space);
    }
}