//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    /// <summary>
    /// Defines minimal contract for a command specification
    /// </summary>
    /// <remarks>
    /// A command specification is a type that, when instantiated, contains
    /// the data necessary to execute a system command
    /// </remarks>
    public interface ICommandSpec
    {
        /// <summary>
        /// The name of the command, e.g., get-schema
        /// </summary>
        CommandName CommandName { get; }

        /// <summary>
        /// A pithy explanation of the command's purpose
        /// </summary>
        string CommandDescription { get; }
        
        /// <summary>
        /// The area into which the the command is segmented and, by default, is the first component of the command URI
        /// </summary>
        string CommandArea { get; }

        /// <summary>
        /// The command function/operation which, by default, is the last component of the command URI
        /// </summary>
        string CommandAction { get; }

        /// <summary>
        /// The name of a hydrated specification
        /// </summary>
        string SpecName { get; }

        /// <summary>
        /// The arguments that will be used when the command is executed
        /// </summary>
        CommandArguments Arguments { get; }

        /// <summary>
        /// Replaces script variables with values from the execution context which
        /// is typically resolved using the local machine's environment variables
        /// </summary>
        ICommandSpec ExpandVariables();

        /// <summary>
        /// The message that describes the command upon commencement of execution
        /// </summary>
        IAppMsg DescribeIntent();        
    }

    public interface ICommandSpec<S> : ICommandSpec
        where S : CommandSpec<S>, new()
    {
        new S ExpandVariables();
    }

    /// <summary>
    /// Characterizes a reified payload-parametric command specification
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    /// <typeparam name="P">The payload type</typeparam>
    public interface ICommandSpec<S,P> : ICommandSpec<S>
        where S : CommandSpec<S,P>, new()
    {
    }
}