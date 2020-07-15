//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Specifies a file that contains enum literal data aspects of the target enum type
    /// </summary>
    public readonly struct EnumFile
    {        
        /// <summary>
        /// The name of the archived file that defines the enumeration literals
        /// </summary>
        public readonly StringRef FileName;

        /// <summary>
        /// The enum type name identifier
        /// </summary>
        public readonly StringRef EnumName;
        
        /// <summary>
        /// The primal kind refined by the enum
        /// </summary>
        public readonly EnumScalarKind BaseType;

        [MethodImpl(Inline)]
        public EnumFile(StringRef file, StringRef name, EnumScalarKind @base)
        {
            FileName = file;
            EnumName = name;
            BaseType = @base;
        }

        public EnumFile Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (FileName.IsEmpty && EnumName.IsEmpty);
        }

        public bool IsNonEmpty
        {
            get => !IsEmpty;
        }

        public static EnumFile Empty 
            => new EnumFile(StringRef.Empty, StringRef.Empty, 0);
    }
}