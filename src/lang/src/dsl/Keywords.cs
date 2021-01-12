//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{

    using Z0.Lang;

    [ApiType]
    public struct Keywords
    {
        /// <summary>
        /// Presents a value of one type as another
        /// </summary>
        public static Keyword @as() => "as";

        /// <summary>
        /// Specifies memory segment of known width
        /// </summary>
        public static Keyword cell() => "cell";

        /// <summary>
        /// An data type that represents a binary state
        /// </summary>
        public static Keyword bit() => "bit";

        /// <summary>
        /// Specifies a buffer
        /// </summary>
        public static Keyword buffer() => "buffer";

        /// <summary>
        /// Allocates a buffer
        /// </summary>
        public static Keyword alloc() => "alloc";

        /// <summary>
        /// Loads buffer content from a source
        /// </summary>
        public static Keyword load() => "load";

        /// <summary>
        /// Persists a buffer content to a target
        /// </summary>
        public static Keyword store() => "store";

        /// <summary>
        /// Extends a buffer over a memory segment
        /// </summary>
        public static Keyword cover() => "cover";

        /// <summary>
        /// Presents a buffers with cells of one type as a buffer with cells of another type
        /// </summary>
        public static Keyword recover() => "recover";

        /// <summary>
        /// Specifies an action
        /// </summary>
        public static Keyword action() => "action";

        /// <summary>
        /// Invokes a build process
        /// </summary>
        public static Keyword build() => "build";

        /// <summary>
        /// Specifies a command
        /// </summary>
        public static Keyword cmd() => "cmd";

        /// <summary>
        /// Specifies a directory
        /// </summary>
        public static Keyword dir() => "dir";

        /// <summary>
        /// Specifies a function
        /// </summary>
        public static Keyword func() => "func";

        /// <summary>
        /// Specifies an instruction
        /// </summary>
        public static Keyword instr() => "instr";

        /// <summary>
        /// Specifies an operator, a func specialization
        /// </summary>
        public static Keyword @operator() => "operator";

        /// <summary>
        /// A function or action
        /// </summary>
        public static Keyword operation() => "operation";

        /// <summary>
        /// Specifies the arity of an operation
        /// </summary>
        public static Keyword arity() => "arity";

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
        /// Specifies a file
        /// </summary>
        public static Keyword file() => "file";

        /// <summary>
        /// Invokes a tool
        /// </summary>
        public static Keyword tool() => "tool";

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
        /// Declares a data type
        /// </summary>
        public static Keyword data() => "data";

        /// <summary>
        /// Defines a type with value semantics, and composed of datatypes, that can be persisted/hydrated
        /// </summary>
        public static Keyword record() => "record";

        /// <summary>
        /// Transforms a <see cref='record'/>, or sequence thereof, to a serializable cell sequence
        /// </summary>
        public static Keyword render() => "render";

        /// <summary>
        /// Defines reactor
        /// </summary>
        public static Keyword reactor() => "reactor";

        /// <summary>
        /// Hydrates a <see cref='record'/>, or sequence thereof, from a cell sequence
        /// </summary>
        public static Keyword hydrate() => "hydrate";

        /// <summary>
        /// Specifies a datatype/record field
        /// </summary>
        public static Keyword field() => "field";

        /// <summary>
        /// Defines a closed interval
        /// </summary>
        public static Keyword segment() => "segment";

        /// <summary>
        /// Defines a finite sequence of values
        /// </summary>
        public static Keyword range() => "range";

        /// <summary>
        /// Defines an iterative context
        /// </summary>
        public static Keyword loop() => "loop";

        /// <summary>
        /// In an iterative context, declares an integral value that may be used as an increment/decrement size
        /// </summary>
        public static Keyword step() => "step";

        /// <summary>
        /// Declares a variable
        /// </summary>
        public static Keyword var() => "var";

        /// <summary>
        /// Defines a control structure that transfers control predicated on a finite set of conditions
        /// </summary>
        public static Keyword branch() => "branch";

        /// <summary>
        /// Specifies an identifer that is unique within some scope
        /// </summary>
        public static Keyword label() => "label";

        /// <summary>
        /// Delimits a statement sequence
        /// </summary>
        public static Keyword scope() => "label";

        /// <summary>
        /// Publishes an event
        /// </summary>
        public static Keyword raise() => "raise";

        /// <summary>
        /// Specifies unsigned data type that occupies an 8-bit cell
        /// </summary>
        public static Keyword u8() => "u8";

        /// <summary>
        /// Specifies an unsigned integer of designated width
        /// </summary>
        public static Keyword<uint> u => "u(n:uint)";

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
        /// Specifies a natural number
        /// </summary>
        public static Keyword nat() => "nat";

    }
}