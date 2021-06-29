//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    readonly struct XedSourceMarkers
    {
        public static string RuleHeader(string name)
            => $"{name}()::";

        public const string RuleMarker = "()::";

        /// <summary>
        /// Whe encountered, signals a list  of  insruction specifications to follow,
        /// where each specification covers multiple lines of text, bounded above by
        /// a line containing a single left-brace and below by a line cotaining a
        /// single right-brace
        /// </summary>
        public const string Instructions = "INSTRUCTIONS()::";

        /// <summary>
        /// When encountered, signals a sequence of lines that describe an instruction
        /// </summary>
        public const string FuncBodyBegin = "{" ;

        /// <summary>
        /// Signals that a sequence of instruction description lines has concluded
        /// </summary>
        public const string FuncBodyEnd = "}" ;

        /// <summary>
        /// Signals a forthcoming named symbol index
        /// </summary>
        public const string SEQUENCE = nameof(SEQUENCE);

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

        public const string IMPLIES = "->";

        public const string Separator = RP.PageBreak120;

        public const string Bar = " | ";
    }
}