//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static ApiKeywordNames;

    [ApiDeep]
    public unsafe struct ApiKeywords
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ApiKeyword<T> cell<T>(T t)
            => new ApiKeyword<T>(pchar(Cell), t);

        /// <summary>
        /// Specifies an action
        /// </summary>
        public static ApiKeyword action() => Action;

        /// <summary>
        /// Allocates a buffer
        /// </summary>
        public static ApiKeyword alloc() => Alloc;

        /// <summary>
        /// Specifies the arity of an operation
        /// </summary>
        public static ApiKeyword arity() => Arity;

        /// <summary>
        /// Specifies a file repository
        /// </summary>
        public static ApiKeyword archive() => Archive;

        /// <summary>
        /// Presents a value of one type as another
        /// </summary>
        public static ApiKeyword @as() => As;

        /// <summary>
        /// An data type that represents a binary state
        /// </summary>
        public static ApiKeyword bit() => "bit";

        /// <summary>
        /// Invokes a build process
        /// </summary>
        public static ApiKeyword build() => "build";

        /// <summary>
        /// Defines a control structure that transfers control predicated on a finite set of conditions
        /// </summary>
        public static ApiKeyword branch() => "branch";

        /// <summary>
        /// Specifies a buffer
        /// </summary>
        public static ApiKeyword buffer() => "buffer";

        /// <summary>
        /// Specifies memory segment of known width
        /// </summary>
        public static ApiKeyword cell() => Cell;

        /// <summary>
        /// Extends a buffer over a memory segment
        /// </summary>
        public static ApiKeyword cover() => "cover";

        /// <summary>
        /// Specifies a command
        /// </summary>
        public static ApiKeyword cmd() => "cmd";

        /// <summary>
        /// Declares a data type
        /// </summary>
        public static ApiKeyword data() => "data";

        /// <summary>
        /// Specifies a directory
        /// </summary>
        public static ApiKeyword dir() => "dir";

        /// <summary>
        /// Specifies a file
        /// </summary>
        public static ApiKeyword file() => "file";

        /// <summary>
        /// Specifies a function
        /// </summary>
        public static ApiKeyword func() => "func";

        /// <summary>
        /// Specifies a datatype/record field
        /// </summary>
        public static ApiKeyword field() => "field";

        /// <summary>
        /// Specifies an instruction
        /// </summary>
        public static ApiKeyword instr() => "instr";

        /// <summary>
        /// Loads buffer content from a source
        /// </summary>
        public static ApiKeyword load() => "load";

        /// <summary>
        /// Calls a function
        /// </summary>
        public static ApiKeyword call() => "call";

        /// <summary>
        /// Emits a source input to a target output
        /// </summary>
        public static ApiKeyword emit() => "emit";

        /// <summary>
        /// Specifies an event, a datatype specialization
        /// </summary>
        public static ApiKeyword @event() => "event";

        /// <summary>
        /// Specifies a format operation
        /// </summary>
        public static ApiKeyword format() => "format";

        /// <summary>
        /// Invokes an action
        /// </summary>
        public static ApiKeyword invoke() => "invoke";

        /// <summary>
        /// Transfers control from the point of invocation to a specified target
        /// </summary>
        public static ApiKeyword jump() => "jump";

        /// <summary>
        /// Test a predicate and returns a bit indicating the rusult
        /// </summary>
        public static ApiKeyword test() => "test";

        /// <summary>
        /// Specifies an identifer that is unique within some scope
        /// </summary>
        public static ApiKeyword label() => "label";

        /// <summary>
        /// Defines an iterative context
        /// </summary>
        public static ApiKeyword loop() => "loop";

        /// <summary>
        /// Specifies an operator, a func specialization
        /// </summary>
        public static ApiKeyword @operator() => "operator";

        /// <summary>
        /// A function or action
        /// </summary>
        public static ApiKeyword operation() => "operation";

        /// <summary>
        /// Defines a type with value semantics, and composed of datatypes, that can be persisted/hydrated
        /// </summary>
        public static ApiKeyword record() => "record";

        /// <summary>
        /// Specifies a reactor
        /// </summary>
        public static ApiKeyword reactor() => "reactor";

        /// <summary>
        /// Presents a buffers with cells of one type as a buffer with cells of another type
        /// </summary>
        public static ApiKeyword recover() => "recover";

        /// <summary>
        /// Defines a finite value sequence
        /// </summary>
        public static ApiKeyword range() => "range";

        /// <summary>
        /// Specifies a natural number
        /// </summary>
        public static ApiKeyword nat() => "nat";

        /// <summary>
        /// Publishes an event
        /// </summary>
        public static ApiKeyword raise() => "raise";

        /// <summary>
        /// Defines a closed interval
        /// </summary>
        public static ApiKeyword segment() => "segment";

        /// <summary>
        /// In an iterative context, declares an integral value that may be used as an increment/decrement size
        /// </summary>
        public static ApiKeyword step() => "step";

        /// <summary>
        /// Specifies a data emitter
        /// </summary>
        public static ApiKeyword source() => "source";

        /// <summary>
        /// Specifies a data emitter
        /// </summary>
        public static ApiKeyword type() => "type";

        /// <summary>
        /// Specifies a tool
        /// </summary>
        public static ApiKeyword tool() => "tool";

        /// <summary>
        /// Specifies a data receiver
        /// </summary>
        public static ApiKeyword target() => "target";

        /// <summary>
        /// Defines a sequence of indeterminate length
        /// </summary>
        public static ApiKeyword seq() => "seq";

        /// <summary>
        /// Specifies a stream
        /// </summary>
        public static ApiKeyword stream() => "stream";

        /// <summary>
        /// Delimits a statement sequence
        /// </summary>
        public static ApiKeyword scope() => "scope";

        /// <summary>
        /// Persists a buffer content to a target
        /// </summary>
        public static ApiKeyword store() => "store";

        /// <summary>
        /// Specifies a vector of the form bitwidth X cellwidth
        /// </summary>
        public static ApiKeyword vector() => Vector;

        /// <summary>
        /// Specifies an unsigned data type
        /// </summary>
        public static ApiKeyword unsigned() => "unsigned";

        /// <summary>
        /// Specifies unsigned data type that occupies an 8-bit cell
        /// </summary>
        public static ApiKeyword u8() => "u8";

        /// <summary>
        /// Specifies an unsigned data type that occupies an 16-bit cell
        /// </summary>
        public static ApiKeyword u16() => "u16";

        /// <summary>
        /// Specifies an unsigned data type that occupies a 32-bit cell
        /// </summary>
        public static ApiKeyword u32() => "u32";

        /// <summary>
        /// Specifies an unsigned data type that occupies an 64-bit cell
        /// </summary>
        public static ApiKeyword u64() => "u64";

        /// <summary>
        /// Specifes an unsigned data type that occupies a 128-bit cell
        /// </summary>
        public static ApiKeyword u128() => "u128";

        /// <summary>
        /// An unsigned data type that occupies a 256-bit cell
        /// </summary>
        public static ApiKeyword u256() => "u256";

        /// <summary>
        /// An unsigned data type that occupies a 512-bit cell
        /// </summary>
        public static ApiKeyword u512() => "u512";

        /// <summary>
        /// Specifies a variable
        /// </summary>
        public static ApiKeyword var() => Var;

        /// <summary>
        /// Specifies a bit-width
        /// </summary>
        public static ApiKeyword width() => Width;
    }
}