//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using static Root;

    [ApiComplete]
    public unsafe struct ApiKeywords
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Specifies an action
        /// </summary>
        public static Keyword action() => "action";

        /// <summary>
        /// Allocates a buffer
        /// </summary>
        public static Keyword alloc() => "alloc";

        /// <summary>
        /// Specifies the arity of an operation
        /// </summary>
        public static Keyword arity() => "arity";

        /// <summary>
        /// Specifies a file repository
        /// </summary>
        public static Keyword archive() => "archive";

        /// <summary>
        /// Presents a value of one type as another
        /// </summary>
        public static Keyword @as() => "as";

        /// <summary>
        /// An data type that represents a binary state
        /// </summary>
        public static Keyword bit() => "bit";

        /// <summary>
        /// Invokes a build process
        /// </summary>
        public static Keyword build() => "build";

        /// <summary>
        /// Defines a control structure that transfers control predicated on a finite set of conditions
        /// </summary>
        public static Keyword branch() => "branch";

        /// <summary>
        /// Specifies a buffer
        /// </summary>
        public static Keyword buffer() => "buffer";

        /// <summary>
        /// Specifies memory segment of known width
        /// </summary>
        public static Keyword cell() => "cell";

        /// <summary>
        /// Extends a buffer over a memory segment
        /// </summary>
        public static Keyword cover() => "cover";

        /// <summary>
        /// Specifies a command
        /// </summary>
        public static Keyword cmd() => "cmd";

        /// <summary>
        /// Declares a data type
        /// </summary>
        public static Keyword data() => "data";

        /// <summary>
        /// Specifies a directory
        /// </summary>
        public static Keyword dir() => "dir";

        /// <summary>
        /// Specifies a file
        /// </summary>
        public static Keyword file() => "file";

        /// <summary>
        /// Specifies a function
        /// </summary>
        public static Keyword func() => "func";

        /// <summary>
        /// Specifies a datatype/record field
        /// </summary>
        public static Keyword field() => "field";

        /// <summary>
        /// Specifies an instruction
        /// </summary>
        public static Keyword instr() => "instr";

        /// <summary>
        /// Loads buffer content from a source
        /// </summary>
        public static Keyword load() => "load";

        /// <summary>
        /// Calls a function
        /// </summary>
        public static Keyword call() => "call";

        /// <summary>
        /// Emits a source input to a target output
        /// </summary>
        public static Keyword emit() => "emit";

        /// <summary>
        /// Specifies an event, a datatype specialization
        /// </summary>
        public static Keyword @event() => "event";

        /// <summary>
        /// Specifies a format operation
        /// </summary>
        public static Keyword format() => "format";

        /// <summary>
        /// Invokes an action
        /// </summary>
        public static Keyword invoke() => "invoke";

        /// <summary>
        /// Transfers control from the point of invocation to a specified target
        /// </summary>
        public static Keyword jump() => "jump";

        /// <summary>
        /// Test a predicate and returns a bit indicating the rusult
        /// </summary>
        public static Keyword test() => "test";

        /// <summary>
        /// Specifies an identifer that is unique within some scope
        /// </summary>
        public static Keyword label() => "label";

        /// <summary>
        /// Defines an iterative context
        /// </summary>
        public static Keyword loop() => "loop";

        /// <summary>
        /// Specifies an operator, a func specialization
        /// </summary>
        public static Keyword @operator() => "operator";

        /// <summary>
        /// A function or action
        /// </summary>
        public static Keyword operation() => "operation";

        /// <summary>
        /// Defines a type with value semantics, and composed of datatypes, that can be persisted/hydrated
        /// </summary>
        public static Keyword record() => "record";

        /// <summary>
        /// Specifies a reactor
        /// </summary>
        public static Keyword reactor() => "reactor";

        /// <summary>
        /// Presents a buffers with cells of one type as a buffer with cells of another type
        /// </summary>
        public static Keyword recover() => "recover";

        /// <summary>
        /// Defines a finite value sequence
        /// </summary>
        public static Keyword range() => "range";

        /// <summary>
        /// Specifies a natural number
        /// </summary>
        public static Keyword nat() => "nat";

        /// <summary>
        /// Publishes an event
        /// </summary>
        public static Keyword raise() => "raise";

        /// <summary>
        /// Defines a closed interval
        /// </summary>
        public static Keyword segment() => "segment";

        /// <summary>
        /// In an iterative context, declares an integral value that may be used as an increment/decrement size
        /// </summary>
        public static Keyword step() => "step";

        /// <summary>
        /// Specifies a data emitter
        /// </summary>
        public static Keyword source() => "source";

        /// <summary>
        /// Specifies a data emitter
        /// </summary>
        public static Keyword type() => "type";

        /// <summary>
        /// Specifies a tool
        /// </summary>
        public static Keyword tool() => "tool";

        /// <summary>
        /// Specifies a data receiver
        /// </summary>
        public static Keyword target() => "target";

        /// <summary>
        /// Defines a sequence of indeterminate length
        /// </summary>
        public static Keyword seq() => "seq";

        /// <summary>
        /// Specifies a stream
        /// </summary>
        public static Keyword stream() => "stream";

        /// <summary>
        /// Delimits a statement sequence
        /// </summary>
        public static Keyword scope() => "scope";

        /// <summary>
        /// Persists a buffer content to a target
        /// </summary>
        public static Keyword store() => "store";

        /// <summary>
        /// Specifies a vector of the form bitwidth X cellwidth
        /// </summary>
        public static Keyword vector() => "vector";

        /// <summary>
        /// Specifies an unsigned data type
        /// </summary>
        public static Keyword unsigned() => "unsigned";

        /// <summary>
        /// Specifies unsigned data type that occupies an 8-bit cell
        /// </summary>
        public static Keyword u8() => "u8";

        /// <summary>
        /// Specifies an unsigned data type that occupies an 16-bit cell
        /// </summary>
        public static Keyword u16() => "u16";

        /// <summary>
        /// Specifies an unsigned data type that occupies a 32-bit cell
        /// </summary>
        public static Keyword u32() => "u32";

        /// <summary>
        /// Specifies an unsigned data type that occupies an 64-bit cell
        /// </summary>
        public static Keyword u64() => "u64";

        /// <summary>
        /// Specifes an unsigned data type that occupies a 128-bit cell
        /// </summary>
        public static Keyword u128() => "u128";

        /// <summary>
        /// An unsigned data type that occupies a 256-bit cell
        /// </summary>
        public static Keyword u256() => "u256";

        /// <summary>
        /// An unsigned data type that occupies a 512-bit cell
        /// </summary>
        public static Keyword u512() => "u512";

        /// <summary>
        /// Specifies a bit-width
        /// </summary>
        public static Keyword width() => "width";
    }
}