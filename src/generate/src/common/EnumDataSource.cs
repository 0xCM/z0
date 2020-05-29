//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Specifies a file that contains enum literal data aspects of the target enum type
    /// </summary>
    public readonly struct EnumDataSource
    {        
        public static EnumDataSource Empty 
            => new EnumDataSource(FileName.Empty, string.Empty, EnumPrimalKind.None, string.Empty);

        /// <summary>
        /// The name of the archived file that defines the enumeration literals
        /// </summary>
        public FileName File {get;}

        /// <summary>
        /// The enum type name identifier
        /// </summary>
        public string EnumName {get;}
        
        /// <summary>
        /// The primal kind refined by the enum
        /// </summary>
        public EnumPrimalKind BaseType {get;}

        /// <summary>
        /// The purpose of the enum
        /// </summary>
        public string Description {get;}

        [MethodImpl(Inline)]
        public EnumDataSource(FileName File, string EnumName, EnumPrimalKind BaseType, string Description)
        {
            this.File = File;
            this.EnumName = EnumName;
            this.BaseType = BaseType;
            this.Description = Description;
        }

        public EnumDataSource Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (File?.IsEmpty ?? true) && text.empty(EnumName) && BaseType == 0 && text.empty(Description);
        }

        public bool IsNonEmpty
        {
            get => !(File?.IsEmpty ?? true) || text.nonempty(EnumName) || BaseType != 0 || text.nonempty(Description);
        }
    }
}