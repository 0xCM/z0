//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    class InstructionMarkers
    {
        /// <summary>
        /// Whe encountered, signals a list  of  insruction specifications to follow,
        /// where each specification covers multiple lines of text, bounded above by
        /// a line containing a single left-brace and below by a line cotaining a
        /// single right-brace
        /// </summary>
        public const string INSTRUCTION_SEQ = "INSTRUCTIONS()::";

        /// <summary>
        /// When encountered, signals a sequence of lines that describe an instruciton
        /// </summary>
        public const string DECL_BEGIN = "{" ;

        /// <summary>
        /// When encountered, signals that a sequence of instruction description lines has concluded
        /// </summary>
        public const string DECL_END = "}" ;

        public const char ASSIGN = Chars.Eq;

        public const char PROP_DELIMITER = Chars.Colon;

        public const string ICLASS = nameof(ICLASS);

        public const string CPL = nameof(CPL);

        public const string CATEGORY = nameof(CATEGORY);

        public const string EXTENSION = nameof(EXTENSION);

        public const string EXCEPTIONS = nameof(EXCEPTIONS);

        public const string PATTERN = nameof(PATTERN);

        public const string OPERANDS = nameof(OPERANDS);

        public const string IFORM = nameof(IFORM);

        public const string ISA_SET = nameof(ISA_SET);

        public const string ATTRIBUTES = nameof(ATTRIBUTES);

        public const string REAL_OPCODE = nameof(REAL_OPCODE);

        public const string MOD = nameof(MOD);

        public const string MODIDX = MOD + CharText.Eq;

        public const string REG = nameof(REG);
    }
}